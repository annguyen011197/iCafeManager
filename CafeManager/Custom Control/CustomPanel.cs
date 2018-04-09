using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManager.Custom_Control
{
   
    public class CustomPanel : Panel
    {
        private System.Windows.Forms.Timer timer;
        private ContainerControl containerControl;
        private IContainer icontainer;
        private int sizeCircle = 0;


        public CustomPanel() : base()
        {
            this.Resize += control_Resize;
        }

        private void control_Resize(object sender, EventArgs e)
        {
            Elipse.Apply(this, this.sizeCircle);
        }

      

        public int ElipseRadius
        {
            get
            {
                return this.sizeCircle;
            }
            set
            {
                this.sizeCircle = value;
                this.ApplyElipse();
            }
        }

        public void ApplyElipse()
        {
            try
            {
                Elipse.Apply(this, this.sizeCircle);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi sủ lý FormEclipse");
            }
        }

       
    }
}
