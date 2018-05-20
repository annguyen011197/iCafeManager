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
    public partial class Items : Form
    {
        Boolean check = false;
        public Items()
        {
            InitializeComponent();
            updateData();
            check = true;
        }
        public static Items Instance
        {
            get
            {
                return new Items();
            }
        }

        void updateData()
        {
            dgvItems.DataSource = FoodController.getController().getListFoodType();
            dgvItems.RowHeadersVisible = false;
            dgvItems.AllowUserToAddRows = false;
            dgvItems.Columns["FoodName"].HeaderText = "Tên món";
            dgvItems.Columns["Price"].HeaderText = "Giá";
            dgvItems.Columns["CategoryName"].HeaderText = "Loại";
            dgvItems.Columns["FoodName"].Width = 200;
            dgvItems.Columns["Price"].Width = 200;
            dgvItems.Columns["CategoryName"].Width = 200;
            dgvItems.Columns["CategoryID"].Visible = false;

            lbType.DataSource = CategoryController.getController().getTableCategory();
            lbType.DisplayMember = "CategoryName";
            lbType.ValueMember = "CategoryName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddNewFood().ShowDialog();
            updateData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var row = dgvItems.CurrentRow;
            Food food = new Food();
            Category category = new Category();
            food.ID =(int) row.Cells["ID"].Value;
            food.FoodName = row.Cells["FoodName"].Value.ToString();
            food.Price =  int.Parse(row.Cells["Price"].Value.ToString());
            food.Category = int.Parse(row.Cells["CategoryID"].Value.ToString());
            new EditItems(food).ShowDialog();
            updateData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var row = dgvItems.CurrentRow;
            Food food = new Food();
            food.ID = (int)row.Cells["ID"].Value;
            FoodController.getController().Remove(food);
            updateData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new AddFoodType().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var row = dgvItems.CurrentRow;
            Category category = new Category();
            category.ID = (int)row.Cells["CategoryID"].Value;
            category.CategoryName = row.Cells["CategoryName"].Value.ToString();
            new EditItemType(category).ShowDialog();
            updateData();
        }

        private void lbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check)
            {
                var curItem = lbType.SelectedValue;
                dgvItems.DataSource = FoodController.getController().getListFoodType(curItem.ToString());
            }

        }

        private void textboxCustom1_Load(object sender, EventArgs e)
        {

        }

        private void keydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) {
                String text = textBox1.Text;
                dgvItems.DataSource = FoodController.getController().getListFoodType(text);
            }
        }

    }
}
