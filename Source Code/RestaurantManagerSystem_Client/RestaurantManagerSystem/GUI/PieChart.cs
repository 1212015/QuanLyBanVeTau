using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace c3DPieChart
{
    class PieChart
    {
        private int depth;

        private int firstAngle;
        private List<int> elements;
        private Graphics objGraphics;
        private int sum;

        public PieChart()
        {
            this.elements = new List<int>(5);
            this.sum = 0;
            this.Depth = 10;
        }

        public PieChart(Graphics objGraphics)
        {
            this.elements = new List<int>(5);
            this.sum = 0;
            this.objGraphics = objGraphics;
            this.Depth = 10;
        }

        public PieChart(int[] elements)
        {
            this.elements = new List<int>(5);
            this.sum = 0;
            this.Depth = 10;
            this.elements = new List<int>(elements);
            foreach (int num in elements)
            {
                this.sum += num;
            }
        }

        public PieChart(int[] elements, Graphics objGraphics)
        {
            this.elements = new List<int>(5);
            this.sum = 0;
            this.Depth = 10;
            this.objGraphics = objGraphics;
            this.elements = new List<int>(elements);
            foreach (int num in elements)
            {
                this.sum += num;
            }
        }

        public void Add(int element)
        {
            this.elements.Add(element);
            this.sum += element;
        }

        public void Draw()
        {
            this.Draw(this.objGraphics);
        }

        public void Draw(Graphics objGraphics)
        {
            int x = ((int)objGraphics.VisibleClipBounds.Left) + 5;
            int y = ((int)objGraphics.VisibleClipBounds.Top) + 5;
            int width = ((int)objGraphics.VisibleClipBounds.Width) - 10;
            int height = (((int)objGraphics.VisibleClipBounds.Height) - this.Depth) - 10;
            int num6 = this.FirstAngle - 90;
            SolidBrush brush = new SolidBrush(Color.Aqua);
            Random random = new Random((int)DateTime.Now.Ticks);
            objGraphics.SmoothingMode = SmoothingMode.AntiAlias;
            for (int i = 0; i < this.elements.Count; i++)
            {
                int num7;
                if (i == (this.elements.Count - 1))
                {
                    num7 = ((360 - num6) + this.FirstAngle) - 90;
                }
                else
                {
                    num7 = (this.elements[i] * 360) / this.sum;
                }
                brush.Color = Color.FromArgb(random.Next(0xff), random.Next(0xff), random.Next(0xff));
                if ((num6 < 180) && ((num6 + num7) > 0))
                {
                    objGraphics.SmoothingMode = SmoothingMode.HighSpeed;
                    Pen pen = new Pen(ControlPaint.Dark(brush.Color, 0.05f));
                    int startAngle = Math.Max(num6, 0);
                    int sweepAngle = Math.Min(num6 + num7, 180) - startAngle;
                    int num = 0;
                    while (num < this.Depth)
                    {
                        objGraphics.DrawArc(pen, x, y + num, width, height, startAngle, sweepAngle);
                        num++;
                    }
                    objGraphics.SmoothingMode = SmoothingMode.AntiAlias;
                    pen.Width = 2f;
                    objGraphics.DrawArc(pen, x, (y + num) - 1, width, height, startAngle, sweepAngle);
                }
                objGraphics.FillPie(brush, x, y, width, height, num6, num7);
                objGraphics.DrawArc(new Pen(brush, 2f), x, y, width, height, num6, num7);
                num6 += num7;
            }
        }

        public int Depth
        {

            get
            {
                return this.depth;
            }

            set
            {
                this.depth = value;
            }
        }

        public int FirstAngle
        {

            get
            {
                return this.firstAngle;
            }

            set
            {
                this.firstAngle = value;
            }
        }
    }
}
