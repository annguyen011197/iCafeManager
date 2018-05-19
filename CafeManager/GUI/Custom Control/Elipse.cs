using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManager
{
    public static class Elipse
    {
        [DllImport("gdi32.dll")]
        static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int cx, int cy);

        public static void Apply(Form Form, int _Elipse)
        {
            try
            {
                Form.FormBorderStyle = FormBorderStyle.None;
                Form.Region = Region.FromHrgn(Elipse.CreateRoundRectRgn(0, 0, Form.Width, Form.Height, _Elipse, _Elipse));
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xử lí giao diện Elipse cho Form");
            }
        }

        public static void Apply(Control ctrl, int _Elipse)
        {
            try
            {
                ctrl.Region = Region.FromHrgn(Elipse.CreateRoundRectRgn(0, 0, ctrl.Width, ctrl.Height, _Elipse, _Elipse));
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xử lí giao diện Elipse cho Control");
            }
        }
    }
}
