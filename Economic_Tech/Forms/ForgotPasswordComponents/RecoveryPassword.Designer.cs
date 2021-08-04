namespace Economic_Tech.Forms.ForgotPasswordComponents
{
    partial class RecoveryPassword
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoveryPassword));
            this.Question_Label = new ns1.BunifuCustomLabel();
            this.AnsverButton = new ns1.BunifuMetroTextbox();
            this.NewPassword = new ns1.BunifuMetroTextbox();
            this.RepeatNewPassword = new ns1.BunifuMetroTextbox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Question_Label
            // 
            this.Question_Label.AutoSize = true;
            this.Question_Label.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Question_Label.ForeColor = System.Drawing.Color.White;
            this.Question_Label.Location = new System.Drawing.Point(6, 21);
            this.Question_Label.Name = "Question_Label";
            this.Question_Label.Size = new System.Drawing.Size(70, 21);
            this.Question_Label.TabIndex = 19;
            this.Question_Label.Text = "Вопрос";
            // 
            // AnsverButton
            // 
            this.AnsverButton.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(158)))), ((int)(((byte)(35)))));
            this.AnsverButton.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.AnsverButton.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(118)))));
            this.AnsverButton.BorderThickness = 3;
            this.AnsverButton.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AnsverButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnsverButton.ForeColor = System.Drawing.Color.White;
            this.AnsverButton.isPassword = false;
            this.AnsverButton.Location = new System.Drawing.Point(6, 56);
            this.AnsverButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AnsverButton.Name = "AnsverButton";
            this.AnsverButton.Size = new System.Drawing.Size(287, 41);
            this.AnsverButton.TabIndex = 18;
            this.AnsverButton.Text = "Ответ";
            this.AnsverButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AnsverButton.Enter += new System.EventHandler(this.AnsverButton_Enter);
            // 
            // NewPassword
            // 
            this.NewPassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(158)))), ((int)(((byte)(35)))));
            this.NewPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.NewPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(118)))));
            this.NewPassword.BorderThickness = 3;
            this.NewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NewPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPassword.ForeColor = System.Drawing.Color.White;
            this.NewPassword.isPassword = false;
            this.NewPassword.Location = new System.Drawing.Point(6, 107);
            this.NewPassword.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(287, 41);
            this.NewPassword.TabIndex = 20;
            this.NewPassword.Text = "Новый пароль";
            this.NewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NewPassword.Enter += new System.EventHandler(this.NewPassword_Enter);
            // 
            // RepeatNewPassword
            // 
            this.RepeatNewPassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(158)))), ((int)(((byte)(35)))));
            this.RepeatNewPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.RepeatNewPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(118)))));
            this.RepeatNewPassword.BorderThickness = 3;
            this.RepeatNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RepeatNewPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepeatNewPassword.ForeColor = System.Drawing.Color.White;
            this.RepeatNewPassword.isPassword = false;
            this.RepeatNewPassword.Location = new System.Drawing.Point(6, 158);
            this.RepeatNewPassword.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.RepeatNewPassword.Name = "RepeatNewPassword";
            this.RepeatNewPassword.Size = new System.Drawing.Size(287, 41);
            this.RepeatNewPassword.TabIndex = 21;
            this.RepeatNewPassword.Text = "Повторите новый пароль";
            this.RepeatNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RepeatNewPassword.Enter += new System.EventHandler(this.RepeatNewPassword_Enter);
            this.RepeatNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.RepeatNewPassword_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this.RepeatNewPassword;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // RecoveryPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.RepeatNewPassword);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.Question_Label);
            this.Controls.Add(this.AnsverButton);
            this.Name = "RecoveryPassword";
            this.Size = new System.Drawing.Size(341, 223);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ns1.BunifuCustomLabel Question_Label;
        public ns1.BunifuMetroTextbox AnsverButton;
        public ns1.BunifuMetroTextbox NewPassword;
        public ns1.BunifuMetroTextbox RepeatNewPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
