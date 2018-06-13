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
    public partial class Chart : Form
    {
        String startString;
        String endString;
        public Chart()
        {
            InitializeComponent();

        }

        public Chart(DateTime start, DateTime end)
        {
             startString = Utils.HelperUtils.ConvertDate(start);
             endString = Utils.HelperUtils.ConvertDate(end.AddDays(1));

            InitializeComponent();
            chart2.Visible = false;
            DataTable dt = StatisticsController.getController().findWithOffsetGroupbyDate(0 , 0, startString, endString);
            chart1.DataSource = dt;
            chart1.Series[1].XValueMember = "Date";
            chart1.Series[1].YValueMembers = "Total";
            chart1.Series[1]["PixelPointWidth"] = "5";
            chart1.Series[0].XValueMember = "Date";
            chart1.Series[0].YValueMembers = "BillCount";
            //chart1.Series["Series1"].X
        }

        private void resize(object sender, EventArgs e)
        {
            //chart1.Width = this.Width / 2;
            //chart2.Width = this.Width / 2;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chart1.Visible)
            {
                chart1.Visible = false;
                chart2.Visible = true;
                DataTable dt = StatisticsController.getController().findWithOffsetGroupbyFood(0, 0, startString, endString);
                chart2.DataSource = dt;
                chart2.Series[0].YValueMembers = "Total";
                chart2.Series[0].XValueMember = "FoodName";
                chart2.Series[0].IsValueShownAsLabel = true;
                button1.Text = "Biểu đồ theo ngày";

            }
            else
            {
                chart1.Visible = true;
                chart2.Visible = false;
                button1.Text = "Biểu đồ theo món";

            }
        }
    }
}
