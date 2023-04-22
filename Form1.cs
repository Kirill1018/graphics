using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graph
{
    public partial class Graph_edit : Form
    {
        public Graph_edit() { InitializeComponent(); }
        Image image;
        List<Point> points = new List<Point>(), dots = new List<Point>(), spots = new List<Point>(), locations = new List<Point>(), places = new List<Point>(), pixels = new List<Point>();
        List<Rectangle> rectangles = new List<Rectangle>(), rects = new List<Rectangle>(), squares = new List<Rectangle>(), boxes = new List<Rectangle>(), _rectangles = new List<Rectangle>(), _rects = new List<Rectangle>();
        Graphics graphic_1, graphic_2, graphic_3, graphic_4, graphic_5, graphic_6;
        private void точкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rectangle = false;
            location = true;
        }

        Drawing figure = new Drawing();
        bool thin_brush, med_brush = true, thick_brush, clicking, rectangle = false, location = true, azure = true, ind_red = false;
        private void индийскийКрасныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            azure = false;
            ind_red = true;
        }

        private void лазурьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            azure = true;
            ind_red = false;
        }

        private void открытьToolStripMenuItem_Click_1(object sender, EventArgs e) { figure.Show(); }

        private void прямоугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rectangle = true;
            location = false;
        }

        private void сохранитьКакToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            filedialog.FileName = dialog.FileName;
            if (filedialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var художник = new System.IO.StreamWriter(filedialog.FileName, false, System.Text.Encoding.GetEncoding(1251));
                    художник.Write(image);
                    художник.Close();
                }
                catch (Exception ситуация) { MessageBox.Show(ситуация.Message, "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
        }

        private void средняяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thin_brush = false;
            med_brush = true;
            thick_brush = false;
        }

        private void graph_edit_Paint(object sender, PaintEventArgs e)
        {
            graphic_1 = e.Graphics;
            graphic_2 = e.Graphics;
            graphic_3 = e.Graphics;
            foreach (Point dot in points)
                graphic_1.FillEllipse(Brushes.Azure, dot.X, dot.Y, 60F, 60F);
            foreach (Point point in dots)
                graphic_2.FillEllipse(Brushes.Azure, point.X, point.Y, 100F, 100F);
            foreach (Point spot in spots)
                graphic_3.FillEllipse(Brushes.Azure, spot.X, spot.Y, 150F, 150F);
            SolidBrush brush = new SolidBrush(Color.Azure);
            foreach (Rectangle square in rectangles)
                graphic_1.FillRectangle(brush, square);
            foreach (Rectangle rectangle in rects)
                graphic_2.FillRectangle(brush, rectangle);
            foreach (Rectangle rect in squares)
                graphic_3.FillRectangle(brush, rect);
            graphic_4 = e.Graphics;
            graphic_5 = e.Graphics;
            graphic_6 = e.Graphics;
            foreach (Point _dot in locations)
                graphic_4.FillEllipse(Brushes.IndianRed, _dot.X, _dot.Y, 60F, 60F);
            foreach (Point _point in places)
                graphic_5.FillEllipse(Brushes.IndianRed, _point.X, _point.Y, 100F, 100F);
            foreach (Point _spot in pixels)
                graphic_6.FillEllipse(Brushes.IndianRed, _spot.X, _spot.Y, 150F, 150F);
            brush = new SolidBrush(Color.IndianRed);
            foreach (Rectangle box in boxes)
                graphic_4.FillRectangle(brush, box);
            foreach (Rectangle _rectangle in _rectangles)
                graphic_5.FillRectangle(brush, _rectangle);
            foreach (Rectangle _rect in _rects)
                graphic_6.FillRectangle(brush, _rect);
        }

        private void graph_edit_MouseClick(object sender, MouseEventArgs e)
        {
            if (location)
            {
                rectangle = false;
                if (azure)
                {
                    ind_red = false;
                    if (thin_brush)
                        points.Add(new Point(e.X, e.Y));
                    else if (med_brush)
                        dots.Add(new Point(e.X, e.Y));
                    else if (thick_brush)
                        spots.Add(new Point(e.X, e.Y));
                }
                else if (ind_red)
                {
                    azure = false;
                    if (thin_brush)
                        locations.Add(new Point(e.X, e.Y));
                    else if (med_brush)
                        places.Add(new Point(e.X, e.Y));
                    else if (thick_brush)
                        pixels.Add(new Point(e.X, e.Y));
                }
            }
            else if (rectangle)
            {
                location = false;
                if (azure)
                {
                    ind_red = false;
                    if (thin_brush)
                        rectangles.Add(new Rectangle(e.X, e.Y, 100, 30));
                    else if (med_brush)
                        rects.Add(new Rectangle(e.X, e.Y, 200, 60));
                    else if (thick_brush)
                        squares.Add(new Rectangle(e.X, e.Y, 300, 90));
                }
                else if (ind_red)
                {
                    azure = false;
                    if (thin_brush)
                        boxes.Add(new Rectangle(e.X, e.Y, 100, 30));
                    else if (med_brush)
                        _rects.Add(new Rectangle(e.X, e.Y, 200, 60));
                    else if (thick_brush)
                        _rectangles.Add(new Rectangle(e.X, e.Y, 300, 90));
                }
            }
            Invalidate();
        }

        private void большаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thin_brush = false;
            med_brush = false;
            thick_brush = true;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e) { this.Close(); }

        private void узкаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thin_brush = true;
            med_brush = false;
            thick_brush = false;
        }
    }
}