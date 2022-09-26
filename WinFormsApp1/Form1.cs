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
                    CircleButton bufer_button = Create_Circle_Button(i, j);
                    this.Controls.Add(bufer_button);
                    array[i, j] = bufer_button;
                    bufer_button.Click += new EventHandler(Press_Button);
                }
            }

        }

        public CircleButton Create_Circle_Button(int i, int j)
        { Random rand = new Random();
            CircleButton circle_button = new CircleButton();
            circle_button.Position_X = i;
            circle_button.Position_Y = j;
            circle_button.Width = 45;
            circle_button.Height = 45;
            circle_button.Left = 200 + 45 * i;
            circle_button.Top = 50 + 45 * j;
            circle_button.BackColor = circle_button.colors_button[rand.Next(0, 5)];
            return circle_button;
        }

        public void Press_Button(object sender, EventArgs e)
        {  
           CircleButton circle_button = (CircleButton)sender;
           if (CircleButton.Move_is ) {
                if (Test_In_Neigbors(CircleButton.Move_CircleButton, circle_button))
                {
                    Swap_Circle_Buttons(CircleButton.Move_CircleButton, circle_button);
                }
                CircleButton.Move_is = false;
           } else {
                CircleButton.Move_CircleButton = circle_button;
                CircleButton.Move_is = true;

           }

        }
        
        public void Swap_Circle_Buttons(CircleButton button1, CircleButton button2)
        {
            (button2.BackColor, button1.BackColor) = (button1.BackColor, button2.BackColor);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public bool Test_In_Neigbors(CircleButton button1, CircleButton button2)
        {
            if ((Math.Abs(button1.Position_X - button2.Position_X) +
                Math.Abs(button1.Position_Y - button2.Position_Y)) == 1) {
            return true;
            }
            return false;
        }
    }


}