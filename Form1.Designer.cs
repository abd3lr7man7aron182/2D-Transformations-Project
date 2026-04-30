namespace GraphicsProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMove = new System.Windows.Forms.Button();
            this.btnScale = new System.Windows.Forms.Button();
            this.btnReflect = new System.Windows.Forms.Button();
            this.btnShear = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.txtMoveX = new System.Windows.Forms.TextBox();
            this.txtMoveY = new System.Windows.Forms.TextBox();
            this.txtScaleY = new System.Windows.Forms.TextBox();
            this.txtScaleX = new System.Windows.Forms.TextBox();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.txtShearY = new System.Windows.Forms.TextBox();
            this.txtShearX = new System.Windows.Forms.TextBox();
            this.cmbReflect = new System.Windows.Forms.ComboBox();
            this.X = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(639, 12);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(101, 27);
            this.btnMove.TabIndex = 0;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnScale
            // 
            this.btnScale.Location = new System.Drawing.Point(851, 12);
            this.btnScale.Name = "btnScale";
            this.btnScale.Size = new System.Drawing.Size(101, 27);
            this.btnScale.TabIndex = 1;
            this.btnScale.Text = "Scale";
            this.btnScale.UseVisualStyleBackColor = true;
            this.btnScale.Click += new System.EventHandler(this.btnScale_Click);
            // 
            // btnReflect
            // 
            this.btnReflect.Location = new System.Drawing.Point(639, 160);
            this.btnReflect.Name = "btnReflect";
            this.btnReflect.Size = new System.Drawing.Size(101, 27);
            this.btnReflect.TabIndex = 3;
            this.btnReflect.Text = "Reflect";
            this.btnReflect.UseVisualStyleBackColor = true;
            this.btnReflect.Click += new System.EventHandler(this.btnReflect_Click);
            // 
            // btnShear
            // 
            this.btnShear.Location = new System.Drawing.Point(851, 417);
            this.btnShear.Name = "btnShear";
            this.btnShear.Size = new System.Drawing.Size(101, 27);
            this.btnShear.TabIndex = 4;
            this.btnShear.Text = "Shear";
            this.btnShear.UseVisualStyleBackColor = true;
            this.btnShear.Click += new System.EventHandler(this.btnShear_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(107, 658);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(352, 289);
            this.txtOutput.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(549, 654);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(627, 417);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 27);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(851, 160);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(101, 27);
            this.btnRotate.TabIndex = 2;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // txtMoveX
            // 
            this.txtMoveX.Location = new System.Drawing.Point(648, 45);
            this.txtMoveX.Name = "txtMoveX";
            this.txtMoveX.Size = new System.Drawing.Size(80, 22);
            this.txtMoveX.TabIndex = 25;
            this.txtMoveX.Text = "0";
            // 
            // txtMoveY
            // 
            this.txtMoveY.Location = new System.Drawing.Point(648, 73);
            this.txtMoveY.Name = "txtMoveY";
            this.txtMoveY.Size = new System.Drawing.Size(80, 22);
            this.txtMoveY.TabIndex = 26;
            this.txtMoveY.Text = "0";
            // 
            // txtScaleY
            // 
            this.txtScaleY.Location = new System.Drawing.Point(860, 86);
            this.txtScaleY.Name = "txtScaleY";
            this.txtScaleY.Size = new System.Drawing.Size(80, 22);
            this.txtScaleY.TabIndex = 30;
            this.txtScaleY.Text = "0";
            // 
            // txtScaleX
            // 
            this.txtScaleX.Location = new System.Drawing.Point(860, 45);
            this.txtScaleX.Name = "txtScaleX";
            this.txtScaleX.Size = new System.Drawing.Size(80, 22);
            this.txtScaleX.TabIndex = 29;
            this.txtScaleX.Text = "0";
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(860, 209);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(80, 22);
            this.txtAngle.TabIndex = 31;
            this.txtAngle.Text = "0";
            // 
            // txtShearY
            // 
            this.txtShearY.Location = new System.Drawing.Point(860, 498);
            this.txtShearY.Name = "txtShearY";
            this.txtShearY.Size = new System.Drawing.Size(80, 22);
            this.txtShearY.TabIndex = 34;
            this.txtShearY.Text = "0";
            // 
            // txtShearX
            // 
            this.txtShearX.Location = new System.Drawing.Point(860, 470);
            this.txtShearX.Name = "txtShearX";
            this.txtShearX.Size = new System.Drawing.Size(80, 22);
            this.txtShearX.TabIndex = 33;
            this.txtShearX.Text = "0";
            // 
            // cmbReflect
            // 
            this.cmbReflect.FormattingEnabled = true;
            this.cmbReflect.Items.AddRange(new object[] {
            "X-axis",
            "Y-axis",
            "Origin"});
            this.cmbReflect.Location = new System.Drawing.Point(660, 207);
            this.cmbReflect.Name = "cmbReflect";
            this.cmbReflect.Size = new System.Drawing.Size(68, 24);
            this.cmbReflect.TabIndex = 35;
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(614, 51);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(15, 16);
            this.X.TabIndex = 36;
            this.X.Text = "X";
            this.X.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(826, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(825, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(799, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Angle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(826, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(826, 501);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 945);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.X);
            this.Controls.Add(this.cmbReflect);
            this.Controls.Add(this.txtShearY);
            this.Controls.Add(this.txtShearX);
            this.Controls.Add(this.txtAngle);
            this.Controls.Add(this.txtScaleY);
            this.Controls.Add(this.txtScaleX);
            this.Controls.Add(this.txtMoveY);
            this.Controls.Add(this.txtMoveX);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnShear);
            this.Controls.Add(this.btnReflect);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.btnScale);
            this.Controls.Add(this.btnMove);
            this.Name = "Form1";
            this.Text = "0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnScale;
        private System.Windows.Forms.Button btnReflect;
        private System.Windows.Forms.Button btnShear;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.TextBox txtMoveX;
        private System.Windows.Forms.TextBox txtMoveY;
        private System.Windows.Forms.TextBox txtScaleY;
        private System.Windows.Forms.TextBox txtScaleX;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.TextBox txtShearY;
        private System.Windows.Forms.TextBox txtShearX;
        private System.Windows.Forms.ComboBox cmbReflect;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

