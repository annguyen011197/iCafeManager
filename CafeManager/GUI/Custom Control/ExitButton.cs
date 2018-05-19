using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManager.Custom_Control
{
    public partial class ExitButton : Button
    {
        public ExitButton()
        {
            this.BackgroundImage = Properties.Resources.exit;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Text = "";
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseOverBackColor = Color.Red;
            this.FlatAppearance.MouseDownBackColor = Color.Tomato;
            InitializeComponent();
        }

        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
            SuspendLayout();
            this.BackgroundImage = Properties.Resources.exit_hover;
            ResumeLayout();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            SuspendLayout();
            this.BackgroundImage = Properties.Resources.exit;
            ResumeLayout();
        }
    }
}
