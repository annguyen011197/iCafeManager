namespace CafeManager.ManagerForm
{
    partial class InputNumber
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
            this.formEclipse1 = new CafeManager.FormEclipse(this.components);
            this.header1 = new CafeManager.Header();
            this.customPanel7 = new CafeManager.Custom_Control.CustomPanel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.customPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // formEclipse1
            // 
            this.formEclipse1.ElipseRadius = 5;
            this.formEclipse1.TargetControl = this;
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.header1.Location = new System.Drawing.Point(-1, -1);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(274, 34);
            this.header1.TabIndex = 1;
            this.header1.TargetControl = null;
            // 
            // customPanel7
            // 
            this.customPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.customPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel7.Controls.Add(this.textBox7);
            this.customPanel7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customPanel7.ElipseRadius = 0;
            this.customPanel7.Location = new System.Drawing.Point(12, 70);
            this.customPanel7.Name = "customPanel7";
            this.customPanel7.Size = new System.Drawing.Size(246, 44);
            this.customPanel7.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(4, 15);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(237, 16);
            this.textBox7.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nhập số:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(21, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 30);
            this.button1.TabIndex = 21;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(166, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 30);
            this.button2.TabIndex = 22;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InputNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 175);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customPanel7);
            this.Controls.Add(this.header1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InputNumber";
            this.customPanel7.ResumeLayout(false);
            this.customPanel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FormEclipse formEclipse1;
        private Header header1;
        private System.Windows.Forms.Label label1;
        private Custom_Control.CustomPanel customPanel7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}