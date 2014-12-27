using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPR3
{
    public partial class FormТеорияВажности : Form
    {
        public FormТеорияВажности()
        {
            InitializeComponent();

            dataGridViewСкалярныеОценки.Columns.Add("K1", "K1");
            dataGridViewСкалярныеОценки.Columns.Add("K2", "K2");

            dataGridViewСкалярныеОценки.Rows.Add();
            dataGridViewСкалярныеОценки.Rows[0].HeaderCell.Value = "x1";
            dataGridViewСкалярныеОценки.Rows[0].Cells[0].Value = 8;
            dataGridViewСкалярныеОценки.Rows[0].Cells[1].Value = 10;

            dataGridViewСкалярныеОценки.Rows.Add();
            dataGridViewСкалярныеОценки.Rows[1].HeaderCell.Value = "x2";
            dataGridViewСкалярныеОценки.Rows[1].Cells[0].Value = 8;
            dataGridViewСкалярныеОценки.Rows[1].Cells[1].Value = 11;

            dataGridViewСкалярныеОценки.Rows.Add();
            dataGridViewСкалярныеОценки.Rows[2].HeaderCell.Value = "x3";
            dataGridViewСкалярныеОценки.Rows[2].Cells[0].Value = 8;
            dataGridViewСкалярныеОценки.Rows[2].Cells[1].Value = 12;

            dataGridViewСкалярныеОценки.Rows.Add();
            dataGridViewСкалярныеОценки.Rows[3].HeaderCell.Value = "x4";
            dataGridViewСкалярныеОценки.Rows[3].Cells[0].Value = 9;
            dataGridViewСкалярныеОценки.Rows[3].Cells[1].Value = 9;

            dataGridViewСкалярныеОценки.Rows.Add();
            dataGridViewСкалярныеОценки.Rows[4].HeaderCell.Value = "x5";
            dataGridViewСкалярныеОценки.Rows[4].Cells[0].Value = 9;
            dataGridViewСкалярныеОценки.Rows[4].Cells[1].Value = 10;

            dataGridViewСкалярныеОценки.Rows.Add();
            dataGridViewСкалярныеОценки.Rows[5].HeaderCell.Value = "x6";
            dataGridViewСкалярныеОценки.Rows[5].Cells[0].Value = 10;
            dataGridViewСкалярныеОценки.Rows[5].Cells[1].Value = 10;

            dataGridViewСкалярныеОценки.Rows.Add();
            dataGridViewСкалярныеОценки.Rows[6].HeaderCell.Value = "x7";
            dataGridViewСкалярныеОценки.Rows[6].Cells[0].Value = 10;
            dataGridViewСкалярныеОценки.Rows[6].Cells[1].Value = 11;

            dataGridViewСкалярныеОценки.Rows.Add();
            dataGridViewСкалярныеОценки.Rows[7].HeaderCell.Value = "x8";
            dataGridViewСкалярныеОценки.Rows[7].Cells[0].Value = 11;
            dataGridViewСкалярныеОценки.Rows[7].Cells[1].Value = 9;

            dataGridViewВажности.Columns.Add("K1", "K1");
            dataGridViewВажности.Columns.Add("K2", "K2");

            dataGridViewВажности.Rows.Add();
            dataGridViewВажности.Rows[0].Cells[0].Value = 2;
            dataGridViewВажности.Rows[0].Cells[1].Value = 1;
        }
        private void buttonДобавитьКритерий_Click(object sender, EventArgs e)
        {
            dataGridViewСкалярныеОценки.Columns.Add("K" + dataGridViewСкалярныеОценки.Columns.Count, "K" + dataGridViewСкалярныеОценки.Columns.Count);
            dataGridViewВажности.Columns.Add("K" + dataGridViewВажности.Columns.Count, "K" + dataGridViewВажности.Columns.Count);
        }
        private void buttonУдалитьКритерий_Click(object sender, EventArgs e)
        {
            dataGridViewСкалярныеОценки.Columns.Remove("K" + (dataGridViewСкалярныеОценки.Columns.Count - 1));
            dataGridViewВажности.Columns.Remove("K" + (dataGridViewВажности.Columns.Count - 1));
        }
        private void buttonВычислить_Click(object sender, EventArgs e)
        {
            SortedList<int, SortedList<int, double>> матрицаСкалярныхОценок = СчитываниеМатрицыСкалярныхОценок();
            if (матрицаСкалярныхОценок == null)
            {
                return;
            }
            SortedList<int, double> векторВажностиКритериев = СчитываниеВектораВажностиКритериев();
            if (векторВажностиКритериев == null)
            {
                return;
            }
            #region Вычисление коэфициентов относительной важности
            SortedList<int, SortedList<int, double>> КоэффициентыОтносительнойВажностиКритериевQij =
               ВычислениеМатрицыКоэфициентовОтносительнойВажностиQij(векторВажностиКритериев);
            FormDataGridView formDataGridViewОтносительнаяВажностьКритериевQij = new FormDataGridView();
            formDataGridViewОтносительнаяВажностьКритериевQij.Text = "Матрица коэффициентов относительной важности критериев";
            SortedList<int, string> строкиQij = new SortedList<int, string>();
            SortedList<int, string[]> столбцыQij = new SortedList<int, string[]>();
            foreach (int i in векторВажностиКритериев.Keys)
            {
                строкиQij.Add(i, "K" + (i + 1));
                столбцыQij.Add(i + 1, new string[2]);
                столбцыQij[i + 1][0] = "K" + (i + 1);
                столбцыQij[i + 1][1] = "K" + (i + 1);
            }
            formDataGridViewОтносительнаяВажностьКритериевQij.Visible = true;
            formDataGridViewОтносительнаяВажностьКритериевQij.DoubleЗаполнение(
                КоэффициентыОтносительнойВажностиКритериевQij, строкиQij, столбцыQij);
            #endregion


            #region Модифицированние значений критериев
            SortedList<int, SortedList<int, double>> модифицированныеЗначенияКритериев =
                ВычислениеМатрицыВекторныхОценок(матрицаСкалярныхОценок,
                КоэффициентыОтносительнойВажностиКритериевQij, векторВажностиКритериев);
            FormDataGridView formDataGridViewМодифицированныеЗначенияКритериев = new FormDataGridView();
            formDataGridViewМодифицированныеЗначенияКритериев.Text = "Модифизированные значения критериев";
            formDataGridViewМодифицированныеЗначенияКритериев.Visible = true;
            SortedList<int, string> строкиКмз = new SortedList<int, string>();
            SortedList<int, string[]> столбцыКмз = new SortedList<int, string[]>();
            string[] нулевойСтолбецКмз = new string[2];
            нулевойСтолбецКмз[0] = "Варианты";
            нулевойСтолбецКмз[1] = "Варианты";
            foreach (int i in векторВажностиКритериев.Keys)
            {
                столбцыКмз.Add(i + 1, new string[2]);
                столбцыКмз[i + 1][0] = "K" + (i + 1);
                столбцыКмз[i + 1][1] = "K" + (i + 1);
            }
            foreach (int i in модифицированныеЗначенияКритериев.Keys)
            {
                строкиКмз.Add(i, "x" + (i + 1));
            }
            formDataGridViewМодифицированныеЗначенияКритериев.Visible = true;
            formDataGridViewМодифицированныеЗначенияКритериев.DoubleЗаполнение(
                модифицированныеЗначенияКритериев, строкиКмз, столбцыКмз);
            #endregion

            #region Вычисление и вывод множества несравнимых решений
            SortedList<int, SortedList<int, double>> множествоНесравнимыхРешений =
               ВычислениеМатрицыМножестваНесравнимыхМеждуСобойРешенийXMin(модифицированныеЗначенияКритериев);
            FormDataGridView formDataGridViewМножествоНесравнимыхРешений = new FormDataGridView();
            formDataGridViewМножествоНесравнимыхРешений.Text = "Множество несравнимых решений";
            SortedList<int, string> строкиXнр = new SortedList<int, string>();
            SortedList<int, string[]> столбцыXнр = new SortedList<int, string[]>();
            foreach (int i in векторВажностиКритериев.Keys)
            {
                столбцыXнр.Add(i, new string[2]);
                столбцыXнр[i][0] = "K" + (i+1);
                столбцыXнр[i][1] = "K" + (i+1);
            }

            foreach (int i in множествоНесравнимыхРешений.Keys)
            {
                строкиXнр.Add(i, "x" + (i + 1));
            }
            formDataGridViewМножествоНесравнимыхРешений.Visible = true;
            formDataGridViewМножествоНесравнимыхРешений.DoubleЗаполнение(
                множествоНесравнимыхРешений, строкиXнр, столбцыXнр);
            #endregion

            if (матрицаСкалярныхОценок[0].Count == 2)
            {
                #region Построение графика

                
                График график = new График();
                график.Visible = true;

                график.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
                график.chart1.ChartAreas[0].Axes[0].Maximum = Math.Max((int)матрицаСкалярныхОценок[0].Values.Max(), (int)модифицированныеЗначенияКритериев[0].Values.Max())+1;
                график.chart1.ChartAreas[0].Axes[0].Minimum = Math.Min((int)матрицаСкалярныхОценок[0].Values.Min(),(int)модифицированныеЗначенияКритериев[0].Values.Min());
                график.chart1.ChartAreas[0].Axes[1].Maximum = Math.Max((int)матрицаСкалярныхОценок[1].Values.Max(), (int)модифицированныеЗначенияКритериев[1].Values.Max())+1;
                график.chart1.ChartAreas[0].Axes[1].Minimum = Math.Min((int)матрицаСкалярныхОценок[1].Values.Min(), (int)модифицированныеЗначенияКритериев[1].Values.Min());
                for (int i = 0; i < матрицаСкалярныхОценок.Count; i++)
                {
                    график.chart1.Series[0].Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(матрицаСкалярныхОценок[i][0], матрицаСкалярныхОценок[i][1]));
                    график.chart1.Series[0].Points[i].Label = i+"";
                    график.chart1.Series[0].Label = i + "";
                }
                
                график.chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
                график.chart2.ChartAreas[0].Axes[0].Maximum = Math.Max((int)матрицаСкалярныхОценок[0].Values.Max(), (int)модифицированныеЗначенияКритериев[0].Values.Max())+1;
                график.chart2.ChartAreas[0].Axes[0].Minimum = Math.Min((int)матрицаСкалярныхОценок[0].Values.Min(), (int)модифицированныеЗначенияКритериев[0].Values.Min());
                график.chart2.ChartAreas[0].Axes[1].Maximum = Math.Max((int)матрицаСкалярныхОценок[1].Values.Max(), (int)модифицированныеЗначенияКритериев[1].Values.Max())+1;
                график.chart2.ChartAreas[0].Axes[1].Minimum = Math.Min((int)матрицаСкалярныхОценок[1].Values.Min(), (int)модифицированныеЗначенияКритериев[1].Values.Min());
                for (int i = 0; i < модифицированныеЗначенияКритериев.Count; i++)
                {
                    график.chart2.Series[0].Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(модифицированныеЗначенияКритериев[i][0], модифицированныеЗначенияКритериев[i][1]));
                }
                график.chart3.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
                график.chart3.ChartAreas[0].Axes[0].Maximum = Math.Max((int)матрицаСкалярныхОценок[0].Values.Max(), (int)модифицированныеЗначенияКритериев[0].Values.Max())+1;
                график.chart3.ChartAreas[0].Axes[0].Minimum = Math.Min((int)матрицаСкалярныхОценок[0].Values.Min(), (int)модифицированныеЗначенияКритериев[0].Values.Min());
                график.chart3.ChartAreas[0].Axes[1].Maximum = Math.Max((int)матрицаСкалярныхОценок[1].Values.Max(), (int)модифицированныеЗначенияКритериев[1].Values.Max())+1;
                график.chart3.ChartAreas[0].Axes[1].Minimum = Math.Min((int)матрицаСкалярныхОценок[1].Values.Min(), (int)модифицированныеЗначенияКритериев[1].Values.Min());
                foreach (int i in множествоНесравнимыхРешений.Keys)
                {
                    график.chart3.Series[0].Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(множествоНесравнимыхРешений[i][0], множествоНесравнимыхРешений[i][1]));
                }
                #endregion
            }
        }
        private void buttonВыход_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void dataGridViewСкалярныеОценки_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dataGridViewСкалярныеОценки.Rows[dataGridViewСкалярныеОценки.Rows.Count - 1].HeaderCell.Value = "x" + dataGridViewСкалярныеОценки.Rows.Count;
        }
        public SortedList<int, SortedList<int, double>> СчитываниеМатрицыСкалярныхОценок()
        {
            SortedList<int, SortedList<int, double>> матрицаСкалярныхОценок = new SortedList<int, SortedList<int, double>>();
            for (int i = 0; i < dataGridViewСкалярныеОценки.Rows.Count - 1; i++)
            {
                матрицаСкалярныхОценок.Add(i, new SortedList<int, double>());
                for (int j = 0; j < dataGridViewСкалярныеОценки.Columns.Count; j++)
                {
                    double result = 0;
                    if (double.TryParse(dataGridViewСкалярныеОценки.Rows[i].Cells[j].Value+"", out result) == true)
                    {
                        матрицаСкалярныхОценок[i].Add(j, result);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка оценках");
                        return null;
                    }
                }
            }
            return матрицаСкалярныхОценок;
        }
        public SortedList<int, double> СчитываниеВектораВажностиКритериев()
        {
            SortedList<int, double> векторВажностиКритериев = new SortedList<int, double>();
            for (int j = 0; j < dataGridViewВажности.Columns.Count; j++)
            {
                double result = 0;
                if (double.TryParse(dataGridViewВажности.Rows[0].Cells[j].Value+"", out result) == true)
                {
                    векторВажностиКритериев.Add(j, result);
                }
            }
            return векторВажностиКритериев;
        }
        public SortedList<int, SortedList<int, double>> ВычислениеМатрицыКоэфициентовОтносительнойВажностиQij(
            SortedList<int, double> векторВажностиКритериев)
        {
            SortedList<int, SortedList<int, double>> матрицаКоэффициентовОтносительнойВажностиКритериевQij = new SortedList<int, SortedList<int, double>>();

            foreach (int i in векторВажностиКритериев.Keys)
            {
                матрицаКоэффициентовОтносительнойВажностиКритериевQij.Add(i, new SortedList<int, double>());
                foreach (int j in векторВажностиКритериев.Keys)
                {
                    матрицаКоэффициентовОтносительнойВажностиКритериевQij[i].Add(j,
                        (double)векторВажностиКритериев[j] / (double)(векторВажностиКритериев[i] + векторВажностиКритериев[j]));
                }
            }
            return матрицаКоэффициентовОтносительнойВажностиКритериевQij;
        }
        public SortedList<int, SortedList<int, double>> ВычислениеМатрицыМножестваНесравнимыхМеждуСобойРешенийXMax(
            SortedList<int, SortedList<int, double>> матрицаСкалярныхОценок)
        {
            SortedList<int, SortedList<int, double>> матрицаМножестваНесравнимыхМеждуСобойРешенийX = new SortedList<int, SortedList<int, double>>();
            foreach (int i in матрицаСкалярныхОценок.Keys)
            {
                матрицаМножестваНесравнимыхМеждуСобойРешенийX.Add(i, матрицаСкалярныхОценок[i]);
            }
            foreach (int k in матрицаСкалярныхОценок.Keys)
            {
                foreach (int i in матрицаСкалярныхОценок.Keys)
                {
                    bool kяОценкаБольшеИлиРавнаiйОценки = true;
                    foreach (int j in матрицаСкалярныхОценок[i].Keys)
                    {
                        if (матрицаСкалярныхОценок[k][j] < матрицаСкалярныхОценок[i][j] && i != k)
                        {
                            kяОценкаБольшеИлиРавнаiйОценки = false;
                        }
                    }
                    bool однаjяkйОценкиБольшеОднойjйiйОценки = false;
                    if (kяОценкаБольшеИлиРавнаiйОценки == true)
                    {
                        foreach (int j in матрицаСкалярныхОценок[i].Keys)
                        {
                            if (матрицаСкалярныхОценок[k][j] > матрицаСкалярныхОценок[i][j] && i != k)
                            {
                                однаjяkйОценкиБольшеОднойjйiйОценки = true;
                                break;
                            }
                        }
                    }
                    if (kяОценкаБольшеИлиРавнаiйОценки == true && однаjяkйОценкиБольшеОднойjйiйОценки == true)
                    {
                        матрицаМножестваНесравнимыхМеждуСобойРешенийX.Remove(i);
                    }
                }
            }
            return матрицаМножестваНесравнимыхМеждуСобойРешенийX;
        }

        public SortedList<int, SortedList<int, double>> ВычислениеМатрицыМножестваНесравнимыхМеждуСобойРешенийXMin(
           SortedList<int, SortedList<int, double>> матрицаСкалярныхОценок)
        {
            SortedList<int, SortedList<int, double>> матрицаМножестваНесравнимыхМеждуСобойРешенийX = new SortedList<int, SortedList<int, double>>();
            foreach (int i in матрицаСкалярныхОценок.Keys)
            {
                матрицаМножестваНесравнимыхМеждуСобойРешенийX.Add(i, матрицаСкалярныхОценок[i]);
            }
            foreach (int k in матрицаСкалярныхОценок.Keys)
            {
                foreach (int i in матрицаСкалярныхОценок.Keys)
                {
                    bool kяОценкаБольшеИлиРавнаiйОценки = true;
                    foreach (int j in матрицаСкалярныхОценок[i].Keys)
                    {
                        if (матрицаСкалярныхОценок[k][j] > матрицаСкалярныхОценок[i][j] && i != k)
                        {
                            kяОценкаБольшеИлиРавнаiйОценки = false;
                        }
                    }
                    bool однаjяkйОценкиБольшеОднойjйiйОценки = false;
                    if (kяОценкаБольшеИлиРавнаiйОценки == true)
                    {
                        foreach (int j in матрицаСкалярныхОценок[i].Keys)
                        {
                            if (матрицаСкалярныхОценок[k][j] < матрицаСкалярныхОценок[i][j] && i != k)
                            {
                                однаjяkйОценкиБольшеОднойjйiйОценки = true;
                                break;
                            }
                        }
                    }
                    if (kяОценкаБольшеИлиРавнаiйОценки == true && однаjяkйОценкиБольшеОднойjйiйОценки == true)
                    {
                        матрицаМножестваНесравнимыхМеждуСобойРешенийX.Remove(i);
                    }
                }
            }
            return матрицаМножестваНесравнимыхМеждуСобойРешенийX;
        }
        public SortedList<int, SortedList<int, double>> ВычислениеМатрицыВекторныхОценок(
            SortedList<int, SortedList<int, double>> матрицыМножестваНесравнимыхМеждуСобойРешенийX,
            SortedList<int, SortedList<int, double>> матрицаКоэфициэнтовОтносительнойВажности,
            SortedList<int, double> векторВажностиКритериев)
        {
            SortedList<int, SortedList<int, double>> матрицаВекторыхОценок = new SortedList<int, SortedList<int, double>>();

            foreach (int i in матрицыМножестваНесравнимыхМеждуСобойРешенийX.Keys)
            {
                матрицаВекторыхОценок.Add(i, new SortedList<int, double>());
                foreach (int j in матрицыМножестваНесравнимыхМеждуСобойРешенийX[i].Keys)
                {
                    матрицаВекторыхОценок[i].Add(j, матрицыМножестваНесравнимыхМеждуСобойРешенийX[i][j]);
                }
            }
            foreach (int k in матрицыМножестваНесравнимыхМеждуСобойРешенийX.Keys)
            {
                foreach (int i in векторВажностиКритериев.Keys)
                {
                    foreach (int j in векторВажностиКритериев.Keys)
                    {
                        if (векторВажностиКритериев[j] > векторВажностиКритериев[i])
                        {
                            матрицаВекторыхОценок[k][j] = (double)((double)(матрицыМножестваНесравнимыхМеждуСобойРешенийX[k][i] * матрицаКоэфициэнтовОтносительнойВажности[j][i]) +
                                (double)(матрицыМножестваНесравнимыхМеждуСобойРешенийX[k][j] * (1 - матрицаКоэфициэнтовОтносительнойВажности[j][i])));

                        }
                    }
                }
            }
            return матрицаВекторыхОценок;
        }
    }
}
