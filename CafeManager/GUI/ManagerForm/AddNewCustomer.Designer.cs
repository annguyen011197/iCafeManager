namespace CafeManager.GUI.ManagerForm
{
    partial class AddNewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewCustomer));
            this.header1 = new CafeManager.Header();
            this.exitButton1 = new CafeManager.Custom_Control.ExitButton();
            this.customPanel3 = new CafeManager.Custom_Control.CustomPanel();
            this.tbDisplayName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.customPanel1 = new CafeManager.Custom_Control.CustomPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.customPanel4 = new CafeManager.Custom_Control.CustomPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.customPanel3.SuspendLayout();
            this.customPanel1.SuspendLayout();
            this.customPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.header1.Location = new System.Drawing.Point(-1, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(429, 33);
            this.header1.TabIndex = 1;
            this.header1.TargetControl = null;
            // 
            // exitButton1
            // 
            this.exitButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.exitButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton1.BackgroundImage")));
            this.exitButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton1.FlatAppearance.BorderSize = 0;
            this.exitButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.exitButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exitButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton1.Location = new System.Drawing.Point(395, 0);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Size = new System.Drawing.Size(33, 33);
            this.exitButton1.TabIndex = 2;
            this.exitButton1.UseVisualStyleBackColor = false;
            this.exitButton1.Click += new System.EventHandler(this.exitButton1_Click);
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.customPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel3.Controls.Add(this.tbDisplayName);
            this.customPanel3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customPanel3.ElipseRadius = 0;
            this.customPanel3.Location = new System.Drawing.Point(144, 46);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(241, 44);
            this.customPanel3.TabIndex = 9;
            // 
            // tbDisplayName
            // 
            this.tbDisplayName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDisplayName.Location = new System.Drawing.Point(3, 19);
            this.tbDisplayName.Name = "tbDisplayName";
            this.tbDisplayName.Size = new System.Drawing.Size(233, 13);
            this.tbDisplayName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(89, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên";
            // 
            // tbPhone
            // 
            this.tbPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPhone.Location = new System.Drawing.Point(3, 19);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(233, 13);
            this.tbPhone.TabIndex = 2;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.customPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel1.Controls.Add(this.tbPhone);
            this.customPanel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customPanel1.ElipseRadius = 0;
            this.customPanel1.Location = new System.Drawing.Point(144, 111);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(241, 44);
            this.customPanel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(66, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Địa chỉ";
            // 
            // tbCMND
            // 
            this.tbCMND.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCMND.Location = new System.Drawing.Point(3, 19);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(233, 13);
            this.tbCMND.TabIndex = 2;
            // 
            // customPanel4
            // 
            this.customPanel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.customPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel4.Controls.Add(this.tbCMND);
            this.customPanel4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customPanel4.ElipseRadius = 0;
            this.customPanel4.Location = new System.Drawing.Point(144, 234);
            this.customPanel4.Name = "customPanel4";
            this.customPanel4.Size = new System.Drawing.Size(237, 44);
            this.customPanel4.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(67, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "CMND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(83, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Note";
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(144, 300);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(237, 49);
            this.rtbNote.TabIndex = 17;
            this.rtbNote.Text = "";
            // 
            // rtbAddress
            // 
            this.rtbAddress.Location = new System.Drawing.Point(144, 171);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(237, 40);
            this.rtbAddress.TabIndex = 18;
            this.rtbAddress.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(239)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(278, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 40);
            this.button1.TabIndex = 19;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(428, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbAddress);
            this.Controls.Add(this.rtbNote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customPanel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customPanel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitButton1);
            this.Controls.Add(this.header1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewCustomer";
            this.Text = "AddNewCustomer";
            this.customPanel3.ResumeLayout(false);
            this.customPanel3.PerformLayout();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.customPanel4.ResumeLayout(false);
            this.customPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Header header1;
        private CafeManager.Custom_Control.ExitButton exitButton1;
        private CafeManager.Custom_Control.CustomPanel customPanel3;
        private System.Windows.Forms.TextBox tbDisplayName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPhone;
        private CafeManager.Custom_Control.CustomPanel customPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCMND;
        private CafeManager.Custom_Control.CustomPanel customPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.Button button1;
    }
}