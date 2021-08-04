using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economic_Tech.Forms.ManiClass
{
    public class CalculatingInvestmentClass
    {
        public CalculatingInvestmentClass() { }
        public void two(MainUserControl.UserData_Control userData_Control, 
            MainUserControl.TypeOfProductionControl typeOfProductionControl, 
            MainUserControl.CalculatingInvestmentControl calculatingInvestmentControl)
        {
            calculatingInvestmentControl.DataGridStanokB.Rows.Clear();
            calculatingInvestmentControl.DataGridStanokP.Rows.Clear();
            //Величину капитальных вложений в производственную площадь для размещения оборудования
            //и заполнение двух таблиц цен станков
            // Капитальные вложения в технологическое оборудование
            int Kdj = 2;//Коэффициент предусматривающий доп. площадь
            double At = 0.04;//Коэффициент, учитывающий транспортные расходы 
            double Am = 0.04;//Коэффициент, учитывающий затраты на монтаж оборудования
            double KzdB = 0, KzdP = 0, KobB = 0, KobP = 0;
            for (int i = 0; i < typeOfProductionControl.BaseDataGrid.RowCount - 1; i++)
            {
                KzdB += (Convert.ToDouble(typeOfProductionControl.BaseDataGrid.Rows[i].Cells[5].Value) * Convert.ToDouble(typeOfProductionControl.datagrid1_2_1.Rows[i].Cells[5].Value) * Kdj) + (Convert.ToDouble(typeOfProductionControl.BaseDataGrid.Rows[i].Cells[5].Value) / 2);
                calculatingInvestmentControl.DataGridStanokB.Rows.Add();
                calculatingInvestmentControl.DataGridStanokB.Rows[i].Cells[0].Value = typeOfProductionControl.BaseDataGrid.Rows[i].Cells[2].Value;
                calculatingInvestmentControl.DataGridStanokB.Rows[i].Cells[1].Value = userData_Control.BaseDataGrid.Rows[i].Cells[7].Value;
                KobB += (Convert.ToDouble(typeOfProductionControl.datagrid1_2_1.Rows[i].Cells[5].Value) * Convert.ToDouble(userData_Control.BaseDataGrid.Rows[i].Cells[7].Value)) * (1 + At + Am);
            }
            for (int i = 0; i < typeOfProductionControl.ProjectedDataGrid.RowCount - 1; i++)
            {
                KzdP += (Convert.ToDouble(typeOfProductionControl.ProjectedDataGrid.Rows[i].Cells[5].Value) * Convert.ToDouble(typeOfProductionControl.DataColMest1_3_2.Rows[i].Cells[5].Value) * Kdj) + (Convert.ToDouble(typeOfProductionControl.ProjectedDataGrid.Rows[i].Cells[5].Value) / 2);
                calculatingInvestmentControl.DataGridStanokP.Rows.Add();
                calculatingInvestmentControl.DataGridStanokP.Rows[i].Cells[0].Value = typeOfProductionControl.ProjectedDataGrid.Rows[i].Cells[2].Value;
                calculatingInvestmentControl.DataGridStanokP.Rows[i].Cells[1].Value = userData_Control.ProjectedDataGrid.Rows[i].Cells[7].Value;
                KobP += (Convert.ToDouble(typeOfProductionControl.datagrid1_2_2.Rows[i].Cells[5].Value) * Convert.ToDouble(userData_Control.ProjectedDataGrid.Rows[i].Cells[7].Value)) * (1 + At + Am);
            }
            calculatingInvestmentControl.KzdB.Text = Convert.ToString(Math.Round(KzdB * 16 * Convert.ToDouble(userData_Control.Dollar.Text), 4));
            calculatingInvestmentControl.KzdP.Text = Convert.ToString(Math.Round(KzdP * 16 * Convert.ToDouble(userData_Control.Dollar.Text), 4));
            calculatingInvestmentControl.KobB.Text = Convert.ToString(Math.Round(KobB, 4));
            calculatingInvestmentControl.KobP.Text = Convert.ToString(Math.Round(KobP, 4));
            //Стоимость транспортных средств
            calculatingInvestmentControl.Ktr.Text = Convert.ToString(Convert.ToDouble(userData_Control.DollarTS.Text) * Convert.ToDouble(userData_Control.KolTS.Text));
            // Капиталовложения в инструмент
            calculatingInvestmentControl.KinstB.Text = Convert.ToString(Math.Round(Convert.ToDouble(calculatingInvestmentControl.KobB.Text) * 0.01, 4));
            calculatingInvestmentControl.KinstP.Text = Convert.ToString(Math.Round(Convert.ToDouble(calculatingInvestmentControl.KobP.Text) * 0.01, 4));
            // Капиталовложения в производственный инвертарь
            calculatingInvestmentControl.KinvB.Text = Convert.ToString(Math.Round(Convert.ToDouble(calculatingInvestmentControl.KobB.Text) * 0.02, 4));
            calculatingInvestmentControl.KinvP.Text = Convert.ToString(Math.Round(Convert.ToDouble(calculatingInvestmentControl.KobP.Text) * 0.02, 4));
            // Величина капитальных вложений
            calculatingInvestmentControl.KofB.Text = Convert.ToString(Math.Round((Convert.ToDouble(calculatingInvestmentControl.KzdB.Text) + 
                Convert.ToDouble(calculatingInvestmentControl.KobB.Text) + Convert.ToDouble(calculatingInvestmentControl.Ktr.Text) + 
                Convert.ToDouble(calculatingInvestmentControl.KinstB.Text) + Convert.ToDouble(calculatingInvestmentControl.KinvB.Text))*
                Convert.ToDouble(typeOfProductionControl.KzanSumB.Text),4));
            calculatingInvestmentControl.KofP.Text = Convert.ToString(Math.Round((Convert.ToDouble(calculatingInvestmentControl.KzdP.Text) +
                Convert.ToDouble(calculatingInvestmentControl.KobP.Text) + Convert.ToDouble(calculatingInvestmentControl.Ktr.Text) +
                Convert.ToDouble(calculatingInvestmentControl.KinstP.Text) + Convert.ToDouble(calculatingInvestmentControl.KinvP.Text)) *
                Convert.ToDouble(typeOfProductionControl.KzanSumP.Text), 4));
            //Раздел 2,2
            //Стоимость основных материалов в расчете на одно изделие 
            double Ktz = 1.05;
            calculatingInvestmentControl.Zom.Text = Convert.ToString(Math.Round(Convert.ToDouble(typeOfProductionControl.NormTextbox.Text) * Convert.ToDouble(userData_Control.MaterialPrice.Text) * Ktz, 4));
            /*Стоимость вспомогательных материалов в расчете на одно изделие в двух
            вариантах технологического процесса(принимается в размере 1 % от стоимости
            основных материалов).*/
            calculatingInvestmentControl.Zvm.Text = Convert.ToString(Convert.ToDouble(calculatingInvestmentControl.Zom.Text) * 0.01);
            //Общуая сумма оборотных средств на годовую программу выпуска изделий
            calculatingInvestmentControl.Hoc.Text = Convert.ToString(Math.Round((Convert.ToDouble(calculatingInvestmentControl.Zom.Text) + 
                Convert.ToDouble(calculatingInvestmentControl.Zvm.Text)) * Convert.ToDouble(typeOfProductionControl.KolDetTextbox.Text), 4));
            // Размер инвестиций
            calculatingInvestmentControl.IB.Text = Convert.ToString(Math.Round(Convert.ToDouble(calculatingInvestmentControl.Hoc.Text) + Convert.ToDouble(calculatingInvestmentControl.KofB.Text), 4));
            calculatingInvestmentControl.IP.Text = Convert.ToString(Math.Round(Convert.ToDouble(calculatingInvestmentControl.Hoc.Text) + Convert.ToDouble(calculatingInvestmentControl.KofP.Text), 4));
            calculatingInvestmentControl.FinTable.Rows.Clear();
            string[] Stroka1 = { "1. Здания и сообружения, руб.", calculatingInvestmentControl.KzdB.Text, calculatingInvestmentControl.KzdP.Text };
            string[] Stroka2 = { "2. Рабочие машины и оборудование, руб.", calculatingInvestmentControl.KobB.Text, calculatingInvestmentControl.KobP.Text };
            string[] Stroka3 = { "3. Транспортные средства, руб.", calculatingInvestmentControl.Ktr.Text, calculatingInvestmentControl.Ktr.Text };
            string[] Stroka4 = { "4. Инструмент, руб.", calculatingInvestmentControl.KinstB.Text, calculatingInvestmentControl.KinstP.Text };
            string[] Stroka5 = { "5. Производственный инвентарь, руб.", calculatingInvestmentControl.KinvB.Text, calculatingInvestmentControl.KinvP.Text };
            addGridParam(Stroka1, calculatingInvestmentControl.FinTable);
            addGridParam(Stroka2, calculatingInvestmentControl.FinTable);
            addGridParam(Stroka3, calculatingInvestmentControl.FinTable);
            addGridParam(Stroka4, calculatingInvestmentControl.FinTable);
            addGridParam(Stroka5, calculatingInvestmentControl.FinTable);
            double sumOsnB = 0, sumOsnP = 0;
            for (int i=0;i<5;i++)
            {
                sumOsnB += Convert.ToDouble(calculatingInvestmentControl.FinTable.Rows[i].Cells[1].Value);
                sumOsnP += Convert.ToDouble(calculatingInvestmentControl.FinTable.Rows[i].Cells[2].Value);
            }
            string[] Stroka6 = { "6. Итого основных средств, руб.", Convert.ToString(sumOsnB), Convert.ToString(sumOsnP) };
            string[] Stroka7 = { "7. Стоимость основных средств с учетом коэффициента занятости, руб.", calculatingInvestmentControl.KofB.Text, calculatingInvestmentControl.KofP.Text };
            string[] Stroka8 = { "8. Оборотные средства, руб.", calculatingInvestmentControl.Hoc.Text, calculatingInvestmentControl.Hoc.Text };
            string[] Stroka9 = { "9. Инвестиции, руб.", calculatingInvestmentControl.IB.Text, calculatingInvestmentControl.IP.Text };
            addGridParam(Stroka6, calculatingInvestmentControl.FinTable);
            addGridParam(Stroka7, calculatingInvestmentControl.FinTable);
            addGridParam(Stroka8, calculatingInvestmentControl.FinTable);
            addGridParam(Stroka9, calculatingInvestmentControl.FinTable);






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
    }
}
