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
namespace Economic_Tech.Forms.MainUserControl
{
    public partial class VvodForm : Form
    {
        public double Assk = 0;
        public VvodForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        //закрыть форму
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            TextBox.Text = "";
            try
            {
                if (Convert.ToDouble(TextBox.Text) < 0)
                    throw new Exception();
                else
                {
                    Assk = Convert.ToDouble(TextBox.Text);
                    this.Close();
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Мы тебя не выпустим пока данные не введешь", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //отмена
        private void metroButton2_Click(object sender, EventArgs e)
        {
            TextBox.Text = "";
            try
            {
                if(Convert.ToDouble(TextBox.Text)<0)
                    throw new Exception();
                else
                {
                    Assk = Convert.ToDouble(TextBox.Text);
                    this.Close();
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Введите данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Запуск формы с изменением label.Text
        public void ShowDialog1(string labeltext)
        {
            label.Text = labeltext;
            this.ShowDialog();
        }
        //Кнопка ОК
        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TextBox.Text);
                try
                {
                    if (x <= 0)
                        throw new Exception();
                    else
                    {
                        Assk = Convert.ToDouble(TextBox.Text);
                        this.Close();
                    }
                }
                catch
                {
                    MetroMessageBox.Show(this, "Переменная не может быть меньше нуля", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Произошла ошибка формата ввода данных", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        //Загрузка формы
        private void VvodForm_Load(object sender, EventArgs e)
        {
            TextBox.Text = "";
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void VvodForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                metroButton1.PerformClick();// имитируем нажатие ок
            }
            if (e.KeyCode == Keys.Escape)
            {
                metroButton2.PerformClick();// имитируем нажатие отмены
            }
        }
    }
}
