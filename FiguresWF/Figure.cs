//GabdrahmanovRadmir220_Figures3

namespace FiguresWF
{
    using System;
    using System.Drawing;
   
    class Figure
    {
        public Point point;
        public string name;
        public Graphics paper;
        protected Pen pen;
        protected Color color;
        protected int thickness;
        public virtual void Draw()
        {
            Console.WriteLine("Фигура: " + name + "\nКоординаты: " + point.Print());
        }
    }
}


