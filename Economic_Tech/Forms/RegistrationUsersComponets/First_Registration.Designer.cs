namespace Economic_Tech.Forms
{
    partial class First_Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(First_Registration));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TelButton = new System.Windows.Forms.MaskedTextBox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.EmailButton = new ns1.BunifuMaterialTextbox();
            this.SecondPasswordButton = new ns1.BunifuMaterialTextbox();
            this.FirstPasswordButton = new ns1.BunifuMaterialTextbox();
            this.LoginButton = new ns1.BunifuMaterialTextbox();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuDropdown2 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuTextBox2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(380, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 4);
            this.panel1.TabIndex = 15;
            // 
            // TelButton
            // 
            this.TelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TelButton.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TelButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TelButton.ForeColor = System.Drawing.Color.White;
            this.TelButton.Location = new System.Drawing.Point(380, 120);
            this.TelButton.Mask = "+375(99)99-999-99";
            this.TelButton.Name = "TelButton";
            this.TelButton.Size = new System.Drawing.Size(253, 20);
            this.TelButton.TabIndex = 14;
            this.TelButton.Enter += new System.EventHandler(this.TelButton_Enter);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(33, 29);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(183, 21);
            this.bunifuCustomLabel1.TabIndex = 13;
            this.bunifuCustomLabel1.Text = "Введите ваши данные";
            // 
            // EmailButton
            // 
            this.EmailButton.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.EmailButton.ForeColor = System.Drawing.Color.White;
            this.EmailButton.HintForeColor = System.Drawing.Color.Empty;
            this.EmailButton.HintText = "";
            this.EmailButton.isPassword = false;
            this.EmailButton.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(158)))), ((int)(((byte)(35)))));
            this.EmailButton.LineIdleColor = System.Drawing.Color.Gray;
            this.EmailButton.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(118)))));
            this.EmailButton.LineThickness = 4;
            this.EmailButton.Location = new System.Drawing.Point(380, 70);
            this.EmailButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.EmailButton.Name = "EmailButton";
            this.EmailButton.Size = new System.Drawing.Size(253, 32);
            this.EmailButton.TabIndex = 11;
            this.EmailButton.Text = "Email адрес";
            this.EmailButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmailButton.Enter += new System.EventHandler(this.EmailButton_Enter);
            this.EmailButton.Validating += new System.ComponentModel.CancelEventHandler(this.EmailButton_Validating);
            // 
            // SecondPasswordButton
            // 
            this.SecondPasswordButton.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SecondPasswordButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.SecondPasswordButton.ForeColor = System.Drawing.Color.White;
            this.SecondPasswordButton.HintForeColor = System.Drawing.Color.Empty;
            this.SecondPasswordButton.HintText = "";
            this.SecondPasswordButton.isPassword = false;
            this.SecondPasswordButton.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(158)))), ((int)(((byte)(35)))));
            this.SecondPasswordButton.LineIdleColor = System.Drawing.Color.Gray;
            this.SecondPasswordButton.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(118)))));
            this.SecondPasswordButton.LineThickness = 4;
            this.SecondPasswordButton.Location = new System.Drawing.Point(37, 154);
            this.SecondPasswordButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SecondPasswordButton.Name = "SecondPasswordButton";
            this.SecondPasswordButton.Size = new System.Drawing.Size(253, 32);
            this.SecondPasswordButton.TabIndex = 10;
            this.SecondPasswordButton.Text = "Повторите пароль";
            this.SecondPasswordButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SecondPasswordButton.Enter += new System.EventHandler(this.SecondPasswordButton_Enter);
            this.SecondPasswordButton.Validating += new System.ComponentModel.CancelEventHandler(this.SecondPasswordButton_Validating);
            // 
            // FirstPasswordButton
            // 
            this.FirstPasswordButton.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FirstPasswordButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FirstPasswordButton.ForeColor = System.Drawing.Color.White;
            this.FirstPasswordButton.HintForeColor = System.Drawing.Color.Empty;
            this.FirstPasswordButton.HintText = "";
            this.FirstPasswordButton.isPassword = false;
            this.FirstPasswordButton.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(158)))), ((int)(((byte)(35)))));
            this.FirstPasswordButton.LineIdleColor = System.Drawing.Color.Gray;
            this.FirstPasswordButton.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(118)))));
            this.FirstPasswordButton.LineThickness = 4;
            this.FirstPasswordButton.Location = new System.Drawing.Point(37, 112);
            this.FirstPasswordButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.FirstPasswordButton.Name = "FirstPasswordButton";
            this.FirstPasswordButton.Size = new System.Drawing.Size(253, 32);
            this.FirstPasswordButton.TabIndex = 9;
            this.FirstPasswordButton.Text = "Пароль";
            this.FirstPasswordButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FirstPasswordButton.Enter += new System.EventHandler(this.FirstPasswordButton_Enter);
            this.FirstPasswordButton.Validating += new System.ComponentModel.CancelEventHandler(this.FirstPasswordButton_Validating);
            // 
            // LoginButton
            // 
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.HintForeColor = System.Drawing.Color.Empty;
            this.LoginButton.HintText = "";
            this.LoginButton.isPassword = false;
            this.LoginButton.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(158)))), ((int)(((byte)(35)))));
            this.LoginButton.LineIdleColor = System.Drawing.Color.Gray;
            this.LoginButton.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(118)))));
            this.LoginButton.LineThickness = 4;
            this.LoginButton.Location = new System.Drawing.Point(37, 70);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(253, 32);
            this.LoginButton.TabIndex = 8;
            this.LoginButton.Text = "Логин";
            this.LoginButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LoginButton.Enter += new System.EventHandler(this.LoginButton_Enter);
            this.LoginButton.Validating += new System.ComponentModel.CancelEventHandler(this.LoginButton_Validating);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this.bunifuDropdown2;
            // 
            // bunifuDropdown2
            // 
            this.bunifuDropdown2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuDropdown2.BorderRadius = 5;
            this.bunifuDropdown2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(158)))), ((int)(((byte)(35)))));
            this.bunifuDropdown2.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifuDropdown2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bunifuDropdown2.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.bunifuDropdown2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifuDropdown2.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown2.FillDropDown = false;
            this.bunifuDropdown2.FillIndicator = false;
            this.bunifuDropdown2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuDropdown2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuDropdown2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(158)))), ((int)(((byte)(35)))));
            this.bunifuDropdown2.FormattingEnabled = true;
            this.bunifuDropdown2.Icon = null;
            this.bunifuDropdown2.IndicatorColor = System.Drawing.Color.Blue;
            this.bunifuDropdown2.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown2.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(254)))), ((int)(((byte)(199)))));
            this.bunifuDropdown2.ItemBorderColor = System.Drawing.Color.DimGray;
            this.bunifuDropdown2.ItemForeColor = System.Drawing.Color.Purple;
            this.bunifuDropdown2.ItemHeight = 26;
            this.bunifuDropdown2.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(209)))), ((int)(((byte)(232)))));
            this.bunifuDropdown2.Items.AddRange(new object[] {
            "Девичья фамилия матери",
            "Ваше любимое животное",
            "Количество оставшихся пальцев",
            "Любимая марка телефона",
            "Свой вариант....."});
            this.bunifuDropdown2.Location = new System.Drawing.Point(37, 226);
            this.bunifuDropdown2.Name = "bunifuDropdown2";
            this.bunifuDropdown2.Size = new System.Drawing.Size(596, 32);
            this.bunifuDropdown2.TabIndex = 18;
            this.bunifuDropdown2.Tag = "";
            this.bunifuDropdown2.Text = null;
            this.bunifuDropdown2.SelectedIndexChanged += new System.EventHandler(this.bunifuDropdown2_SelectedIndexChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(40, 202);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(161, 21);
            this.bunifuCustomLabel2.TabIndex = 17;
            this.bunifuCustomLabel2.Text = "Секретный вопрос";
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.AcceptsReturn = false;
            this.bunifuTextBox1.AcceptsTab = false;
            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(158)))), ((int)(((byte)(35)))));
            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(35)))));
            this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.bunifuTextBox1.BorderRadius = 1;
            this.bunifuTextBox1.BorderThickness = 2;
            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuTextBox1.DefaultText = "Введите вопрос";
            this.bunifuTextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bunifuTextBox1.ForeColor = System.Drawing.Color.White;
            this.bunifuTextBox1.HideSelection = true;
            this.bunifuTextBox1.IconLeft = null;
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox1.IconPadding = 10;
            this.bunifuTextBox1.IconRight = null;
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox1.Location = new System.Drawing.Point(37, 264);
            this.bunifuTextBox1.MaxLength = 32767;
            this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox1.Modified = false;
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.ReadOnly = false;
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.SelectionLength = 0;
            this.bunifuTextBox1.SelectionStart = 0;
            this.bunifuTextBox1.ShortcutsEnabled = true;
            this.bunifuTextBox1.Size = new System.Drawing.Size(596, 35);
            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox1.TabIndex = 19;
            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox1.TextMarginLeft = 5;
            this.bunifuTextBox1.TextPlaceholder = "";
            this.bunifuTextBox1.UseSystemPasswordChar = false;
            this.bunifuTextBox1.Visible = false;
            this.bunifuTextBox1.Enter += new System.EventHandler(this.bunifuTextBox1_Enter);
            this.bunifuTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.bunifuTextBox1_Validating);
            // 
            // bunifuTextBox2
            // 
            this.bunifuTextBox2.AcceptsReturn = false;
            this.bunifuTextBox2.AcceptsTab = false;
            this.bunifuTextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox2.BackgroundImage")));
            this.bunifuTextBox2.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(158)))), ((int)(((byte)(35)))));
            this.bunifuTextBox2.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuTextBox2.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(35)))));
            this.bunifuTextBox2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.bunifuTextBox2.BorderRadius = 1;
            this.bunifuTextBox2.BorderThickness = 2;
            this.bunifuTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox2.DefaultFont = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuTextBox2.DefaultText = "Ответ";
            this.bunifuTextBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bunifuTextBox2.ForeColor = System.Drawing.Color.White;
            this.bunifuTextBox2.HideSelection = true;
            this.bunifuTextBox2.IconLeft = null;
            this.bunifuTextBox2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox2.IconPadding = 10;
            this.bunifuTextBox2.IconRight = null;
            this.bunifuTextBox2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox2.Location = new System.Drawing.Point(37, 305);
            this.bunifuTextBox2.MaxLength = 32767;
            this.bunifuTextBox2.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox2.Modified = false;
            this.bunifuTextBox2.Name = "bunifuTextBox2";
            this.bunifuTextBox2.PasswordChar = '\0';
            this.bunifuTextBox2.ReadOnly = false;
            this.bunifuTextBox2.SelectedText = "";
            this.bunifuTextBox2.SelectionLength = 0;
            this.bunifuTextBox2.SelectionStart = 0;
            this.bunifuTextBox2.ShortcutsEnabled = true;
            this.bunifuTextBox2.Size = new System.Drawing.Size(596, 35);
            this.bunifuTextBox2.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox2.TabIndex = 20;
            this.bunifuTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox2.TextMarginLeft = 5;
            this.bunifuTextBox2.TextPlaceholder = "";
            this.bunifuTextBox2.UseSystemPasswordChar = false;
            this.bunifuTextBox2.Enter += new System.EventHandler(this.bunifuTextBox2_Enter);
            this.bunifuTextBox2.Validating += new System.ComponentModel.CancelEventHandler(this.bunifuTextBox2_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            this.errorProvider1.RightToLeftChanged += new System.EventHandler(this.SecondPasswordButton_Enter);
            // 
            // First_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.bunifuTextBox2);
            this.Controls.Add(this.bunifuTextBox1);
            this.Controls.Add(this.bunifuDropdown2);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TelButton);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.EmailButton);
            this.Controls.Add(this.SecondPasswordButton);
            this.Controls.Add(this.FirstPasswordButton);
            this.Controls.Add(this.LoginButton);
            this.Name = "First_Registration";
            this.Size = new System.Drawing.Size(800, 350);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        public ns1.BunifuMaterialTextbox LoginButton;
        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.MaskedTextBox TelButton;
        public ns1.BunifuMaterialTextbox EmailButton;
        public ns1.BunifuMaterialTextbox SecondPasswordButton;
        public ns1.BunifuMaterialTextbox FirstPasswordButton;
        public Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown2;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox bunifuTextBox1;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox bunifuTextBox2;
    }
}
