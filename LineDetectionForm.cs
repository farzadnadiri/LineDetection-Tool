using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System.Collections.Generic;

namespace LineDetection
{
    public partial class LineDetectionForm : Form
    {
        public LineDetectionForm()
        {
            InitializeComponent();
        }

        private Image<Hsv, Byte> _frameImage;
        private Image<Gray, Byte> _maskedImage;
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                imageBox1.Load(openFileDialog1.FileName);
            }
        }
        int SelectedLineSegmentIndex = -1;

        private void Process2(Image<Hsv, Byte> image)
        {
            for (int i = 0; i < 320; i++)
            {
                for (int j = 0; j < 240; j++)
                {
                    if (IsInColorRange(image.Data[j, i, 0], image.Data[j, i, 1], image.Data[j, i, 2]))
                    {
                        image.Data[j, i, 0] = 100;
                        image.Data[j, i, 1] = 255;
                        image.Data[j, i, 2] = 255;
                        break;
                    }
                    else
                    {
                        image.Data[j, i, 0] = 0;
                        image.Data[j, i, 1] = 0;
                        image.Data[j, i, 2] = 0;
                    }
                }
            }
            _maskedImage = image.InRange(new Hsv(Convert.ToDouble(numericUpDownHmin.Value), Convert.ToDouble(numericUpDownSmin.Value), Convert.ToDouble(numericUpDownVmin.Value)), new Hsv(Convert.ToDouble(numericUpDownHmax.Value), Convert.ToDouble(numericUpDownSmax.Value), Convert.ToDouble(numericUpDownVmax.Value)));
            if (radioButton2.Checked)
                imageBox2.Image = _maskedImage;
            Image<Gray, Byte> cannyEdges = _maskedImage.Canny(180, 120);
            var lines = cannyEdges.HoughLinesBinary(
                1, //Distance resolution in pixel-related units
                Math.PI / 45.0, //Angle resolution measured in radians.
                20, //threshold
                30, //min Line width
                10 //gap between lines
                )[0]; //Get the lines from the first channel


            var GroupByDirection = GroupingLines(lines.ToList(),0.08,true);
            var finalList = new List<List<LineSegment2D>>();
            for (int k = 0; k < GroupByDirection.Count; k++)
            {
                var childGroup = GroupingLines(GroupByDirection[k],10,false);
                foreach (var group in childGroup)
                {
                    finalList.Add(group);
                }
            }

            listBox1.Items.Clear();
            for (int k = 0; k < finalList.Count; k++)
            {
                listBox1.Items.Add("Group:" + k + " Count:" + finalList[k].Count);
            }

            label14.Text = lines.Length.ToString();
            dataGridView1.Rows.Clear();
            var hsv = new Hsv(180, 255, 255);
            int jj = 180;
            foreach (var list in finalList)
            {
                foreach (var line in list)
                {
                    dataGridView1.Rows.Add(dataGridView1.Rows.Count+1, line.P1, line.P2, line.Length, line.Direction.ToString(), "Select");
                    image.Draw(line, hsv, 2);
                }
                jj-=30;
                hsv = new Hsv(jj, 255, 255);
               
            }
            var lieList = new List<LineSegment2D>();
            var finalImage = image.CopyBlank();
            foreach (var list in finalList)
            {
                if (list.Count > 0)
                {
                    var m = CreateLineFromGroup(list);
                    lieList.Add(m);
                    finalImage.Draw(m, new Hsv(50, 255, 255), 2);
                }
            }
            Point intersec=new Point(0,0);
            var CornerList = new List<corner>();
            for (int write = 0; write < lieList.Count; write++)
            {
                for (int sort = 0; sort < lieList.Count - 1; sort++)
                {
                    var first = Distance_BtwPointAndLine(lieList[sort],lieList[sort+1].P1);
                    var sec = Distance_BtwPointAndLine(lieList[sort], lieList[sort + 1].P2);

                    var cor = new corner();
                    if (first<90)
                    {
                        cor.Type = "L";
                        cor.pos = lieList[sort+1].P1;
                        CornerList.Add(cor);
                    }
                    else if (sec<90)
                    {
                        cor.Type = "L";
                        cor.pos = lieList[sort+1].P2;
                        CornerList.Add(cor);
                    }
                    else if (first < 200)
                    {
                        cor.Type = "T";
                        cor.pos = lieList[sort + 1].P2;
                        CornerList.Add(cor);
                    
                    }
                    else if (sec < 200)
                    {
                        cor.Type = "T";
                        cor.pos = lieList[sort + 1].P1;
                        CornerList.Add(cor);
                    
                    }
                }
            }
            
            foreach (var corner in CornerList)
            {
                finalImage.Draw(new CircleF(corner.pos,5), new Hsv(180, 255, 255), 2);
                MCvFont f = new MCvFont(FONT.CV_FONT_HERSHEY_COMPLEX, 0.7, 0.7);
                if(corner.Type=="L")
                finalImage.Draw("L", ref f, new Point(corner.pos.X,corner.pos.Y-15), new Hsv(110, 255, 255));
                else if(corner.Type=="T")
                    finalImage.Draw("T", ref f, new Point(corner.pos.X, corner.pos.Y - 15), new Hsv(110, 255, 255));
                else
                    finalImage.Draw("X", ref f, new Point(corner.pos.X, corner.pos.Y - 15), new Hsv(110, 255, 255));
            }

            imageBox4.Image = finalImage;
          
            //for (int i = 0; i < lines.Count(); i++)
            //{
            //    dataGridView1.Rows.Add(i, lines[i].P1, lines[i].P2, lines[i].Length, lines[i].Direction.ToString(), "Select");
            //    if (SelectedLineSegmentIndex == i)
            //    {
            //        image.Draw(lines[i], new Hsv(50, 255, 255), 2);
            //        dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.GreenYellow;
            //        dataGridView1.Rows[i].Cells[1].Style.BackColor = Color.GreenYellow;
            //        dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.GreenYellow;
            //        dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.GreenYellow;
            //        dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.GreenYellow;
            //        dataGridView1.Rows[i].Cells[5].Style.BackColor = Color.GreenYellow;
            //    }
            //    else
            //    {
            //        image.Draw(lines[i], new Hsv(180, 255, 255), 2);
            //    }
            //}

            imageBox3.Image = image;
        }
        private void numericUpDownHmin_ValueChanged(object sender, EventArgs e)
        {
            Image<Bgr, Byte> img = new Image<Bgr, byte>(textBox1.Text);
            Process2(img.Convert<Hsv, Byte>());
        }
        public bool IsInColorRange(int h, int s, int v)
        {
            return (h >= numericUpDownFieldHmin.Value && h <= numericUpDownFieldHmax.Value) && (s >= numericUpDownFieldSmin.Value && s <= numericUpDownFieldSmax.Value) && (v >= numericUpDownFieldVmin.Value && v <= numericUpDownFieldVmax.Value);
        }

        private double Distance_BtwnPoints(Point p, Point q)
        {
            int X_Diff = p.X - q.X;
            int Y_Diff = p.Y - q.Y;
            return Math.Sqrt((X_Diff * X_Diff) + (Y_Diff * Y_Diff));
        }
        private double Distance_BtwPointAndLine(LineSegment2D line, Point p)
        {
            var landa = ((line.P2.X - line.P1.X) + (line.P2.Y - line.P1.Y)) / (Math.Pow((line.P2.X - line.P1.X), 2) + Math.Pow((line.P2.Y - line.P1.Y), 2));
            return Math.Sqrt(Math.Pow((p.X - line.P1.X - landa * (line.P2.X - line.P1.X)), 2) + Math.Pow((p.Y - line.P1.Y - landa * (line.P2.Y - line.P1.Y)), 2));
        }

   
        private bool intersection(Point o1, Point p1, Point o2, Point p2, ref Point r)
        {
            Point x = new Point(o2.X - o1.X, o2.Y - o1.Y);
            Point d1 = new Point(p1.X - o1.X, p1.Y - o1.Y);
            Point d2 = new Point(p2.X - o2.X, p2.Y - o2.Y);

            float cross = d1.X * d2.Y - d1.Y * d2.X;
            if (Math.Abs(cross) < 1e-8)
                return false;

            double t1 = (x.X * d2.Y - x.Y * d2.X) / cross;
            r = new Point(Convert.ToInt32(o1.X + d1.X * t1), Convert.ToInt32(o1.Y + d1.Y * t1));
            return true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex != 5) return;
            SelectedLineSegmentIndex = e.RowIndex;
            Image<Bgr, Byte> img = new Image<Bgr, byte>(textBox1.Text);
            Process2(img.Convert<Hsv, Byte>());
        }

        private double GetGradient(LineSegment2D line)
        {
            return line.Direction.Y / line.Direction.X;
        }

        private double GetC(LineSegment2D line)
        {  // y=mx+c
            return line.P1.Y - line.P1.X * GetGradient(line);
        }

        private List<List<LineSegment2D>> GroupingLines(List<LineSegment2D> list , double step , bool GroupByDirection)
        {
            var Lines = new List<List<LineSegment2D>>();
            int start = 0;
            if (GroupByDirection)
            {
                list = list.OrderBy(o => o.Direction.Y).ToList();
                for (int i = 0; i < list.Count-1; i++)
                {
                    if (Math.Abs(list[i].Direction.Y - list[i + 1].Direction.Y) > step)
                    {
                        Lines.Add(list.GetRange(start, i-start+1));
                        start = i+1;
                    }
                }
                Lines.Add(list.GetRange(start, list.Count-start));
            }
            else 
            {
                list = list.OrderBy(o => GetC(o)).ToList();

                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (Math.Abs(GetC(list[i]) - GetC(list[i + 1])) > step)
                    {
                        Lines.Add(list.GetRange(start, i - start + 1));
                        start = i + 1;
                    }
                }
                Lines.Add(list.GetRange(start, list.Count - start));
            }

            return Lines;
        }

        private LineSegment2D CreateLineFromGroup(List<LineSegment2D> list)
        {
            
            var x = new List<int>();
            var y = new List<int>();

            foreach (var line in list)
            {
                x.Add(line.P1.X);
                x.Add(line.P2.X);
                y.Add(line.P1.Y);
                y.Add(line.P2.Y);
            }
            if(list[0].Direction.Y>0)
            return new LineSegment2D(new Point(x.Min(),y.Max()),new Point(x.Max(),y.Min()));
            else
                return new LineSegment2D(new Point(x.Min(), y.Min()), new Point(x.Max(), y.Max()));
        
        }
      
    }
   public class corner
    {
       public string Type;
       public Point pos;
    }
}
