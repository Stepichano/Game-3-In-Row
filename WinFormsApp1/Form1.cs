using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public const int WHIDTH = 6;
        public const int HEIGHT = 8;
        CircleButton[,] array = new CircleButton[WHIDTH, HEIGHT]; 

        public Form1()
        {
            InitializeComponent();
            Create_Board();
        }

        private void Create_Board()
        {
            for (int i = 0; i < WHIDTH; i++)
            {
                for (int j = 0; j < HEIGHT; j++)
                {   
                    CircleButton bufer_button = Create_Button(i, j);
                    this.Controls.Add(bufer_button);
                    array [i, j] = bufer_button;
                }
            }

        }

        public CircleButton Create_Button(int i, int j)
        {   Random rand = new Random();
            CircleButton button = new CircleButton();
            button.Width = 45;
            button.Height = 45;
            button.Left = 200 + 45 * i;
            button.Top = 50 + 45 * j;
            button.BackColor = button.colors_button[rand.Next(0, 5)];
            return button;
        }

    }


}