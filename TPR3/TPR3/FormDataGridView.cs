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
    public partial class FormDataGridView : Form
    {
        public FormDataGridView()
        {
            InitializeComponent();
        }

        public void DoubleЗаполнение(SortedList<int, SortedList<int, double>> матрица, SortedList<int, string> строки, SortedList<int, string[]> столбцы)
        {
            foreach (int i in столбцы.Keys)
            {
                dataGridView.Columns.Add(столбцы[i][0], столбцы[i][1]);
            }
            int k = 0;
            foreach (int i in матрица.Keys)
            {
                int l = 0;
                dataGridView.Rows.Add();
                foreach (int j in матрица[i].Keys)
                {
                    if (строки == null)
                    {
                        dataGridView.Rows[k].Cells[l].Value=Math.Round(матрица[i][j],5).ToString();
                    }
                    else
                    {
                        dataGridView.Rows[k].Cells[l].Value=Math.Round(матрица[i][j],5).ToString();
                    }
                    l++;
                }
                k++;
            }
            k = 0;
            foreach (int i in строки.Keys)
            {
                dataGridView.Rows[k].HeaderCell.Value = строки[i];
                k++;
            }
        }
    }
}
