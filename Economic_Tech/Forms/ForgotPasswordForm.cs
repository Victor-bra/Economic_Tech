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
using System.Data.OleDb;

namespace Economic_Tech.Forms.RegistrationUsersComponets
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
            email1.BringToFront();
            this.KeyPreview = true;
        }
        //CloseButton
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
        }
        //Свернуть Button
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Change cursor while moving
        private void Top_panel_MouseUp(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        private void Top_panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.Cursor = Cursors.SizeAll;
        }

        public int SchetButton=0;
        public static string ConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Registration_Base.mdb;Jet OLEDB:Engine Type=5;Jet OLEDB:Database Password=Baranchik";
        public OleDbConnection baza;
        string Email = "", Question = "", Ask = "";
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            SchetButton++;
            if (SchetButton == 1)
            {
                try
                {
                    baza = new OleDbConnection(ConnString);
                    baza.Open();
                    string query = "SELECT E_mail FROM Registration_People WHERE E_mail = '" + email1.Email_Button.Text + "'";
                    // создаем объект OleDbCommand для выполнения запроса к БД MS Access
                    OleDbCommand command = new OleDbCommand(query, baza);
                    Email = command.ExecuteScalar().ToString();
                    query = "SELECT Question FROM Registration_People WHERE E_mail = '" + email1.Email_Button.Text + "'";
                    command = new OleDbCommand(query, baza);
                    Question = command.ExecuteScalar().ToString();
                    recoveryPassword1.Question_Label.Text = Question;
                    query = "SELECT Answer FROM Registration_People WHERE E_mail = '" + email1.Email_Button.Text + "'";
                    command = new OleDbCommand(query, baza);
                    Ask = command.ExecuteScalar().ToString();
                    recoveryPassword1.BringToFront();
                    baza.Close();
                }
                catch (Exception)
                {
                    SchetButton--;
                    MetroMessageBox.Show(this, "Данного адреса не сужествует", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (SchetButton == 2)
            {
                try
                {
                    if (recoveryPassword1.AnsverButton.Text == Ask &&
                        recoveryPassword1.NewPassword.Text == recoveryPassword1.RepeatNewPassword.Text)
                    {
                        try
                        {
                            baza = new OleDbConnection(ConnString);
                            baza.Open();
                            // текст запроса
                            string query = "UPDATE Registration_People SET Пароль ='"+ recoveryPassword1.NewPassword.Text + "' WHERE E_mail = '"+ Email + "'";
                            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
                            OleDbCommand command = new OleDbCommand(query, baza);

                            // выполняем запрос к MS Access
                            command.ExecuteNonQuery();
                            baza.Close();
                            MessageBox.Show("Пароль успешно заменен");
                            this.Close();
                            AuthorizationForm authorizationForm = new AuthorizationForm();
                            authorizationForm.Show();
                        }
                        catch
                        {
                            SchetButton--;
                            MessageBox.Show("Ошибка сохранения пароля");
                        }
                    }
                    else
                        throw new Exception();
                }
                catch(Exception)
                {
                    MetroMessageBox.Show(this, "Ошибка ответа на вопрос или пароли должны совпадать", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    SchetButton--;
                }
            }

        }
    }
}
