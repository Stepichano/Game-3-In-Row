using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public const int BUTTON_SIZE = 50;
        public const int INDENT_Y = 50;
        public const int INDENT_X = 250;
        public const int WHIDTH = 8;
        public const int HEIGHT = 8;
       
        public CircleButton[,] array = new CircleButton[HEIGHT, WHIDTH];
        public Form1()
        {
            Init();
        }

        public void Init()
        {  
            InitializeComponent();
            Create_Board();
        }
        public void Create_Board()
        {
            for (int j = 0; j < HEIGHT; j++)
            {
                for (int i = 0; i < WHIDTH; i++)
                {
                    CircleButton bufer_button = Create_Circle_Button(i, j);
                    this.Controls.Add(bufer_button);
                    array[j, i] = bufer_button;
                    bufer_button.Click += new EventHandler(Press_Button);
                }
            }

        }

        public CircleButton Create_Circle_Button(int i, int j)
        {
            Random rand = new Random();
            CircleButton circle_button = new CircleButton();
            circle_button.Position = rand.Next(1, 7);
            circle_button.Position_X = i;
            circle_button.Position_Y = j;
            circle_button.Width = BUTTON_SIZE;
            circle_button.Height = BUTTON_SIZE;
            circle_button.Left = INDENT_X + BUTTON_SIZE * i;
            circle_button.Top = INDENT_Y + BUTTON_SIZE * j;
            circle_button.BackColor = CircleButton.colors_button[circle_button.Position];
            return circle_button;
        }

        public void Press_Button(object sender, EventArgs e)
        {
            CircleButton circle_button = (CircleButton)sender;
            if (CircleButton.Move_is)
            {
                if (Test_In_Neigbors(CircleButton.Move_CircleButton, circle_button))
                {
                    Swap_Circle_Buttons(CircleButton.Move_CircleButton, circle_button);
                    Algoritm_Searches_Group_Gorizontal();
                    Algoritm_Searches_Group_Vertical();
                    Subsidence_buttons();
                    Killer();
                }
                CircleButton.Move_is = false;
            }
            else
            {
                CircleButton.Move_CircleButton = circle_button;
                CircleButton.Move_is = true;

            }

        }

        public void Swap_Circle_Buttons(CircleButton button1, CircleButton button2)
        {
            (button1.Position, button2.Position) = (button2.Position, button1.Position);
            (button1.BackColor, button2.BackColor) = (button2.BackColor, button1.BackColor);

        }

        public bool Test_In_Neigbors(CircleButton button1, CircleButton button2)
        {
            if ((Math.Abs(button1.Position_X - button2.Position_X) +
                Math.Abs(button1.Position_Y - button2.Position_Y)) == 1)
            {
                return true;
            }
            return false;
        }

        public void Algoritm_Searches_Group_Gorizontal()
        {
            int amount_elem = 0;
            int number_Group = 0;
            int amount_Group = 0;         
            for (int y = 0; y < HEIGHT; y++)
            {
                amount_elem = 0;
                for (int x = 0; x < WHIDTH; x++)
                {
                    if (x == 0) { number_Group = Math.Abs(array[y, x].Position); };
                    if (Math.Abs(array[y, x].Position) == number_Group)
                    {
                        amount_elem++;
                        if (x == WHIDTH - 1 && amount_elem > 2)
                        {
                            amount_Group++;
                            for (int i = 0; i < amount_elem; i++)
                            {
                                array[y, x - amount_elem + i].Position = (-1) * Math.Abs(array[y, x - amount_elem + i].Position);
                            }
                        }

                    }
                    else
                    {
                        if (amount_elem > 2)
                        {
                            amount_Group++;
                            for (int i = 0; i < amount_elem; i++)
                            {
                                array[y, x - amount_elem + i].Position = (-1) *
                                    Math.Abs(array[y, x - amount_elem + i].Position);
                            }
                        }
                        amount_elem = 1;
                        number_Group = array[y, x].Position;
                    }



                }



            }
        }

        public void Algoritm_Searches_Group_Vertical()
        {
            int amount_elem = 0;
            int number_Group = 0;
            int amount_Group = 0;
            for (int x = 0; x < WHIDTH; x++)
            {
                amount_elem = 0;
                for (int y = 0; y < HEIGHT; y++)
                {
                    if (y == 0) { number_Group = Math.Abs(array[y, x].Position); };
                    if (Math.Abs(array[y, x].Position) == number_Group)
                    {
                        amount_elem++;
                        if (y == HEIGHT - 1 && amount_elem > 2)
                        {
                            amount_Group++;
                            for (int i = 0; i < amount_elem; i++)
                            {
                                array[y - amount_elem + i, x].Position = (-1) * Math.Abs(array[y - amount_elem + i, x].Position);
                            }
                        }

                    }
                    else
                    {
                        if (amount_elem > 2)
                        {
                            amount_Group++;
                            for (int i = 0; i < amount_elem; i++)
                            {
                                array[y - amount_elem + i, x].Position = (-1) *
                                    Math.Abs(array[y - amount_elem + i, x].Position);
                            }
                        }
                        amount_elem = 1;
                        number_Group = array[y, x].Position;
                    }



                }



            }
        }

        public void Start_Algoritm(int mode)
        {
            
           

           
        }

        public void Killer()
        {   Random rnd = new Random();
            for (int i = 0; i < HEIGHT; i++)
            {
                for (int j = 0; j < WHIDTH; j++)
                {   
                    if (array[i, j].Position < 0)
                    {
                        array[i, j].Position = rnd.Next(1, 7);
                        array[i, j].BackColor = CircleButton.colors_button[array[i, j].Position];
                    }
                }
            }
        }

        public void Subsidence_buttons()
        {
            for (int x = 0; x < WHIDTH; x++)
            {
                int y_hole = 0;
                int amount_hole = 0;
                for (int y = HEIGHT - 1; y >= 0; y--)
                {
                    if (array[y, x].Position < 0)
                    {
                        amount_hole++;
                        if (amount_hole == 1) { y_hole = y; }


                    }
                    if (array[y, x].Position > 0 && amount_hole > 0)
                    {
                        array [y_hole, x].Position = array[y, x].Position;
                        (array[y_hole, x].BackColor, array[y, x].BackColor) = (array[y, x].BackColor, array[y_hole, x].BackColor);
                        y_hole--;
                        array[y, x].Position = -1;
                    }
                }
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Init();
        }

        private void exitToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 new_Form2 = new Form2();
            this.Hide();
            new_Form2.Show();
        }

    }
}