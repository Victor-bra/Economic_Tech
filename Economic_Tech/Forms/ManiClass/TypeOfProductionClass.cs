using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace Economic_Tech.Forms.ManiClass
{
    public class TypeOfProductionClass
    {
        public TypeOfProductionClass() { }
        public void ishodnic(DataGridView UB, DataGridView TB, DataGridView UP, DataGridView TP,
            string m, string fond,string kolDet,string material,string norma, DataGridView data1_2_1, DataGridView data1_2_2,
            MetroFramework.Controls.MetroTextBox text1, MetroFramework.Controls.MetroTextBox text2,
            MetroFramework.Controls.MetroTextBox text3, MetroFramework.Controls.MetroTextBox text4,
            MetroFramework.Controls.MetroTextBox text5, MetroFramework.Controls.MetroTextBox text6,
            MetroFramework.Controls.MetroTextBox text7, MetroFramework.Controls.MetroTextBox text8,
            Bunifu.UI.WinForms.BunifuLabel Tipe, DataGridView dataColMest1_3_1, DataGridView dataColMest1_3_2,
            MetroFramework.Controls.MetroTextBox TsumB1, MetroFramework.Controls.MetroTextBox TsumP1,
            MetroFramework.Controls.MetroTextBox WpiB1, MetroFramework.Controls.MetroTextBox WpiP1,
            MetroFramework.Controls.MetroTextBox WsumBpri1, MetroFramework.Controls.MetroTextBox WsumPpri1,
            MetroFramework.Controls.MetroTextBox KzfB, MetroFramework.Controls.MetroTextBox KzfP,
            MetroFramework.Controls.MetroTextBox KzanSumB, MetroFramework.Controls.MetroTextBox KzanSumP)
        {
            TB.Rows.Clear();
            TP.Rows.Clear();
            data1_2_1.Rows.Clear();
            data1_2_2.Rows.Clear();
            dataColMest1_3_1.Rows.Clear();
            dataColMest1_3_2.Rows.Clear();
            //1.1 таблица исходных данных
            for (int i = 0; i < UB.RowCount - 1; i++)
            {
                TB.Rows.Add();
                for (int j = 0; j < UB.ColumnCount-1; j++)
                    TB.Rows[i].Cells[j].Value = UB.Rows[i].Cells[j].Value;
            }
            for (int i = 0; i < UP.RowCount - 1; i++)
            {
                TP.Rows.Add();
                for (int j = 0; j < UP.ColumnCount-1; j++)
                    TP.Rows[i].Cells[j].Value = UP.Rows[i].Cells[j].Value;
            }
            //1.2 таблица определение типа производства
            for (int i = 0; i < TB.RowCount - 1; i++)
            {
                data1_2_1.Rows.Add();
                for (int j = 0; j < 4; j++)
                    data1_2_1.Rows[i].Cells[j].Value = TB.Rows[i].Cells[j].Value;
            }
            for (int i = 0; i < TP.RowCount - 1; i++)
            {
                data1_2_2.Rows.Add();
                for (int j = 0; j < 4; j++)
                    data1_2_2.Rows[i].Cells[j].Value = TP.Rows[i].Cells[j].Value;
            }
            double Knz = 0.8;
            double TsumB = 0;
            double WsumBpri = 0;
            double WsumPpri = 0;
            double OBazi = 0;
            double Opri = 0;
            for (int i = 0; i < data1_2_1.RowCount - 1; i++)
            {
                data1_2_1.Rows[i].Cells[4].Value = Math.Round((Convert.ToInt32(kolDet) * Convert.ToDouble(data1_2_1.Rows[i].Cells[3].Value))
                    / (60 * Convert.ToInt32(fond) * Knz), 3);
                data1_2_1.Rows[i].Cells[5].Value = Math.Ceiling(Convert.ToDouble(data1_2_1.Rows[i].Cells[4].Value));
                data1_2_1.Rows[i].Cells[6].Value = data1_2_1.Rows[i].Cells[4].Value;
                double RRR = Math.Floor(Math.Round(Knz / Convert.ToDouble(data1_2_1.Rows[i].Cells[6].Value),3));
                if (RRR < 1)
                    RRR = 1;
                data1_2_1.Rows[i].Cells[7].Value = RRR;
                TsumB += Convert.ToDouble(data1_2_1.Rows[i].Cells[3].Value);
                WsumBpri += Convert.ToDouble(data1_2_1.Rows[i].Cells[5].Value);
                OBazi += Convert.ToDouble(data1_2_1.Rows[i].Cells[7].Value);
            }
            double TsumP = 0;
            for (int i = 0; i < data1_2_2.RowCount - 1; i++)
            {
                data1_2_2.Rows[i].Cells[4].Value = Math.Round((Convert.ToInt32(kolDet) * Convert.ToDouble(data1_2_2.Rows[i].Cells[3].Value))
                    / (60 * Convert.ToInt32(fond) * Knz), 3);
                data1_2_2.Rows[i].Cells[5].Value = Math.Ceiling(Convert.ToDouble(data1_2_2.Rows[i].Cells[4].Value));
                data1_2_2.Rows[i].Cells[6].Value = data1_2_2.Rows[i].Cells[4].Value;
                double RRR = Math.Floor(Math.Round(Knz / Convert.ToDouble(data1_2_2.Rows[i].Cells[6].Value), 3));
                if (RRR < 1)
                    RRR = 1;
                data1_2_2.Rows[i].Cells[7].Value = RRR;
                TsumP += Convert.ToDouble(data1_2_2.Rows[i].Cells[3].Value);
                WsumPpri += Convert.ToDouble(data1_2_2.Rows[i].Cells[5].Value);
                Opri += Convert.ToDouble(data1_2_2.Rows[i].Cells[7].Value);
            }
            text1.Text = Convert.ToString(TsumB);
            text2.Text = Convert.ToString(TsumP);
            text3.Text = Convert.ToString(WsumBpri);
            text4.Text = Convert.ToString(WsumPpri);
            text5.Text = Convert.ToString(OBazi);
            text6.Text = Convert.ToString(Opri);
            text7.Text = Convert.ToString(Math.Round(OBazi / WsumBpri, 4));
            text8.Text = Convert.ToString(Math.Round(Opri / WsumPpri, 4));
            string TipB = "", TipP = "";
            if (Convert.ToDouble(text7.Text) > 0 && Convert.ToDouble(text7.Text) <= 3)
                TipB = "Массовый";
            if (Convert.ToDouble(text7.Text) > 3 && Convert.ToDouble(text7.Text) <= 10)
                TipB = "Крупносерийный";
            if (Convert.ToDouble(text7.Text) > 10 && Convert.ToDouble(text7.Text) <= 20)
                TipB = "Среднесерийный";
            if (Convert.ToDouble(text7.Text) > 20)
                TipB = "Мелкосерийный";
            if (Convert.ToDouble(text8.Text) > 0 && Convert.ToDouble(text8.Text) <= 3)
                TipP = "Массовый";
            if (Convert.ToDouble(text8.Text) > 3 && Convert.ToDouble(text8.Text) <= 10)
                TipP = "Крупносерийный";
            if (Convert.ToDouble(text8.Text) > 10 && Convert.ToDouble(text8.Text) <= 20)
                TipP = "Среднесерийный";
            if (Convert.ToDouble(text8.Text) > 20)
                TipP = "Мелкосерийный";
            Tipe.Text = "Согласно выше приведенным рекомендациям тип производства базового тех. процесса-" + TipB + "" +
                " тип проектируемого тех. процесса-" + TipP;
            for (int i = 0; i < data1_2_1.RowCount - 1; i++)
            {
                dataColMest1_3_1.Rows.Add();
                for (int j = 0; j < 6; j++)
                    dataColMest1_3_1.Rows[i].Cells[j].Value = data1_2_1.Rows[i].Cells[j].Value; 
            }
            for (int i = 0; i < data1_2_2.RowCount - 1; i++)
            {
                dataColMest1_3_2.Rows.Add();
                for (int j = 0; j < 6; j++)
                    dataColMest1_3_2.Rows[i].Cells[j].Value = data1_2_2.Rows[i].Cells[j].Value;
            }
            double wpiB1 = 0, wpiP1 = 0, kzfB = 0, kzfP = 0, kzanSumB = 0, kzanSumP = 0;
            for (int i=0;i< data1_2_1.RowCount - 1; i++)
            {
                wpiB1 += Convert.ToDouble(dataColMest1_3_1.Rows[i].Cells[4].Value);
                dataColMest1_3_1.Rows[i].Cells[6].Value = Convert.ToDouble(data1_2_1.Rows[i].Cells[6].Value) * 100;
                kzfB += Convert.ToDouble(dataColMest1_3_1.Rows[i].Cells[6].Value);
                dataColMest1_3_1.Rows[i].Cells[7].Value = Convert.ToDouble(dataColMest1_3_1.Rows[i].Cells[4].Value) / 0.8;
                kzanSumB += Convert.ToDouble(dataColMest1_3_1.Rows[i].Cells[7].Value);
            }
            for (int i = 0; i < data1_2_2.RowCount - 1; i++)
            {
                wpiP1 += Convert.ToDouble(dataColMest1_3_2.Rows[i].Cells[4].Value);
                dataColMest1_3_2.Rows[i].Cells[6].Value = Convert.ToDouble(data1_2_2.Rows[i].Cells[6].Value) * 100;
                kzfP += Convert.ToDouble(dataColMest1_3_2.Rows[i].Cells[6].Value);
                dataColMest1_3_2.Rows[i].Cells[7].Value = Convert.ToDouble(dataColMest1_3_2.Rows[i].Cells[4].Value) / 0.8;
                kzanSumP += Convert.ToDouble(dataColMest1_3_2.Rows[i].Cells[7].Value);
            }

            TsumB1.Text = text1.Text;
            TsumP1.Text = text2.Text;
            WpiB1.Text = Convert.ToString(wpiB1);
            WpiP1.Text = Convert.ToString(wpiP1);
            WsumBpri1.Text = text3.Text;
            WsumPpri1.Text = text4.Text;
            KzfB.Text = Convert.ToString(Math.Round(kzfB / Convert.ToInt32(text3.Text), 4));
            KzfP.Text = Convert.ToString(Math.Round(kzfP / Convert.ToInt32(text4.Text), 4));
            KzanSumB.Text = Convert.ToString(Math.Round(kzanSumB / Convert.ToInt32(text3.Text), 4));
            KzanSumP.Text = Convert.ToString(Math.Round(kzanSumP / Convert.ToInt32(text4.Text), 4));
        }

    }
}
