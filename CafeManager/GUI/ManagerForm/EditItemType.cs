using CafeManager.Controller;
using CafeManager.Model;
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
    public partial class EditItemType : Form
    {
        Category category;
        public EditItemType(Category category)
        {
            InitializeComponent();
            this.category = category;
            textBox1.Text = category.CategoryName;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var text = this.textBox1.Text;
            if (text.Trim() != "")
            {
                category.CategoryName = text;
                if (CategoryController.getController().Exist(category))
                {
                    MessageBox.Show("Tên đã tồn tại");
                }
                else
                {
                    CategoryController.getController().Update(category);
                    MessageBox.Show("Thành công");
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Không được để trống");
            }
        }
    }
}
