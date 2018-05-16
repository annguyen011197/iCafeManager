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

namespace CafeManager
{
    public partial class TableControl : UserControl
    {
        private Table table;

        public delegate void onClickTable(TableControl tb);

        public onClickTable onClick;

        public TableControl()
        {
            InitializeComponent();
        }

        public Table Table {
            get {
                return table;
            }
            set {
                table = value;
                label1.Text = table.Name;
                label2.Text = table.Status ? "Có Người" : "Trống";
                if (!table.Status)
                {
                    this.BackColor = Color.FromArgb(241, 196, 15);
                }
                else
                {
                    this.BackColor = Color.FromArgb(149, 165, 166);
                }
            }
        }

        public void check(){
            if (!table.Status)
            {
                this.BackColor = Color.FromArgb(243, 156, 18);
            }
            else
            {
                this.BackColor = Color.FromArgb(127, 140, 141);
            }
  
        }
        public void unCheck()
        {
            if (!table.Status)
            {
                this.BackColor = Color.FromArgb(241, 196, 15);
            }
            else
            {
                this.BackColor = Color.FromArgb(149, 165, 166);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
            onClick(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            onClick(this);
        }

        private void TableControl_MouseClick(object sender, MouseEventArgs e)
        {
            onClick(this);
        }
    }
}
