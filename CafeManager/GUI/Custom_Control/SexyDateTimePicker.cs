using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManager.GUI.Custom_Control
{
    class SexyDateTimePicker :DateTimePicker
    {
        public SexyDateTimePicker() : base()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Black, 0, this.ClientSize.Height - 1, this.ClientSize.Width, this.ClientSize.Height - 1);
            e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(Color.Black), 0, 0);
            e.Graphics.DrawImage(Properties.Resources.datetime, new Point(this.ClientRectangle.X + this.ClientRectangle.Width - 16, this.ClientRectangle.Y));
        }
    }
}
