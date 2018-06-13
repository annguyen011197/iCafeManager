using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeManager.Model;
using CafeManager.Utils;
namespace CafeManager
{
    public partial class AccountControl : UserControl
    {
        private Account account;
        private List<Color> listColor = new List<Color>();
        public Boolean Checked { get; set; }
        public delegate void onClickAccount(AccountControl tb);

        public onClickAccount onClick;

        public AccountControl()
        {
            InitializeComponent();
            listColor.Add(Color.FromArgb(26, 188, 156));
            listColor.Add(Color.FromArgb(46, 204, 113));
            listColor.Add(Color.FromArgb(52, 152, 219));
            listColor.Add(Color.FromArgb(155, 89, 182));
            listColor.Add(Color.FromArgb(52, 73, 94));
            listColor.Add(Color.FromArgb(241, 196, 15));
            listColor.Add(Color.FromArgb(231, 76, 60));
            listColor.Add(Color.FromArgb(230, 126, 34));
            Checked = false;
            unCheck();
        }

        private ToolTip createToolTip()
        {
            ToolTip toolTip1 = new ToolTip();
            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;
            return toolTip1;
        }

        public Account Account {
            get {
                return account;
            }
            set {
                account = value;
                String[] Names = account.Display_Name.Split(' ');
                String name = Names[Names.Length - 1];
                label1.Text = name.ToString();
                
                createToolTip().SetToolTip(this.label1, account.Display_Name);
            }
        }

        public void check(){
            BackColor = "#2980b9".ToColor();
            Checked = true;
        }
        public void unCheck()
        {
            BackColor = "#3498db".ToColor();
            Checked = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            onClick(this);
        }
    }
}
