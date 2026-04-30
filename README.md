# 🎨 2D Transformations Project (Computer Graphics)

A Windows Forms application built in **C#** that demonstrates fundamental **2D transformations** using matrix operations.

---

## 🚀 Features

This project implements the following transformations:

* 🔹 **Translation (Move)**
* 🔹 **Rotation**
* 🔹 **Scaling**
* 🔹 **Reflection (X-axis, Y-axis, Origin)**
* 🔹 **Shearing**

All transformations are applied using **manual matrix calculations** (no built-in transformation functions).

---

## 🧠 Concepts Used

* 2D Transformation Matrices
* Homogeneous Coordinates
* Matrix Multiplication
* Graphics Rendering using `Graphics.DrawImage()`
* Event-driven programming (Windows Forms)

---

## 🎮 User Interface

The user can control transformations through:

* Input fields (X, Y, Angle)
* Buttons for each transformation
* ComboBox for selecting reflection type
* Output panel showing coordinates before & after transformation

---

## 🖼️ Example

* The application loads an image and applies transformations dynamically.
* The transformed image is rendered inside a `PictureBox`.

---

## ⚙️ Technologies

* C# (.NET Framework)
* Windows Forms (WinForms)
* GDI+ Graphics

---

## 📂 Project Structure

```plaintext
GraphicsProject/
│── Form1.cs
│── Form1.Designer.cs
│── images.png
│── Program.cs
```

---

## ▶️ How to Run

1. Clone the repository:

```bash
git clone https://github.com/YOUR_USERNAME/2D-Transformations-Project.git
```

2. Open the solution in **Visual Studio**

3. Make sure the image file is included in the project

4. Run the application:

```plaintext
Press F5
```

---

## 📌 Notes

* All transformations are implemented **without using built-in matrix functions**.
* Reflection is applied relative to the **center of the object** for correct visualization.
* Input validation is used to prevent runtime errors.

---

## ⭐ Future Improvements

* 🎮 Real-time control using sliders (TrackBars)
* 🔥 Combine multiple transformations together
* 🖱️ Zoom & drag support
* 🎨 UI enhancements


