//GabdrahmanovRadmir220_Figures3

namespace FiguresWF
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    
    class Line : Figure
    {
        private Point point2;

        public Line(int x1, int y1, int x2, int y2)
        {
            point = new Point(x1, y1);
            point2 = new Point(x2, y2);
            name = "Line";
        }

        public void Draw(Panel panel, Color color, int thickness, 
                        int numX1, int numY1, int numX2, int numY2 )
        {
            this.color = color;
            this.thickness = thickness;
            pen = new Pen(color, thickness);
            paper = panel.CreateGraphics();
            paper.DrawLine(pen, numX1, numY1, numX2, numY2);
        }

        public override string ToString()
        {
            return ($"{name}: {point.Print()} ; {point2.Print()} ; {color.ToArgb()} ; {thickness}");
        }
    }
}