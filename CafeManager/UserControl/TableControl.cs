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
using CafeManager.Controller;

namespace CafeManager
{
    public partial class TableControl : UserControl
    {
        private Table table;
        private List<Food> listFood = new List<Food>();
        public Bill bill = new Bill();
        private List<Bill_Info> listBillInfo = new List<Bill_Info>();
        private List<Bill_Voucher> listVoucher = new List<Bill_Voucher>();
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
                loadBill();
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

        public void loadBill()
        {
            if(table.TableStatus == true)
            {
                bill =  BillController.getController().findBill(table.IDBill);
                listBillInfo = Bill_InfoController.getController().getListFromBill(bill.ID);
                listBillInfo.ForEach(item =>
                {
                    listFood.Add(FoodController.getController().findFood(item.Food));
                });
            }
        }


        public void makeBill()
        {
            BillController.getController().updateBill(bill);
        }

        public void clearTable()
        {
            table.TableStatus = false;
            label2.Text = table.TableStatus ? "Có Người" : "Trống";
            TableController.getController().saveTable(table);
            listFood = new List<Food>();
            listBillInfo = new List<Bill_Info>();
            onClick(this);
            
        }

        public void createBill()
        {
            Bill b = BillController.getController().createNoneBill();
            bill.ID = b.ID;
            bill.Date_Check_In = DateTime.Now;
            bill.IDTable = table.ID;
            bill.Discount = 0;
            bill.Customer = -1;
            table.IDBill = bill.ID;
            this.Table.TableStatus = true;
            check();
            label2.Text = table.TableStatus ? "Có Người" : "Trống";
            TableController.getController().saveTable(table);
            BillController.getController().updateBill(bill);
        }

        public void endBill(int custom)
        {
            bill.Date_Check_Out = DateTime.Now;
            bill.Customer = custom;
        }

        public void addVoucher(string voucher)
        {
            Bill_Voucher bill_Voucher = new Bill_Voucher();
            bill_Voucher.ID_Voucher = voucher;
            bill_Voucher.ID_Bill = bill.ID;
            this.listVoucher.Add(bill_Voucher);
        }

        public void removeFood(int id)
        {
            listFood.RemoveAt(id);
            listBillInfo.RemoveAt(id);
        }

        public void addFood(Food food, int num)
        {
            Bill_Info bill_infor = new Bill_Info();
            bill_infor.Food = food.ID;
            bill_infor.FoodCount = num;
            bill_infor.Bill = bill.ID;
            listBillInfo.Add(bill_infor);
            Bill_InfoController.getController().createBill_Info(bill_infor);
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
