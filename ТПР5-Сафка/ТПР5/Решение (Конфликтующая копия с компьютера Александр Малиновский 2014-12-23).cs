﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ТПР5
{
    public partial class Решение : Form
    {
        public Решение(List<List<double>> значенияРешенийИКритериев, string направлениеПоиска)
        {
            InitializeComponent();
            ЗаполнениеМатрицы(значенияРешенийИКритериев, dataGridView, "f", "x");
            List<double> значенияИдеальнойТочки = ВычислениеЗначенийИдеальнойТочки(значенияРешенийИКритериев,направлениеПоиска);
            ЗаполнениеСтроки(значенияИдеальнойТочки, dataGridViewЗначенияТочкиУтопии, "f");
            List<List<double>> матрицаНесравнимыхМеждуСобойРешений;
            if (направлениеПоиска == "Максимум")
            {
                матрицаНесравнимыхМеждуСобойРешений = ВычислениеМатрицыМножестваНесравнимыхМеждуСобойРешенийXMax(значенияРешенийИКритериев);
            }
            else
            {
                матрицаНесравнимыхМеждуСобойРешений = ВычислениеМатрицыМножестваНесравнимыхМеждуСобойРешенийXMin(значенияРешенийИКритериев);
            }
            ЗаполнениеМатрицы(матрицаНесравнимыхМеждуСобойРешений, dataGridViewНесравнимыеРешения, "f", "x");
            List<double> растояниеДоИдеальнойТочки = ВычислениеРастоянияДоИдеальнойТочки(значенияИдеальнойТочки, матрицаНесравнимыхМеждуСобойРешений);
            ЗаполнениеСтолбца(растояниеДоИдеальнойТочки,dataGridViewРастояниеДоИдеальнойТочки,"x");
            dataGridViewРастояниеДоИдеальнойТочки.Rows[растояниеДоИдеальнойТочки.IndexOf(растояниеДоИдеальнойТочки.Min())].Cells[0].Style.BackColor = Color.Red;
        }

        void ЗаполнениеМатрицы(List<List<double>> матрица,DataGridView dataGridView,string nameColumns,string nameRows)
        {
            for (int i = 0; i < матрица[0].Count; i++)
            {
                dataGridView.Columns.Add(nameColumns + (i+1), nameColumns + (i+1));
            }
            for (int i = 0; i < матрица.Count; i++)
            {
                dataGridView.Rows.Add();
                dataGridView.Rows[i].HeaderCell.Value = nameRows+(i+1);
                for (int j = 0; j < матрица[i].Count; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = матрица[i][j]+"";
                }
            }
        }
        void ЗаполнениеСтроки(List<double> вектор, DataGridView dataGridView, string nameColumns)
        {
            for (int i = 0; i < вектор.Count; i++)
            {
                dataGridView.Columns.Add(nameColumns + (i + 1), nameColumns + (i + 1));

            } 
            dataGridView.Rows.Add();
            for (int i = 0; i < вектор.Count; i++)
            {
                dataGridView.Rows[0].Cells[i].Value = вектор[i] + "";
            }
        }

        void ЗаполнениеСтолбца(List<double> вектор, DataGridView dataGridView, string nameRows)
        {
            dataGridView.Columns.Add("Растояние", "Растояние");
            
            for (int i = 0; i < вектор.Count; i++)
            {
                dataGridView.Rows.Add(вектор[i]);
                dataGridView.Rows[i].HeaderCell.Value=nameRows+(i+1);
            }
        }

        List<double> ВычислениеЗначенийИдеальнойТочки(List<List<double>> значенияРешенийИКритериев,string направлениеПоиска)
        {
            List<double> значенияИдеальнойТочки = new List<double>();
            for(int j=0;j<значенияРешенийИКритериев[0].Count;j++)
            {
                значенияИдеальнойТочки.Add(0);
            }
            if (направлениеПоиска == "Максимум")
            {
                for (int i = 0; i < значенияРешенийИКритериев.Count; i++)
                {
                    for (int j = 0; j < значенияРешенийИКритериев[i].Count; j++)
                    {
                        if (значенияРешенийИКритериев[i][j] > значенияИдеальнойТочки[j])
                        {
                            значенияИдеальнойТочки[j] = значенияРешенийИКритериев[i][j];
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < значенияРешенийИКритериев.Count; i++)
                {
                    for (int j = 0; j < значенияРешенийИКритериев[i].Count; j++)
                    {
                        if (значенияРешенийИКритериев[i][j] < значенияИдеальнойТочки[j])
                        {
                            значенияИдеальнойТочки[j] = значенияРешенийИКритериев[i][j];
                        }
                    }
                }
            }
                return значенияИдеальнойТочки;
        }

        public List<List<double>> ВычислениеМатрицыМножестваНесравнимыхМеждуСобойРешенийXMax(
           List<List<double>> матрицаСкалярныхОценок)
        {
            List<List<double>> матрицаМножестваНесравнимыхМеждуСобойРешенийX = new List<List<double>>();
            for (int i = 0; i < матрицаСкалярныхОценок.Count; i++)
            {
                матрицаМножестваНесравнимыхМеждуСобойРешенийX.Add(матрицаСкалярныхОценок[i]);
            }
            for (int k = 0; k < матрицаМножестваНесравнимыхМеждуСобойРешенийX.Count; k++)
            {
                for (int i = 0; i < матрицаМножестваНесравнимыхМеждуСобойРешенийX.Count; i++)
                {
                    bool kяОценкаБольшеИлиРавнаiйОценки = true;
                    for (int j = 0; j < матрицаМножестваНесравнимыхМеждуСобойРешенийX[i].Count; j++)
                    {
                        if (матрицаМножестваНесравнимыхМеждуСобойРешенийX[k][j] < матрицаМножестваНесравнимыхМеждуСобойРешенийX[i][j] && i != k)
                        {
                            kяОценкаБольшеИлиРавнаiйОценки = false;
                            break;
                        }
                    }
                    bool однаjяkйОценкиБольшеОднойjйiйОценки = false;
                    if (kяОценкаБольшеИлиРавнаiйОценки == true)
                    {
                        for (int j = 0; j < матрицаМножестваНесравнимыхМеждуСобойРешенийX[i].Count; j++)
                        {
                            if (матрицаМножестваНесравнимыхМеждуСобойРешенийX[k][j] > матрицаМножестваНесравнимыхМеждуСобойРешенийX[i][j] && i != k)
                            {
                                однаjяkйОценкиБольшеОднойjйiйОценки = true;
                                break;
                            }
                        }
                    }
                    if (kяОценкаБольшеИлиРавнаiйОценки == true && однаjяkйОценкиБольшеОднойjйiйОценки == true)
                    {
                        матрицаМножестваНесравнимыхМеждуСобойРешенийX.RemoveAt(k);
                    }
                }
            }
            return матрицаМножестваНесравнимыхМеждуСобойРешенийX;
        }

        public List<List<double>> ВычислениеМатрицыМножестваНесравнимыхМеждуСобойРешенийXMin(
           List<List<double>> матрицаСкалярныхОценок)
        {
            List<List<double>> матрицаМножестваНесравнимыхМеждуСобойРешенийX = new List<List<double>>();
            for (int i = 0; i < матрицаСкалярныхОценок.Count;i++ )
            {
                матрицаМножестваНесравнимыхМеждуСобойРешенийX.Add(матрицаСкалярныхОценок[i]);
            }
            for (int k = 0; k < матрицаМножестваНесравнимыхМеждуСобойРешенийX.Count; k++)
            {
                for (int i = 0; i < матрицаМножестваНесравнимыхМеждуСобойРешенийX.Count; i++)
                {
                    bool kяОценкаБольшеИлиРавнаiйОценки = true;
                    for (int j = 0; j < матрицаМножестваНесравнимыхМеждуСобойРешенийX[i].Count; j++)
                    {
                        if (матрицаМножестваНесравнимыхМеждуСобойРешенийX[k][j] > матрицаМножестваНесравнимыхМеждуСобойРешенийX[i][j] && i != k)
                        {
                            kяОценкаБольшеИлиРавнаiйОценки = false;
                        }
                    }
                    bool однаjяkйОценкиБольшеОднойjйiйОценки = false;
                    if (kяОценкаБольшеИлиРавнаiйОценки == true)
                    {
                        for (int j = 0; j < матрицаМножестваНесравнимыхМеждуСобойРешенийX[i].Count; j++)
                        {
                            if (матрицаМножестваНесравнимыхМеждуСобойРешенийX[k][j] < матрицаМножестваНесравнимыхМеждуСобойРешенийX[i][j] && i != k)
                            {
                                однаjяkйОценкиБольшеОднойjйiйОценки = true;
                                break;
                            }
                        }
                    }
                    if (kяОценкаБольшеИлиРавнаiйОценки == true && однаjяkйОценкиБольшеОднойjйiйОценки == true)
                    {
                        матрицаМножестваНесравнимыхМеждуСобойРешенийX.RemoveAt(i);
                    }
                }
            }
            return матрицаМножестваНесравнимыхМеждуСобойРешенийX;
        }

        public List<double> ВычислениеРастоянияДоИдеальнойТочки(List<double> значенияИдеальнойТочки,List<List<double>> множествоНесравнимыххМеждуСобойРешений)
        {
            List<double> растояниеДоИдеальнойТочки = new List<double>();
            for (int i = 0; i < множествоНесравнимыххМеждуСобойРешений.Count; i++)
            {
                растояниеДоИдеальнойТочки.Add(0);
                for (int j = 0; j < множествоНесравнимыххМеждуСобойРешений[i].Count; j++)
                {
                    растояниеДоИдеальнойТочки[i]+=Math.Pow(значенияИдеальнойТочки[j]-множествоНесравнимыххМеждуСобойРешений[i][j],2);
                }
                растояниеДоИдеальнойТочки[i] = Math.Sqrt(растояниеДоИдеальнойТочки[i]);
            }
                return растояниеДоИдеальнойТочки;
        }
    }
}
