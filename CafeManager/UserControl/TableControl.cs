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
        private List<Food> listFood = new List<Food>();
        private List<Bill_Info> listBillInfo = new List<Bill_Info>();
        private Customer customer;

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
                label1.Text = table.TableName;
                label2.Text = table.TableStatus ? "Có Người" : "Trống";
                if (!table.TableStatus)
                {
                    this.BackColor = Color.FromArgb(241, 196, 15);
                }
                else
                {
                    this.BackColor = Color.FromArgb(149, 165, 166);
                }
            }
        }


        public List<Food> ListFood { 
            get
            {
                return listFood;
            }
            set
            {
                listFood = value;
            }
        }

        public List<Bill_Info> ListBill_Info
        {
            get
            {
                return listBillInfo;
            }
            set
            {
                listBillInfo = value;
            }
        }


        public void removeFood(int id)
        {
            listFood.RemoveAt(id);
            listBillInfo.RemoveAt(id);
        }

        public void addFood(Food food, int num)
        {
            Bill_Info bill = new Bill_Info();
            bill.Food = food.ID;
            bill.FoodCount = num;
            listBillInfo.Add(bill);
            listFood.Add(food);
        }

        public void check(){
            if (!table.TableStatus)
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
            if (!table.TableStatus)
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
