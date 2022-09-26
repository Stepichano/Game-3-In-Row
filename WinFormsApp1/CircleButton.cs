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
        public Dictionary<int, Color> colors_button = new Dictionary<int, Color>()
        {
            { 0, Color.Red },
            { 1, Color.Green },
            { 2, Color.Blue },
            { 3, Color.Yellow},
            { 4, Color.Violet},

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
