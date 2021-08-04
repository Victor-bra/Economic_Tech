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
    public partial class Email : UserControl
    {
        public Email()
        {
            InitializeComponent();
        }

        private void Email_Button_Enter(object sender, EventArgs e)
        {
            Email_Button.Text = "";
        }
    }
}
