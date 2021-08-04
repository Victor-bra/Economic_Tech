namespace Economic_Tech.Forms.ForgotPasswordComponents
{
    partial class Email
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
            this.Email_Button = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // Email_Button
            // 
            this.Email_Button.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(158)))), ((int)(((byte)(35)))));
            this.Email_Button.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.Email_Button.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(118)))));
            this.Email_Button.BorderThickness = 3;
            this.Email_Button.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email_Button.ForeColor = System.Drawing.Color.White;
            this.Email_Button.isPassword = false;
            this.Email_Button.Location = new System.Drawing.Point(6, 56);
            this.Email_Button.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Email_Button.Name = "Email_Button";
            this.Email_Button.Size = new System.Drawing.Size(305, 41);
            this.Email_Button.TabIndex = 16;
            this.Email_Button.Text = "Email";
            this.Email_Button.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Email_Button.Enter += new System.EventHandler(this.Email_Button_Enter);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(5, 30);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(116, 21);
            this.bunifuCustomLabel2.TabIndex = 17;
            this.bunifuCustomLabel2.Text = "Введите почту";
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.Email_Button);
            this.Name = "Email";
            this.Size = new System.Drawing.Size(320, 129);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        public ns1.BunifuMetroTextbox Email_Button;
    }
}
