using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
   public class CircleButton : Button
    {   
        public static bool Move_is = false;
        public static CircleButton Move_CircleButton;
        public int Position_X { get; set; }
        public int Position_Y { get; set; }
        public int Position { get; set; }

        public static Dictionary<int, Color> colors_button = new Dictionary<int, Color>() 
        //// Колекция для выбора цветов у кнопки. Цвет выбирается по свойству Position 
        //// Пример: CircleButton.colors_button[5]. Результат возвращает цвет Red ///
        {
            { 1, Color.Green },
            { 2, Color.Blue },
            { 3, Color.Yellow},
            { 4, Color.Violet},
            { 5, Color.Red},
            { 6, Color.Orange},
            

        };
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }

}
