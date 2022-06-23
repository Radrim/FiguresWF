//GabdrahmanovRadmir220_Figures3

namespace FiguresWF
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    class Circle : Figure
    {
        private int radius;

        public Circle(int x1, int y1, int radius)
        {
            point = new Point(x1, y1);
            name = "Circle";
            this.radius = radius;
        }

        public void Draw(Panel panel, Color color, int thickness,
                        int numX1, int numY1)
        {
            this.color = color;
            this.thickness = thickness;
            pen = new Pen(color, thickness);
            paper = panel.CreateGraphics();
            paper.DrawEllipse(pen, numX1, numY1, radius, radius);
        }

        public override string ToString()
        {
            return ($"{name}: {point.Print()} ; radius: {radius} ; {color.ToArgb()} ; {thickness}");
        }
    }
}


