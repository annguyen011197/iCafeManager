using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManager
{
    public partial class Header : UserControl
    {
        private Point pClient;
        private Control control = null;
        public Header()
        {
            InitializeComponent();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pClient = e.Location;
            }
        }



        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && control != null)
            {
                control.Left += e.X - pClient.X;
                control.Top += e.Y - pClient.Y;
            }
        }


        public Control TargetControl
        {
            get
            {
                return this.control;
            }
            set
            {
                this.control = value;
            }
        }
    }
}
