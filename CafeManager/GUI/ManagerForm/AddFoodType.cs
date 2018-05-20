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
    public partial class AddFoodType : Form
    {
        List<Category> Types = new List<Category>();
        public AddFoodType()
        {
            InitializeComponent();
            UpdateData();
        }

        void UpdateData()
        {
            DataTable dataTable = CategoryController.getController().getTableCategory();
            listBox1.DataSource = dataTable;
            listBox1.DisplayMember = "CategoryName";
            listBox1.ValueMember = "CategoryName";
            Types.Clear();
            Types = HelperUtils.DataTableToList<Category>(dataTable);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String type = textBox1.Text;
            if (type.Trim() != "")
            {
                if (Types.Exists(x => x.CategoryName == type.ToUpper()))
                {
                    MessageBox.Show("Đã tồn tại");
                }
                else
                {
                    Category at = new Category();
                    at.CategoryName = type.ToUpper();
                    if (!CategoryController.getController().Save(at))
                    {
                        MessageBox.Show("Lỗi ");
                    }
                    else
                    {
                        UpdateData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Không được để trống");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
