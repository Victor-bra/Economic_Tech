using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economic_Tech.Forms
{
    public partial class First_Registration : UserControl
    {
        public First_Registration()
        {
            InitializeComponent();
            bunifuDropdown2.SelectedIndex = 0;
        }

        private void LoginButton_Enter(object sender, EventArgs e)
        {
            LoginButton.Text = "";
        }

        private void FirstPasswordButton_Enter(object sender, EventArgs e)
        {
            FirstPasswordButton.Text = "";
        }

        private void SecondPasswordButton_Enter(object sender, EventArgs e)
        {
            SecondPasswordButton.Text = "";
        }

        private void TelButton_Enter(object sender, EventArgs e)
        {
            TelButton.Text = "";
        }

        private void EmailButton_Enter(object sender, EventArgs e)
        {
            EmailButton.Text = "";
        }

        private void bunifuDropdown2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bunifuDropdown2.SelectedIndex == 4)
                bunifuTextBox1.Visible = true;
            else
                bunifuTextBox1.Visible = false;
        }

        private void bunifuTextBox2_Enter(object sender, EventArgs e)
        {
            bunifuTextBox2.DefaultText = "";
        }

        private void LoginButton_Validating(object sender, CancelEventArgs e)
        {
            if (LoginButton.Text == "")
            {
                LoginButton.Text = "Логин";
                e.Cancel = false;
            }
        }

        private void FirstPasswordButton_Validating(object sender, CancelEventArgs e)
        {
            if (FirstPasswordButton.Text == "")
            {
                FirstPasswordButton.Text = "Пароль";
                e.Cancel = false;
            }
        }

        private void SecondPasswordButton_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.Clear();
            if (SecondPasswordButton.Text == "")
            {
                SecondPasswordButton.Text = "Повторите пароль";
                e.Cancel = false;
            }
            if (SecondPasswordButton.Text != FirstPasswordButton.Text)
                errorProvider1.SetError(SecondPasswordButton, "Пароли должны совпадать");
            else
                errorProvider1.Clear();
        }

        private void bunifuTextBox1_Enter(object sender, EventArgs e)
        {
            bunifuTextBox1.DefaultText = "";
        }

        private void bunifuTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (bunifuTextBox1.DefaultText == "")
            {
                bunifuTextBox1.DefaultText = "Введите вопрос";
                e.Cancel = false;
            }
        }

        private void bunifuTextBox2_Validating(object sender, CancelEventArgs e)
        {
            if (bunifuTextBox2.DefaultText == "")
            {
                bunifuTextBox2.DefaultText = "Ответ";
                e.Cancel = false;
            }
        }

        private void EmailButton_Validating(object sender, CancelEventArgs e)
        {
            if (EmailButton.Text == "")
            {
                EmailButton.Text = "Email адрес";
                e.Cancel = false;
            }
        }
    }
}
