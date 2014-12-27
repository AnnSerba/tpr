using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView.Rows.Add(3, 2, 2);
            dataGridView.Rows[0].HeaderCell.Value = "x1";
            dataGridView.Rows.Add(5, 6, 4);
            dataGridView.Rows[1].HeaderCell.Value = "x2";
            dataGridView.Rows.Add(5, 3, 3);
            dataGridView.Rows[2].HeaderCell.Value = "x3";
            dataGridView.Rows.Add(8, 4, 4);
            dataGridView.Rows[3].HeaderCell.Value = "x4";
            dataGridView.Rows.Add(6, 2, 6);
            dataGridView.Rows[4].HeaderCell.Value = "x5";
            dataGridView.Rows.Add(3, 8, 5);
            dataGridView.Rows[5].HeaderCell.Value = "x6";
            dataGridView.Rows.Add(6, 4, 3);
            dataGridView.Rows[6].HeaderCell.Value = "x7";
            dataGridView.Rows.Add(2, 5, 2);
            dataGridView.Rows[7].HeaderCell.Value = "x8";
            dataGridView.Rows.Add(9, 2, 5);
            dataGridView.Rows[8].HeaderCell.Value = "x9";
            dataGridView.Rows.Add(3, 5, 2);
            dataGridView.Rows[9].HeaderCell.Value = "x10";
        }

        private void buttonВычислить_Click(object sender, EventArgs e)
        {
            List<List<double>> ЗначениеРешенийИКритериев=Считывание(dataGridView);
            if (ЗначениеРешенийИКритериев != null&&ЗначениеРешенийИКритериев.Count!=0)
            {
                Решение решение = new Решение(ЗначениеРешенийИКритериев, comboBoxНаправлениеПоиска.Text);
                решение.Visible = true;
            }
            
        }
        List<List<double>> Считывание(DataGridView dataGridView)
        {
            List<List<double>> матрица=new List<List<double>>();
            for (int i = 0; i < dataGridView.Rows.Count-1; i++)
            {
                матрица.Add(new List<double>());
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    try
                    {
                        матрица[i].Add(double.Parse(dataGridView.Rows[i].Cells[j].Value.ToString()));
                    }catch(Exception e){
                        MessageBox.Show(e.Message);
                        return null;
                    }
                }
            }
                return матрица;
        }
        private void buttonВыход_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonДобавитьКритерий_Click(object sender, EventArgs e)
        {
            dataGridView.Columns.Add("f" + dataGridView.Columns.Count + "", "f" + dataGridView.Columns.Count + "");
        }

        private void buttonУдалитьКритерий_Click(object sender, EventArgs e)
        {
            if (dataGridView.Columns.Count > 2)
            {
                dataGridView.Columns.Remove("f" + dataGridView.Columns.Count + "");
            }
        }

        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dataGridView.Rows[dataGridView.Rows.Count - 1].HeaderCell.Value="x"+dataGridView.Rows.Count;
        }
    }
}
