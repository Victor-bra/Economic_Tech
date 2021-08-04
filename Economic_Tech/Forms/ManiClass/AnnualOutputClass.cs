using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;

namespace Economic_Tech.Forms.ManiClass
{
    public class AnnualOutputClass
    {
        public AnnualOutputClass() { }
        public void product(MainUserControl.UserData_Control userData_Control, MainUserControl.TypeOfProductionControl
            typeOfProductionControl, MainUserControl.CalculatingInvestmentControl calculatingInvestmentControl, MainUserControl.ProductCostControl productCostControl,
            MainUserControl.AdditionalDataControl additionalDataControl, MainUserControl.AnnualOutputControl annualOutputControl)
        {
            //Таблица 1
            annualOutputControl.DataGrid1.Rows.Clear();
            annualOutputControl.DataGrid1.Rows.Add(8);
            //заполнение первого столбца
            annualOutputControl.DataGrid1.Rows[0].Cells[0].Value = "1. Объем производства в натуральном выражении, шт.";
            annualOutputControl.DataGrid1.Rows[1].Cells[0].Value = "2. Велечина инвестиций, руб.";
            annualOutputControl.DataGrid1.Rows[2].Cells[0].Value = "3. Стоимость основных средств с учетом коэффициента занятости, руб.";
            annualOutputControl.DataGrid1.Rows[3].Cells[0].Value = "4. Цеховая себестоимость, руб.";
            annualOutputControl.DataGrid1.Rows[4].Cells[0].Value = "5. Реальная рентабельность предприятия по чистой прибыли в базовом варианте, %";
            annualOutputControl.DataGrid1.Rows[5].Cells[0].Value = "6. Ставка налога на недвижимость, %";
            annualOutputControl.DataGrid1.Rows[6].Cells[0].Value = "7. Ставка налога на добавочную стоимость, %";
            annualOutputControl.DataGrid1.Rows[7].Cells[0].Value = "8. Ставка налога на прибыль, %";
            //продолжение заполнения
            annualOutputControl.DataGrid1.Rows[0].Cells[1].Value = annualOutputControl.DataGrid1.Rows[0].Cells[2].Value = typeOfProductionControl.KolDetTextbox.Text;
            annualOutputControl.DataGrid1.Rows[1].Cells[1].Value = calculatingInvestmentControl.IB.Text;
            annualOutputControl.DataGrid1.Rows[1].Cells[2].Value = calculatingInvestmentControl.IP.Text;
            annualOutputControl.DataGrid1.Rows[2].Cells[1].Value = calculatingInvestmentControl.KofB.Text;
            annualOutputControl.DataGrid1.Rows[2].Cells[2].Value = calculatingInvestmentControl.KofP.Text;
            annualOutputControl.DataGrid1.Rows[3].Cells[1].Value = productCostControl.FinalDataGrid.Rows[11].Cells[2].Value;
            annualOutputControl.DataGrid1.Rows[3].Cells[2].Value = productCostControl.FinalDataGrid.Rows[11].Cells[4].Value;
            annualOutputControl.DataGrid1.Rows[4].Cells[1].Value = annualOutputControl.DataGrid1.Rows[4].Cells[2].Value = 10;
            annualOutputControl.DataGrid1.Rows[5].Cells[1].Value = annualOutputControl.DataGrid1.Rows[5].Cells[2].Value = 1;
            annualOutputControl.DataGrid1.Rows[6].Cells[1].Value = annualOutputControl.DataGrid1.Rows[6].Cells[2].Value = 20;
            annualOutputControl.DataGrid1.Rows[7].Cells[1].Value = annualOutputControl.DataGrid1.Rows[7].Cells[2].Value = 18;
            //Таблица 2
            annualOutputControl.DataGrid2.Rows.Clear();
            annualOutputControl.DataGrid2.Rows.Add(8);
            //заполнение первого столбца
            annualOutputControl.DataGrid2.Rows[0].Cells[0].Value = "1. Чистая прибыль";
            annualOutputControl.DataGrid2.Rows[1].Cells[0].Value = "2. Прибыль налогооблагаемая";
            annualOutputControl.DataGrid2.Rows[2].Cells[0].Value = "3. Налог на прибыль";
            annualOutputControl.DataGrid2.Rows[3].Cells[0].Value = "4. Прибыдь балансовая";
            annualOutputControl.DataGrid2.Rows[4].Cells[0].Value = "5. Объем выпуска продукции в оптовых ценах";
            annualOutputControl.DataGrid2.Rows[5].Cells[0].Value = "6. Объем выпуска продукции в отпускных ценах с НДС";
            annualOutputControl.DataGrid2.Rows[6].Cells[0].Value = "7. Свободная отпускная цена единицы продукции без НДС";
            annualOutputControl.DataGrid2.Rows[7].Cells[0].Value = "8. Свободная отпускная цена единицы продукции с НДС";
            //продолжение заполнения
            annualOutputControl.DataGrid2.Rows[0].Cells[1].Value = Math.Round(0.1 * Convert.ToDouble(calculatingInvestmentControl.IB.Text),4);
            annualOutputControl.DataGrid2.Rows[1].Cells[1].Value = Math.Round(Convert.ToDouble(annualOutputControl.DataGrid2.Rows[0].Cells[1].Value) / (1 - 0.18));
            annualOutputControl.DataGrid2.Rows[2].Cells[1].Value = Math.Round(Convert.ToDouble(annualOutputControl.DataGrid2.Rows[1].Cells[1].Value) * 0.18, 4);
            annualOutputControl.DataGrid2.Rows[3].Cells[1].Value = Convert.ToDouble(annualOutputControl.DataGrid2.Rows[0].Cells[1].Value) + Convert.ToDouble(annualOutputControl.DataGrid2.Rows[2].Cells[1].Value);
            annualOutputControl.DataGrid2.Rows[4].Cells[1].Value = Convert.ToDouble(annualOutputControl.DataGrid1.Rows[3].Cells[1].Value) + Convert.ToDouble(annualOutputControl.DataGrid2.Rows[3].Cells[1].Value);
            double QB = Convert.ToDouble(annualOutputControl.DataGrid2.Rows[4].Cells[1].Value);
            annualOutputControl.DataGrid2.Rows[5].Cells[1].Value = Math.Round(QB + (QB * 0.2), 4);
            double QndsB = Convert.ToDouble(annualOutputControl.DataGrid2.Rows[5].Cells[1].Value);
            annualOutputControl.DataGrid2.Rows[6].Cells[1].Value = Math.Round(QB / Convert.ToDouble(typeOfProductionControl.KolDetTextbox.Text), 4);
            annualOutputControl.DataGrid2.Rows[7].Cells[1].Value = Math.Round(QndsB / Convert.ToDouble(typeOfProductionControl.KolDetTextbox.Text), 4);
            //Таблица 3
            annualOutputControl.DataGrid3.Rows.Clear();
            annualOutputControl.DataGrid3.Rows.Add(8);
            //заполнение первого столбца
            annualOutputControl.DataGrid3.Rows[0].Cells[0].Value = "1. Свободная отпускная цена единицы продукции с НДС";
            annualOutputControl.DataGrid3.Rows[1].Cells[0].Value = "2. Свободная отпускная цена единицы продукции без НДС";
            annualOutputControl.DataGrid3.Rows[2].Cells[0].Value = "3. Объем выпуска продукции в отпускных ценах с НДС";
            annualOutputControl.DataGrid3.Rows[3].Cells[0].Value = "4. Объем выпуска продукции в оптовых ценах";
            annualOutputControl.DataGrid3.Rows[4].Cells[0].Value = "5. Прибыдь балансовая";
            annualOutputControl.DataGrid3.Rows[5].Cells[0].Value = "6. Прибыль налогооблагаемая";
            annualOutputControl.DataGrid3.Rows[6].Cells[0].Value = "7. Налог на прибыль";
            annualOutputControl.DataGrid3.Rows[7].Cells[0].Value = "8. Чистая прибыль";
            // продолжение заполнения
            annualOutputControl.DataGrid3.Rows[0].Cells[1].Value = annualOutputControl.DataGrid2.Rows[7].Cells[1].Value;
            annualOutputControl.DataGrid3.Rows[1].Cells[1].Value = annualOutputControl.DataGrid2.Rows[6].Cells[1].Value;
            annualOutputControl.DataGrid3.Rows[2].Cells[1].Value = annualOutputControl.DataGrid2.Rows[5].Cells[1].Value;
            annualOutputControl.DataGrid3.Rows[3].Cells[1].Value = annualOutputControl.DataGrid2.Rows[4].Cells[1].Value;
            annualOutputControl.DataGrid3.Rows[4].Cells[1].Value = Convert.ToDouble(annualOutputControl.DataGrid3.Rows[3].Cells[1].Value) - Convert.ToDouble(annualOutputControl.DataGrid1.Rows[3].Cells[2].Value);
            annualOutputControl.DataGrid3.Rows[5].Cells[1].Value = annualOutputControl.DataGrid3.Rows[4].Cells[1].Value;
            annualOutputControl.DataGrid3.Rows[6].Cells[1].Value = Math.Round(Convert.ToDouble(annualOutputControl.DataGrid3.Rows[5].Cells[1].Value) * 0.18, 4);
            annualOutputControl.DataGrid3.Rows[7].Cells[1].Value = Convert.ToDouble(annualOutputControl.DataGrid3.Rows[5].Cells[1].Value) - Convert.ToDouble(annualOutputControl.DataGrid3.Rows[6].Cells[1].Value);
        }

    }
}
