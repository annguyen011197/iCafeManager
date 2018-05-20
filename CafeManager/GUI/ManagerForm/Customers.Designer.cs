namespace CafeManager.GUI.ManagerForm
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nonFlickerSplitContainer1 = new CafeManager.NonFlickerSplitContainer();
            this.dgvCus = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.customPanel1 = new CafeManager.Custom_Control.CustomPanel();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.rtbAdress = new System.Windows.Forms.RichTextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbBirthay = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customPanel7 = new CafeManager.Custom_Control.CustomPanel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nonFlickerSplitContainer1)).BeginInit();
            this.nonFlickerSplitContainer1.Panel1.SuspendLayout();
            this.nonFlickerSplitContainer1.Panel2.SuspendLayout();
            this.nonFlickerSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCus)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.customPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // nonFlickerSplitContainer1
            // 
            this.nonFlickerSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nonFlickerSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.nonFlickerSplitContainer1.Name = "nonFlickerSplitContainer1";
            // 
            // nonFlickerSplitContainer1.Panel1
            // 
            this.nonFlickerSplitContainer1.Panel1.Controls.Add(this.dgvCus);
            // 
            // nonFlickerSplitContainer1.Panel2
            // 
            this.nonFlickerSplitContainer1.Panel2.Controls.Add(this.customPanel1);
            this.nonFlickerSplitContainer1.Panel2.Controls.Add(this.customPanel7);
            this.nonFlickerSplitContainer1.Panel2.Controls.Add(this.label1);
            this.nonFlickerSplitContainer1.Panel2.Controls.Add(this.button3);
            this.nonFlickerSplitContainer1.Panel2.Controls.Add(this.button2);
            this.nonFlickerSplitContainer1.Panel2.Controls.Add(this.button1);
            this.nonFlickerSplitContainer1.Size = new System.Drawing.Size(800, 450);
            this.nonFlickerSplitContainer1.SplitterDistance = 334;
            this.nonFlickerSplitContainer1.TabIndex = 0;
            // 
            // dgvCus
            // 
            this.dgvCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCus.Location = new System.Drawing.Point(3, 3);
            this.dgvCus.Name = "dgvCus";
            this.dgvCus.Size = new System.Drawing.Size(328, 444);
            this.dgvCus.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(239)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(330, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 37);
            this.button3.TabIndex = 7;
            this.button3.Text = "Chỉnh thông tin";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(239)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(330, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Xóa tài khoản";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(239)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(330, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thêm tài khoản";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.Controls.Add(this.rtbNote);
            this.customPanel1.Controls.Add(this.rtbAdress);
            this.customPanel1.Controls.Add(this.lbPhone);
            this.customPanel1.Controls.Add(this.lbType);
            this.customPanel1.Controls.Add(this.lbBirthay);
            this.customPanel1.Controls.Add(this.lbName);
            this.customPanel1.Controls.Add(this.label7);
            this.customPanel1.Controls.Add(this.label6);
            this.customPanel1.Controls.Add(this.label5);
            this.customPanel1.Controls.Add(this.label4);
            this.customPanel1.Controls.Add(this.label3);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.ElipseRadius = 0;
            this.customPanel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.customPanel1.Location = new System.Drawing.Point(240, 180);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(219, 268);
            this.customPanel1.TabIndex = 22;
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(72, 160);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(139, 96);
            this.rtbNote.TabIndex = 11;
            this.rtbNote.Text = "";
            // 
            // rtbAdress
            // 
            this.rtbAdress.Location = new System.Drawing.Point(72, 108);
            this.rtbAdress.Name = "rtbAdress";
            this.rtbAdress.Size = new System.Drawing.Size(139, 45);
            this.rtbAdress.TabIndex = 10;
            this.rtbAdress.Text = "";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(72, 86);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(35, 13);
            this.lbPhone.TabIndex = 9;
            this.lbPhone.Text = "label8";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(72, 62);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(35, 13);
            this.lbType.TabIndex = 8;
            this.lbType.Text = "label8";
            // 
            // lbBirthay
            // 
            this.lbBirthay.AutoSize = true;
            this.lbBirthay.Location = new System.Drawing.Point(72, 40);
            this.lbBirthay.Name = "lbBirthay";
            this.lbBirthay.Size = new System.Drawing.Size(35, 13);
            this.lbBirthay.TabIndex = 7;
            this.lbBirthay.Text = "label8";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(69, 16);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 13);
            this.lbName.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Note:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "SDT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên:";
            // 
            // customPanel7
            // 
            this.customPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.customPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel7.Controls.Add(this.textBox7);
            this.customPanel7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customPanel7.ElipseRadius = 0;
            this.customPanel7.Location = new System.Drawing.Point(240, 130);
            this.customPanel7.Name = "customPanel7";
            this.customPanel7.Size = new System.Drawing.Size(219, 44);
            this.customPanel7.TabIndex = 21;
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(4, 15);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(223, 16);
            this.textBox7.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(253, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tìm kiếm";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nonFlickerSplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.Text = "Customers";
            this.nonFlickerSplitContainer1.Panel1.ResumeLayout(false);
            this.nonFlickerSplitContainer1.Panel2.ResumeLayout(false);
            this.nonFlickerSplitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nonFlickerSplitContainer1)).EndInit();
            this.nonFlickerSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCus)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.customPanel7.ResumeLayout(false);
            this.customPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NonFlickerSplitContainer nonFlickerSplitContainer1;
        private System.Windows.Forms.DataGridView dgvCus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private CafeManager.Custom_Control.CustomPanel customPanel1;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.RichTextBox rtbAdress;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbBirthay;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CafeManager.Custom_Control.CustomPanel customPanel7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label1;
    }
}