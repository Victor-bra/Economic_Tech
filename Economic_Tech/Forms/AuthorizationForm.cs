using Economic_Tech.Forms.RegistrationUsersComponets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Threading;
using System.Data.OleDb;

namespace Economic_Tech.Forms
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            metroProgressBar1.Visible = false;
            label1.Text = "";
        }
        //Change cursor while moving
        private void Top_panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.Cursor = Cursors.SizeAll;
        }
        private void Top_panel_MouseUp(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
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
        //Свернуть Button
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //ButtonRegistration
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForms registrationForms = new RegistrationForms();
            registrationForms.ShowDialog();
        }
        //Enter a TextBox
        private void Text_Login_Enter(object sender, EventArgs e)
        {
            Text_Login.Text = "";
        }
        private void Text_Password_Enter(object sender, EventArgs e)
        {
            Text_Password.Text = "";
        }
        public static string ConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Registration_Base.mdb;Jet OLEDB:Engine Type=5;Jet OLEDB:Database Password=Baranchik";
        public OleDbConnection baza;
        string Login = "", Password = "";
        //ButtonOK
        private void Button_OK_Click(object sender, EventArgs e)
        {
            metroProgressBar1.Visible = true;
            metroProgressBar1.Minimum = 0;
            metroProgressBar1.Maximum = 7;
            metroProgressBar1.Value = 0;
            try
            {
                baza = new OleDbConnection(ConnString);
                baza.Open();
                metroProgressBar1.Value++;
                label1.Text = (100 * metroProgressBar1.Value) / metroProgressBar1.Maximum + " %";
                string query = "SELECT Логин FROM Registration_People WHERE Логин = '" + Text_Login.Text + "'";
                metroProgressBar1.Value++;
                label1.Text = (100 * metroProgressBar1.Value) / metroProgressBar1.Maximum + " %";
                // создаем объект OleDbCommand для выполнения запроса к БД MS Access
                OleDbCommand command = new OleDbCommand(query, baza);
                metroProgressBar1.Value++;
                label1.Text = (100 * metroProgressBar1.Value) / metroProgressBar1.Maximum + " %";
                // выполняем запрос к MS Access
                command.ExecuteNonQuery();
                metroProgressBar1.Value++;
                label1.Text = (100 * metroProgressBar1.Value) / metroProgressBar1.Maximum + " %";
                Login = command.ExecuteScalar().ToString();
                query = "SELECT Пароль FROM Registration_People WHERE Логин = '" + Text_Login.Text + "'";
                metroProgressBar1.Value++;
                label1.Text = (100 * metroProgressBar1.Value) / metroProgressBar1.Maximum + " %";
                command = new OleDbCommand(query, baza);
                command.ExecuteNonQuery();
                metroProgressBar1.Value++;
                label1.Text = (100 * metroProgressBar1.Value) / metroProgressBar1.Maximum + " %";
                Password = command.ExecuteScalar().ToString();
                metroProgressBar1.Value++;
                label1.Text = (100 * metroProgressBar1.Value) / metroProgressBar1.Maximum + " %";
                if (Login == Text_Login.Text && Password == Text_Password.Text)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Hide();
                    baza.Close();
                }
                else
                    throw new Exception();
            }
            catch
            {
                
                baza.Close();
                MetroMessageBox.Show(this, "Ошибка ввода логина или пароль", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                metroProgressBar1.Visible = false;
                label1.Text = "";
            }
        }

        private void AuthorizationForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button_OK_Click(Button_OK, null);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.ShowDialog();

        }
    }
}
