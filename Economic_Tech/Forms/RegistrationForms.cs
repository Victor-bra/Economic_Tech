using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MetroFramework;
using System.Data.SqlClient;

namespace Economic_Tech.Forms
{
    public partial class RegistrationForms : Form
    {
        public static string ConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Registration_Base.mdb;Jet OLEDB:Engine Type=5;Jet OLEDB:Database Password=Baranchik";
        public OleDbConnection baza;
        public static string ConnString1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Activator_Cods.mdb;Jet OLEDB:Engine Type=5;Jet OLEDB:Database Password=Baranchik";
        public OleDbConnection baza1;
        public RegistrationForms()
        {
            InitializeComponent();
            first_Registration1.BringToFront();
            //создание или открытие существующей
            ADOX.Catalog BD = new ADOX.Catalog();
            try
            {
                BD.Create(ConnString);
                BD = null;
                baza = new OleDbConnection(ConnString);
                baza.Open();
                //Создание таблицы в БД
                OleDbCommand com = new OleDbCommand("CREATE TABLE Registration_People (ID int IDENTITY(1,1),Логин STRING, Пароль STRING, E_mail STRING, Phone STRING, Question STRING, Answer STRING)", baza);
                com.ExecuteNonQuery();
            }
            catch
            {
                baza = new OleDbConnection(ConnString);
                baza.Open();
            }
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
        //CloseButton
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
        }
        int SchetButton = 0;
        string ComputerCode = "", LicenseCode = "";
        //ДалееButton
        string Login = "", Password = "", SeconPasword = "", Email = "", Phone = "", Question = "", Answer = "";

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            SchetButton++;
            if (SchetButton == 1)
            {
                try
                {
                    Login = first_Registration1.LoginButton.Text;
                    Password = first_Registration1.FirstPasswordButton.Text;
                    SeconPasword = first_Registration1.SecondPasswordButton.Text;
                    if (Password != SeconPasword)
                        throw new ArgumentException();
                    Email = first_Registration1.EmailButton.Text;
                    Phone = first_Registration1.TelButton.Text;
                    if (first_Registration1.bunifuDropdown2.SelectedIndex == 4)
                        Question = first_Registration1.bunifuTextBox1.DefaultText;
                    else
                        Question = first_Registration1.bunifuDropdown2.Text;
                    Answer = first_Registration1.bunifuTextBox2.DefaultText;
                    second_Registration1.BringToFront();
                    bunifuCheckbox1.Visible = true;
                    bunifuCustomLabel1.Visible = true;
                    bunifuFlatButton3.Enabled = false;
                    bunifuFlatButton4.Visible = true;
                }
                catch (ArgumentException)
                {
                    SchetButton--;
                    MetroMessageBox.Show(this,"Пароли должны совпадать", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch
                {
                    SchetButton--;
                    MetroMessageBox.Show(this, "Неизвестная ошибка", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                bunifuCheckbox1.Visible = false;
                bunifuCustomLabel1.Visible = false;
            }
            
            if (SchetButton == 2)
            {
                third_Registration1.BringToFront();
                bunifuFlatButton3.Text = "Готово";
                bunifuFlatButton3.Iconimage_right = null;
                Random random = new Random();
                int x=random.Next(4001);
                baza1 = new OleDbConnection(ConnString1);
                baza1.Open();
                // текст запроса
                string query = "SELECT Code1 FROM Actvators WHERE Cod = "+(x-1)+"";
                // создаем объект OleDbCommand для выполнения запроса к БД MS Access
                OleDbCommand command = new OleDbCommand(query, baza1);
                // выполняем запрос и выводим результат в textBox1
                ComputerCode = command.ExecuteScalar().ToString();
                string query1 = "SELECT Code2 FROM Actvators WHERE Cod = " + (x - 1) + "";
                OleDbCommand command1 = new OleDbCommand(query1, baza1);
                LicenseCode = command1.ExecuteScalar().ToString();
                third_Registration1.ComputerCode.Text = ComputerCode;
                //third_Registration1.LicenseCode.Text = LicenseCode;
                baza1.Close();
            }
            if (SchetButton == 3)
            {
                if (LicenseCode == third_Registration1.LicenseCode.Text)
                {
                    string query = "INSERT INTO Registration_People (Логин, Пароль,E_mail,Phone,Question,Answer) VALUES ('"
                        + Login + "','" + Password + "','" + Email + "','" + Phone + "','" + Question + "','" + Answer + "')";
                    // создаем объект OleDbCommand для выполнения запроса к БД MS Access
                    OleDbCommand command = new OleDbCommand(query, baza);
                    // выполняем запрос к MS Access
                    command.ExecuteNonQuery();
                    baza.Close();
                    MessageBox.Show("Регистрация пройдена успешна =)");
                    this.Hide();
                    AuthorizationForm authorizationForm = new AuthorizationForm();
                    authorizationForm.Show();
                }
                if (LicenseCode != third_Registration1.LicenseCode.Text)
                {
                    SchetButton--;
                    MetroMessageBox.Show(this, "Лицензионный ключ не действителен", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked==true)
                bunifuFlatButton3.Enabled = true;
            else
                bunifuFlatButton3.Enabled = false;
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked == true)
            {
                bunifuCheckbox1.Checked = false;
                bunifuFlatButton3.Enabled = false;
            }
            else
            {
                bunifuCheckbox1.Checked = true;
                bunifuFlatButton3.Enabled = true;
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (SchetButton == 1)
            {
                SchetButton = 0;
                first_Registration1.BringToFront();
                bunifuCheckbox1.Visible = false;
                bunifuCustomLabel1.Visible = false;
                bunifuFlatButton3.Enabled = true;
                bunifuFlatButton4.Visible = false;
            }
            if (SchetButton == 2)
            {
                SchetButton = 1;
                second_Registration1.BringToFront();
                bunifuCheckbox1.Visible = true;
                bunifuCustomLabel1.Visible = true;
                bunifuFlatButton3.Enabled = false;
                bunifuCheckbox1.Checked = false;
                bunifuFlatButton3.Text = "Далее";
                bunifuFlatButton3.Iconimage = null;
                bunifuFlatButton3.Iconimage_right = System.Drawing.Image.FromFile("icons8-воспроизведение-96.png");
                //bunifuFlatButton3.Iconimage = System.Drawing.Image.FromFile("1.ico");
            }
        }

        private void RegistrationForms_FormClosing(object sender, FormClosingEventArgs e)
        {
            baza.Close();
        }
    }
}
