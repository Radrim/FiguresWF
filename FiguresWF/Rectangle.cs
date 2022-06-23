//GabdrahmanovRadmir220_Figures3

namespace FiguresWF
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    class Rectangle : Figure
    {
        private Point point2;
        private Point point3;
        private Point point4;
        private int heightRect;
        private int widthRect;

        public Rectangle(int x1, int y1, int width, int height)
        {
            heightRect = height;
            widthRect = width;

            point = new Point(x1, y1);
            point2 = new Point(x1 + width, y1);
            point3 = new Point(x1 + width, y1 - height);
            point4 = new Point(x1, y1 - height);
            name = "Rectangle";
        }

        public void Draw(Panel panel, Color color, int thickness,
                       int numX1, int numY1)
        {
            this.color = color;
            this.thickness = thickness;
            pen = new Pen(color, thickness);
            paper = panel.CreateGraphics();
            paper.DrawRectangle(pen, numX1, numY1, widthRect, heightRect);
        }

        public override string ToString()
        {
            return ($"{name}: {point.Print()} ; {widthRect} ; {heightRect} ; {color.ToArgb()} ; {thickness}");
        }
    }
}


