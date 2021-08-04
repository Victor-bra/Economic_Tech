using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economic_Tech.Forms.ForgotPasswordComponents
{
    public partial class RecoveryPassword : UserControl
    {
        public RecoveryPassword()
        {
            InitializeComponent();
        }

        private void AnsverButton_Enter(object sender, EventArgs e)
        {
            AnsverButton.Text = "";
        }

        private void NewPassword_Enter(object sender, EventArgs e)
        {
            NewPassword.Text = "";
        }

        private void RepeatNewPassword_Enter(object sender, EventArgs e)
        {
            RepeatNewPassword.Text = "";
        }

        private void RepeatNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (NewPassword.Text != RepeatNewPassword.Text)
                errorProvider1.SetError(RepeatNewPassword, "Пароли должны совпадать");
            else
                errorProvider1.Clear();
        }
    }
}
