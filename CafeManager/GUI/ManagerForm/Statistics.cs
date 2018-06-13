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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
            DateTime monday = Utils.HelperUtils.GetMonday(DateTime.Today.AddDays(0));
            dtpStart.Value = monday;
            dtpEnd.Value = monday.AddDays(6);
            rbWeek.Checked = true;
            rbBill.Checked = true;
            UpdateData();
        }

        

        public static Statistics Instance
        {
            get
            {
                return new Statistics();
            }
        }

        private void UpdateData()
        {
            int offset = Decimal.ToInt32(offsetBox.Value);
            int limit = 10;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            String start = Utils.HelperUtils.ConvertDate(dtpStart.Value);
            String end = Utils.HelperUtils.ConvertDate(dtpEnd.Value.AddDays(1));
            if (rbBill.Checked)
            {
                dgv.DataSource = StatisticsController.getController().findWithOffset(offset * limit, limit,start,end);
                if (dgv.RowCount > 0)
                {
                    dgv.Columns["Bill"].HeaderText = "Bill ID";
                    dgv.Columns["Total"].HeaderText = "Tiền";
                    dgv.Columns["Date_Check_In"].HeaderText = "Ngày";

                    dgv.Columns["Date_Check_In"].DefaultCellStyle.Format = @"dd/MM/yyyy";

                }
            }

            if (rbFood.Checked)
            {
                dgv.DataSource = StatisticsController.getController().findWithOffsetGroupbyFood(offset * limit, limit, start, end);
                if (dgv.RowCount > 0)
                {
                    dgv.Columns["Food"].HeaderText = "ID";
                    dgv.Columns["FoodName"].HeaderText = "Tên";
                    dgv.Columns["FoodCount"].HeaderText = "Số lượng";
                    dgv.Columns["Total"].HeaderText = "Thành tiền";
                }

            }

            if (rbDate.Checked)
            {
                dgv.DataSource = StatisticsController.getController().findWithOffsetGroupbyDate(offset * limit, limit, start, end);
                if (dgv.RowCount > 0)
                {
                    dgv.Columns["Date"].HeaderText = "Ngày";
                    dgv.Columns["BillCount"].HeaderText = "Số lượng hóa đơn";
                    dgv.Columns["Total"].HeaderText = "Tổng tiền";
                }
            }

            FormatDatagridview();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            offsetBox.UpButton();
            UpdateData();
        }

        private void offsetBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                UpdateData();
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            offsetBox.DownButton();
            UpdateData();
        }

        private void Resize(object sender, EventArgs e)
        {
            FormatDatagridview();
        }

        private void FormatDatagridview()
        {
            int width = container.Panel1.Width;
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].Width = width / dgv.ColumnCount;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            DateTime dt = dtpStart.Value;
            DateTime start = new DateTime(dt.Year, dt.Month,1);
            DateTime end = start.AddMonths(1).AddDays(-1);
            dtpStart.Value = start;
            dtpEnd.Value = end;

        }

        private void rbWeek_CheckedChanged(object sender, EventArgs e)
        {
            DateTime monday = Utils.HelperUtils.GetMonday(dtpStart.Value);
            dtpStart.Value = monday;
            dtpEnd.Value = monday.AddDays(6);
        }

        private void rbYear_CheckedChanged(object sender, EventArgs e)
        {
            DateTime dt = dtpStart.Value;
            DateTime start = new DateTime(dt.Year, 1, 1);
            DateTime end = start.AddYears(1).AddDays(-1);
            dtpStart.Value = start;
            dtpEnd.Value = end;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dtpStart.Value;
            if (rbWeek.Checked)
            {
                DateTime monday = Utils.HelperUtils.GetMonday(dt);
                dtpStart.Value = monday;
                dtpEnd.Value = monday.AddDays(6);
                return;
            }

            if (rbMonth.Checked)
            {
                DateTime start = new DateTime(dt.Year, dt.Month, 1);
                DateTime end = start.AddMonths(1).AddDays(-1);
                dtpStart.Value = start;
                dtpEnd.Value = end;
                return;
            }

            if (rbYear.Checked)
            {
                DateTime start = new DateTime(dt.Year, 1, 1);
                DateTime end = start.AddYears(1).AddDays(-1);
                dtpStart.Value = start;
                dtpEnd.Value = end;
                return;
            }
        }

        private void rbBill_CheckedChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void rbFood_CheckedChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void rbDate_CheckedChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Chart(dtpStart.Value,dtpEnd.Value).ShowDialog();
        }
    }
}
