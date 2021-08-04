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
    public partial class UserData_Control : UserControl
    {
        public UserData_Control()
        {
            InitializeComponent();
            string [] Stroka1 = { "002", "Автоматная токарная", "1Б265-6К", "1,313", "3", "8,4", "10", "583531,224" };
            string[] Stroka2 = { "025", "Сверлильная", "2А135", "0,15", "3", "0,8", "5,5","23088,29" };
            string[] Stroka3 = { "026", "Сверлильная", "2А135", "0,18", "3", "0,8", "5,5","23088,29" };
            string[] Stroka4 = { "040", "Зубофрезерная", "5В312", "1,75", "4", "2,25", "8", "399068,285" };
            string[] Stroka5 = { "045", "Протяжная", "7Б55У", "0,351", "4", "6", "25","65679,362" };
            string[] Stroka6 = { "046", "Вертикально-протяжная", "7Б55У", "0,547", "4", "6", "25","65679,362" };
            string[] Stroka7 = { "075", "Шевинговальная", "5702", "1,202", "4", "2,25", "10","33132,884" };
            string[] Stroka8 = { "076", "Шевинговальная", "5702", "1,21", "4", "2,25", "10", "33132,884" };
            //добавляем строки в таблицу
            addGridParam(Stroka1, BaseDataGrid);
            addGridParam(Stroka2, BaseDataGrid);
            addGridParam(Stroka3, BaseDataGrid);
            addGridParam(Stroka4, BaseDataGrid);
            addGridParam(Stroka5, BaseDataGrid);
            addGridParam(Stroka6, BaseDataGrid);
            addGridParam(Stroka7, BaseDataGrid);
            addGridParam(Stroka8, BaseDataGrid);
            //----------------------------------------------------
            string[] Stroka11 = { "002", "Автоматная токарная", "1Б265-6К", "1,313", "3", "8,4", "10","583531,224" };
            string[] Stroka21 = { "025", "Сверлильная", "2А125", "0,15", "3", "0,8", "3", "23088,29" };
            string[] Stroka31 = { "026", "Сверлильная", "2А125", "0,15", "3", "0,8", "3", "23088,29" };
            string[] Stroka41 = { "040", "Зубофрезерная", "5В312", "1,75", "4", "2,25", "8","399068,285" };
            string[] Stroka51 = { "045", "Протяжная", "МП7612-124", "0,351", "4", "3,25", "10","138399,904" };
            string[] Stroka61 = { "046", "Вертикально-протяжная", "МП7612-124", "0,4", "4", "3,25", "10","138399,904" };
            string[] Stroka71 = { "075", "Шевинговальная", "ABC022363", "1,21", "4", "2,25", "8","35310,825" };
            string[] Stroka81 = { "076", "Шевинговальная", "ABC022363", "0,9", "4", "2,25", "8", "35310,825" };
            //добавляем строки в таблицу
            addGridParam(Stroka11, ProjectedDataGrid);
            addGridParam(Stroka21, ProjectedDataGrid);
            addGridParam(Stroka31, ProjectedDataGrid);
            addGridParam(Stroka41, ProjectedDataGrid);
            addGridParam(Stroka51, ProjectedDataGrid);
            addGridParam(Stroka61, ProjectedDataGrid);
            addGridParam(Stroka71, ProjectedDataGrid);
            addGridParam(Stroka81, ProjectedDataGrid);
            MassaTextbox.Text = "0,581";
            FondTextbox.Text = "2024";
            KolDetTextbox.Text = "15000";
            MaterialTextbox.Text = "Сталь 45x";
            NormTextbox.Text = "0,836";
            Dollar.Text = "2,08";
            TS.Text = "Кран-балка";
            DollarTS.Text = "670,641";
            KolTS.Text = "1";
            MaterialPrice.Text = "1,80";
        }
        //функция заполнения таблицы
        /*N - массив строк
        Grid - сетка в которой будем отображать данные*/  
        public void addGridParam(string[] N, DataGridView Grid)
        {
            //пока столбцов не будет достаточное количество добавляем их
            while (N.Length > Grid.ColumnCount)
            {
                //если колонок нехватает добавляем их пока их будет хватать
                Grid.Columns.Add("", "");
            }
            //заполняем строку
            Grid.Rows.Add(N);
        }

        private void MassaTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void FondTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void KolDetTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void NormTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void Dollar_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void DollarTS_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void KolTS_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void MaterialPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }
    }
}
