namespace CafeManager.GUI.ManagerForm
{
    partial class EditVoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditVoucher));
            this.customPanel1 = new CafeManager.Custom_Control.CustomPanel();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.rtbName = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.header1 = new CafeManager.Header();
            this.button1 = new System.Windows.Forms.Button();
            this.customPanel6 = new CafeManager.Custom_Control.CustomPanel();
            this.dtpBirthDay = new CafeManager.GUI.Custom_Control.SexyDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.exitButton1 = new CafeManager.Custom_Control.ExitButton();
            this.rbtValue = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customPanel1.SuspendLayout();
            this.customPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customPanel1.Controls.Add(this.cbType);
            this.customPanel1.ElipseRadius = 0;
            this.customPanel1.Location = new System.Drawing.Point(119, 177);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(436, 31);
            this.customPanel1.TabIndex = 21;
            // 
            // cbType
            // 
            this.cbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Đã sử dụng",
            "Chưa sử dụng"});
            this.cbType.Location = new System.Drawing.Point(3, 7);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(436, 21);
            this.cbType.TabIndex = 0;
            // 
            // rtbName
            // 
            this.rtbName.Location = new System.Drawing.Point(121, 78);
            this.rtbName.MaxLength = 100;
            this.rtbName.Name = "rtbName";
            this.rtbName.Size = new System.Drawing.Size(436, 33);
            this.rtbName.TabIndex = 19;
            this.rtbName.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(13, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Đã Sử Dụng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(17, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Code";
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.header1.Location = new System.Drawing.Point(-1, -1);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(575, 33);
            this.header1.TabIndex = 14;
            this.header1.TargetControl = null;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(239)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(448, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 40);
            this.button1.TabIndex = 22;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customPanel6
            // 
            this.customPanel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.customPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel6.Controls.Add(this.dtpBirthDay);
            this.customPanel6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customPanel6.ElipseRadius = 0;
            this.customPanel6.Location = new System.Drawing.Point(121, 128);
            this.customPanel6.Name = "customPanel6";
            this.customPanel6.Size = new System.Drawing.Size(436, 33);
            this.customPanel6.TabIndex = 23;
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Location = new System.Drawing.Point(-1, 7);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(439, 20);
            this.dtpBirthDay.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Expired";
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
            this.exitButton1.Location = new System.Drawing.Point(541, -1);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Size = new System.Drawing.Size(33, 33);
            this.exitButton1.TabIndex = 15;
            this.exitButton1.UseVisualStyleBackColor = false;
            this.exitButton1.Click += new System.EventHandler(this.exitButton1_Click);
            // 
            // rbtValue
            // 
            this.rbtValue.Location = new System.Drawing.Point(119, 226);
            this.rbtValue.MaxLength = 100;
            this.rbtValue.Name = "rbtValue";
            this.rbtValue.Size = new System.Drawing.Size(436, 33);
            this.rbtValue.TabIndex = 26;
            this.rbtValue.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(15, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Value";
            // 
            // EditVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(572, 361);
            this.Controls.Add(this.rbtValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customPanel6);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.rtbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton1);
            this.Controls.Add(this.header1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditVoucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditItems";
            this.Load += new System.EventHandler(this.EditItems_Load);
            this.customPanel1.ResumeLayout(false);
            this.customPanel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CafeManager.Custom_Control.CustomPanel customPanel1;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.RichTextBox rtbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private CafeManager.Custom_Control.ExitButton exitButton1;
        private Header header1;
        private System.Windows.Forms.Button button1;
        private CafeManager.Custom_Control.CustomPanel customPanel6;
        private Custom_Control.SexyDateTimePicker dtpBirthDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rbtValue;
        private System.Windows.Forms.Label label2;
    }
}