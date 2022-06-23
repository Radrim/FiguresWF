//GabdrahmanovRadmir220_Figures3

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiguresWF
{
    public partial class frmMain : Form
    {
        Figures fig = new Figures();
        string figure;
        Graphics paper;
        int thickness;
        Color color;
        public frmMain()
        {
            InitializeComponent();
            paper = pnlPaper.CreateGraphics();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            gbPoint1.Visible = false;
            gbPoint2.Visible = false;
            gbPoint3.Visible = false;
            gbParams.Visible = false;
            gbRadius.Visible = false;

            numX1.Value = 0;
            numY1.Value = 0;

            numX2.Value = 0;
            numY2.Value = 0;

            numX3.Value = 0;
            numY3.Value = 0;

            numWidth.Value = 0;
            numHeight.Value = 0;

            numThickness.Value = 0;
            numRadius.Value = 0;
        }
        private void btnLine_Click(object sender, EventArgs e)
        {
            gbPoint1.Visible = true;
            gbPoint2.Visible = true;
            figure = "Line";
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            gbPoint1.Visible = true;
            gbRadius.Visible = true;
            figure = "Circle";
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            gbPoint1.Visible = true;
            gbParams.Visible = true;
            figure = "Rect";
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            gbPoint1.Visible = true;
            gbPoint2.Visible = true;
            gbPoint3.Visible = true;
            figure = "Triangle";
        }
         

        private void btnDraw_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            thickness = Convert.ToInt32(numThickness.Value);
            color = colorDialog1.Color;

            switch (figure)
            {
                case "Line":
                {
                    Line line = new Line(Convert.ToInt32(numX1.Value), Convert.ToInt32(numY1.Value),
                                         Convert.ToInt32(numX2.Value), Convert.ToInt32(numY2.Value));
                    fig.Add(line);
                    line.Draw(pnlPaper, color, thickness, 
                                Convert.ToInt32(numX1.Value), Convert.ToInt32(numY1.Value), 
                                Convert.ToInt32(numX2.Value), Convert.ToInt32(numY2.Value));
                    break;
                }

                case "Triangle":
                {
                    Triangle triangle = new Triangle(Convert.ToInt32(numX1.Value), Convert.ToInt32(numY1.Value),
                                                       Convert.ToInt32(numX2.Value), Convert.ToInt32(numY2.Value),
                                                       Convert.ToInt32(numX3.Value), Convert.ToInt32(numY3.Value));
                    fig.Add(triangle);
                    triangle.Draw(pnlPaper, color, thickness,
                                    Convert.ToInt32(numX1.Value), Convert.ToInt32(numY1.Value),
                                    Convert.ToInt32(numX2.Value), Convert.ToInt32(numY2.Value),
                                    Convert.ToInt32(numX3.Value), Convert.ToInt32(numY3.Value));
                    break;
                }

                case "Rect":
                { 
                    Rectangle rectangle = new Rectangle(Convert.ToInt32(numX1.Value), Convert.ToInt32(numY1.Value),
                                                        Convert.ToInt32(numWidth.Value), Convert.ToInt32(numHeight.Value));
                    fig.Add(rectangle);
                    rectangle.Draw(pnlPaper, color, thickness,
                                    Convert.ToInt32(numX1.Value), Convert.ToInt32(numY1.Value));
                    break;
                }

                case "Circle":
                {
                    Circle circle = new Circle(Convert.ToInt32(numX1.Value), Convert.ToInt32(numY1.Value),
                                               Convert.ToInt32(numRadius.Value));
                    fig.Add(circle);
                        circle.Draw(pnlPaper, color, thickness, 
                                      Convert.ToInt32(numX1.Value), Convert.ToInt32(numY1.Value));
                    break;
                } 
            }
        } 

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fig.Save(saveFileDialog1.FileName);
            }
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fig.Load(openFileDialog1.FileName);
            }

            string filename = openFileDialog1.FileName;

            paper = pnlPaper.CreateGraphics();

            for (int i = 0; i < System.IO.File.ReadAllLines(filename).Length; i++)
            {
                using (StreamReader sr = new StreamReader(filename, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        ConvertToFig(line);
                    }
                }
            }
        }

        public void ConvertToFig(string line) {

            List<int> coordArr = new List<int>();
            
            var figName = line[0];

            var numbers = Regex.Matches(line, @"-?\d+");
            for (int i = 0; i < numbers.Count; i++)
            {
                string num = numbers[i].ToString();
                coordArr.Add(int.Parse(num));
            }

            //initializating of figure

            int x1 = coordArr[0];
            int y1 = coordArr[1];
            

            switch (figName)
            {
                case 'L':
                    int x2 = coordArr[2];
                    int y2 = coordArr[3];
                    Line figL = new Line(x1, y1, x2, y2);
                    figL.Draw(pnlPaper, Color.FromArgb(coordArr[4]), coordArr[5], x1, y1, x2, y2);
                    break;
                case 'T':
                    int tX2 = coordArr[2];
                    int tY2 = coordArr[3];
                    int tX3 = coordArr[4];
                    int tY3 = coordArr[5];
                    int color = coordArr[6];
                    int thickness = coordArr[7];
                    Triangle figT = new Triangle(x1, y1, tX2, tY2, tX3, tY3);
                    figT.Draw(pnlPaper, Color.FromArgb(color), thickness, x1, y1, tX2, tY2, tX3, tY3);
                    break;
                case 'R':
                    int rWidth = coordArr[2];
                    int rHeight = coordArr[3];
                    int colorR = coordArr[4];
                    int thicknessR = coordArr[5];
                    Rectangle figR = new Rectangle(x1, y1, rWidth, rHeight);
                    figR.Draw(pnlPaper, Color.FromArgb(colorR), thicknessR, x1, y1);
                    break;
                case 'C':
                    int r = coordArr[2];
                    int colorC = coordArr[3];
                    int thicknessC = coordArr[4];
                    Circle figC = new Circle(x1, y1, r);
                    figC.Draw(pnlPaper, Color.FromArgb(colorC), thicknessC, x1, y1);

                    break;
                default:
                    Figure figDefault = new Figure();
                    break;
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            paper.Clear(Color.White);
            fig.Clear();
        }

    }
}
