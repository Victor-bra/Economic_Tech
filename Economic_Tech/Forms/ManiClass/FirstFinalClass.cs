using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic_Tech.Forms.ManiClass
{
    public class FirstFinalClass
    {
        public FirstFinalClass() { }
        public void Final1(MainUserControl.UserData_Control userData_Control, MainUserControl.TypeOfProductionControl
            typeOfProductionControl, MainUserControl.CalculatingInvestmentControl calculatingInvestmentControl, MainUserControl.ProductCostControl productCostControl,
            MainUserControl.AdditionalDataControl additionalDataControl, MainUserControl.AnnualOutputControl annualOutputControl,
            MainUserControl.EfficiencyMarkControl efficiencyMarkControl, MainUserControl.FirstFinalControl firstFinalControl)
        {
            //Таблица 1
            firstFinalControl.DataGrid1.Rows.Clear();
            firstFinalControl.DataGrid1.Rows.Add(21);
            //заполнение первого столбца
            firstFinalControl.DataGrid1.Rows[0].Cells[0].Value = "1. Годовой объем выпуска продукции – в натуральном выражении, шт; ";
            firstFinalControl.DataGrid1.Rows[1].Cells[0].Value = "   – в стоимостном выражении по цене базового варианта, руб.";
            firstFinalControl.DataGrid1.Rows[2].Cells[0].Value = "2. Стоимость основных средств, руб.";
            firstFinalControl.DataGrid1.Rows[3].Cells[0].Value = "3. Трудоемкость изготовления единицы продукции, мин/шт.";
            firstFinalControl.DataGrid1.Rows[4].Cells[0].Value = "4. Амортизационные отчисления, руб.";
            firstFinalControl.DataGrid1.Rows[5].Cells[0].Value = "5. Численность работающих, чел.";
            firstFinalControl.DataGrid1.Rows[6].Cells[0].Value = "6. Себестоимость единицы продукции, руб.";
            firstFinalControl.DataGrid1.Rows[7].Cells[0].Value = "7. Материалоемкость, руб.";
            firstFinalControl.DataGrid1.Rows[8].Cells[0].Value = "8. Энергоемкость, руб.";
            firstFinalControl.DataGrid1.Rows[9].Cells[0].Value = "9. Фондоемкость, руб.";
            firstFinalControl.DataGrid1.Rows[10].Cells[0].Value = "10. Зарплатоемкость, руб.";
            firstFinalControl.DataGrid1.Rows[11].Cells[0].Value = "11. Прибыль остающаяся в роспоряжении предприятия, руб.";
            firstFinalControl.DataGrid1.Rows[12].Cells[0].Value = "12. Рентабильность, %";
            firstFinalControl.DataGrid1.Rows[13].Cells[0].Value = "13. Производительность труда, руб/чел.";
            firstFinalControl.DataGrid1.Rows[14].Cells[0].Value = "14. Фондоотдача, руб/на 1руб. фондов";
            firstFinalControl.DataGrid1.Rows[15].Cells[0].Value = "15. Эконмический эффект, руб.";
            firstFinalControl.DataGrid1.Rows[16].Cells[0].Value = "16. Период возврата инвестиция, лет.";
            firstFinalControl.DataGrid1.Rows[17].Cells[0].Value = "17. Динамические показатели эффективности: - чистая дисконтированная стоимость, руб.";
            firstFinalControl.DataGrid1.Rows[18].Cells[0].Value = "    - Индекс доходности";
            firstFinalControl.DataGrid1.Rows[19].Cells[0].Value = "    - Внутренняя норма рентабельности, %";
            firstFinalControl.DataGrid1.Rows[20].Cells[0].Value = "    - Срок окупаемости инвестиций";
            //заполнение второго/третьего столбца
            firstFinalControl.DataGrid1.Rows[0].Cells[1].Value = firstFinalControl.DataGrid1.Rows[0].Cells[2].Value = typeOfProductionControl.KolDetTextbox.Text;
            firstFinalControl.DataGrid1.Rows[1].Cells[1].Value = firstFinalControl.DataGrid1.Rows[1].Cells[2].Value = annualOutputControl.DataGrid3.Rows[3].Cells[1].Value;
            firstFinalControl.DataGrid1.Rows[2].Cells[1].Value = calculatingInvestmentControl.KobB.Text;
            firstFinalControl.DataGrid1.Rows[2].Cells[2].Value = calculatingInvestmentControl.KobP.Text;
            firstFinalControl.DataGrid1.Rows[3].Cells[1].Value = typeOfProductionControl.TsumB.Text;
            firstFinalControl.DataGrid1.Rows[3].Cells[2].Value = typeOfProductionControl.TsumP.Text;
            firstFinalControl.DataGrid1.Rows[4].Cells[1].Value = productCostControl.Abaz.Text;
            firstFinalControl.DataGrid1.Rows[4].Cells[2].Value = productCostControl.Apr.Text;
            //Кол. вспомог. рабочих
            double nb = Math.Round(Convert.ToDouble(typeOfProductionControl.WsumBpri.Text) * 0.25, 4);
            double np = Math.Round(Convert.ToDouble(typeOfProductionControl.WsumPpri.Text) * 0.25, 4);
            firstFinalControl.DataGrid1.Rows[5].Cells[1].Value = Convert.ToInt32(typeOfProductionControl.WsumBpri.Text) + Convert.ToInt32(nb);
            firstFinalControl.DataGrid1.Rows[5].Cells[2].Value = Convert.ToInt32(typeOfProductionControl.WsumPpri.Text) + Convert.ToInt32(nb);
            firstFinalControl.DataGrid1.Rows[6].Cells[1].Value = productCostControl.FinalDataGrid.Rows[11].Cells[1].Value;
            firstFinalControl.DataGrid1.Rows[6].Cells[2].Value = productCostControl.FinalDataGrid.Rows[11].Cells[3].Value;
            firstFinalControl.DataGrid1.Rows[7].Cells[1].Value = efficiencyMarkControl.MmB.Text;
            firstFinalControl.DataGrid1.Rows[7].Cells[2].Value = efficiencyMarkControl.MmP.Text;
            firstFinalControl.DataGrid1.Rows[8].Cells[1].Value = efficiencyMarkControl.MieB.Text;
            firstFinalControl.DataGrid1.Rows[8].Cells[2].Value = efficiencyMarkControl.MieP.Text;
            firstFinalControl.DataGrid1.Rows[9].Cells[1].Value = efficiencyMarkControl.MeB.Text;
            firstFinalControl.DataGrid1.Rows[9].Cells[2].Value = efficiencyMarkControl.MeP.Text;
            firstFinalControl.DataGrid1.Rows[10].Cells[1].Value = efficiencyMarkControl.MzB.Text;
            firstFinalControl.DataGrid1.Rows[10].Cells[2].Value = efficiencyMarkControl.MzP.Text;
            firstFinalControl.DataGrid1.Rows[11].Cells[1].Value = annualOutputControl.DataGrid2.Rows[0].Cells[1].Value;
            firstFinalControl.DataGrid1.Rows[11].Cells[2].Value = annualOutputControl.DataGrid3.Rows[7].Cells[1].Value;
            firstFinalControl.DataGrid1.Rows[12].Cells[1].Value = 10;
            firstFinalControl.DataGrid1.Rows[12].Cells[2].Value = efficiencyMarkControl.R.Text;
            firstFinalControl.DataGrid1.Rows[13].Cells[1].Value = efficiencyMarkControl.PtB.Text;
            firstFinalControl.DataGrid1.Rows[13].Cells[2].Value = efficiencyMarkControl.PtP.Text;
            firstFinalControl.DataGrid1.Rows[14].Cells[1].Value = efficiencyMarkControl.FoB.Text;
            firstFinalControl.DataGrid1.Rows[14].Cells[2].Value = efficiencyMarkControl.FoP.Text;
            firstFinalControl.DataGrid1.Rows[15].Cells[1].Value = efficiencyMarkControl.IE.Text;
            firstFinalControl.DataGrid1.Rows[15].Cells[2].Value = efficiencyMarkControl.IE.Text;
            firstFinalControl.DataGrid1.Rows[16].Cells[1].Value = efficiencyMarkControl.TB.Text;
            firstFinalControl.DataGrid1.Rows[16].Cells[2].Value = efficiencyMarkControl.TP.Text;
            firstFinalControl.DataGrid1.Rows[17].Cells[1].Value = efficiencyMarkControl.Chds.Text;
            firstFinalControl.DataGrid1.Rows[17].Cells[2].Value = efficiencyMarkControl.Chds.Text;
            firstFinalControl.DataGrid1.Rows[18].Cells[1].Value = efficiencyMarkControl.RI.Text;
            firstFinalControl.DataGrid1.Rows[18].Cells[2].Value = efficiencyMarkControl.RI.Text;
            if (Convert.ToDouble(efficiencyMarkControl.fin.Text) == -1 || Convert.ToDouble(efficiencyMarkControl.fin.Text) == -2)
            {
                firstFinalControl.DataGrid1.Rows[19].Cells[1].Value = "-";
                firstFinalControl.DataGrid1.Rows[19].Cells[2].Value = "-";
            }
            else
            {
                firstFinalControl.DataGrid1.Rows[19].Cells[1].Value = Convert.ToDouble(efficiencyMarkControl.fin.Text) * 100;
                firstFinalControl.DataGrid1.Rows[19].Cells[2].Value = Convert.ToDouble(efficiencyMarkControl.fin.Text) * 100;
            }
            if (Convert.ToDouble(efficiencyMarkControl.TD.Text) != 0)
            {
                firstFinalControl.DataGrid1.Rows[20].Cells[1].Value = efficiencyMarkControl.TD.Text;
                firstFinalControl.DataGrid1.Rows[20].Cells[2].Value = efficiencyMarkControl.TD.Text;
            }
            else
            {
                firstFinalControl.DataGrid1.Rows[20].Cells[1].Value = "-";
                firstFinalControl.DataGrid1.Rows[20].Cells[2].Value = "-";
            }


        }
    }
}
