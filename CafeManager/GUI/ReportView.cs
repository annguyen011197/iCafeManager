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

namespace CafeManager.GUI
{
    public partial class ReportView : Form
    {
        List<BillReport> list = new List<BillReport>();
        public ReportView()
        {
            InitializeComponent();
            crystalReportViewer1.ShowCloseButton = true;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            BillReport a = new BillReport();
            a.FoodName = "A";
            a.Price = 10000;
            a.Count = 2;
            //a.Sum = a.Price * a.Count;
            list.Add(a);
            BillReport a2 = new BillReport();
            a2.FoodName = "B";
            a2.Price = 5000;
            a2.Count = 1;
            //a2.Sum = a2.Price * a2.Count;
            list.Add(a2);

            Bill bill = new Bill();
            bill.ID = 1;
            bill.Date_Check_In = DateTime.Now;
            bill.Date_Check_Out = DateTime.Now;
            bill.Customer = 13213;
            bill.Discount = 10;
            bill.TableID = 12;

            billReportPage2.SetDataSource(list);

            billReportPage2.SetParameterValue("Date_Check_In",bill.Date_Check_In);
            billReportPage2.SetParameterValue("ID", bill.ID.ToString());
            billReportPage2.SetParameterValue("Date_Check_Out", bill.Date_Check_Out);
            billReportPage2.SetParameterValue("Customer", bill.Customer.ToString());
            billReportPage2.SetParameterValue("Discount", bill.Discount);
            billReportPage2.SetParameterValue("Table", bill.TableID.ToString());
            crystalReportViewer1.ReportSource = billReportPage2;
            crystalReportViewer1.Refresh();
        }

        private void ReportView_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
    }

}
