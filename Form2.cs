using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace graph
{
    public partial class Drawing : Form
    {
        public Drawing() { InitializeComponent(); }
        System.Drawing.Image illustration;
        private void panel_Paint(object sender, PaintEventArgs e)
        {
            OpenFileDialog open_dial = new OpenFileDialog();
            open_dial.Filter = "файлы изображений|*.bmp;*.png;*.jpg";
            if (open_dial.ShowDialog() != DialogResult.OK)
                return;
            try { illustration = System.Drawing.Image.FromFile(open_dial.FileName); }
            catch (OutOfMemoryException exception)
            {
                MessageBox.Show("ошибка чтения картинки");
                return;
            }
            if (illustration == null)
                return;
            e.Graphics.DrawImage(illustration, panel.AutoScrollPosition.X, panel.AutoScrollPosition.Y, illustration.Size.Width, illustration.Size.Height);
        }
    }
}