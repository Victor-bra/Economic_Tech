using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economic_Tech.Forms.ManiClass
{
    public class EfficiencyMarkClass
    {
        public EfficiencyMarkClass() { }
        public void EfficiencyMark(MainUserControl.UserData_Control userData_Control, MainUserControl.TypeOfProductionControl
            typeOfProductionControl, MainUserControl.CalculatingInvestmentControl calculatingInvestmentControl, MainUserControl.ProductCostControl productCostControl,
            MainUserControl.AdditionalDataControl additionalDataControl, MainUserControl.AnnualOutputControl annualOutputControl,
            MainUserControl.EfficiencyMarkControl efficiencyMarkControl,MainUserControl.FirstFinalControl firstFinalControl)
        {
            double MZB = Convert.ToDouble(calculatingInvestmentControl.Hoc.Text) + Convert.ToDouble(productCostControl.CelB.Text) +
                Convert.ToDouble(productCostControl.CCvB.Text) + Convert.ToDouble(productCostControl.Cpp.Text) +
                Convert.ToDouble(productCostControl.CocB.Text) + Convert.ToDouble(productCostControl.CpoB.Text);
            double MZP = Convert.ToDouble(calculatingInvestmentControl.Hoc.Text) + Convert.ToDouble(productCostControl.CelP.Text) +
                Convert.ToDouble(productCostControl.CCvP.Text) + Convert.ToDouble(productCostControl.Cpp.Text) +
                Convert.ToDouble(productCostControl.CocP.Text) + Convert.ToDouble(productCostControl.CpoP.Text);
            //паказатель материалоемкости
            double Q = Convert.ToDouble(annualOutputControl.DataGrid3.Rows[3].Cells[1].Value);
            double MmB = Math.Round(MZB / Q, 4);
            double MmP = Math.Round(MZP / Q, 4);
            efficiencyMarkControl.MmB.Text = Convert.ToString(MmB);
            efficiencyMarkControl.MmP.Text = Convert.ToString(MmP);
            double MieB = Math.Round((Convert.ToDouble(productCostControl.CelB.Text) + Convert.ToDouble(productCostControl.CocB.Text)) / Q, 4);
            double MieP = Math.Round((Convert.ToDouble(productCostControl.CelP.Text) + Convert.ToDouble(productCostControl.CocP.Text)) / Q, 4);
            efficiencyMarkControl.MieB.Text = Convert.ToString(MieB);
            efficiencyMarkControl.MieP.Text = Convert.ToString(MieP);
            double MeB = Math.Round(Convert.ToDouble(calculatingInvestmentControl.KofB.Text) / Q, 4);
            double MeP = Math.Round(Convert.ToDouble(calculatingInvestmentControl.KofP.Text) / Q, 4);
            efficiencyMarkControl.MeB.Text = Convert.ToString(MeB);
            efficiencyMarkControl.MeP.Text = Convert.ToString(MeP);
            double MzB = Math.Round((Convert.ToDouble(productCostControl.FZP_B.Text) + Convert.ToDouble(productCostControl.FZPvB.Text) + Convert.ToDouble(productCostControl.ZyprB.Text)) / Q, 4);
            double MzP = Math.Round((Convert.ToDouble(productCostControl.FZP_P.Text) + Convert.ToDouble(productCostControl.FZPvP.Text) + Convert.ToDouble(productCostControl.ZyprP.Text)) / Q, 4);
            efficiencyMarkControl.MzB.Text = Convert.ToString(MzB);
            efficiencyMarkControl.MzP.Text = Convert.ToString(MzP);
            //Таблица 1
            efficiencyMarkControl.DataGrid1.Rows.Clear();
            efficiencyMarkControl.DataGrid1.Rows.Add(18);
            //заполнение первого столбца
            efficiencyMarkControl.DataGrid1.Rows[0].Cells[0].Value = "1. Материальные затраты, в том числе сырье и материалы, руб.";
            efficiencyMarkControl.DataGrid1.Rows[1].Cells[0].Value = "   - годовые затраты на силовую электроэнергию, руб.";
            efficiencyMarkControl.DataGrid1.Rows[2].Cells[0].Value = "   - затраты на сжатый воздух, руб.";
            efficiencyMarkControl.DataGrid1.Rows[3].Cells[0].Value = "   - затраты на пар для производственных нужд, руб.";
            efficiencyMarkControl.DataGrid1.Rows[4].Cells[0].Value = "   - затраты на электроэнергию для освещения здания, руб.";
            efficiencyMarkControl.DataGrid1.Rows[5].Cells[0].Value = "   - затраты на пар для отопления здания, руб.";
            efficiencyMarkControl.DataGrid1.Rows[6].Cells[0].Value = "2. Материалоёмкость, руб/руб.";
            efficiencyMarkControl.DataGrid1.Rows[7].Cells[0].Value = "3. Затраты на энергию:";
            efficiencyMarkControl.DataGrid1.Rows[8].Cells[0].Value = "   - в том числе годовые затраты на силовую электроэнергию";
            efficiencyMarkControl.DataGrid1.Rows[9].Cells[0].Value = "   - затраты на электроэнергию для освещения зданий";
            efficiencyMarkControl.DataGrid1.Rows[10].Cells[0].Value = "4. Энергоёмкость, руб/руб.";
            efficiencyMarkControl.DataGrid1.Rows[11].Cells[0].Value = "5. Стоимость основных средств предприятия с учетом коэффициента занятости, руб.";
            efficiencyMarkControl.DataGrid1.Rows[12].Cells[0].Value = "6. Фондоёмкость, руб/руб.";
            efficiencyMarkControl.DataGrid1.Rows[13].Cells[0].Value = "7. Фонд зароботной платы работников";
            efficiencyMarkControl.DataGrid1.Rows[14].Cells[0].Value = "в том числе фонд оплаты труда рабочих, занятых на технологических операциях, руб";
            efficiencyMarkControl.DataGrid1.Rows[15].Cells[0].Value = "   - фонд заработной платы вспомогательных рабочих, руб.";
            efficiencyMarkControl.DataGrid1.Rows[16].Cells[0].Value = "   - фонд заработной платы ИТР, служащий и МОП, руб.";
            efficiencyMarkControl.DataGrid1.Rows[17].Cells[0].Value = "8. Зарплатоёмкость, руб/руб.";
            //продолжение заполнения
            efficiencyMarkControl.DataGrid1.Rows[0].Cells[1].Value = MZB;
            efficiencyMarkControl.DataGrid1.Rows[0].Cells[2].Value = MZP;
            efficiencyMarkControl.DataGrid1.Rows[1].Cells[1].Value = productCostControl.CelB.Text;
            efficiencyMarkControl.DataGrid1.Rows[1].Cells[2].Value = productCostControl.CelP.Text;
            efficiencyMarkControl.DataGrid1.Rows[2].Cells[1].Value = productCostControl.CCvB.Text;
            efficiencyMarkControl.DataGrid1.Rows[2].Cells[2].Value = productCostControl.CCvP.Text;
            efficiencyMarkControl.DataGrid1.Rows[3].Cells[1].Value = productCostControl.Cpp.Text;
            efficiencyMarkControl.DataGrid1.Rows[3].Cells[2].Value = productCostControl.Cpp.Text;
            efficiencyMarkControl.DataGrid1.Rows[4].Cells[1].Value = productCostControl.CocB.Text;
            efficiencyMarkControl.DataGrid1.Rows[4].Cells[2].Value = productCostControl.CocP.Text;
            efficiencyMarkControl.DataGrid1.Rows[5].Cells[1].Value = productCostControl.CpoB.Text;
            efficiencyMarkControl.DataGrid1.Rows[5].Cells[2].Value = productCostControl.CpoP.Text;
            efficiencyMarkControl.DataGrid1.Rows[6].Cells[1].Value = MmB;
            efficiencyMarkControl.DataGrid1.Rows[6].Cells[2].Value = MmP;
            efficiencyMarkControl.DataGrid1.Rows[8].Cells[1].Value = efficiencyMarkControl.DataGrid1.Rows[1].Cells[1].Value;
            efficiencyMarkControl.DataGrid1.Rows[8].Cells[2].Value = efficiencyMarkControl.DataGrid1.Rows[1].Cells[2].Value;
            efficiencyMarkControl.DataGrid1.Rows[9].Cells[1].Value = efficiencyMarkControl.DataGrid1.Rows[4].Cells[1].Value;
            efficiencyMarkControl.DataGrid1.Rows[9].Cells[2].Value = efficiencyMarkControl.DataGrid1.Rows[4].Cells[2].Value;
            efficiencyMarkControl.DataGrid1.Rows[7].Cells[1].Value = Convert.ToDouble(efficiencyMarkControl.DataGrid1.Rows[1].Cells[1].Value) + Convert.ToDouble(efficiencyMarkControl.DataGrid1.Rows[4].Cells[1].Value);
            efficiencyMarkControl.DataGrid1.Rows[7].Cells[2].Value = Convert.ToDouble(efficiencyMarkControl.DataGrid1.Rows[1].Cells[2].Value) + Convert.ToDouble(efficiencyMarkControl.DataGrid1.Rows[4].Cells[2].Value);
            efficiencyMarkControl.DataGrid1.Rows[10].Cells[1].Value = MieB;
            efficiencyMarkControl.DataGrid1.Rows[10].Cells[2].Value = MieP;
            efficiencyMarkControl.DataGrid1.Rows[11].Cells[1].Value = calculatingInvestmentControl.KofB.Text;
            efficiencyMarkControl.DataGrid1.Rows[11].Cells[2].Value = calculatingInvestmentControl.KofP.Text;
            efficiencyMarkControl.DataGrid1.Rows[12].Cells[1].Value = MeB;
            efficiencyMarkControl.DataGrid1.Rows[12].Cells[2].Value = MeP;
            efficiencyMarkControl.DataGrid1.Rows[13].Cells[1].Value = (Convert.ToDouble(productCostControl.FZP_B.Text) + Convert.ToDouble(productCostControl.FZPvB.Text) + Convert.ToDouble(productCostControl.ZyprB.Text));
            efficiencyMarkControl.DataGrid1.Rows[13].Cells[2].Value = (Convert.ToDouble(productCostControl.FZP_P.Text) + Convert.ToDouble(productCostControl.FZPvP.Text) + Convert.ToDouble(productCostControl.ZyprP.Text));
            efficiencyMarkControl.DataGrid1.Rows[14].Cells[1].Value = productCostControl.FZP_B.Text;
            efficiencyMarkControl.DataGrid1.Rows[14].Cells[2].Value = productCostControl.FZP_P.Text;
            efficiencyMarkControl.DataGrid1.Rows[15].Cells[1].Value = productCostControl.FZPvB.Text;
            efficiencyMarkControl.DataGrid1.Rows[15].Cells[2].Value = productCostControl.FZPvP.Text;
            efficiencyMarkControl.DataGrid1.Rows[16].Cells[1].Value = productCostControl.ZyprB.Text;
            efficiencyMarkControl.DataGrid1.Rows[16].Cells[2].Value = productCostControl.ZyprP.Text;
            efficiencyMarkControl.DataGrid1.Rows[17].Cells[1].Value = MzB;
            efficiencyMarkControl.DataGrid1.Rows[17].Cells[2].Value = MzP;
            double R = (Convert.ToDouble(annualOutputControl.DataGrid3.Rows[7].Cells[1].Value) / Convert.ToDouble(annualOutputControl.DataGrid1.Rows[1].Cells[2].Value)) * 100;
            efficiencyMarkControl.R.Text = Convert.ToString(Math.Round(R, 4));
            double IE = Convert.ToDouble(annualOutputControl.DataGrid3.Rows[7].Cells[1].Value) - 0.1 * Convert.ToDouble(annualOutputControl.DataGrid1.Rows[1].Cells[2].Value);
            efficiencyMarkControl.IE.Text = Convert.ToString(Math.Round(IE, 4));
            double TB = Convert.ToDouble(annualOutputControl.DataGrid1.Rows[1].Cells[1].Value) / Convert.ToDouble(annualOutputControl.DataGrid2.Rows[0].Cells[1].Value);
            double TP = Convert.ToDouble(annualOutputControl.DataGrid1.Rows[1].Cells[2].Value) / Convert.ToDouble(annualOutputControl.DataGrid3.Rows[7].Cells[1].Value);
            efficiencyMarkControl.TB.Text = Convert.ToString(Math.Round(TB, 1));
            efficiencyMarkControl.TP.Text = Convert.ToString(Math.Round(TP, 1));
            double PtB = Q / 10;
            double PtP = Q / 10;
            efficiencyMarkControl.PtB.Text = Convert.ToString(PtB);
            efficiencyMarkControl.PtP.Text = Convert.ToString(PtP);
            double FoB = Math.Round(Q / Convert.ToDouble(calculatingInvestmentControl.KofB.Text), 4);
            double FoP = Math.Round(Q / Convert.ToDouble(calculatingInvestmentControl.KofP.Text), 4);
            efficiencyMarkControl.FoB.Text = Convert.ToString(FoB);
            efficiencyMarkControl.FoP.Text = Convert.ToString(FoP);
            //Раздел 5.2
            //ЧДС
            double I = Convert.ToDouble(annualOutputControl.DataGrid1.Rows[1].Cells[2].Value);
            double Pch = Convert.ToDouble(annualOutputControl.DataGrid3.Rows[7].Cells[1].Value);
            double ss = 0;
            double ND = Convert.ToDouble(additionalDataControl.ND.Text);
            for (int i = 0; i < 10; i++)
                ss += Pch / Math.Pow((1 + ND), i + 1);
            double Chds = -I + ss;
            efficiencyMarkControl.Chds.Text = Convert.ToString(Math.Round(Chds, 4));
            double RI = ss / I;
            efficiencyMarkControl.RI.Text = Convert.ToString(Math.Round(RI, 4));
            //Построение графика
            var canvas = new Bunifu.DataViz.WinForms.Canvas();
            var datapoint = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_spline);
            double[] nums = new double[10];
            int[] zz = new int[10];
            double ndl = 0;
            CalculatingClass calculatingClass = new CalculatingClass();
            for (int i = 0; i < 10; i++)
            {
                nums[i] = ndl;
                ndl += 0.05;
                zz[i] = Convert.ToInt32(Math.Round(calculatingClass.CHDS(nums[i], annualOutputControl), 0));
            }
            for (int i = 0; i < 10; i++)
            {
                datapoint.addLabely(Convert.ToString(nums[i]), Convert.ToString(zz[i]));
            }
            // Add data sets to canvas
            canvas.addData(datapoint);
            //render canvas
            efficiencyMarkControl.bunifuDataViz1.Render(canvas);
            /*zz[0] = 5;
            zz[1] = 30;
            nums[0] = 0;
            nums[1] = 10;*/
            //пересечение графика в ОХ 
            double fin = calculatingClass.OX1(zz, nums);
            int znach = calculatingClass.OX2(zz, nums);
            double TD = 0;
            if (fin == -1 && znach == -1)
            {
                efficiencyMarkControl.bunifuLabel32.Text = "Определение внутренней нормы рентабельности невозможно, так как график не пересекает ось ОХ и находится в 4-ой " +
                    "координатной четверти. Значит проект не стоит принимать, так как вне зависимости от нормы рентабельности он будет в убытке.";
                //MessageBox.Show("нижний без пересечения");
                efficiencyMarkControl.bunifuLabel34.Text = "Расчет динамического срока окупаемости производить не нужно, так как проек никогда не окупится и будет убыточным";
                firstFinalControl.bunifuLabel33.Text = "По результатам выполнения рассчетов видно, что проектируемый проект сильно отличается от базового.В проектируемом технологическом " +
                    "нет возможности определить норму рентабельности, график не пересекает ось ОХ и проектируемый технологический процесс не сможет окубиться за 10 лет." +
                    "Следовательно проектируеммый технологический процесс не следует принимать, так как предприятие понесет большие убытки!!!";
                firstFinalControl.bunifuLabel2.Text = "Проектируемый технологический процесс не следует принимать.";
            }
            if (znach == 1)
            {
                efficiencyMarkControl.bunifuLabel32.Text = "Определяется внутренняя норма рентабельности, которая будет равна  значению нормы дисконта в точке пересечения прямой с осью абсцисс. По " +
                    "расчетам было получено, что внутренняя норма рентабельности составила " + fin + " то есть " + fin * 100 + "%.";
                ///MessageBox.Show("нижний c пересечения");
                int h = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (zz[i] < 0)
                    {
                        h = 10 - i + 1;
                        break;
                    }
                }
                TD = (h - 1) - (calculatingClass.TD(h - 1, ND, annualOutputControl) / (calculatingClass.TD(h, ND, annualOutputControl) - calculatingClass.TD(h - 1, ND, annualOutputControl)));
                efficiencyMarkControl.bunifuLabel34.Text = "Динамический срок окупаемости инвестиций - " + Math.Round(TD, 2) + " года";
                firstFinalControl.bunifuLabel33.Text = "По результатам выполнения рассчетов видно, что проектируемый проект незначительно отличается от базового." +
                    "В проектируемом технологическом процессе снизилась стоимость основных средств, за счёт введения нового технологического оборудования, что за" +
                    "что за собой повлекло уменьшение амортизационных отчислений и уменьшение себестоимости единицы продукции и уменьшение трудоемкости изготовления единицы " +
                    "продукции. Уменьшение себестоимости единицы продукции увеличило чистую прибыль.Расчет динамических показателей эффективности показал, что при " +
                    "внедрении проектируемого технологического процесса в производство, предприятие не понесет убытки и окупится менее чем за десять лет. " +
                    "Следовательно, данный проект принимаем, т.к.он является эффективным.";
                firstFinalControl.bunifuLabel2.Text = "Проектируемый технологический процесс стоить принять.";
            }

            if (fin == -2 && znach == -2)
            {
                efficiencyMarkControl.bunifuLabel32.Text = "Определение внутренней нормы рентабельности невозможно, так как график не пересекает ось ОХ и находится в 1-ой " +
                    "координатной четверти. Значит проект следует принять, так как он не зависит от нормы рентабельности и всегда будет прибыльным.";
                //MessageBox.Show("верхний без пересечения");
                efficiencyMarkControl.bunifuLabel34.Text = "Расчет динамического срока окупаемости производить не нужно, так как проек со старта будет прибыльным";
                firstFinalControl.bunifuLabel33.Text = "По результатам выполнения рассчетов видно, что проектируемый проект сильно отличается от базового.В проектируемом технологическом " +
                    "нет возможности определить норму рентабельности, график не пересекает ось ОХ но проектируемый технологический процесс вне зависимости от нормы рентабельности будет всегда положителен." +
                    "Следовательно проектируеммый технологический процесс нужно принимать, так как предприятие от этого получает только прибыли и никаких затрат!!!";
                firstFinalControl.bunifuLabel2.Text = "Проектируемый технологический процесс стоит принять, т.к убытки нулевые.";
            }
            if (znach == 2)
            {
                efficiencyMarkControl.bunifuLabel32.Text = "Определяется внутренняя норма рентабельности, которая будет равна  значению нормы дисконта в точке пересечения прямой с осью абсцисс. По " +
                    "расчетам было получено, что внутренняя норма рентабельности составила " + fin + " то есть " + fin * 100 + "%.";
                //MessageBox.Show("верхний с пересечения");
                int h = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (zz[i] < 0)
                    {
                        h = i + 1;
                        break;
                    }
                }
                TD = (h - 1) - (calculatingClass.TD(h - 1, ND, annualOutputControl) / (calculatingClass.TD(h, ND, annualOutputControl) - calculatingClass.TD(h - 1, ND, annualOutputControl)));
                efficiencyMarkControl.bunifuLabel34.Text = "Динамический срок окупаемости инвестиций - " + Math.Round(TD, 2) + " года";
                firstFinalControl.bunifuLabel33.Text = "По результатам выполнения рассчетов видно, что проектируемый проект незначительно отличается от базового." +
                    "В проектируемом технологическом процессе снизилась стоимость основных средств, за счёт введения нового технологического оборудования, что за" +
                    "что за собой повлекло уменьшение амортизационных отчислений и уменьшение себестоимости единицы продукции и уменьшение трудоемкости изготовления единицы " +
                    "продукции. Уменьшение себестоимости единицы продукции увеличило чистую прибыль.Расчет динамических показателей эффективности показал, что при " +
                    "внедрении проектируемого технологического процесса в производство, предприятие не понесет убытки и окупится менее чем за десять лет. " +
                    "Следовательно, данный проект принимаем, т.к.он является эффективным.";
                firstFinalControl.bunifuLabel2.Text = "Проектируемый технологический процесс стоит принять.";
            }
            efficiencyMarkControl.fin.Text = Convert.ToString(fin);
            efficiencyMarkControl.TD.Text = Convert.ToString(Math.Round(TD, 2));
        }

    }
}
