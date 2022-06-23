//GabdrahmanovRadmir220_Figures3

namespace FiguresWF
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    class Triangle : Figure
    {
        private Point point2;
        private Point point3;

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            point = new Point(x1, y1);
            point2 = new Point(x2, y2);
            point3 = new Point(x3, y3);
            name = "Triangle";
        }

        public void Draw(Panel panel, Color color, int thickness,
                         int numX1, int numY1, int numX2, int numY2, int numX3, int numY3)
        {
            this.color = color;
            this.thickness = thickness;
            pen = new Pen(color, thickness);
            paper = panel.CreateGraphics();
            paper.DrawLine(pen, numX1, numY1, numX2, numY2);
            paper.DrawLine(pen, numX2, numY2, numX3, numY3);
            paper.DrawLine(pen, numX3, numY3, numX1, numY1);
        }

        public override string ToString()
        {
            return ($"{name}: {point.Print()} ; {point2.Print()} ; {point3.Print()} ; {color.ToArgb()} ; {thickness}");
        }
    }
}