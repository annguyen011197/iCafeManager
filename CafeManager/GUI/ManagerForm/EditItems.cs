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
    public partial class EditItems : Form
    {
        int id;
        public EditItems(Food food)
        {
            InitializeComponent();
            cbType.DataSource = CategoryController.getController().getListCategory();
            cbType.DisplayMember = "CategoryName";
            cbType.ValueMember = "ID";
            id = food.ID;
            rtbName.Text = food.FoodName;
            rtbPrice.Text = food.Price.ToString();
            cbType.SelectedValue = food.Category;
        }

        private void exitButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditItems_Load(object sender, EventArgs e)
        {

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
            food.ID = id;
            food.FoodName = rtbName.Text.Trim();
            food.Price = int.Parse(rtbPrice.Text.Trim());
            food.Category = int.Parse(cbType.SelectedValue.ToString());
            if (FoodController.getController().Update(food))
            {
                MessageBox.Show("Sửa thành công");
                this.Close();
            }
            else{
                MessageBox.Show("Error");
            }
        }
    }
}
