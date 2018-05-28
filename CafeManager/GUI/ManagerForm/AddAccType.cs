using CafeManager.Controller;
using CafeManager.Model;
using CafeManager.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManager.GUI.ManagerForm
{
    public partial class AddAccType : Form
    {
        List<Account_Type> Types = new List<Account_Type>();
        public AddAccType()
        {
            InitializeComponent();
            UpdateData();
        }

        void UpdateData()
        {
            DataTable dataTable = Account_TypeController.getController().getTypeTable();
            listBox1.DataSource = dataTable;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Name";
            Types.Clear();
            Types = HelperUtils.DataTableToList<Account_Type>(dataTable);
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String type = textBox1.Text;
            if (type.Trim() == "")
            {
                MessageBox.Show("Không được để trống");
            }
            if (Types.Exists( x => x.Name==type.ToUpper())){
                MessageBox.Show("Đã tồn tại");
            }
            else
            {
                Account_Type at = new Account_Type();
                at.Name = type.ToUpper();
                if (!Account_TypeController.getController().Save(at))
                {
                    MessageBox.Show("Lỗi ");
                }
                else
                {
                    UpdateData();
                }
            }
        }
    }
}
