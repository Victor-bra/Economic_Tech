using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economic_Tech.Forms.MainUserControl
{
    public partial class AboutProgramControl : UserControl
    {
        public AboutProgramControl()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
