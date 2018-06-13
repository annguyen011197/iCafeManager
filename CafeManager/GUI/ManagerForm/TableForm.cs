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
    public partial class TableForm : Form
    {
        public TableForm()
        {
            InitializeComponent();
            UpdateData();
        }

        public static TableForm Instance
        {
            get
            {
                return new TableForm();
            }
        }

        public void UpdateData()
        {
            dgv.DataSource = TableController.getController().findAll();
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            label1.Text = dgv.RowCount.ToString() + " Bàn";
            dgv.Columns["IDBill"].Visible = false;
            FormatDatagridview();
        }

        private void FormatDatagridview()
        {
            int width = dgv.Width;
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].Width = width / (dgv.ColumnCount-1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Add
            Table table = new Table();
            table.TableName = tbName.Text.Trim();
            if (table.TableName != "")
            {
                TableController.getController().createTable(table);
                UpdateData();
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Delete
            var row = dgv.CurrentRow;
            TableController.getController().Delete((int)row.Cells["ID"].Value);
            UpdateData();
        }
    }
}
