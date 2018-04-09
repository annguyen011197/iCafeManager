using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace CafeManager.Custom_Control
{
    public partial class TextboxCustom : UserControl
    {
        public TextboxCustom()
        {
            InitializeComponent();
            this.pictureBox1.Top = base.Height / 2 - this.pictureBox1.Height / 2;
            this.textBox1.Top = base.Height / 2 - this.textBox1.Height / 2;
            this.textBox1.Width = base.Width - this.textBox1.Left - 10;
            this.BackgroundImage =Graphics.OverlayColor(this.BackgroundImage, this.ForeColor);
            this.pictureBox1.Image =Graphics.OverlayColor(this.pictureBox1.Image, this.ForeColor);
        }




        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.eventHandler_TextChanged != null)
            {
                this.eventHandler_TextChanged(this, e);
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.eventHandler_KeyDown != null)
            {
                this.eventHandler_KeyDown(this, e);
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.eventHandler_KeyPress != null)
            {
                this.eventHandler_KeyPress(this, e);
            }
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.eventHandler_KeyUp != null)
            {
                this.eventHandler_KeyUp(this, e);
            }
        }

        [CompilerGenerated]
        private EventHandler eventHandler_TextChanged;
        [CompilerGenerated]
        private EventHandler eventHandler_KeyDown;
        [CompilerGenerated]
        private EventHandler eventHandler_KeyPress;
        [CompilerGenerated]
        private EventHandler eventHandler_KeyUp;

        private void TextboxCustom_BackColorChanged(object sender, EventArgs e)
        {
            this.textBox1.BackColor = this.BackColor;
        }

        private void TextboxCustom_ForeColorChanged(object sender, EventArgs e)
        {
            this.textBox1.ForeColor = this.ForeColor;
            this.BackgroundImage = Graphics.OverlayColor(this.BackgroundImage, this.ForeColor);
            this.pictureBox1.Image = Graphics.OverlayColor(this.pictureBox1.Image, this.ForeColor);
        }

        private void TextboxCustom_Resize(object sender, EventArgs e)
        {
            this.pictureBox1.Top = base.Height / 2 - this.pictureBox1.Height / 2;
            this.textBox1.Top = base.Height / 2 - this.textBox1.Height / 2;
            this.textBox1.Width = base.Width - this.textBox1.Left - 10;
        }
    }

}
