namespace CafeManager.GUI.ManagerForm
{
    partial class Edit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.formEclipse1 = new CafeManager.FormEclipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customPanel7 = new CafeManager.Custom_Control.CustomPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.customPanel6 = new CafeManager.Custom_Control.CustomPanel();
            this.dtpBd = new CafeManager.GUI.Custom_Control.SexyDateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.customPanel3 = new CafeManager.Custom_Control.CustomPanel();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customPanel2 = new CafeManager.Custom_Control.CustomPanel();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.customPanel1 = new CafeManager.Custom_Control.CustomPanel();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton1 = new CafeManager.Custom_Control.ExitButton();
            this.header1 = new CafeManager.Header();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.customPanel4 = new CafeManager.Custom_Control.CustomPanel();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.dtpBirthDay = new CafeManager.GUI.Custom_Control.SexyDateTimePicker();
            this.cbType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.customPanel7.SuspendLayout();
            this.customPanel6.SuspendLayout();
            this.customPanel3.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.customPanel1.SuspendLayout();
            this.customPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // formEclipse1
            // 
            this.formEclipse1.ElipseRadius = 100;
            this.formEclipse1.TargetControl = this.pictureBox1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CafeManager.Properties.Resources.Untitled;
            this.pictureBox1.Location = new System.Drawing.Point(32, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // customPanel7
            // 
            this.customPanel7.BackColor = System.Drawing.Color.White;
            this.customPanel7.Controls.Add(this.cbType);
            this.customPanel7.ElipseRadius = 0;
            this.customPanel7.Location = new System.Drawing.Point(296, 416);
            this.customPanel7.Name = "customPanel7";
            this.customPanel7.Size = new System.Drawing.Size(241, 46);
            this.customPanel7.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(164, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 24);
            this.label7.TabIndex = 34;
            this.label7.Text = "Loại:";
            // 
            // customPanel6
            // 
            this.customPanel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.customPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel6.Controls.Add(this.dtpBd);
            this.customPanel6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customPanel6.ElipseRadius = 0;
            this.customPanel6.Location = new System.Drawing.Point(296, 356);
            this.customPanel6.Name = "customPanel6";
            this.customPanel6.Size = new System.Drawing.Size(241, 44);
            this.customPanel6.TabIndex = 33;
            // 
            // dtpBd
            // 
            this.dtpBd.Location = new System.Drawing.Point(-1, 11);
            this.dtpBd.Name = "dtpBd";
            this.dtpBd.Size = new System.Drawing.Size(241, 20);
            this.dtpBd.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(164, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 32;
            this.label6.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(164, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(164, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "Địa chỉ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(239)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(430, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 40);
            this.button1.TabIndex = 28;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.customPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel3.Controls.Add(this.tbFirstName);
            this.customPanel3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customPanel3.ElipseRadius = 0;
            this.customPanel3.Location = new System.Drawing.Point(296, 168);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(241, 44);
            this.customPanel3.TabIndex = 27;
            // 
            // tbFirstName
            // 
            this.tbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFirstName.Location = new System.Drawing.Point(3, 16);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(237, 13);
            this.tbFirstName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(164, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tên";
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.customPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel2.Controls.Add(this.tbLastName);
            this.customPanel2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customPanel2.ElipseRadius = 0;
            this.customPanel2.Location = new System.Drawing.Point(296, 106);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(241, 44);
            this.customPanel2.TabIndex = 25;
            // 
            // tbLastName
            // 
            this.tbLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLastName.Location = new System.Drawing.Point(3, 16);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(237, 13);
            this.tbLastName.TabIndex = 1;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.customPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel1.Controls.Add(this.tbDisplay);
            this.customPanel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customPanel1.ElipseRadius = 0;
            this.customPanel1.Location = new System.Drawing.Point(296, 44);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(241, 44);
            this.customPanel1.TabIndex = 23;
            // 
            // tbDisplay
            // 
            this.tbDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDisplay.Location = new System.Drawing.Point(3, 11);
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(237, 13);
            this.tbDisplay.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(164, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tên hiển thị";
            // 
            // exitButton1
            // 
            this.exitButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.exitButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton1.BackgroundImage")));
            this.exitButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton1.FlatAppearance.BorderSize = 0;
            this.exitButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.exitButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exitButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton1.Location = new System.Drawing.Point(552, 2);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Size = new System.Drawing.Size(33, 33);
            this.exitButton1.TabIndex = 21;
            this.exitButton1.UseVisualStyleBackColor = false;
            this.exitButton1.Click += new System.EventHandler(this.exitButton1_Click);
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.header1.Location = new System.Drawing.Point(0, 2);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(585, 33);
            this.header1.TabIndex = 20;
            this.header1.TargetControl = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(164, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Họ";
            // 
            // rtbAddress
            // 
            this.rtbAddress.Location = new System.Drawing.Point(296, 229);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(241, 45);
            this.rtbAddress.TabIndex = 38;
            this.rtbAddress.Text = "";
            // 
            // customPanel4
            // 
            this.customPanel4.BackColor = System.Drawing.Color.White;
            this.customPanel4.Controls.Add(this.tbPhone);
            this.customPanel4.ElipseRadius = 0;
            this.customPanel4.Location = new System.Drawing.Point(296, 289);
            this.customPanel4.Name = "customPanel4";
            this.customPanel4.Size = new System.Drawing.Size(241, 49);
            this.customPanel4.TabIndex = 39;
            // 
            // tbPhone
            // 
            this.tbPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPhone.Location = new System.Drawing.Point(3, 20);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(238, 13);
            this.tbPhone.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(164, 492);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 24);
            this.label8.TabIndex = 40;
            this.label8.Text = "Note:";
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(296, 479);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(241, 53);
            this.rtbNote.TabIndex = 41;
            this.rtbNote.Text = "";
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Location = new System.Drawing.Point(0, 0);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthDay.TabIndex = 0;
            // 
            // cbType
            // 
            this.cbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(0, 13);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(241, 21);
            this.cbType.TabIndex = 0;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(586, 628);
            this.Controls.Add(this.rtbNote);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rtbAddress);
            this.Controls.Add(this.customPanel7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.customPanel6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customPanel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton1);
            this.Controls.Add(this.header1);
            this.Controls.Add(this.customPanel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.customPanel7.ResumeLayout(false);
            this.customPanel6.ResumeLayout(false);
            this.customPanel3.ResumeLayout(false);
            this.customPanel3.PerformLayout();
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.customPanel4.ResumeLayout(false);
            this.customPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Custom_Control.SexyDateTimePicker dtpBirthDay;
        private FormEclipse formEclipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CafeManager.Custom_Control.CustomPanel customPanel7;
        private System.Windows.Forms.Label label7;
        private CafeManager.Custom_Control.CustomPanel customPanel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private CafeManager.Custom_Control.CustomPanel customPanel3;
        private System.Windows.Forms.Label label3;
        private CafeManager.Custom_Control.CustomPanel customPanel2;
        private CafeManager.Custom_Control.CustomPanel customPanel1;
        private System.Windows.Forms.Label label1;
        private CafeManager.Custom_Control.ExitButton exitButton1;
        private Header header1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private CafeManager.Custom_Control.CustomPanel customPanel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.TextBox tbPhone;
        private Custom_Control.SexyDateTimePicker dtpBd;
        private System.Windows.Forms.ComboBox cbType;
    }
}