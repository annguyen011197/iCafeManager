using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManager.ManagerForm
{
    public partial class InputNumber : Form
    {

        int defaultNumber;

      
        public InputNumber()
        {
            InitializeComponent();
            textBox7.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(textBox7.Text, out value))
            {
                if(value <= 0)
                {
                    MessageBox.Show("Vui lòng nhập đúng số lớn hơn 0");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng số");
                return;

            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public int getNum()
        {
            return int.Parse(textBox7.Text);
        }

       
    }
}
