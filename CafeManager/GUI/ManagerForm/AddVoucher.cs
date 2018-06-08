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
    public partial class AddVoucher : Form
    {
        int id;
        public AddVoucher()
        {
            InitializeComponent();
            cbType.SelectedIndex = 0;
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
                MessageBox.Show("Code và giá không được để trống");
                return;
            }
            if (VoucherController.getController().checkExist(rtbName.Text) != null)
            {
                MessageBox.Show("Code đã tồn tại");
                return;
            }
            Voucher voucher = new Voucher();
            voucher.Expired = DateTime.Parse(dtpBirthDay.Text);
            voucher.Status = cbType.SelectedIndex == 0 ? true : false;
            voucher.VCValue = int.Parse(rbtValue.Text);
            voucher.Code = rtbName.Text;
            if (VoucherController.getController().Save(voucher))
            {
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            else{
                MessageBox.Show("Error");
            }
        }
    }
}
