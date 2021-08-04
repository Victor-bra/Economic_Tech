using Economic_Tech.Forms;
using Economic_Tech.Forms.MainUserControl;
using Economic_Tech.Forms.ManiClass;
using MetroFramework;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace Economic_Tech
{
    public partial class MainWindow : Form
    {

        public MainWindow()
        {

            InitializeComponent();
            XY.Top = bunifuFlatButton6.Top;
            typeOfProductionControl1.Visible = false;
            calculatingInvestmentControl1.Visible = false;
            productCostControl1.Visible = false;
            annualOutputControl1.Visible = false;
            efficiencyMarkControl1.Visible = false;
            firstFinalControl1.Visible = false;
            userData_Control1.BringToFront();
            Сalculate.BringToFront();
        }

        public int q = 0;
        //CloseButton
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(30);
                this.Opacity = this.Opacity - 0.1;
                if (i == 9)
                    Application.Exit();
            }
        }
        //CollapseButton
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                Left_panel.Width = 50;
                this.WindowState = FormWindowState.Normal;
                bunifuFlatButton2.Iconimage = System.Drawing.Image.FromFile("2.ico");
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                bunifuFlatButton2.Iconimage = System.Drawing.Image.FromFile("1.ico");
                Left_panel.Width = 250;
            }
        }
        //Maximized,Normal
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton5_Click_1(object sender, EventArgs e)
        {
            XY.Top = bunifuFlatButton5.Top;
            userData_Control1.Visible = false;
            typeOfProductionControl1.Visible = true;
            calculatingInvestmentControl1.Visible = false;
            productCostControl1.Visible = false;
            annualOutputControl1.Visible = false;
            efficiencyMarkControl1.Visible = false;
            firstFinalControl1.Visible = false;
            typeOfProductionControl1.BringToFront();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            userData_Control1.Visible = true;
            typeOfProductionControl1.Visible = false;
            calculatingInvestmentControl1.Visible = false;
            productCostControl1.Visible = false;
            annualOutputControl1.Visible = false;
            efficiencyMarkControl1.Visible = false;
            firstFinalControl1.Visible = false;
            XY.Top = bunifuFlatButton6.Top;
            userData_Control1.BringToFront();
            Сalculate.BringToFront();
        }

        private void Сalculate_Click(object sender, EventArgs e)
        {
            try
            {
                Thread myThread = new Thread(new ThreadStart(Count1));
                myThread.Start(); // запускаем поток 
                AdditionalDataForm additionalDataForm = new AdditionalDataForm();
                additionalDataForm.ShowDialog();
                //Заполнение Исходных данных
                string m = typeOfProductionControl1.MassaTextbox.Text = userData_Control1.MassaTextbox.Text;
                string fond = typeOfProductionControl1.FondTextbox.Text = userData_Control1.FondTextbox.Text;
                string kolDet = typeOfProductionControl1.KolDetTextbox.Text = userData_Control1.KolDetTextbox.Text;
                string Material = typeOfProductionControl1.MaterialTextbox.Text = userData_Control1.MaterialTextbox.Text;
                string Norma = typeOfProductionControl1.NormTextbox.Text = userData_Control1.NormTextbox.Text;
                //Расчет
                TypeOfProductionClass typeOfProductionClass = new TypeOfProductionClass();
                typeOfProductionClass.ishodnic(userData_Control1.BaseDataGrid, typeOfProductionControl1.BaseDataGrid,
                    userData_Control1.ProjectedDataGrid, typeOfProductionControl1.ProjectedDataGrid, m, fond, kolDet, Material, Norma,
                    typeOfProductionControl1.datagrid1_2_1, typeOfProductionControl1.datagrid1_2_2,
                    typeOfProductionControl1.TsumB, typeOfProductionControl1.TsumP, typeOfProductionControl1.WsumBpri,
                    typeOfProductionControl1.WsumPpri, typeOfProductionControl1.OBazi, typeOfProductionControl1.Opri,
                    typeOfProductionControl1.KzoB, typeOfProductionControl1.KzoP, typeOfProductionControl1.tipe, typeOfProductionControl1.DataColMest1_3_1,
                    typeOfProductionControl1.DataColMest1_3_2,
                    typeOfProductionControl1.TsumB1, typeOfProductionControl1.TsumP1, typeOfProductionControl1.WpiB1, typeOfProductionControl1.WpiP1,
                    typeOfProductionControl1.WsumBpri1, typeOfProductionControl1.WsumPpri1, typeOfProductionControl1.KzfB, typeOfProductionControl1.KzfP,
                    typeOfProductionControl1.KzanSumB, typeOfProductionControl1.KzanSumP);
                bunifuFlatButton5.Enabled = true;
                //Раздел 2
                CalculatingInvestmentClass calculatingInvestmentClass = new CalculatingInvestmentClass();
                calculatingInvestmentClass.two(userData_Control1, typeOfProductionControl1, calculatingInvestmentControl1);
                bunifuFlatButton7.Enabled = true;
                //Раздел 3
                ProductCostClass productCostClass = new ProductCostClass();
                AdditionalDataControl additionalDataControl = new AdditionalDataControl();
                productCostClass.productCost(userData_Control1, typeOfProductionControl1, calculatingInvestmentControl1, productCostControl1, additionalDataControl);
                bunifuFlatButton8.Enabled = true;
                //Раздел 4
                AnnualOutputClass annualOutputClass = new AnnualOutputClass();
                annualOutputClass.product(userData_Control1, typeOfProductionControl1, calculatingInvestmentControl1, productCostControl1,
                    additionalDataControl, annualOutputControl1);
                bunifuFlatButton9.Enabled = true;
                //Раздел 5
                EfficiencyMarkClass efficiencyMarkClass = new EfficiencyMarkClass();
                efficiencyMarkClass.EfficiencyMark(userData_Control1, typeOfProductionControl1, calculatingInvestmentControl1,
                    productCostControl1, additionalDataControl, annualOutputControl1, efficiencyMarkControl1, firstFinalControl1);
                bunifuFlatButton10.Enabled = true;
                //Раздел 6
                FirstFinalClass firstFinalClass = new FirstFinalClass();
                firstFinalClass.Final1(userData_Control1, typeOfProductionControl1, calculatingInvestmentControl1,
                    productCostControl1, additionalDataControl, annualOutputControl1, efficiencyMarkControl1, firstFinalControl1);
                bunifuFlatButton11.Enabled = true;
                MessageBox.Show("Расчет произведен успешно");
                Thread myThread1 = new Thread(new ThreadStart(Count2));
                myThread1.Start(); // запускаем поток 
            }
            catch
            {
                MetroMessageBox.Show(this, "Проверте правильность введенных данных и повторите попытку", "Произошла ошибка расчета", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Thread myThread1 = new Thread(new ThreadStart(Count2));
                myThread1.Start(); // запускаем поток 
            }
        }
        public void Count1()
        {
            progressPanel1.BringToFront();
        }
        public void Count2()
        {
            progressPanel1.SendToBack();
        }
        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            XY.Top = bunifuFlatButton7.Top;
            userData_Control1.Visible = false;
            calculatingInvestmentControl1.Visible = true;
            productCostControl1.Visible = false;
            annualOutputControl1.Visible = false;
            efficiencyMarkControl1.Visible = false;
            firstFinalControl1.Visible = false;
            calculatingInvestmentControl1.BringToFront();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            XY.Top = bunifuFlatButton8.Top;
            userData_Control1.Visible = false;
            typeOfProductionControl1.Visible = false;
            calculatingInvestmentControl1.Visible = false;
            productCostControl1.Visible = true;
            annualOutputControl1.Visible = false;
            efficiencyMarkControl1.Visible = false;
            firstFinalControl1.Visible = false;
            productCostControl1.BringToFront();
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            XY.Top = bunifuFlatButton9.Top;
            userData_Control1.Visible = false;
            typeOfProductionControl1.Visible = false;
            calculatingInvestmentControl1.Visible = false;
            productCostControl1.Visible = false;
            annualOutputControl1.Visible = true;
            efficiencyMarkControl1.Visible = false;
            firstFinalControl1.Visible = false;
            annualOutputControl1.BringToFront();
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            XY.Top = bunifuFlatButton10.Top;
            userData_Control1.Visible = false;
            typeOfProductionControl1.Visible = false;
            calculatingInvestmentControl1.Visible = false;
            productCostControl1.Visible = false;
            annualOutputControl1.Visible = false;
            efficiencyMarkControl1.Visible = true;
            firstFinalControl1.Visible = false;
            efficiencyMarkControl1.BringToFront();
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            XY.Top = bunifuFlatButton11.Top;
            userData_Control1.Visible = false;
            typeOfProductionControl1.Visible = false;
            calculatingInvestmentControl1.Visible = false;
            productCostControl1.Visible = false;
            annualOutputControl1.Visible = false;
            efficiencyMarkControl1.Visible = false;
            firstFinalControl1.Visible = true;
            firstFinalControl1.BringToFront();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        bool menuExpanded = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                if (!bunifuTransition1.IsCompleted) return;
                if (Left_panel.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
                {
                    if (!menuExpanded)
                    {
                        menuExpanded = true;
                        Left_panel.Visible = false;
                        Left_panel.Width = 225;
                        bunifuTransition1.Show(Left_panel);
                    }
                }
                else
                {
                    if (menuExpanded)
                    {
                        menuExpanded = false;
                        Left_panel.Visible = false;
                        Left_panel.Width = 50;
                        bunifuTransition1.Show(Left_panel);
                    }
                }
            }
            //Thread myThread2 = new Thread(new ThreadStart(PanelThreadFirst));
            //myThread2.Start(); // запускаем поток
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            AboutProgramControl aboutProgramControl = new AboutProgramControl();
            for (int i = 0; i < 1; i++)
            {
                if (q == 0)
                {
                    aboutProgramControl.Location = new Point(bunifuFlatButton12.Location.X + 30 - 300, bunifuFlatButton12.Location.Y + 30);
                    this.Controls.Add(aboutProgramControl);
                    aboutProgramControl.BringToFront();
                    q++;
                    break;
                }
                if (q == 1)
                {
                    aboutProgramControl.SendToBack();
                    q = 0;
                    if (userData_Control1.Visible == true)
                    {
                        userData_Control1.BringToFront();
                        Сalculate.BringToFront();
                    }
                    if (typeOfProductionControl1.Visible == true)
                        typeOfProductionControl1.BringToFront();
                    if (calculatingInvestmentControl1.Visible == true)
                        calculatingInvestmentControl1.BringToFront();
                    if (productCostControl1.Visible == true)
                        productCostControl1.BringToFront();
                    if (annualOutputControl1.Visible == true)
                        annualOutputControl1.BringToFront();
                    if (efficiencyMarkControl1.Visible == true)
                        efficiencyMarkControl1.BringToFront();
                    if (firstFinalControl1.Visible == true)
                        firstFinalControl1.BringToFront();
                    break;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string name;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = saveFileDialog1.FileName;
                StreamWriter text = new StreamWriter(name);
                try
                {
                    AdditionalDataForm additionalDataForm = new AdditionalDataForm();
                    text.WriteLine(additionalDataForm.additionalDataControl1.MinZP.Text);
                    text.WriteLine(userData_Control1.MassaTextbox.Text);
                    text.WriteLine(userData_Control1.FondTextbox.Text);
                    text.WriteLine(userData_Control1.KolDetTextbox.Text);
                    text.WriteLine(userData_Control1.MaterialTextbox.Text);
                    text.WriteLine(userData_Control1.MaterialPrice.Text);
                    text.WriteLine(userData_Control1.Dollar.Text);
                    text.WriteLine(userData_Control1.TS.Text);
                    text.WriteLine(userData_Control1.DollarTS.Text);
                    text.WriteLine(userData_Control1.KolTS.Text);

                    for (int i = 0; i < userData_Control1.BaseDataGrid.RowCount - 1; i++)
                    {
                        for (int j = 0; j < userData_Control1.BaseDataGrid.ColumnCount; j++)
                        {
                            text.Write(userData_Control1.BaseDataGrid.Rows[i].Cells[j].Value.ToString() + "|");
                        }
                        text.WriteLine();
                    }
                    text.WriteLine("^&");
                    for (int i = 0; i < userData_Control1.ProjectedDataGrid.RowCount - 1; i++)
                    {
                        for (int j = 0; j < userData_Control1.ProjectedDataGrid.ColumnCount; j++)
                        {
                            text.Write(userData_Control1.ProjectedDataGrid.Rows[i].Cells[j].Value.ToString() + "|");
                        }
                        text.WriteLine();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    text.Close();
                }

            }
        }

        private void Open_Bt_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string name = openFileDialog1.FileName;
                StreamReader text = new StreamReader(name);
                try
                {
                    AdditionalDataForm additionalDataForm = new AdditionalDataForm();
                    additionalDataForm.additionalDataControl1.MinZP.Text = text.ReadLine();
                    userData_Control1.MassaTextbox.Text = text.ReadLine();
                    userData_Control1.FondTextbox.Text = text.ReadLine();
                    userData_Control1.KolDetTextbox.Text = text.ReadLine();
                    userData_Control1.MaterialTextbox.Text = text.ReadLine();
                    userData_Control1.MaterialPrice.Text = text.ReadLine();
                    userData_Control1.Dollar.Text = text.ReadLine();
                    userData_Control1.TS.Text = text.ReadLine();
                    userData_Control1.DollarTS.Text = text.ReadLine();
                    userData_Control1.KolTS.Text = text.ReadLine();
                    string[] str;
                    string[] str6;
                    string[] str1 = text.ReadToEnd().Split('\n');
                    int col = 0;
                    for (int i = 0; i < str1.Length - 1; i++)
                    {
                        if (i == 0)
                        {
                            userData_Control1.BaseDataGrid.Rows.Clear();
                        }
                        str = str1[i].Split('|');
                        str6 = str1[i].Split('&');
                        if (str6[0] == "^")
                        {
                            col = i;
                            break;
                        }

                        userData_Control1.BaseDataGrid.Rows.Add();
                        for (int j = 0; j < userData_Control1.BaseDataGrid.ColumnCount; j++)
                        {
                            userData_Control1.BaseDataGrid.Rows[i].Cells[j].Value = str[j];
                        }
                    }
                    //MessageBox.Show(Convert.ToString(str1.Length));
                    int r = 0;
                    for (int i = col + 1; i < str1.Length - 1; i++)
                    {
                        if (i == col + 1)
                        {
                            userData_Control1.ProjectedDataGrid.Rows.Clear();
                        }
                        str = str1[i].Split('|');
                        userData_Control1.ProjectedDataGrid.Rows.Add();
                        for (int j = 0; j < userData_Control1.ProjectedDataGrid.ColumnCount; j++)
                        {
                            userData_Control1.ProjectedDataGrid.Rows[r].Cells[j].Value = str[j];
                        }
                        r++;
                    }
                    bunifuFlatButton5.Enabled = false;
                    bunifuFlatButton7.Enabled = false;
                    bunifuFlatButton8.Enabled = false;
                    bunifuFlatButton9.Enabled = false;
                    bunifuFlatButton10.Enabled = false;
                    bunifuFlatButton11.Enabled = false;
                    bunifuFlatButton6_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    text.Close();
                }
            }
        }

        private void BunifuFlatButton14_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string name = openFileDialog1.FileName;
                StreamReader text = new StreamReader(name);
                try
                {
                    AdditionalDataForm additionalDataForm = new AdditionalDataForm();
                    additionalDataForm.additionalDataControl1.MinZP.Text = text.ReadLine();
                    userData_Control1.MassaTextbox.Text = text.ReadLine();
                    userData_Control1.FondTextbox.Text = text.ReadLine();
                    userData_Control1.KolDetTextbox.Text = text.ReadLine();
                    userData_Control1.MaterialTextbox.Text = text.ReadLine();
                    userData_Control1.MaterialPrice.Text = text.ReadLine();
                    userData_Control1.Dollar.Text = text.ReadLine();
                    userData_Control1.TS.Text = text.ReadLine();
                    userData_Control1.DollarTS.Text = text.ReadLine();
                    userData_Control1.KolTS.Text = text.ReadLine();
                    string[] str;
                    string[] str6;
                    string[] str1 = text.ReadToEnd().Split('\n');
                    int col = 0;
                    for (int i = 0; i < str1.Length - 1; i++)
                    {
                        if (i == 0)
                        {
                            userData_Control1.BaseDataGrid.Rows.Clear();
                        }
                        str = str1[i].Split('|');
                        str6 = str1[i].Split('&');
                        if (str6[0] == "^")
                        {
                            col = i;
                            break;
                        }

                        userData_Control1.BaseDataGrid.Rows.Add();
                        for (int j = 0; j < userData_Control1.BaseDataGrid.ColumnCount; j++)
                        {
                            userData_Control1.BaseDataGrid.Rows[i].Cells[j].Value = str[j];
                        }
                    }
                    //MessageBox.Show(Convert.ToString(str1.Length));
                    int r = 0;
                    for (int i = col + 1; i < str1.Length - 1; i++)
                    {
                        if (i == col + 1)
                        {
                            userData_Control1.ProjectedDataGrid.Rows.Clear();
                        }
                        str = str1[i].Split('|');
                        userData_Control1.ProjectedDataGrid.Rows.Add();
                        for (int j = 0; j < userData_Control1.ProjectedDataGrid.ColumnCount; j++)
                        {
                            userData_Control1.ProjectedDataGrid.Rows[r].Cells[j].Value = str[j];
                        }
                        r++;
                    }
                    bunifuFlatButton5.Enabled = false;
                    bunifuFlatButton7.Enabled = false;
                    bunifuFlatButton8.Enabled = false;
                    bunifuFlatButton9.Enabled = false;
                    bunifuFlatButton10.Enabled = false;
                    bunifuFlatButton11.Enabled = false;
                    bunifuFlatButton6_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    text.Close();
                }
            }
        }

        private void Save_Bat_Click(object sender, EventArgs e)
        {
            string name;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = saveFileDialog1.FileName;
                StreamWriter text = new StreamWriter(name);
                try
                {
                    AdditionalDataForm additionalDataForm = new AdditionalDataForm();
                    text.WriteLine(additionalDataForm.additionalDataControl1.MinZP.Text);
                    text.WriteLine(userData_Control1.MassaTextbox.Text);
                    text.WriteLine(userData_Control1.FondTextbox.Text);
                    text.WriteLine(userData_Control1.KolDetTextbox.Text);
                    text.WriteLine(userData_Control1.MaterialTextbox.Text);
                    text.WriteLine(userData_Control1.MaterialPrice.Text);
                    text.WriteLine(userData_Control1.Dollar.Text);
                    text.WriteLine(userData_Control1.TS.Text);
                    text.WriteLine(userData_Control1.DollarTS.Text);
                    text.WriteLine(userData_Control1.KolTS.Text);

                    for (int i = 0; i < userData_Control1.BaseDataGrid.RowCount - 1; i++)
                    {
                        for (int j = 0; j < userData_Control1.BaseDataGrid.ColumnCount; j++)
                        {
                            text.Write(userData_Control1.BaseDataGrid.Rows[i].Cells[j].Value.ToString() + "|");
                        }
                        text.WriteLine();
                    }
                    text.WriteLine("^&");
                    for (int i = 0; i < userData_Control1.ProjectedDataGrid.RowCount - 1; i++)
                    {
                        for (int j = 0; j < userData_Control1.ProjectedDataGrid.ColumnCount; j++)
                        {
                            text.Write(userData_Control1.ProjectedDataGrid.Rows[i].Cells[j].Value.ToString() + "|");
                        }
                        text.WriteLine();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    text.Close();
                }
            }
        }

        private void TypeOfProductionControl1_Load(object sender, EventArgs e)
        {

        }
    }
}