//GabdrahmanovRadmir220_Figures3

namespace FiguresWF
{
    public struct Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public string Print()
        {
            return ("(" + x + ";" + y + ")");
        }
    }
}



