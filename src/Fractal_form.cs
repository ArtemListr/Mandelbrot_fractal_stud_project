using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace Fractal_listr
{
    public partial class Fractal_form : Form
    {
        private Mandelbrot mandelbrot;
        private const decimal x0 = -2;// начальные значения
        private const decimal y0 = -2;
        private const decimal size = 4;
        private bool event_handler_enabled = true;
        private Point start_point;
        public Fractal_form()
        {
            InitializeComponent();
            Create_Image();
            tssl_size.Text = picbox.Width.ToString() + " x " + picbox.Height.ToString();
        }


        private void Create_Image()
        {
            tssl_status.Text = "|Ожидайте|";
            StatStrip.Refresh();
            int bmp_size = picbox.Height > picbox.Width ? picbox.Width : picbox.Height;
            mandelbrot = new Mandelbrot((double)nudX.Value, (double)nudY.Value, (double)nudSize.Value, (int)nudIter.Value, bmp_size);
            tssl_status.Text = "|Изображение готово|";
            picbox.Invalidate();
        }

        private void Zoom(Point p, decimal scale)//  передаем кординаты точки и увеличиваем или уменьшаем
        {
            event_handler_enabled = false;
            decimal X_center = nudX.Value + nudSize.Value * ((decimal)p.X / mandelbrot.bmp.Width);
            decimal Y_center = nudY.Value + nudSize.Value * ((decimal)p.Y / mandelbrot.bmp.Height);//координаты центра
            Set_nud(nudSize, nudSize.Value / scale);
            Set_nud(nudX, X_center - nudSize.Value / 2);
            Set_nud(nudY, Y_center - nudSize.Value / 2);
            event_handler_enabled = true; // чтобы лишнее не вычислялось
            Create_Image();
        }

        private void nudIter_ValueChanged(object sender, EventArgs e)
        {
            Create_Image();
        }

        private void bt_Draw_Click(object sender, EventArgs e)
        {
            int bmp_size = picbox.Height > picbox.Width ? picbox.Width : picbox.Height;
            mandelbrot = new Mandelbrot((double)nudX.Value, (double)nudY.Value, (double)nudSize.Value, (int)nudIter.Value, bmp_size);
            picbox.CreateGraphics().DrawImage(mandelbrot.bmp, 0, 0);
        }

        private void picbox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(mandelbrot.bmp, 0, 0);
        }

       

        private void bt_savepic_Click(object sender, EventArgs e)
        {
            if (sfd_image.ShowDialog() == DialogResult.OK)
            {
                switch (sfd_image.FilterIndex)
                {
                    case 1: mandelbrot.bmp.Save(sfd_image.FileName, ImageFormat.Png); break;
                    case 2: mandelbrot.bmp.Save(sfd_image.FileName, ImageFormat.Bmp); break;
                    default: mandelbrot.bmp.Save(sfd_image.FileName, ImageFormat.Jpeg); break;
                }
            }
        }

        private void bt_saveparam_Click(object sender, EventArgs e)
        {
            if (sfd_param.ShowDialog() == DialogResult.OK)
            {
                StreamWriter bwt = new StreamWriter(sfd_param.FileName);
                bwt.WriteLine(nudX.Value.ToString());
                bwt.WriteLine(nudY.Value.ToString());
                bwt.WriteLine(nudSize.Value.ToString());
                bwt.WriteLine(nudIter.Value.ToString());
                bwt.Dispose();
            }
        }

        private void picbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button ==MouseButtons.Left)
            {
                Zoom(e.Location, nudZoom.Value);
                Invalidate();
            }
            else if (e.Button == MouseButtons.Right)
            {
                Zoom(e.Location, 1 / nudZoom.Value);
                Invalidate();
            }
        }


        private void picbox_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
                start_point = e.Location;
        }

        private void Set_nud(NumericUpDown nud, decimal value) //1.2 - крайние значения
        {
            if (nud.Minimum > value)
                nud.Value = nud.Minimum;
            else if (nud.Maximum < value)
                nud.Value = nud.Maximum;
            else
                nud.Value = value;
        }
        private void picbox_MouseUp(object sender, MouseEventArgs e)
        {
            event_handler_enabled = false;
            int dx = start_point.X - e.X;
            int dy = start_point.Y - e.Y;
            Set_nud(nudX, nudX.Value + nudSize.Value * ((decimal)dx / picbox.ClientSize.Width));
            Set_nud(nudY, nudY.Value + nudSize.Value * ((decimal)dy / picbox.ClientSize.Height));
            event_handler_enabled = true;
            Create_Image();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int bmp_size = picbox.Height > picbox.Width ? picbox.Width : picbox.Height;
            bmp_size = bmp_size / 2;
            Point zoom_point = new Point(bmp_size, bmp_size);
            if (rb_iteration.Checked == true)
                nudIter.Value++;
            else if (rb_deep.Checked == true)
                Zoom(zoom_point, nudZoom.Value);
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void bt_loadparam_Click(object sender, EventArgs e)
        {
            if (ofd_param.ShowDialog() == DialogResult.OK)
            {
                switch (ofd_param.FilterIndex)
                {
                    case 1:
                        StreamReader sr = new StreamReader(ofd_param.FileName);
                        nudX.Value = Convert.ToDecimal(sr.ReadLine());
                        nudY.Value = Convert.ToDecimal(sr.ReadLine());
                        nudSize.Value = Convert.ToDecimal(sr.ReadLine());
                        nudIter.Value = Convert.ToDecimal(sr.ReadLine());
                        sr.Dispose();
                        break;

                    case 2:
                        BinaryReader br = new BinaryReader(File.Open(ofd_param.FileName, FileMode.Open));
                        nudX.Value = br.ReadDecimal();
                        nudY.Value = br.ReadDecimal();
                        nudSize.Value = br.ReadDecimal();
                        nudIter.Value = br.ReadDecimal();
                        br.Dispose();
                        break;
                }
            }
            Create_Image();
        }

        private void bt_loadpic_Click(object sender, EventArgs e)
        {
            if (ofd_image.ShowDialog() == DialogResult.OK)
            {
                picbox.Load(sfd_image.FileName);
                picbox.Invalidate();
            }
        }

        private void Fractal_form_Resize(object sender, EventArgs e)
        {
            tssl_size.Text = picbox.Width.ToString() + "x" + picbox.Height.ToString();
            Create_Image();
        }

        private void picbox_MouseMove(object sender, MouseEventArgs e)
        {
            tssl_Cursor.Text = e.X.ToString() + "|" + e.Y.ToString();
        }

        

        private void bt_Restart_Click(object sender, EventArgs e)
        {
            nudX.Value = -2;
            nudY.Value = -2;
            nudZoom.Value = 2;
            nudSize.Value = 4;
            nudIter.Value = 127;
            Create_Image();
            //зато без ошибок
        }
    }
}
