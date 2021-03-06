﻿using CafeManager.Controller;
using CafeManager.GUI;
using CafeManager.GUI.ManagerForm;
using CafeManager.ManagerForm;
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
using static CafeManager.TableControl;

namespace CafeManager
{
    public partial class HomeV2 : Form
    {
        private List<TableControl> listTable = new List<TableControl>();
        private List<Food> listFood = new List<Food>();
        private List<Food> listFoodCategory = new List<Food>();
        private List<Category> listCategory = new List<Category>();
        private TableControl chooseTable = null;
        private bool _canUpdate = false;

        private int Discount = 0;


        public HomeV2()
        {
            InitializeComponent();
            button6.Enabled = false;
            button6.BackColor = Color.White;
            button6.ForeColor = Color.Black;
            updateTable();


            listView1.Columns.Add("Tên", 200);
            listView1.Columns.Add("Giá", 100);
            listView1.View = View.Details;
            updateFood(-1);

            listView2.Columns.Add("Loại", 200);
            listView2.View = View.Details;
            updateCategory();
            listFood = FoodController.getController().getListFood();
            comboBox1.DataSource = listFood;
            comboBox1.SelectedIndex = -1;

            listView3.Columns.Add("Danh sách đã đặt", 200);
            listView3.Columns.Add("Số lượng", 100);
            listView3.View = View.Details;
        }

        public void onClickTableEvent(TableControl tb)
        {
            chooseTable = tb;
            lbNameTable.Text = tb.Table.TableName;
            unCheckTable();
            tb.check();
            updateListChoose();
        }


        void unCheckTable()
        {
            listTable.ForEach(item =>
            {
                item.unCheck();
            });
        }



        private void updateCategory()
        {
            listCategory = CategoryController.getController().getListCategory();
            listCategory.ForEach(item =>
            {
                ListViewItem itemView = new ListViewItem(item.CategoryName);
                listView2.Items.Add(itemView);
            });
        }

        private void updateFood(int id)
        {
            if (id == -1)
            {
                listFoodCategory = FoodController.getController().getListFood();
            }
            else
            {
                listFoodCategory = FoodController.getController().getListFoodCategory(id);
            }
            listView1.Items.Clear();
            listFoodCategory.ForEach(item =>
            {
                ListViewItem itemView = new ListViewItem(item.FoodName);
                ListViewItem.ListViewSubItem sub = new ListViewItem.ListViewSubItem(itemView, item.Price.ToString());
                itemView.SubItems.Add(sub);
                listView1.Items.Add(itemView);
            });

        }


        private void updateListChoose()
        {
            if (chooseTable != null)
            {
                int sum = 0;
                listView3.Items.Clear();
                int i = 0;
                chooseTable.ListFood.ForEach(item =>
                {
                    ListViewItem itemView = new ListViewItem(item.FoodName);
                    int count = chooseTable.ListBill_Info[i].FoodCount;
                    ListViewItem.ListViewSubItem sub = new ListViewItem.ListViewSubItem(itemView, count.ToString());
                    itemView.SubItems.Add(sub);
                    listView3.Items.Add(itemView);
                    sum += item.Price * count;
                    i++;
                });

                textBox4.Text = sum.ToString();
                textBox6.Text = Discount.ToString();
                textBox7.Text = ((int)(sum - (sum * Discount / 100.0))).ToString();
            }
        }

        private void updateTable()
        {
            List<Table> list = TableController.getController().getListTable();
            if (list != null)
            {
                list.ForEach(item =>
                {
                    TableControl tb = new TableControl();
                    tb.Table = item;
                    tb.Parent = flowLayoutPanel1;
                    flowLayoutPanel1.Controls.Add(tb);
                    tb.onClick = new onClickTable(onClickTableEvent);
                    tb.ContextMenuStrip = menuTable;
                    listTable.Add(tb);
                });
            }
        }

        private void btnExitClick(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void btnExitHover(object sender, EventArgs e)
        {
            this.btnExit.BackgroundImage = Properties.Resources.exit_hover;
        }

        private void btnExitLeave(object sender, EventArgs e)
        {
            this.btnExit.BackgroundImage = Properties.Resources.exit;
        }

        //Mở bàn
        private void button1_Click(object sender, EventArgs e)
        {
            if (chooseTable != null && chooseTable.Table.TableStatus == false)
            {
                chooseTable.createBill();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button6.Enabled = true;
            button6.BackColor = Color.FromArgb(232, 65, 24);
            button6.ForeColor = Color.FromArgb(240, 240, 240);

            button7.Enabled = false;
            button7.BackColor = Color.White;
            button7.ForeColor = Color.Black;
            flowLayoutPanel2.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button7.Enabled = true;
            button7.BackColor = Color.FromArgb(232, 65, 24);
            button7.ForeColor = Color.FromArgb(240, 240, 240);

            button6.Enabled = false;
            button6.BackColor = Color.White;
            button6.ForeColor = Color.Black;
            flowLayoutPanel1.BringToFront();
        }

        private void tableControl3_Load(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                int id = listView2.Items.IndexOf(listView2.SelectedItems[0]);
                updateFood(listFood[id].Category);
            }
            else
            {
                updateFood(-1);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_canUpdate)
            {
                int id = comboBox1.SelectedIndex;
                if (id >= 0)
                {
                    comboBox1.SelectedIndex = -1;
                    if (chooseTable != null && chooseTable.Table.TableStatus == true)
                    {
                        InputNumber form = new InputNumber();
                        //chooseTable.ListFood.Add(listFood[id]);
                        int num = 1;
                        if (form.ShowDialog(this) == DialogResult.OK)
                        {
                            num = form.getNum();
                        }
                        chooseTable.addFood(listFood[id], num);
                        updateListChoose();
                    }
                    else
                    {
                        MessageBox.Show("Chưa chọn hoặc bàn còn trống!");
                    }
                }
            }
            else
            {
                _canUpdate = true;
            }
        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender is TableControl)
            {

            }
            else
            {
                chooseTable = null;
                lbNameTable.Text = "None";
                unCheckTable();
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                int id = listView1.Items.IndexOf(listView1.SelectedItems[0]);
                if (chooseTable != null && chooseTable.Table.TableStatus == true)
                {
                    InputNumber form = new InputNumber();
                    //chooseTable.ListFood.Add(listFood[id]);
                    int num = 1;
                    if (form.ShowDialog(this) == DialogResult.OK)
                    {
                        num = form.getNum();
                        chooseTable.addFood(listFoodCategory[id], num);
                        updateListChoose();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa chọn hoặc bàn còn trống!");
                }
            }

        }

        private void listView3_DoubleClick(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count > 0)
            {
                int id = listView3.Items.IndexOf(listView3.SelectedItems[0]);
                if (chooseTable != null && chooseTable.Table.TableStatus == true)
                {
                    chooseTable.removeFood(id);
                    listView3.Items[id].Remove();
                    updateListChoose();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Khởi tạo built mà mở ReportView lên để khởi tạo;
            //Truyền dữ liệu theo cấu trúc như demo
            if (chooseTable != null && chooseTable.Table.TableStatus == true)
            {
                string voucher = textBox3.Text;
                string IDKH = textBox2.Text;
                if (CustomerController.getController().checkExist(IDKH))
                {
                    chooseTable.endBill(IDKH);
                }
                else
                {
                    chooseTable.endBill("");
                }
               
                if (voucher != "")
                {
                    String[] listVoucher = voucher.Trim().Split(',');
                    foreach(var item in listVoucher){
                        Voucher v = VoucherController.getController().checkExist(item);
                        if (v != null && v.Status != true)
                        {
                            chooseTable.addVoucher(v);
                        }
                    }
                   
                }
                chooseTable.makeBill();
                List<BillReport> list = new List<BillReport>();
                int i = 0;
                chooseTable.ListFood.ForEach(item =>
                {
                    BillReport br = new BillReport();
                    br.FoodName = item.FoodName;
                    br.Price = item.Price;
                    br.Count = chooseTable.ListBill_Info[i].FoodCount;
                    i++;
                    list.Add(br);
                });
                new ReportView(list, chooseTable.bill).ShowDialog(this);
                chooseTable.clearTable();
                Discount = 0;
                textBox5.Text = "0";
                textBox2.Text =  "";
                textBox3.Text = "";
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            string voucher = textBox3.Text;
            if (voucher != "")
            {
                Voucher v = VoucherController.getController().checkExist(voucher);
                if (v != null && v.Status != true)
                {
                    Discount = v.VCValue;
                    updateListChoose();
                }
                else
                {
                    MessageBox.Show("Đã sử dụng hoặc không tồn tại!");
                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            new AddNewCustomer().ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chooseTable != null)
            {
                button1_Click(sender, e);
            }
        }


        private void menuTable_Opening(object sender, CancelEventArgs e)
        {
            ContextMenuStrip menu = sender as ContextMenuStrip;
            TableControl tableControl = menu.SourceControl as TableControl;
            if (tableControl != null)
            {
                if (!tableControl.Table.TableStatus)
                {
                    menuTable.Items[0].Enabled = true;
                    menuTable.Items[1].Enabled = false;
                }
                else
                {
                    menuTable.Items[0].Enabled = false;
                    menuTable.Items[1].Enabled = true;
                }
                chooseTable = tableControl;
                unCheckTable();
                tableControl.check();
                updateListChoose();
            }
        }

        private void billToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chooseTable != null)
            {
                button3_Click(sender, e);
            }
        }

        private void thêmNhanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1 != null && listView1.SelectedItems.Count > 0)
            {
                int id = listView1.Items.IndexOf(listView1.SelectedItems[0]);
                if (chooseTable != null && chooseTable.Table.TableStatus == true)
                {
                    chooseTable.addFood(listFoodCategory[id], 1);
                    updateListChoose();
                }
                else
                {
                    MessageBox.Show("Chưa chọn hoặc bàn còn trống!");
                }
            }
        }

        private void thêmTùyChỉnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1_DoubleClick(sender, e);
        }


        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView3_DoubleClick(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string IDNumber = textBox2.Text;
            if (IDNumber != "")
            {
                bool v = CustomerController.getController().checkExist(IDNumber);
                if (v)
                {
                    MessageBox.Show("IDNumber có thể sử dụng");
                }
                else
                {
                    MessageBox.Show("IDNumber không tồn tại!");
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
