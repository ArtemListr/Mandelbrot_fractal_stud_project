using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fractal_listr
{
    class Mandelbrot
    {
        public readonly Bitmap bmp;
        private readonly int max_iter;

        public Mandelbrot(double x0, double y0, double size, int p_max_iter, int bmp_size)
        {
            bmp = new Bitmap(bmp_size, bmp_size); //размеры пикбокса
            max_iter = p_max_iter;
            double x = x0;// координаты верхнего угла
            double y = y0;
            double delta = size / bmp_size;
            for (int i = 0; i < bmp_size; i++) /// перебираем все точки бмп меняем координаты (пиксели->координаты)
            {
                for (int j = 0; j < bmp_size; j++)
                {
                    bmp.SetPixel(j, i, get_Pixel_Color(get_Iter_Count(x, y)));
                    // (сверху) окрашиваем данный пиксель в цвет соотв условию функции
                    // пиксель через координаты
                    x = x + delta;//переход к следующей точке
                }
                x = x0;// х в начало
                y = y + delta;

            }
        }

        private int get_Iter_Count(double x0, double y0)
        {
            double x = x0; //координаты на пикбоксе
            double y = y0;
            int iter = 0; //счетчик итераций

            while (x * x + y * y < 4 && iter < max_iter)
            {
                double temp_x = x;
                x = x * x - y * y + x0;
                y = 2 * temp_x * y + y0;
                iter++;
            }

            return iter;
        }

        private Color get_Pixel_Color(int iter_count)
        {
            //УСЛОВИЕ ПОКРАСА: если в множестве- черный, остальное в рандомных цветах
            
            //белый
            //K = max_iter / (0xffffff);

            //черный (снизу)
            double K = 1 - ((double)iter_count / max_iter);
            uint clr = (uint)(K * (0xffffff)) + 0xff000000;
            return Color.FromArgb((int)clr);
        }

        ~Mandelbrot()
        {
            bmp.Dispose();
        }
    }
}