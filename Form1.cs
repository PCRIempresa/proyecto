using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Año
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Public Class Form1;
            {
                Dim t As Integer;
                Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick;

                t = t + 1;

                If t &gt;= 450 Then;
                t = 26;
                End If;

                PictureBox1.Left = t;
                End Sub;

                Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click;

                Timer1.Enabled = True;
                End Sub;

                Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click;

                Timer1.Enabled = False;
                End Sub;

                Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load;

                t = 26;
                End Sub;
                End Class;
            }
        }

        private void ImagenFondo_Click(object sender, EventArgs e)
        {

        }

        private class Public
        {
        }
    }
}
