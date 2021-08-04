namespace Economic_Tech
{
    partial class MainWindow
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
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Top_panel = new System.Windows.Forms.Panel();
            this.Save_Bat = new ns1.BunifuFlatButton();
            this.Open_Bat = new ns1.BunifuFlatButton();
            this.bunifuFlatButton12 = new ns1.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton3 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton2 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
            this.Left_panel = new System.Windows.Forms.Panel();
            this.bunifuFlatButton11 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton10 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton9 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new ns1.BunifuFlatButton();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Сalculate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.XY = new System.Windows.Forms.Panel();
            this.typeOfProductionControl1 = new Economic_Tech.Forms.MainUserControl.TypeOfProductionControl();
            this.userData_Control1 = new Economic_Tech.Forms.MainUserControl.UserData_Control();
            this.calculatingInvestmentControl1 = new Economic_Tech.Forms.MainUserControl.CalculatingInvestmentControl();
            this.productCostControl1 = new Economic_Tech.Forms.MainUserControl.ProductCostControl();
            this.annualOutputControl1 = new Economic_Tech.Forms.MainUserControl.AnnualOutputControl();
            this.efficiencyMarkControl1 = new Economic_Tech.Forms.MainUserControl.EfficiencyMarkControl();
            this.firstFinalControl1 = new Economic_Tech.Forms.MainUserControl.FirstFinalControl();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Top_panel.SuspendLayout();
            this.Left_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Top_panel
            // 
            this.Top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.Top_panel.Controls.Add(this.Save_Bat);
            this.Top_panel.Controls.Add(this.Open_Bat);
            this.Top_panel.Controls.Add(this.bunifuFlatButton12);
            this.Top_panel.Controls.Add(this.bunifuCustomLabel1);
            this.Top_panel.Controls.Add(this.bunifuFlatButton3);
            this.Top_panel.Controls.Add(this.bunifuFlatButton2);
            this.Top_panel.Controls.Add(this.bunifuFlatButton1);
            this.bunifuTransition1.SetDecoration(this.Top_panel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_panel.Location = new System.Drawing.Point(0, 0);
            this.Top_panel.Name = "Top_panel";
            this.Top_panel.Size = new System.Drawing.Size(1100, 30);
            this.Top_panel.TabIndex = 0;
            // 
            // Save_Bat
            // 
            this.Save_Bat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Save_Bat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.Save_Bat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Save_Bat.BorderRadius = 0;
            this.Save_Bat.ButtonText = "";
            this.Save_Bat.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTransition1.SetDecoration(this.Save_Bat, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Save_Bat.DisabledColor = System.Drawing.Color.Gray;
            this.Save_Bat.Dock = System.Windows.Forms.DockStyle.Left;
            this.Save_Bat.Iconcolor = System.Drawing.Color.Transparent;
            this.Save_Bat.Iconimage = global::Economic_Tech.Properties.Resources.icons8_save_as_128px1;
            this.Save_Bat.Iconimage_right = null;
            this.Save_Bat.Iconimage_right_Selected = null;
            this.Save_Bat.Iconimage_Selected = null;
            this.Save_Bat.IconMarginLeft = 0;
            this.Save_Bat.IconMarginRight = 0;
            this.Save_Bat.IconRightVisible = true;
            this.Save_Bat.IconRightZoom = 0D;
            this.Save_Bat.IconVisible = true;
            this.Save_Bat.IconZoom = 47D;
            this.Save_Bat.IsTab = false;
            this.Save_Bat.Location = new System.Drawing.Point(174, 0);
            this.Save_Bat.Name = "Save_Bat";
            this.Save_Bat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.Save_Bat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Save_Bat.OnHoverTextColor = System.Drawing.Color.White;
            this.Save_Bat.selected = false;
            this.Save_Bat.Size = new System.Drawing.Size(30, 30);
            this.Save_Bat.TabIndex = 13;
            this.Save_Bat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save_Bat.Textcolor = System.Drawing.Color.White;
            this.Save_Bat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Bat.Click += new System.EventHandler(this.Save_Bat_Click);
            // 
            // Open_Bat
            // 
            this.Open_Bat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Open_Bat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.Open_Bat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Open_Bat.BorderRadius = 0;
            this.Open_Bat.ButtonText = "";
            this.Open_Bat.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTransition1.SetDecoration(this.Open_Bat, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Open_Bat.DisabledColor = System.Drawing.Color.Gray;
            this.Open_Bat.Dock = System.Windows.Forms.DockStyle.Left;
            this.Open_Bat.Iconcolor = System.Drawing.Color.Transparent;
            this.Open_Bat.Iconimage = global::Economic_Tech.Properties.Resources.icons8_opened_folder_100px_61;
            this.Open_Bat.Iconimage_right = null;
            this.Open_Bat.Iconimage_right_Selected = null;
            this.Open_Bat.Iconimage_Selected = null;
            this.Open_Bat.IconMarginLeft = 0;
            this.Open_Bat.IconMarginRight = 0;
            this.Open_Bat.IconRightVisible = true;
            this.Open_Bat.IconRightZoom = 0D;
            this.Open_Bat.IconVisible = true;
            this.Open_Bat.IconZoom = 50D;
            this.Open_Bat.IsTab = false;
            this.Open_Bat.Location = new System.Drawing.Point(144, 0);
            this.Open_Bat.Name = "Open_Bat";
            this.Open_Bat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.Open_Bat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Open_Bat.OnHoverTextColor = System.Drawing.Color.White;
            this.Open_Bat.selected = false;
            this.Open_Bat.Size = new System.Drawing.Size(30, 30);
            this.Open_Bat.TabIndex = 12;
            this.Open_Bat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Open_Bat.Textcolor = System.Drawing.Color.White;
            this.Open_Bat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open_Bat.Click += new System.EventHandler(this.BunifuFlatButton14_Click);
            // 
            // bunifuFlatButton12
            // 
            this.bunifuFlatButton12.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bunifuFlatButton12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bunifuFlatButton12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton12.BorderRadius = 0;
            this.bunifuFlatButton12.ButtonText = "";
            this.bunifuFlatButton12.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuFlatButton12.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton12.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton12.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton12.Iconimage")));
            this.bunifuFlatButton12.Iconimage_right = null;
            this.bunifuFlatButton12.Iconimage_right_Selected = null;
            this.bunifuFlatButton12.Iconimage_Selected = null;
            this.bunifuFlatButton12.IconMarginLeft = 0;
            this.bunifuFlatButton12.IconMarginRight = 0;
            this.bunifuFlatButton12.IconRightVisible = true;
            this.bunifuFlatButton12.IconRightZoom = 0D;
            this.bunifuFlatButton12.IconVisible = true;
            this.bunifuFlatButton12.IconZoom = 40D;
            this.bunifuFlatButton12.IsTab = false;
            this.bunifuFlatButton12.Location = new System.Drawing.Point(950, 0);
            this.bunifuFlatButton12.Name = "bunifuFlatButton12";
            this.bunifuFlatButton12.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bunifuFlatButton12.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuFlatButton12.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton12.selected = false;
            this.bunifuFlatButton12.Size = new System.Drawing.Size(30, 30);
            this.bunifuFlatButton12.TabIndex = 10;
            this.bunifuFlatButton12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton12.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton12.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton12.Click += new System.EventHandler(this.bunifuFlatButton12_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(144, 19);
            this.bunifuCustomLabel1.TabIndex = 9;
            this.bunifuCustomLabel1.Text = "Economic_Tech v 1.0";
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = global::Economic_Tech.Properties.Resources.icons8_свернуть_окно_961;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 60D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(1010, 0);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(30, 30);
            this.bunifuFlatButton3.TabIndex = 4;
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 60D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(1040, 0);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(30, 30);
            this.bunifuFlatButton2.TabIndex = 3;
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::Economic_Tech.Properties.Resources.icons8_удалить_100;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 45D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(1070, 0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(30, 30);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Tag = "";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // Left_panel
            // 
            this.Left_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.Left_panel.Controls.Add(this.bunifuFlatButton11);
            this.Left_panel.Controls.Add(this.bunifuFlatButton10);
            this.Left_panel.Controls.Add(this.bunifuFlatButton9);
            this.Left_panel.Controls.Add(this.bunifuFlatButton8);
            this.Left_panel.Controls.Add(this.bunifuFlatButton7);
            this.Left_panel.Controls.Add(this.bunifuFlatButton5);
            this.Left_panel.Controls.Add(this.bunifuFlatButton6);
            this.Left_panel.Controls.Add(this.bunifuFlatButton4);
            this.bunifuTransition1.SetDecoration(this.Left_panel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left_panel.Location = new System.Drawing.Point(0, 30);
            this.Left_panel.Name = "Left_panel";
            this.Left_panel.Size = new System.Drawing.Size(50, 481);
            this.Left_panel.TabIndex = 1;
            // 
            // bunifuFlatButton11
            // 
            this.bunifuFlatButton11.Active = false;
            this.bunifuFlatButton11.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bunifuFlatButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton11.BorderRadius = 0;
            this.bunifuFlatButton11.ButtonText = "6. Заключение";
            this.bunifuFlatButton11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuFlatButton11.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton11.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton11.Enabled = false;
            this.bunifuFlatButton11.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton11.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton11.Iconimage")));
            this.bunifuFlatButton11.Iconimage_right = null;
            this.bunifuFlatButton11.Iconimage_right_Selected = null;
            this.bunifuFlatButton11.Iconimage_Selected = null;
            this.bunifuFlatButton11.IconMarginLeft = 0;
            this.bunifuFlatButton11.IconMarginRight = 0;
            this.bunifuFlatButton11.IconRightVisible = true;
            this.bunifuFlatButton11.IconRightZoom = 0D;
            this.bunifuFlatButton11.IconVisible = true;
            this.bunifuFlatButton11.IconZoom = 90D;
            this.bunifuFlatButton11.IsTab = false;
            this.bunifuFlatButton11.Location = new System.Drawing.Point(0, 350);
            this.bunifuFlatButton11.Name = "bunifuFlatButton11";
            this.bunifuFlatButton11.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bunifuFlatButton11.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton11.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton11.selected = false;
            this.bunifuFlatButton11.Size = new System.Drawing.Size(50, 50);
            this.bunifuFlatButton11.TabIndex = 13;
            this.bunifuFlatButton11.Text = "6. Заключение";
            this.bunifuFlatButton11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton11.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton11.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton11.Click += new System.EventHandler(this.bunifuFlatButton11_Click);
            // 
            // bunifuFlatButton10
            // 
            this.bunifuFlatButton10.Active = false;
            this.bunifuFlatButton10.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bunifuFlatButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton10.BorderRadius = 0;
            this.bunifuFlatButton10.ButtonText = "5. Основные параметры и оценка эффективности";
            this.bunifuFlatButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuFlatButton10.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton10.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton10.Enabled = false;
            this.bunifuFlatButton10.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton10.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton10.Iconimage")));
            this.bunifuFlatButton10.Iconimage_right = null;
            this.bunifuFlatButton10.Iconimage_right_Selected = null;
            this.bunifuFlatButton10.Iconimage_Selected = null;
            this.bunifuFlatButton10.IconMarginLeft = 0;
            this.bunifuFlatButton10.IconMarginRight = 0;
            this.bunifuFlatButton10.IconRightVisible = true;
            this.bunifuFlatButton10.IconRightZoom = 0D;
            this.bunifuFlatButton10.IconVisible = true;
            this.bunifuFlatButton10.IconZoom = 90D;
            this.bunifuFlatButton10.IsTab = false;
            this.bunifuFlatButton10.Location = new System.Drawing.Point(0, 300);
            this.bunifuFlatButton10.Name = "bunifuFlatButton10";
            this.bunifuFlatButton10.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bunifuFlatButton10.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton10.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton10.selected = false;
            this.bunifuFlatButton10.Size = new System.Drawing.Size(50, 50);
            this.bunifuFlatButton10.TabIndex = 12;
            this.bunifuFlatButton10.Text = "5. Основные параметры и оценка эффективности";
            this.bunifuFlatButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton10.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton10.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton10.Click += new System.EventHandler(this.bunifuFlatButton10_Click);
            // 
            // bunifuFlatButton9
            // 
            this.bunifuFlatButton9.Active = false;
            this.bunifuFlatButton9.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bunifuFlatButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton9.BorderRadius = 0;
            this.bunifuFlatButton9.ButtonText = "4. Годовой объем выпуска продукции";
            this.bunifuFlatButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuFlatButton9.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton9.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton9.Enabled = false;
            this.bunifuFlatButton9.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton9.Iconimage = global::Economic_Tech.Properties.Resources.Gold_Bars_96px;
            this.bunifuFlatButton9.Iconimage_right = null;
            this.bunifuFlatButton9.Iconimage_right_Selected = null;
            this.bunifuFlatButton9.Iconimage_Selected = null;
            this.bunifuFlatButton9.IconMarginLeft = 0;
            this.bunifuFlatButton9.IconMarginRight = 0;
            this.bunifuFlatButton9.IconRightVisible = true;
            this.bunifuFlatButton9.IconRightZoom = 0D;
            this.bunifuFlatButton9.IconVisible = true;
            this.bunifuFlatButton9.IconZoom = 90D;
            this.bunifuFlatButton9.IsTab = false;
            this.bunifuFlatButton9.Location = new System.Drawing.Point(0, 250);
            this.bunifuFlatButton9.Name = "bunifuFlatButton9";
            this.bunifuFlatButton9.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bunifuFlatButton9.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton9.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton9.selected = false;
            this.bunifuFlatButton9.Size = new System.Drawing.Size(50, 50);
            this.bunifuFlatButton9.TabIndex = 11;
            this.bunifuFlatButton9.Text = "4. Годовой объем выпуска продукции";
            this.bunifuFlatButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton9.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton9.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton9.Click += new System.EventHandler(this.bunifuFlatButton9_Click);
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Active = false;
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton8.BorderRadius = 0;
            this.bunifuFlatButton8.ButtonText = "3. Расчет себестоимости продукции";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton8.Enabled = false;
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton8.Iconimage")));
            this.bunifuFlatButton8.Iconimage_right = null;
            this.bunifuFlatButton8.Iconimage_right_Selected = null;
            this.bunifuFlatButton8.Iconimage_Selected = null;
            this.bunifuFlatButton8.IconMarginLeft = 0;
            this.bunifuFlatButton8.IconMarginRight = 0;
            this.bunifuFlatButton8.IconRightVisible = true;
            this.bunifuFlatButton8.IconRightZoom = 0D;
            this.bunifuFlatButton8.IconVisible = true;
            this.bunifuFlatButton8.IconZoom = 90D;
            this.bunifuFlatButton8.IsTab = false;
            this.bunifuFlatButton8.Location = new System.Drawing.Point(0, 200);
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton8.selected = false;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(50, 50);
            this.bunifuFlatButton8.TabIndex = 10;
            this.bunifuFlatButton8.Text = "3. Расчет себестоимости продукции";
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton8.Click += new System.EventHandler(this.bunifuFlatButton8_Click);
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Active = false;
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "2. Расчет велечины инвестиций";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton7.Enabled = false;
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton7.Iconimage")));
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 90D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(0, 150);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(50, 50);
            this.bunifuFlatButton7.TabIndex = 9;
            this.bunifuFlatButton7.Text = "2. Расчет велечины инвестиций";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton7.Click += new System.EventHandler(this.bunifuFlatButton7_Click);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Active = false;
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "1. Организация производства";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton5.Enabled = false;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton5.Iconimage")));
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 90D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(0, 100);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(50, 50);
            this.bunifuFlatButton5.TabIndex = 8;
            this.bunifuFlatButton5.Text = "1. Организация производства";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Click += new System.EventHandler(this.bunifuFlatButton5_Click_1);
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Active = false;
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "Ввод исходных данных";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton6.Iconimage")));
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 90D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(0, 50);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(50, 50);
            this.bunifuFlatButton6.TabIndex = 7;
            this.bunifuFlatButton6.Text = "Ввод исходных данных";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton6.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = global::Economic_Tech.Properties.Resources.icons8_меню_filled_480;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 70D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(50, 50);
            this.bunifuFlatButton4.TabIndex = 5;
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this.Сalculate;
            // 
            // Сalculate
            // 
            this.Сalculate.Active = false;
            this.Сalculate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Сalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Сalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(118)))), ((int)(((byte)(168)))));
            this.Сalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Сalculate.BorderRadius = 0;
            this.Сalculate.ButtonText = "Расчитать";
            this.Сalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.Сalculate, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Сalculate.DisabledColor = System.Drawing.Color.Gray;
            this.Сalculate.Iconcolor = System.Drawing.Color.Transparent;
            this.Сalculate.Iconimage = global::Economic_Tech.Properties.Resources.icons8_калькулятор_100_1;
            this.Сalculate.Iconimage_right = null;
            this.Сalculate.Iconimage_right_Selected = null;
            this.Сalculate.Iconimage_Selected = null;
            this.Сalculate.IconMarginLeft = 0;
            this.Сalculate.IconMarginRight = 0;
            this.Сalculate.IconRightVisible = true;
            this.Сalculate.IconRightZoom = 0D;
            this.Сalculate.IconVisible = true;
            this.Сalculate.IconZoom = 60D;
            this.Сalculate.IsTab = false;
            this.Сalculate.Location = new System.Drawing.Point(925, 451);
            this.Сalculate.Name = "Сalculate";
            this.Сalculate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(118)))), ((int)(((byte)(168)))));
            this.Сalculate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(152)))), ((int)(((byte)(48)))));
            this.Сalculate.OnHoverTextColor = System.Drawing.Color.White;
            this.Сalculate.selected = false;
            this.Сalculate.Size = new System.Drawing.Size(145, 48);
            this.Сalculate.TabIndex = 3;
            this.Сalculate.Text = "Расчитать";
            this.Сalculate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Сalculate.Textcolor = System.Drawing.Color.White;
            this.Сalculate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Сalculate.Click += new System.EventHandler(this.Сalculate_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.MaxAnimationTime = 15000;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.XY);
            this.bunifuTransition1.SetDecoration(this.panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(50, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 481);
            this.panel1.TabIndex = 11;
            // 
            // XY
            // 
            this.XY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(154)))), ((int)(((byte)(37)))));
            this.bunifuTransition1.SetDecoration(this.XY, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.XY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(154)))), ((int)(((byte)(37)))));
            this.XY.Location = new System.Drawing.Point(0, 150);
            this.XY.Name = "XY";
            this.XY.Size = new System.Drawing.Size(10, 50);
            this.XY.TabIndex = 12;
            // 
            // typeOfProductionControl1
            // 
            this.typeOfProductionControl1.AutoScroll = true;
            this.bunifuTransition1.SetDecoration(this.typeOfProductionControl1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.typeOfProductionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeOfProductionControl1.Location = new System.Drawing.Point(0, 0);
            this.typeOfProductionControl1.Name = "typeOfProductionControl1";
            this.typeOfProductionControl1.Size = new System.Drawing.Size(1100, 511);
            this.typeOfProductionControl1.TabIndex = 5;
            this.typeOfProductionControl1.Load += new System.EventHandler(this.TypeOfProductionControl1_Load);
            // 
            // userData_Control1
            // 
            this.userData_Control1.AutoScroll = true;
            this.userData_Control1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuTransition1.SetDecoration(this.userData_Control1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.userData_Control1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userData_Control1.Location = new System.Drawing.Point(0, 0);
            this.userData_Control1.Name = "userData_Control1";
            this.userData_Control1.Size = new System.Drawing.Size(1100, 511);
            this.userData_Control1.TabIndex = 4;
            // 
            // calculatingInvestmentControl1
            // 
            this.calculatingInvestmentControl1.AutoScroll = true;
            this.bunifuTransition1.SetDecoration(this.calculatingInvestmentControl1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.calculatingInvestmentControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculatingInvestmentControl1.Location = new System.Drawing.Point(0, 0);
            this.calculatingInvestmentControl1.Name = "calculatingInvestmentControl1";
            this.calculatingInvestmentControl1.Size = new System.Drawing.Size(1100, 511);
            this.calculatingInvestmentControl1.TabIndex = 6;
            // 
            // productCostControl1
            // 
            this.productCostControl1.AutoScroll = true;
            this.bunifuTransition1.SetDecoration(this.productCostControl1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.productCostControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productCostControl1.Location = new System.Drawing.Point(0, 0);
            this.productCostControl1.Name = "productCostControl1";
            this.productCostControl1.Size = new System.Drawing.Size(1100, 511);
            this.productCostControl1.TabIndex = 7;
            // 
            // annualOutputControl1
            // 
            this.annualOutputControl1.AutoScroll = true;
            this.bunifuTransition1.SetDecoration(this.annualOutputControl1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.annualOutputControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.annualOutputControl1.Location = new System.Drawing.Point(0, 0);
            this.annualOutputControl1.Name = "annualOutputControl1";
            this.annualOutputControl1.Size = new System.Drawing.Size(1100, 511);
            this.annualOutputControl1.TabIndex = 8;
            // 
            // efficiencyMarkControl1
            // 
            this.efficiencyMarkControl1.AutoScroll = true;
            this.bunifuTransition1.SetDecoration(this.efficiencyMarkControl1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.efficiencyMarkControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.efficiencyMarkControl1.Location = new System.Drawing.Point(0, 0);
            this.efficiencyMarkControl1.Name = "efficiencyMarkControl1";
            this.efficiencyMarkControl1.Size = new System.Drawing.Size(1100, 511);
            this.efficiencyMarkControl1.TabIndex = 9;
            // 
            // firstFinalControl1
            // 
            this.firstFinalControl1.AutoScroll = true;
            this.bunifuTransition1.SetDecoration(this.firstFinalControl1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.firstFinalControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstFinalControl1.Location = new System.Drawing.Point(0, 0);
            this.firstFinalControl1.Name = "firstFinalControl1";
            this.firstFinalControl1.Size = new System.Drawing.Size(1100, 511);
            this.firstFinalControl1.TabIndex = 10;
            // 
            // progressPanel1
            // 
            this.progressPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressPanel1.AnimationElementImage = ((System.Drawing.Image)(resources.GetObject("progressPanel1.AnimationElementImage")));
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.BarAnimationElementThickness = 2;
            this.progressPanel1.Caption = "Подождите пожалуйста";
            this.bunifuTransition1.SetDecoration(this.progressPanel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.progressPanel1.Description = "Загрузка ...";
            this.progressPanel1.Location = new System.Drawing.Point(435, 214);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.TabIndex = 12;
            this.progressPanel1.Text = "progressPanel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormResizing = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = false;
            this.bunifuFormDock1.ShowDockingIndicators = true;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = this.Top_panel;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "RichTextFormate|*.rtf|Text Files|*.txt|All Files|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "RichTextFormate|*.rtf|Text Files|*.txt|All Files|*.*";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 511);
            this.Controls.Add(this.Сalculate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Left_panel);
            this.Controls.Add(this.Top_panel);
            this.Controls.Add(this.progressPanel1);
            this.Controls.Add(this.typeOfProductionControl1);
            this.Controls.Add(this.userData_Control1);
            this.Controls.Add(this.calculatingInvestmentControl1);
            this.Controls.Add(this.productCostControl1);
            this.Controls.Add(this.annualOutputControl1);
            this.Controls.Add(this.efficiencyMarkControl1);
            this.Controls.Add(this.firstFinalControl1);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Economic_Tech";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Top_panel.ResumeLayout(false);
            this.Top_panel.PerformLayout();
            this.Left_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Top_panel;
        private ns1.BunifuFlatButton bunifuFlatButton1;
        private ns1.BunifuFlatButton bunifuFlatButton3;
        private ns1.BunifuFlatButton bunifuFlatButton2;
        private ns1.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton Сalculate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuFlatButton bunifuFlatButton12;
        private System.Windows.Forms.Panel XY;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton7;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton8;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton9;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton10;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton11;
        public System.Windows.Forms.Panel Left_panel;
        public ns1.BunifuElipse bunifuElipse1;
        public Forms.MainUserControl.UserData_Control userData_Control1;
        public Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        public Forms.MainUserControl.TypeOfProductionControl typeOfProductionControl1;
        public Forms.MainUserControl.CalculatingInvestmentControl calculatingInvestmentControl1;
        public Forms.MainUserControl.ProductCostControl productCostControl1;
        public Forms.MainUserControl.AnnualOutputControl annualOutputControl1;
        public Forms.MainUserControl.EfficiencyMarkControl efficiencyMarkControl1;
        public Forms.MainUserControl.FirstFinalControl firstFinalControl1;
        public Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Panel panel1;
        public Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private ns1.BunifuFlatButton Open_Bat;
        private ns1.BunifuFlatButton Save_Bat;
    }
}

