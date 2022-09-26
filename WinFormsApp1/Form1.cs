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
        public const int WHIDTH = 6;
        public const int HEIGHT = 8;
        public int amount_elem = 0;
        public int number_Group = 0;
        public int amount_Group = 0;
        public CircleButton[,] array = new CircleButton[WHIDTH, HEIGHT];
        public Form1()
        {
            InitializeComponent();
            Create_Board();
        }

        public void Create_Board()
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
            circle_button.Position = rand.Next(1, 7);
            circle_button.Position_X = i;
            circle_button.Position_Y = j;
            circle_button.Width = 45;
            circle_button.Height = 45;
            circle_button.Left = 200 + 45 * i;
            circle_button.Top = 50 + 45 * j;
            circle_button.BackColor = circle_button.colors_button[circle_button.Position];
            return circle_button;
        }

        public void Press_Button(object sender, EventArgs e)
        {  
           CircleButton circle_button = (CircleButton)sender;
           if (CircleButton.Move_is ) {
                if (Test_In_Neigbors(CircleButton.Move_CircleButton, circle_button))
                {
                    Swap_Circle_Buttons(CircleButton.Move_CircleButton, circle_button);
                //    Algoritm_Searches_Group_Gorizontal();
                    Algoritm_Searches_Group_Vertical();
                }
                CircleButton.Move_is = false;
           } else {
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
                Math.Abs(button1.Position_Y - button2.Position_Y)) == 1) {
            return true;
            }
            return false;
        }        

        public void Algoritm_Searches_Group_Gorizontal()
        {
            for (int y = 0; y < Height; y++)
            {
                amount_elem = 0;
                for (int x = 0; x < WHIDTH; x++)
                {
                    if (x == 0) { number_Group = Math.Abs(array[y, x].Position); };
                    if (Math.Abs(array[y, x].Position) == number_Group)   {
                        amount_elem++;
                        if (x == 6 && amount_elem > 2)
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
            for (int x = 0; x < WHIDTH - 1; x++)
            {
                amount_elem = 0;
                for (int y = 0; y < Height - 1; y++)
                {
                    if (y == 0) { number_Group = Math.Abs(array[y, x].Position); };
                    if (Math.Abs(array[y, x].Position) == number_Group)
                    {
                        amount_elem++;
                        if (y == Height && amount_elem > 2)
                        {
                            amount_Group++;
                            for (int i = 0; i < amount_elem; i++)
                            {
                                array[y - amount_elem + i, x].Position = (-1) * Math.Abs(array[y, x - amount_elem + i].Position);
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
                                    Math.Abs(array[y - amount_elem + i, x].Position);
                            }
                        }
                        amount_elem = 1;
                        number_Group = array[y, x].Position;
                    }



                }



            }
        }
    }



}
