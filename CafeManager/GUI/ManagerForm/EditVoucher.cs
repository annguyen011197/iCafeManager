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
    public partial class EditVoucher : Form
    {
        int id;
        public EditVoucher(Voucher voucher)
        {
            InitializeComponent();
            rtbName.Text = voucher.Code;
            rtbName.Enabled = false;
            dtpBirthDay.Text = voucher.Expired.ToString();
            if(voucher.Status == true)
            {
                cbType.SelectedIndex = 0;
            }
            else
            {
                cbType.SelectedIndex = 1;
            }
            rbtValue.Text = voucher.VCValue.ToString();
            id = voucher.ID;

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
            if (rbtValue.Text.Trim() == ""
                || rtbName.Text.Trim() == "")
            {
                MessageBox.Show("Tên và giá không được để trống");
                return;
            }
            Voucher voucher = new Voucher();
            voucher.ID = id;
            voucher.Expired = DateTime.Parse(dtpBirthDay.Text);
            voucher.Status = cbType.SelectedIndex == 0 ? true : false;
            voucher.VCValue = int.Parse(rbtValue.Text);
            voucher.Code = rtbName.Text;
            if (VoucherController.getController().Update(voucher))
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
