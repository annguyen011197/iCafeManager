using CafeManager.Controller;
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
        public Items()
        {
            InitializeComponent();
            updateDate();
        }
        public static Items Instance
        {
            get
            {
                return new Items();
            }
        }

        void updateDate()
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddNewFood().ShowDialog();
            updateDate();
        }
    }
}
