using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager.Custom_Control
{
    public static class Graphics
    {
        public static Image OverlayColor(Image _Image, Color Find, Color Replace)
        {
            Bitmap bitmap = new Bitmap(_Image);
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    if (!Graphics.checkBlack(bitmap.GetPixel(j, i)))
                    {
                        bitmap.SetPixel(j, i, Replace);
                    }
                }
            }
            return bitmap;
        }

        // Token: 0x0600002B RID: 43 RVA: 0x00005898 File Offset: 0x00003A98
        public static Image OverlayColor(Image _Image, Color Replace)
        {
            Bitmap bitmap = new Bitmap(_Image);
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    if (!Graphics.checkBlack(bitmap.GetPixel(j, i)))
                    {
                        bitmap.SetPixel(j, i, Replace);
                    }
                }
            }
            return bitmap;
        }

        private static bool checkBlack(Color color_0)
        {
            return color_0.R == 0 && color_0.G == 0 && color_0.B == 0;
        }
    }
}
