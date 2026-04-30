using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicsProject
{
    public partial class Form1 : Form
    {
        List<PointF> square;
        Image img;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.WhiteSmoke;

            pictureBox1.Paint += pictureBox1_Paint;
            img = Image.FromFile(@"E:\DotNet\New folder\images.png");
            square = new List<PointF>()
    {
        new PointF(100,100),
        new PointF(200,100),
        new PointF(200,200),
      new PointF(100,200)
    };



            btnMove.Font = new Font("Arial", 10, FontStyle.Bold);
            btnScale.Font = new Font("Arial", 10, FontStyle.Bold);
            btnRotate.Font = new Font("Arial", 10, FontStyle.Bold);
            btnReflect.Font = new Font("Arial", 10, FontStyle.Bold);
            btnShear.Font = new Font("Arial", 10, FontStyle.Bold);
        }




        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            PointF[] destPoints = new PointF[]
            {
        square[0],
        square[1],
        square[3]
            };

            g.DrawImage(img, destPoints);
        }


        void ShowPoints(string title)
        {
            txtOutput.AppendText(title + "\r\n");

            foreach (var p in square)
                txtOutput.AppendText($"({p.X:F2}, {p.Y:F2})\r\n");

            txtOutput.AppendText("------------------\r\n");
        }

        PointF ApplyMatrix(double[,] m, PointF p)
        {
            float x = (float)(m[0, 0] * p.X + m[0, 1] * p.Y + m[0, 2]);
            float y = (float)(m[1, 0] * p.X + m[1, 1] * p.Y + m[1, 2]);

            return new PointF(x, y);
        }

        void Transform(double[,] matrix, string name)
        {
            txtOutput.Clear();

            ShowPoints("Before " + name);

            for (int i = 0; i < square.Count; i++)
                square[i] = ApplyMatrix(matrix, square[i]);

            ShowPoints("After " + name);

            pictureBox1.Invalidate();
        }

        // ===== Buttons =====

        // Move
        private void btnMove_Click(object sender, EventArgs e)
        {
            float tx, ty;

            if (!float.TryParse(txtMoveX.Text, out tx) ||
                !float.TryParse(txtMoveY.Text, out ty))
            {
                MessageBox.Show("Enter valid Move values");
                return;
            }

            double[,] T = {
        {1,0,tx},
        {0,1,ty},
        {0,0,1}
    };

            Transform(T, "Translation");
        }
        // Scale
        private void btnScale_Click(object sender, EventArgs e)
        {
            float sx, sy;

            if (!float.TryParse(txtScaleX.Text, out sx) ||
                !float.TryParse(txtScaleY.Text, out sy))
            {
                MessageBox.Show("Enter valid Scale values");
                return;
            }

            double[,] S = {
        {sx,0,0},
        {0,sy,0},
        {0,0,1}
    };

            Transform(S, "Scaling");
        }

        // Rotate
        private void btnRotate_Click(object sender, EventArgs e)
        {
            double angle;

            if (!double.TryParse(txtAngle.Text, out angle))
            {
                MessageBox.Show("Enter valid angle");
                return;
            }

            double rad = angle * Math.PI / 180;

            double[,] R = {
        {Math.Cos(rad), -Math.Sin(rad), 0},
        {Math.Sin(rad),  Math.Cos(rad), 0},
        {0,0,1}
    };

            Transform(R, "Rotation");
        }
        PointF GetCenter()
        {
            float cx = 0, cy = 0;

            foreach (var p in square)
            {
                cx += p.X;
                cy += p.Y;
            }

            return new PointF(cx / square.Count, cy / square.Count);
        }
        void ApplyMultiple(double[,] m1, double[,] m2, double[,] m3, string name)
        {
            txtOutput.Clear();

            square = new List<PointF>(square);

            ShowPoints("Before " + name);

            for (int i = 0; i < square.Count; i++)
            {
                PointF p = square[i];
                p = ApplyMatrix(m1, p);
                p = ApplyMatrix(m2, p);
                p = ApplyMatrix(m3, p);

                square[i] = p;
            }

            ShowPoints("After " + name);

            pictureBox1.Invalidate();
        }


        private void btnReflect_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();

            if (cmbReflect.SelectedItem == null)
            {
                MessageBox.Show("Choose reflection type");
                return;
            }

            string choice = cmbReflect.SelectedItem.ToString();


            float cx = 0, cy = 0;
            foreach (var p in square)
            {
                cx += p.X;
                cy += p.Y;
            }
            cx /= square.Count;
            cy /= square.Count;

            ShowPoints("Before Reflection");

            for (int i = 0; i < square.Count; i++)
            {
                PointF p = square[i];

                p.X -= cx;
                p.Y -= cy;

                if (choice == "X-axis")
                {
                    p.Y = -p.Y;
                }
                else if (choice == "Y-axis")
                {
                    p.X = -p.X;
                }
                else
                {
                    p.X = -p.X;
                    p.Y = -p.Y;
                }


                p.X += cx;
                p.Y += cy;

                square[i] = p;
            }

            ShowPoints("After Reflection");

            pictureBox1.Invalidate();
        }


        // Shearing
        private void btnShear_Click(object sender, EventArgs e)
        {
            float shx, shy;

            if (!float.TryParse(txtShearX.Text, out shx) ||
                !float.TryParse(txtShearY.Text, out shy))
            {
                MessageBox.Show("Enter valid Shear values");
                return;
            }

            double[,] Sh = {
        {1,shx,0},
        {shy,1,0},
        {0,0,1}
    };

            Transform(Sh, "Shearing");
        }


        // ReSet
        void ResetSquare()
        {
            square = new List<PointF>()
    {
        new PointF(100,100),
        new PointF(200,100),
        new PointF(200,200),
        new PointF(100,200)
    };

            txtOutput.Clear();
            ShowPoints("Reset Shape");

            pictureBox1.Invalidate();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetSquare();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}