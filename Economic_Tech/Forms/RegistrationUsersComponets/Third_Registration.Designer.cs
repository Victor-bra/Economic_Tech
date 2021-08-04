namespace Economic_Tech.Forms.RegistrationUsersComponets
{
    partial class Third_Registration
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.ComputerCode = new ns1.BunifuMetroTextbox();
            this.LicenseCode = new ns1.BunifuMetroTextbox();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 12);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(206, 21);
            this.bunifuCustomLabel1.TabIndex = 14;
            this.bunifuCustomLabel1.Text = "Код вашего компьютера";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(3, 103);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(170, 21);
            this.bunifuCustomLabel2.TabIndex = 15;
            this.bunifuCustomLabel2.Text = "Лицензионный ключ";
            // 
            // ComputerCode
            // 
            this.ComputerCode.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(158)))), ((int)(((byte)(35)))));
            this.ComputerCode.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComputerCode.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(118)))));
            this.ComputerCode.BorderThickness = 3;
            this.ComputerCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ComputerCode.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ComputerCode.ForeColor = System.Drawing.Color.White;
            this.ComputerCode.isPassword = false;
            this.ComputerCode.Location = new System.Drawing.Point(7, 44);
            this.ComputerCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ComputerCode.Name = "ComputerCode";
            this.ComputerCode.Size = new System.Drawing.Size(766, 40);
            this.ComputerCode.TabIndex = 16;
            this.ComputerCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LicenseCode
            // 
            this.LicenseCode.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(158)))), ((int)(((byte)(35)))));
            this.LicenseCode.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LicenseCode.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(118)))));
            this.LicenseCode.BorderThickness = 3;
            this.LicenseCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LicenseCode.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LicenseCode.ForeColor = System.Drawing.Color.White;
            this.LicenseCode.isPassword = false;
            this.LicenseCode.Location = new System.Drawing.Point(7, 148);
            this.LicenseCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.LicenseCode.Name = "LicenseCode";
            this.LicenseCode.Size = new System.Drawing.Size(766, 40);
            this.LicenseCode.TabIndex = 17;
            this.LicenseCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Third_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.LicenseCode);
            this.Controls.Add(this.ComputerCode);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Name = "Third_Registration";
            this.Size = new System.Drawing.Size(800, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        public ns1.BunifuMetroTextbox LicenseCode;
        public ns1.BunifuMetroTextbox ComputerCode;
        public ns1.BunifuCustomLabel bunifuCustomLabel1;
    }
}
