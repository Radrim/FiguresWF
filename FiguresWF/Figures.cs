//GabdrahmanovRadmir220_Figures3

namespace FiguresWF
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class Figures 
    {
        string path;

        List<Figure> figures = new List<Figure>();

        public void Add(Figure figure)
        {
            figures.Add(figure);
        }

        public void Clear() {
            figures.Clear();
        }

        public void Save(string path)
        {
            this.path = path;
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                foreach (var item in figures)
                {
                    sw.WriteLine(item.ToString());
                }
                sw.Close();
            }
        }

        public void Load(string path)
        {
            figures = new List<Figure>();
            this.path = path;

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    figures.Add(ConvertToFigure(line));
                    //Console.WriteLine(line);
                }

                foreach (var item in figures)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        public Figure ConvertToFigure(string figure)
        {
            List<int> coordArr = new List<int>();
            string coord = "";
            var figName = ' ';
            Figure fig;

            for (int i = 0; i < figure.Length; i++)
            {
                figName = figure[0];

                if (figure[i] > 47 && figure[i] < 58)
                {
                    coord = figure[i].ToString();
                    coordArr.Add(int.Parse(coord));
                }

            }

            //initializating of figure

            int x1 = coordArr[0];
            int y1 = coordArr[1];
            int x2 = coordArr[2];
            int y2 = coordArr[3];

            switch (figName)
            {
                case 'L':

                    fig = new Line(x1, y1, x2, y2);
                    break;
                case 'T':
                    int tX3 = coordArr[4];
                    int tY3 = coordArr[5];
                    fig = new Triangle(x1, y1, x2, y2, tX3, tY3);
                    break;
                case 'R':
                    int rWidth = coordArr[4];
                    int rHeight = coordArr[5];
                    fig = new Rectangle(x1, y1, rWidth, rHeight);
                    break;
                case 'C':
                    int r = coordArr[2];
                    fig = new Circle(x1, y1, r);
                    break;
                default:
                    fig = new Figure();
                    break;
            }
            return fig;
        }
    }
}