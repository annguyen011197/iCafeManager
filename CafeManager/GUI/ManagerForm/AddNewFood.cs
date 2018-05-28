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
    public partial class AddNewFood : Form
    {
        public AddNewFood()
        {
            InitializeComponent();
            cbType.DataSource = CategoryController.getController().getListCategory();
            cbType.DisplayMember = "CategoryName";
            cbType.ValueMember = "ID";
        }


        private void exitButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rtbPrice.Text.Trim() == ""
                || rtbName.Text.Trim() == "")
            {
                MessageBox.Show("Tên và giá không được để trống");
                return;
            }
            Food food = new Food();
            food.FoodName = rtbName.Text.Trim();
            food.Price = int.Parse(rtbPrice.Text.Trim());
            food.Category = int.Parse(cbType.SelectedValue.ToString());
            if (FoodController.getController().Exist(food))
            {
                if (FoodController.getController().Add(food))
                {
                    MessageBox.Show("Thêm thành công");
                    rtbName.Text = "";
                    rtbPrice.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Đã tồn tại");
                return;
            }
        }
    }
}
