using Economic_Tech.Forms.MainUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economic_Tech.Forms.ManiClass
{
    public class ProductCostClass
    {
        public ProductCostClass() { }
        public void productCost(MainUserControl.UserData_Control userData_Control, MainUserControl.TypeOfProductionControl 
            typeOfProductionControl, MainUserControl.CalculatingInvestmentControl calculatingInvestmentControl, MainUserControl.ProductCostControl productCostControl,
            MainUserControl.AdditionalDataControl additionalDataControl)
        {
            productCostControl.BaseDataGrid.Rows.Clear();
            productCostControl.ProjectedDataGrid.Rows.Clear();
            //Расчёт стоимости возвратных отходов
            double Co = Convert.ToDouble(userData_Control.MaterialPrice.Text) * 0.1;
            double Mo = Convert.ToDouble(userData_Control.MassaTextbox.Text);
            double Zm = Convert.ToDouble(calculatingInvestmentControl.Zom.Text) - Mo * Co;
            productCostControl.Co.Text = Convert.ToString(Math.Round(Zm, 4));
            //определения величины затрат на материалы в расчёте на годовой объём выпуска продукции
            double Zmg = Zm * Convert.ToDouble(userData_Control.KolDetTextbox.Text);
            productCostControl.Zmg.Text = Convert.ToString(Math.Round(Zmg, 4));
            
            double minzP = Convert.ToDouble(additionalDataControl.MinZP.Text);//Минимальная ЗП
            CalculatingClass calculatingClass = new CalculatingClass();
            double Fd = Convert.ToDouble(userData_Control.FondTextbox.Text);
            double tsumb = 0, tsump = 0, czosumb = 0, czosump = 0;
            for (int i = 0; i < userData_Control.BaseDataGrid.RowCount - 1; i++)
            {
                productCostControl.BaseDataGrid.Rows.Add();
                productCostControl.BaseDataGrid.Rows[i].Cells[0].Value = userData_Control.BaseDataGrid.Rows[i].Cells[0].Value;
                productCostControl.BaseDataGrid.Rows[i].Cells[1].Value = userData_Control.BaseDataGrid.Rows[i].Cells[1].Value;
                productCostControl.BaseDataGrid.Rows[i].Cells[2].Value = userData_Control.BaseDataGrid.Rows[i].Cells[2].Value;
                productCostControl.BaseDataGrid.Rows[i].Cells[3].Value = userData_Control.BaseDataGrid.Rows[i].Cells[4].Value;
                productCostControl.BaseDataGrid.Rows[i].Cells[4].Value = userData_Control.BaseDataGrid.Rows[i].Cells[3].Value;
                double k = calculatingClass.korRazr(Convert.ToInt32(productCostControl.BaseDataGrid.Rows[i].Cells[3].Value));
                productCostControl.BaseDataGrid.Rows[i].Cells[5].Value = Math.Round((minzP * 12 * k) / Fd, 4);
                productCostControl.BaseDataGrid.Rows[i].Cells[6].Value = Math.Round((Convert.ToDouble(productCostControl.BaseDataGrid.Rows[i].Cells[5].Value) 
                    * Convert.ToDouble(productCostControl.BaseDataGrid.Rows[i].Cells[4].Value) * 1.5 * 1) 
                    / (60 * Convert.ToDouble(typeOfProductionControl.datagrid1_2_1.Rows[i].Cells[5].Value)), 4);
                tsumb += Convert.ToDouble(productCostControl.BaseDataGrid.Rows[i].Cells[4].Value);
                czosumb += Convert.ToDouble(productCostControl.BaseDataGrid.Rows[i].Cells[6].Value);
            }
            productCostControl.TsumB.Text = Convert.ToString(tsumb);
            productCostControl.CzoSumB.Text = Convert.ToString(czosumb);
            for (int i = 0; i < userData_Control.ProjectedDataGrid.RowCount - 1; i++)
            {
                productCostControl.ProjectedDataGrid.Rows.Add();
                productCostControl.ProjectedDataGrid.Rows[i].Cells[0].Value = userData_Control.ProjectedDataGrid.Rows[i].Cells[0].Value;
                productCostControl.ProjectedDataGrid.Rows[i].Cells[1].Value = userData_Control.ProjectedDataGrid.Rows[i].Cells[1].Value;
                productCostControl.ProjectedDataGrid.Rows[i].Cells[2].Value = userData_Control.ProjectedDataGrid.Rows[i].Cells[2].Value;
                productCostControl.ProjectedDataGrid.Rows[i].Cells[3].Value = userData_Control.ProjectedDataGrid.Rows[i].Cells[4].Value;
                productCostControl.ProjectedDataGrid.Rows[i].Cells[4].Value = userData_Control.ProjectedDataGrid.Rows[i].Cells[3].Value;
                double k = calculatingClass.korRazr(Convert.ToInt32(productCostControl.ProjectedDataGrid.Rows[i].Cells[3].Value));
                productCostControl.ProjectedDataGrid.Rows[i].Cells[5].Value = Math.Round((minzP * 12 * k) / Fd, 4);
                productCostControl.ProjectedDataGrid.Rows[i].Cells[6].Value = Math.Round((Convert.ToDouble(productCostControl.ProjectedDataGrid.Rows[i].Cells[5].Value)
                    * Convert.ToDouble(productCostControl.ProjectedDataGrid.Rows[i].Cells[4].Value) * 1.5 * 1)
                    / (60 * Convert.ToDouble(typeOfProductionControl.datagrid1_2_2.Rows[i].Cells[5].Value)), 4);
                tsump += Convert.ToDouble(productCostControl.ProjectedDataGrid.Rows[i].Cells[4].Value);
                czosump += Convert.ToDouble(productCostControl.ProjectedDataGrid.Rows[i].Cells[6].Value);
            }
            productCostControl.TsumP.Text = Convert.ToString(tsump);
            productCostControl.CzoSumP.Text = Convert.ToString(czosump);
            //Раздел 3.3
            productCostControl.dataGrid1_1.Rows.Clear();
            productCostControl.dataGrid1_2.Rows.Clear();
            int Dd = 15;//процент дополнительной заработной платы к основной
            double czdb = 0, czdp = 0, fzpb = 0, fzpp = 0;
            for (int i = 0; i < productCostControl.BaseDataGrid.RowCount - 1; i++)
            {
                productCostControl.dataGrid1_1.Rows.Add();
                productCostControl.dataGrid1_1.Rows[i].Cells[0].Value = productCostControl.BaseDataGrid.Rows[i].Cells[0].Value;
                productCostControl.dataGrid1_1.Rows[i].Cells[1].Value = productCostControl.BaseDataGrid.Rows[i].Cells[1].Value;
                productCostControl.dataGrid1_1.Rows[i].Cells[2].Value = productCostControl.BaseDataGrid.Rows[i].Cells[2].Value;
                productCostControl.dataGrid1_1.Rows[i].Cells[3].Value = productCostControl.BaseDataGrid.Rows[i].Cells[6].Value;
                productCostControl.dataGrid1_1.Rows[i].Cells[4].Value = Math.Round((Convert.ToDouble(productCostControl.dataGrid1_1.Rows[i].Cells[3].Value) * Dd) / 100, 4);
                productCostControl.dataGrid1_1.Rows[i].Cells[5].Value = Math.Round((Convert.ToDouble(productCostControl.dataGrid1_1.Rows[i].Cells[3].Value)
                    + Convert.ToDouble(productCostControl.dataGrid1_1.Rows[i].Cells[4].Value)) * Convert.ToDouble(userData_Control.KolDetTextbox.Text), 4);
                czdb += Convert.ToDouble(productCostControl.dataGrid1_1.Rows[i].Cells[4].Value);
                fzpb += Convert.ToDouble(productCostControl.dataGrid1_1.Rows[i].Cells[5].Value);
            }
            for (int i = 0; i < productCostControl.ProjectedDataGrid.RowCount - 1; i++)
            {
                productCostControl.dataGrid1_2.Rows.Add();
                productCostControl.dataGrid1_2.Rows[i].Cells[0].Value = productCostControl.ProjectedDataGrid.Rows[i].Cells[0].Value;
                productCostControl.dataGrid1_2.Rows[i].Cells[1].Value = productCostControl.ProjectedDataGrid.Rows[i].Cells[1].Value;
                productCostControl.dataGrid1_2.Rows[i].Cells[2].Value = productCostControl.ProjectedDataGrid.Rows[i].Cells[2].Value;
                productCostControl.dataGrid1_2.Rows[i].Cells[3].Value = productCostControl.ProjectedDataGrid.Rows[i].Cells[6].Value;
                productCostControl.dataGrid1_2.Rows[i].Cells[4].Value = Math.Round((Convert.ToDouble(productCostControl.dataGrid1_2.Rows[i].Cells[3].Value) * Dd) / 100, 4);
                productCostControl.dataGrid1_2.Rows[i].Cells[5].Value = Math.Round((Convert.ToDouble(productCostControl.dataGrid1_2.Rows[i].Cells[3].Value)
                    + Convert.ToDouble(productCostControl.dataGrid1_2.Rows[i].Cells[4].Value)) * Convert.ToDouble(userData_Control.KolDetTextbox.Text), 4);
                czdp += Convert.ToDouble(productCostControl.dataGrid1_2.Rows[i].Cells[4].Value);
                fzpp += Convert.ToDouble(productCostControl.dataGrid1_2.Rows[i].Cells[5].Value);
            }
            productCostControl.CzoSumB1.Text = productCostControl.CzoSumB.Text;
            productCostControl.CzoSumP1.Text = productCostControl.CzoSumP.Text;
            productCostControl.CzdB.Text = Convert.ToString(czdb);
            productCostControl.CzdP.Text = Convert.ToString(czdp);
            productCostControl.FZP_B.Text = Convert.ToString(fzpb);
            productCostControl.FZP_P.Text = Convert.ToString(fzpp);
            //Раздел 3.4
            double kobb = 0, kobp = 0, Haj = 0.1, kzansumb = 0, kzansump = 0;
            kobb = Convert.ToDouble(calculatingInvestmentControl.KobB.Text);
            kobp = Convert.ToDouble(calculatingInvestmentControl.KobP.Text);
            kzansumb = Convert.ToDouble(typeOfProductionControl.KzanSumB.Text);
            kzansump = Convert.ToDouble(typeOfProductionControl.KzanSumP.Text);
            double Ab = 0, Ap = 0;
            Ab = kobb * Haj * kzansumb;
            Ap = kobp * Haj * kzansump;
            productCostControl.Abaz.Text = Convert.ToString(Math.Round(Ab, 4));
            productCostControl.Apr.Text = Convert.ToString(Math.Round(Ap, 4));
            //кол. вспомогательных
            double nb = Math.Round(Convert.ToDouble(typeOfProductionControl.WsumBpri.Text) * 0.25, 4);
            double np = Math.Round(Convert.ToDouble(typeOfProductionControl.WsumPpri.Text) * 0.25, 4);
            productCostControl.nB.Text = Convert.ToString(nb);
            productCostControl.nP.Text = Convert.ToString(np);
            //зп вспомогательных
            double k2 = calculatingClass.korRazr(3);
            double k1 = Math.Round((minzP * 12 * k2) / Fd, 4);
            double zovb = Fd * 1.7 * kzansumb * k1*nb;
            double zovp = Fd * 1.7 * kzansump * k1*np;
            productCostControl.ZovB.Text = Convert.ToString(Math.Round(zovb, 4));
            productCostControl.ZovP.Text = Convert.ToString(Math.Round(zovp, 4));
            double zdvb = 0.15 * zovb;
            double zdvp = 0.15 * zovp;
            productCostControl.ZdvB.Text = Convert.ToString(Math.Round(zdvb, 4));
            productCostControl.ZdvP.Text = Convert.ToString(Math.Round(zdvp, 4));
            double fzpvb = zovb + zdvb;
            double fzpvp = zovp + zdvp;
            productCostControl.FZPvB.Text = Convert.ToString(Math.Round(fzpvb, 4));
            productCostControl.FZPvP.Text = Convert.ToString(Math.Round(fzpvp, 4));
            //Годовые затраты на силовую электроэнергию
            double Zen = Convert.ToDouble(additionalDataControl.Electric.Text);
            double Kc = 1.3;//коэф. спроса электроэнергии
            double Kp = 1.04;//коэф. учитывающий потери электроэнергии
            double WystB = calculatingClass.Wyst(typeOfProductionControl.BaseDataGrid);
            double WystP = calculatingClass.Wyst(typeOfProductionControl.ProjectedDataGrid);
            double KMBB = 0.01 * Convert.ToDouble(typeOfProductionControl.KzfB.Text);//коэффициенты, учитывающие загрузку оборудования по мощности и времени
            double KMBP = 0.01 * Convert.ToDouble(typeOfProductionControl.KzfP.Text);
            double celb = WystB * Fd * Kc * KMBB * Kp * Zen;
            double celp = WystP * Fd * Kc * KMBP * Kp * Zen;
            productCostControl.CelB.Text = Convert.ToString(Math.Round(celb, 4));
            productCostControl.CelP.Text = Convert.ToString(Math.Round(celp, 4));
            //затраты на сжатый воздух
            int Hcv = 2;
            int ncv = Convert.ToInt32(additionalDataControl.SgatVozd.Text);
            double Ccv = Convert.ToDouble(additionalDataControl.StoimSgatVozd.Text);
            double ccvb = Hcv * ncv * Fd * 1.5 * Convert.ToDouble(typeOfProductionControl.KzfB.Text) * 0.01 * Ccv;
            double ccvp = Hcv * ncv * Fd * 1.5 * Convert.ToDouble(typeOfProductionControl.KzfP.Text) * 0.01 * Ccv;
            productCostControl.CCvB.Text = Convert.ToString(Math.Round(ccvb, 4));
            productCostControl.CCvP.Text = Convert.ToString(Math.Round(ccvp, 4));
            //Затраты на воду для промывки деталей
            double hvp = 0.35;
            double md = Convert.ToDouble(userData_Control.NormTextbox.Text) - Convert.ToDouble(userData_Control.MassaTextbox.Text);
            double Cvd = Convert.ToDouble(additionalDataControl.VodaProizv.Text);//Cтоимость 1м3 воды на производственные нужды
            double Cvp = (hvp * md * Cvd * Convert.ToDouble(userData_Control.KolDetTextbox.Text)) / 1000;
            productCostControl.CVP.Text = Convert.ToString(Math.Round(Cvp, 4));
            double cvoc = Cvp * 0.05;
            double cvoa = Cvp * 0.03;
            productCostControl.Cvoc.Text = Convert.ToString(Math.Round(cvoc, 4));
            productCostControl.Cvoa.Text = Convert.ToString(Math.Round(cvoa, 4));
            //Затраты на воду для бытовых нужд 
            double Hvb = 0.053;//норма расхода воды на одного работающего в смену, м3
            double nc = Convert.ToDouble(additionalDataControl.Smen.Text);//Число смен в сутках
            int Dr = Convert.ToInt32(additionalDataControl.RabDays.Text);//число раб. дней в году
            int ChrabB = Convert.ToInt32(typeOfProductionControl.WsumBpri.Text) + Convert.ToInt32(nb);
            int ChrabP = Convert.ToInt32(typeOfProductionControl.WsumPpri.Text) + Convert.ToInt32(np);
            double Cvb = Convert.ToDouble(additionalDataControl.VodaBitNugd.Text);//Cтоимость 1 м3 воды на бытовые нужды, руб
            double cvbb = Hvb * nc * Dr * ChrabB * Cvb * Convert.ToDouble(typeOfProductionControl.KzanSumB.Text);
            double cvbp = Hvb * nc * Dr * ChrabP * Cvb * Convert.ToDouble(typeOfProductionControl.KzanSumP.Text);
            productCostControl.CvbB.Text = Convert.ToString(Math.Round(cvbb, 4));
            productCostControl.CvbP.Text = Convert.ToString(Math.Round(cvbp, 4));
            double Cp = Convert.ToDouble(additionalDataControl.Cp.Text);
            double Mdet = (Convert.ToDouble(typeOfProductionControl.KolDetTextbox.Text) * md) / 1000;
            double Hvp = 0.35;//расход воды в моечной машине на 1 т промываемых деталей, м3
            double Kpp = 0.18;//расход пара на подогрев 1 м3 воды, т
            double Kcp = 0.1;//расход пара на сушку 1 т деталей, т
            double cpp = Cp * Mdet * (Hvp * Kpp + Kcp);
            productCostControl.Cpp.Text = Convert.ToString(Math.Round(cpp, 4));
            double ppgB = 0.4 * Convert.ToDouble(typeOfProductionControl.KzanSumB.Text) * Convert.ToDouble(calculatingInvestmentControl.Ktr.Text);
            double ppgP = 0.4 * Convert.ToDouble(typeOfProductionControl.KzanSumP.Text) * Convert.ToDouble(calculatingInvestmentControl.Ktr.Text);
            productCostControl.PpgB.Text = Convert.ToString(Math.Round(ppgB, 4));
            productCostControl.PpgP.Text = Convert.ToString(Math.Round(ppgP, 4));
            double PoB = 0.03 * (Convert.ToDouble(calculatingInvestmentControl.KobB.Text) + Convert.ToDouble(calculatingInvestmentControl.KinstB.Text)) * Convert.ToDouble(typeOfProductionControl.KzanSumB.Text);
            double PoP = 0.03 * (Convert.ToDouble(calculatingInvestmentControl.KobP.Text) + Convert.ToDouble(calculatingInvestmentControl.KinstP.Text)) * Convert.ToDouble(typeOfProductionControl.KzanSumP.Text);
            productCostControl.PoB.Text = Convert.ToString(Math.Round(PoB, 4));
            productCostControl.PoP.Text = Convert.ToString(Math.Round(PoP, 4));
            double ccoB = (Ab + fzpvb + celb + ccvb + Cvp + cvbb + cpp + cvoa + cvoc + ppgB + PoB) / Convert.ToDouble(typeOfProductionControl.KolDetTextbox.Text);
            double ccoP = (Ap + fzpvp + celp + ccvp + Cvp + cvbp + cpp + cvoa + cvoc + ppgP + PoP) / Convert.ToDouble(typeOfProductionControl.KolDetTextbox.Text);
            productCostControl.CcoB.Text = Convert.ToString(Math.Round(ccoB, 4));
            productCostControl.CcoP.Text = Convert.ToString(Math.Round(ccoP, 4));
            //Раздел 3.5
            int Oitr = 800, Osl = 600, Omop = 330;
            double ZitrB = Oitr * 1 * 12 * 1.3 * Convert.ToDouble(typeOfProductionControl.KzanSumB.Text);
            double ZslB = Osl * 1 * 12 * 1.3 * Convert.ToDouble(typeOfProductionControl.KzanSumB.Text);
            double ZmopB = Omop * 1 * 12 * 1.3 * Convert.ToDouble(typeOfProductionControl.KzanSumB.Text);
            double ZitrP = Oitr * 1 * 12 * 1.3 * Convert.ToDouble(typeOfProductionControl.KzanSumP.Text);
            double ZslP = Osl * 1 * 12 * 1.3 * Convert.ToDouble(typeOfProductionControl.KzanSumP.Text);
            double ZmopP = Omop * 1 * 12 * 1.3 * Convert.ToDouble(typeOfProductionControl.KzanSumP.Text);
            productCostControl.ZitrB.Text = Convert.ToString(Math.Round(ZitrB, 4));
            productCostControl.ZslB.Text = Convert.ToString(Math.Round(ZslB, 4));
            productCostControl.ZmopB.Text = Convert.ToString(Math.Round(ZmopB, 4));
            productCostControl.ZitrP.Text = Convert.ToString(Math.Round(ZitrP, 4));
            productCostControl.ZslP.Text = Convert.ToString(Math.Round(ZslP, 4));
            productCostControl.ZmopP.Text = Convert.ToString(Math.Round(ZmopP, 4));
            double ZyproB = ZitrB + ZslB + ZmopB;
            double ZyproP = ZitrP + ZslP + ZmopP;
            productCostControl.ZyproB.Text = Convert.ToString(ZyproB);
            productCostControl.ZyproP.Text = Convert.ToString(ZyproP);
            double ZyprdB = 0.15 * ZyproB;
            double ZyprdP = 0.15 * ZyproP;
            productCostControl.ZyprdB.Text = Convert.ToString(Math.Round(ZyprdB, 4));
            productCostControl.ZyprdP.Text = Convert.ToString(Math.Round(ZyprdP, 4));
            double ZyprB = ZyproB + ZyprdB;
            double ZyprP = ZyproP + ZyprdP;
            productCostControl.ZyprB.Text = Convert.ToString(ZyprB);
            productCostControl.ZyprP.Text = Convert.ToString(ZyprP);
            double ZtrB = 0.03 * (Convert.ToDouble(calculatingInvestmentControl.KzdB.Text) + 
                Convert.ToDouble(calculatingInvestmentControl.KinvB.Text)) * Convert.ToDouble(typeOfProductionControl.KzanSumB.Text);
            double ZtrP = 0.03 * (Convert.ToDouble(calculatingInvestmentControl.KzdP.Text) + 
                Convert.ToDouble(calculatingInvestmentControl.KinvP.Text)) * Convert.ToDouble(typeOfProductionControl.KzanSumP.Text);
            productCostControl.ZtrB.Text = Convert.ToString(Math.Round(ZtrB, 4));
            productCostControl.ZtrP.Text = Convert.ToString(Math.Round(ZtrP, 4));
            double Zce = Convert.ToDouble(additionalDataControl.Zce.Text) / 10000;
            productCostControl.Csod.Text = Convert.ToString(Zce);
            double AzdB = (Convert.ToDouble(calculatingInvestmentControl.KzdB.Text) * 0.05 + Convert.ToDouble(calculatingInvestmentControl.Ktr.Text) * 0.15 +
                Convert.ToDouble(calculatingInvestmentControl.KinstB.Text) * 0.2 + Convert.ToDouble(calculatingInvestmentControl.KinvB.Text) * 0.2) * Convert.ToDouble(typeOfProductionControl.KzanSumB.Text);
            double AzdP = (Convert.ToDouble(calculatingInvestmentControl.KzdP.Text) * 0.05 + Convert.ToDouble(calculatingInvestmentControl.Ktr.Text) * 0.15 +
                Convert.ToDouble(calculatingInvestmentControl.KinstP.Text) * 0.2 + Convert.ToDouble(calculatingInvestmentControl.KinvP.Text) * 0.2) * Convert.ToDouble(typeOfProductionControl.KzanSumP.Text);
            productCostControl.AzdB.Text = Convert.ToString(Math.Round(AzdB, 4));
            productCostControl.AzdP.Text = Convert.ToString(Math.Round(AzdP, 4));
            double SzdB = 0, SzdP = 0;
            for (int i = 0; i < typeOfProductionControl.BaseDataGrid.RowCount - 1; i++)
                SzdB += Convert.ToDouble(typeOfProductionControl.BaseDataGrid.Rows[i].Cells[5].Value) *
                    (Convert.ToDouble(typeOfProductionControl.datagrid1_2_1.Rows[i].Cells[5].Value) * 2) + (Convert.ToDouble(typeOfProductionControl.BaseDataGrid.Rows[i].Cells[5].Value) / 2);
            for (int i = 0; i < typeOfProductionControl.ProjectedDataGrid.RowCount - 1; i++)
                SzdP += Convert.ToDouble(typeOfProductionControl.ProjectedDataGrid.Rows[i].Cells[5].Value) *
                    (Convert.ToDouble(typeOfProductionControl.datagrid1_2_2.Rows[i].Cells[5].Value) * 2) + (Convert.ToDouble(typeOfProductionControl.ProjectedDataGrid.Rows[i].Cells[5].Value) / 2);
            double Hop = 0.015, Hod = 2.6;//соответственно нормы расхода электроэнергии на освещение 1м2
            int Foc = 800;//годовое число часов осветительной нагрузки;
            double SocB = SzdB * (Hop * Foc + Hod * Foc) * Convert.ToDouble(additionalDataControl.Coie.Text) * Convert.ToDouble(typeOfProductionControl.KzanSumB.Text);
            double SocP = SzdP * (Hop * Foc + Hod * Foc) * Convert.ToDouble(additionalDataControl.Coie.Text) * Convert.ToDouble(typeOfProductionControl.KzanSumP.Text);
            productCostControl.CocB.Text = Convert.ToString(Math.Round(SocB, 4));
            productCostControl.CocP.Text = Convert.ToString(Math.Round(SocP, 4));
            double CpoB = SzdB * 0.47 * Convert.ToDouble(additionalDataControl.Cp.Text) * Convert.ToDouble(typeOfProductionControl.KzanSumB.Text) * 8;
            double CpoP = SzdP * 0.47 * Convert.ToDouble(additionalDataControl.Cp.Text) * Convert.ToDouble(typeOfProductionControl.KzanSumP.Text) * 8;
            productCostControl.CpoB.Text = Convert.ToString(Math.Round(CpoB, 4));
            productCostControl.CpoP.Text = Convert.ToString(Math.Round(CpoP, 4));
            double CotB = 10 * Convert.ToDouble(additionalDataControl.Dollar.Text) * Convert.ToDouble(typeOfProductionControl.KzanSumB.Text) * 10;
            double CotP = 10 * Convert.ToDouble(additionalDataControl.Dollar.Text) * Convert.ToDouble(typeOfProductionControl.KzanSumP.Text) * 10;
            productCostControl.CotB.Text = Convert.ToString(Math.Round(CotB, 4));
            productCostControl.CotP.Text = Convert.ToString(Math.Round(CotP, 4));
            double CprochB = (ZyprB + ZtrB + Zce + AzdB + SocB + CpoB + CotB) * 0.03;
            double CprochP = (ZyprP + ZtrP + Zce + AzdP + SocP + CpoP + CotP) * 0.03;
            productCostControl.CprochB.Text = Convert.ToString(Math.Round(CprochB, 4));
            productCostControl.CprochP.Text = Convert.ToString(Math.Round(CprochP, 4));
            double CoprB = (ZyprB + ZtrB + Zce + AzdB + SocB + CpoB + CotB + CprochB) / Convert.ToDouble(typeOfProductionControl.KolDetTextbox.Text);
            double CoprP = (ZyprP + ZtrP + Zce + AzdP + SocP + CpoP + CotP + CprochP) / Convert.ToDouble(typeOfProductionControl.KolDetTextbox.Text);
            productCostControl.CoprB.Text = Convert.ToString(Math.Round(CoprB, 4));
            productCostControl.CoprP.Text = Convert.ToString(Math.Round(CoprP, 4));
            //раздел 3.6
            double CotchB = 0.38 * (fzpb + fzpvb + ZyprB);
            double CotchP = 0.38 * (fzpp + fzpvp + ZyprP);
            productCostControl.CotchB.Text = Convert.ToString(Math.Round(CotchB, 4));
            productCostControl.CotchP.Text = Convert.ToString(Math.Round(CotchP, 4));
            //Фанальная таблица
            productCostControl.FinalDataGrid.Rows.Clear();
            productCostControl.FinalDataGrid.Rows.Add(12);
            productCostControl.FinalDataGrid.Rows[0].Cells[0].Value = "1. Сырье и материалы за вычетом возвратных отходов";
            productCostControl.FinalDataGrid.Rows[1].Cells[0].Value = "2. Основная заработная плата производственных рабочих";
            productCostControl.FinalDataGrid.Rows[2].Cells[0].Value = "3. Дополнительная заработная плата производственных рабочих";
            productCostControl.FinalDataGrid.Rows[3].Cells[0].Value = "4. Расходы на содержание и эксплуатацию машин и оборудования:";
            productCostControl.FinalDataGrid.Rows[4].Cells[0].Value = "   – заработная плата";
            productCostControl.FinalDataGrid.Rows[5].Cells[0].Value = "   – амортизация";
            productCostControl.FinalDataGrid.Rows[6].Cells[0].Value = "5. Итого технологическая себестоимость";
            productCostControl.FinalDataGrid.Rows[7].Cells[0].Value = "6. Общепроизводственные расходы";
            productCostControl.FinalDataGrid.Rows[8].Cells[0].Value = "   – заработная плата";
            productCostControl.FinalDataGrid.Rows[9].Cells[0].Value = "   – амортизация";
            productCostControl.FinalDataGrid.Rows[10].Cells[0].Value = "7. Налоги, отчисления в бюджет и внебюджетные фонды, сборы и отчисления местными органами власти";
            productCostControl.FinalDataGrid.Rows[11].Cells[0].Value = "8. Итого цеховая себестоимость";
            productCostControl.FinalDataGrid.Rows[0].Cells[2].Value = productCostControl.FinalDataGrid.Rows[0].Cells[4].Value = productCostControl.Zmg.Text;
            productCostControl.FinalDataGrid.Rows[0].Cells[1].Value = productCostControl.FinalDataGrid.Rows[0].Cells[3].Value = Math.Round(Convert.ToDouble(productCostControl.Zmg.Text) / Convert.ToDouble(typeOfProductionControl.KolDetTextbox.Text), 4);
            //_________________________
            productCostControl.FinalDataGrid.Rows[1].Cells[1].Value = productCostControl.CzoSumB.Text;
            productCostControl.FinalDataGrid.Rows[1].Cells[2].Value = Math.Round(Convert.ToDouble(productCostControl.CzoSumB.Text) * Convert.ToDouble(typeOfProductionControl.KolDetTextbox.Text), 4);
            productCostControl.FinalDataGrid.Rows[1].Cells[3].Value = productCostControl.CzoSumP.Text;
            productCostControl.FinalDataGrid.Rows[1].Cells[4].Value = Math.Round(Convert.ToDouble(productCostControl.CzoSumP.Text) * Convert.ToDouble(typeOfProductionControl.KolDetTextbox.Text), 4);
            ///////////////________________________________________
            productCostControl.FinalDataGrid.Rows[2].Cells[1].Value = productCostControl.CzdB.Text;
            productCostControl.FinalDataGrid.Rows[2].Cells[2].Value = Math.Round(Convert.ToDouble(productCostControl.CzdB.Text) * Convert.ToDouble(typeOfProductionControl.KolDetTextbox.Text), 4);
            productCostControl.FinalDataGrid.Rows[2].Cells[3].Value = productCostControl.CzdP.Text;
            productCostControl.FinalDataGrid.Rows[2].Cells[4].Value = Math.Round(Convert.ToDouble(productCostControl.CzdB.Text) * Convert.ToDouble(typeOfProductionControl.KolDetTextbox.Text), 4);
            //_________________________________
            productCostControl.FinalDataGrid.Rows[3].Cells[1].Value = productCostControl.CcoB.Text;
            productCostControl.FinalDataGrid.Rows[3].Cells[2].Value = Math.Round(Convert.ToDouble(productCostControl.CcoB.Text) * Convert.ToDouble(typeOfProductionControl.KolDetTextbox.Text), 4);
            productCostControl.FinalDataGrid.Rows[3].Cells[3].Value = productCostControl.CcoP.Text;
            productCostControl.FinalDataGrid.Rows[3].Cells[4].Value = Math.Round(Convert.ToDouble(productCostControl.CcoP.Text) * Convert.ToDouble(typeOfProductionControl.KolDetTextbox.Text), 4);
            //_____________
            productCostControl.FinalDataGrid.Rows[4].Cells[2].Value = Math.Round(fzpvb,4);
            productCostControl.FinalDataGrid.Rows[4].Cells[1].Value = Math.Round(fzpvb / Convert.ToDouble(typeOfProductionControl.KolDetTextbox.Text), 4);
            productCostControl.FinalDataGrid.Rows[4].Cells[4].Value = Math.Round(fzpvp,4);
            productCostControl.FinalDataGrid.Rows[4].Cells[3].Value = Math.Round(fzpvp / Convert.ToDouble(typeOfProductionControl.KolDetTextbox.Text), 4);
            //_________________________________
            productCostControl.FinalDataGrid.Rows[5].Cells[2].Value = Math.Round(Ab, 4);
            productCostControl.FinalDataGrid.Rows[5].Cells[1].Value = Math.Round(Ab / Convert.ToDouble(typeOfProductionControl.KolDetTextbox.Text), 4);
            productCostControl.FinalDataGrid.Rows[5].Cells[4].Value = Math.Round(Ap, 4);
            productCostControl.FinalDataGrid.Rows[5].Cells[3].Value = Math.Round(Ap / Convert.ToDouble(typeOfProductionControl.KolDetTextbox.Text), 4);
            //_____________________
            productCostControl.FinalDataGrid.Rows[6].Cells[1].Value = Convert.ToDouble(productCostControl.FinalDataGrid.Rows[0].Cells[1].Value) +
                Convert.ToDouble(productCostControl.FinalDataGrid.Rows[1].Cells[1].Value) + Convert.ToDouble(productCostControl.FinalDataGrid.Rows[2].Cells[1].Value) +
                Convert.ToDouble(productCostControl.FinalDataGrid.Rows[3].Cells[1].Value);
            productCostControl.FinalDataGrid.Rows[6].Cells[2].Value = Convert.ToDouble(productCostControl.FinalDataGrid.Rows[0].Cells[2].Value) +
                Convert.ToDouble(productCostControl.FinalDataGrid.Rows[1].Cells[2].Value) + Convert.ToDouble(productCostControl.FinalDataGrid.Rows[2].Cells[2].Value) +
                Convert.ToDouble(productCostControl.FinalDataGrid.Rows[3].Cells[2].Value);
            productCostControl.FinalDataGrid.Rows[6].Cells[3].Value = Convert.ToDouble(productCostControl.FinalDataGrid.Rows[0].Cells[3].Value) +
                Convert.ToDouble(productCostControl.FinalDataGrid.Rows[1].Cells[3].Value) + Convert.ToDouble(productCostControl.FinalDataGrid.Rows[2].Cells[3].Value) +
                Convert.ToDouble(productCostControl.FinalDataGrid.Rows[3].Cells[3].Value);
            productCostControl.FinalDataGrid.Rows[6].Cells[4].Value = Convert.ToDouble(productCostControl.FinalDataGrid.Rows[0].Cells[4].Value) +
                Convert.ToDouble(productCostControl.FinalDataGrid.Rows[1].Cells[4].Value) + Convert.ToDouble(productCostControl.FinalDataGrid.Rows[2].Cells[4].Value) +
                Convert.ToDouble(productCostControl.FinalDataGrid.Rows[3].Cells[4].Value);
            //_______________________
            productCostControl.FinalDataGrid.Rows[7].Cells[1].Value = productCostControl.FinalDataGrid.Rows[3].Cells[1].Value;
            productCostControl.FinalDataGrid.Rows[7].Cells[2].Value = productCostControl.FinalDataGrid.Rows[3].Cells[2].Value;
            productCostControl.FinalDataGrid.Rows[7].Cells[3].Value = productCostControl.FinalDataGrid.Rows[3].Cells[3].Value;
            productCostControl.FinalDataGrid.Rows[7].Cells[4].Value = productCostControl.FinalDataGrid.Rows[3].Cells[4].Value;
            //_____________________________
            productCostControl.FinalDataGrid.Rows[8].Cells[2].Value = Math.Round(ZyprB, 4);
            productCostControl.FinalDataGrid.Rows[8].Cells[1].Value = Math.Round(ZyprB / Convert.ToDouble(typeOfProductionControl.KolDetTextbox.Text), 4);
            productCostControl.FinalDataGrid.Rows[8].Cells[4].Value = Math.Round(ZyprP, 4);
            productCostControl.FinalDataGrid.Rows[8].Cells[3].Value = Math.Round(ZyprP / Convert.ToDouble(typeOfProductionControl.KolDetTextbox.Text), 4);
            //__________________________
            productCostControl.FinalDataGrid.Rows[9].Cells[2].Value = Math.Round(AzdB, 4);
            productCostControl.FinalDataGrid.Rows[9].Cells[1].Value = Math.Round(AzdB / Convert.ToDouble(typeOfProductionControl.KolDetTextbox.Text), 4);
            productCostControl.FinalDataGrid.Rows[9].Cells[4].Value = Math.Round(AzdP, 4);
            productCostControl.FinalDataGrid.Rows[9].Cells[3].Value = Math.Round(AzdP / Convert.ToDouble(typeOfProductionControl.KolDetTextbox.Text), 4);
            //_________________________
            productCostControl.FinalDataGrid.Rows[10].Cells[2].Value = Math.Round(CotchB, 4);
            productCostControl.FinalDataGrid.Rows[10].Cells[1].Value = Math.Round(CotchB / Convert.ToDouble(typeOfProductionControl.KolDetTextbox.Text), 4);
            productCostControl.FinalDataGrid.Rows[10].Cells[4].Value = Math.Round(CotchP, 4);
            productCostControl.FinalDataGrid.Rows[10].Cells[3].Value = Math.Round(CotchP / Convert.ToDouble(typeOfProductionControl.KolDetTextbox.Text), 4);
            //_____________________________
            productCostControl.FinalDataGrid.Rows[11].Cells[1].Value = Convert.ToDouble(productCostControl.FinalDataGrid.Rows[6].Cells[1].Value) +
                Convert.ToDouble(productCostControl.FinalDataGrid.Rows[7].Cells[1].Value) + Convert.ToDouble(productCostControl.FinalDataGrid.Rows[10].Cells[1].Value);
            productCostControl.FinalDataGrid.Rows[11].Cells[2].Value = Convert.ToDouble(productCostControl.FinalDataGrid.Rows[6].Cells[2].Value) +
                Convert.ToDouble(productCostControl.FinalDataGrid.Rows[7].Cells[2].Value) + Convert.ToDouble(productCostControl.FinalDataGrid.Rows[10].Cells[2].Value);
            productCostControl.FinalDataGrid.Rows[11].Cells[3].Value = Convert.ToDouble(productCostControl.FinalDataGrid.Rows[6].Cells[3].Value) +
                Convert.ToDouble(productCostControl.FinalDataGrid.Rows[7].Cells[3].Value) + Convert.ToDouble(productCostControl.FinalDataGrid.Rows[10].Cells[3].Value);
            productCostControl.FinalDataGrid.Rows[11].Cells[4].Value = Convert.ToDouble(productCostControl.FinalDataGrid.Rows[6].Cells[4].Value) +
                Convert.ToDouble(productCostControl.FinalDataGrid.Rows[7].Cells[4].Value) + Convert.ToDouble(productCostControl.FinalDataGrid.Rows[10].Cells[4].Value);
        }
    }
}
