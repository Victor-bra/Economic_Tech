using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economic_Tech.Forms.ManiClass
{
    public class CalculatingClass
    {
        public CalculatingClass() { }
        //коррелирующий коэффициент в зависимости от разряда рабочего
        public double korRazr(int razr)
        {
            double korRazr = 0;
            switch (razr)
            {
                case 1:
                    korRazr = 1;
                    break;
                case 2:
                    korRazr = 1.16;
                    break;
                case 3:
                    korRazr = 1.35;
                    break;
                case 4:
                    korRazr = 1.57;
                    break;
                case 5:
                    korRazr = 1.73;
                    break;
                case 6:
                    korRazr = 1.9;
                    break;
                case 7:
                    korRazr = 2.03;
                    break;
                case 8:
                    korRazr = 2.17;
                    break;
                case 9:
                    korRazr = 2.32;
                    break;
                case 10:
                    korRazr = 2.48;
                    break;
                case 11:
                    korRazr = 2.65;
                    break;
                case 12:
                    korRazr = 2.84;
                    break;
                case 13:
                    korRazr = 3.04;
                    break;
                case 14:
                    korRazr = 3.25;
                    break;
                case 15:
                    korRazr = 3.48;
                    break;
                default:
                    korRazr = 4;
                    break;
            }
            return korRazr;
        }
        //Расчет ∑� �=1 �ч� ∙ ��
        public double summ(DataGridView UB, double y)
        {
            double summ = 0;
            for (int i = 0; i < UB.RowCount - 1; i++)
                summ += Convert.ToDouble(UB.Rows[i].Cells[5].Value) * y;
            return summ;
        }
        //Wуст-суммарная установленная мощность оборудования, кВт
        public double Wyst(DataGridView UB)
        {
            double Wyst = 0;
            for (int i = 0; i < UB.RowCount - 1; i++)
                Wyst += Convert.ToDouble(UB.Rows[i].Cells[6].Value);
            return Wyst;
        }
        //ЧДС для графика
        public double CHDS(double NDL, MainUserControl.AnnualOutputControl annualOutputControl)
        {
            double I = Convert.ToDouble(annualOutputControl.DataGrid1.Rows[1].Cells[2].Value);
            double Pch = Convert.ToDouble(annualOutputControl.DataGrid3.Rows[7].Cells[1].Value);
            double ss = 0;
            for (int i = 0; i < 10; i++)
                ss += Pch / Math.Pow((1 + NDL), i);
            return Math.Round(-I + ss, 4);
        }
        //пересечение графика в ОХ
        public double OX1(int[] zz, double[] nums)
        {
            int znach = 0;
            double fin = 0;
            for (int i = 0; i < 10; i++)
            {
                if (zz[i] < 0 && i != 0)
                {
                    if (zz[i - 1] < 0)
                    {
                        int q = 0;
                        for (int i1 = 0; i1 < 10; i++)
                            if (zz[i1] > 0)
                                continue;
                            else
                            {
                                fin = -1;
                                znach = -1;
                                break;
                            }
                    }
                    if (zz[i - 1] > 0)
                    {
                        znach = 1;
                        double K = (zz[i] - zz[i - 1]) / (nums[i] - nums[i - 1]);
                        double B = zz[i - 1] - nums[i - 1] * K;
                        fin = -B / K;
                        break;
                    }
                }
                if (zz[i] > 0 && i != 0)
                {
                    if (zz[i - 1] > 0)
                    {
                        int q = 0;
                        for (int i1 = 0; i1 < 10; i++)
                            if (zz[i1] < 0)
                                continue;
                            else
                            {
                                znach = -2;
                                fin = -2;
                                break;
                            }
                    }
                    if (zz[i - 1] < 0)
                    {
                        znach = 2;
                        double K = (zz[i] - zz[i - 1]) / (nums[i] - nums[i - 1]);
                        double B = zz[i - 1] - nums[i - 1] * K;
                        fin = -B / K;
                        break;
                    }
                }
            }
            return Math.Round(fin, 4);
        }
        public int OX2(int[] zz, double[] nums)
        {
            int znach = 0;
            double fin = 0;
            for (int i = 0; i < 10; i++)
            {
                if (zz[i] < 0 && i != 0)
                {
                    if (zz[i - 1] < 0)
                    {
                        int q = 0;
                        for (int i1 = 0; i1 < 10; i++)
                            if (zz[i1] > 0)
                                continue;
                            else
                            {
                                fin = -1;
                                znach = -1;
                                break;
                            }
                    }
                    if (zz[i - 1] > 0)
                    {
                        znach = 1;
                        double K = (zz[i] - zz[i - 1]) / (nums[i] - nums[i - 1]);
                        double B = zz[i - 1] - nums[i - 1] * K;
                        fin = -B / K;
                        break;
                    }
                }
                if (zz[i] > 0 && i != 0)
                {
                    if (zz[i - 1] > 0)
                    {
                        int q = 0;
                        for (int i1 = 0; i1 < 10; i++)
                            if (zz[i1] < 0)
                                continue;
                            else
                            {
                                znach = -2;
                                fin = -2;
                                break;
                            }
                    }
                    if (zz[i - 1] < 0)
                    {
                        znach = 2;
                        double K = (zz[i] - zz[i - 1]) / (nums[i] - nums[i - 1]);
                        double B = zz[i - 1] - nums[i - 1] * K;
                        fin = -B / K;
                        break;
                    }
                }
            }
            return znach;
        }
        //последняя формула
        public double TD(int n,double NDL, MainUserControl.AnnualOutputControl annualOutputControl)
        {
            double I = Convert.ToDouble(annualOutputControl.DataGrid1.Rows[1].Cells[2].Value);
            double Pch = Convert.ToDouble(annualOutputControl.DataGrid3.Rows[7].Cells[1].Value);
            double ss = 0;
            for (int i = 0; i < n; i++)
                ss += Pch / Math.Pow((1 + NDL), i);
            return Math.Round(-I + ss, 4);
        }
    }
}