using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPR4
{
    public partial class Form1 : Form
    {
        public string UnPowered(DataGridView Datagrid, int Row, int Cell)
        {
            return ((double)1 / (double.Parse(Datagrid.Rows[Row].Cells[Cell].Value.ToString()))) + "";

        }

        public Form1()
        {
            InitializeComponent();
            dataGridViewA.Columns.Add("Ai1", "Ai1");
            dataGridViewA.Columns.Add("Ai2", "Ai2");
            dataGridViewA.Columns.Add("Ai3", "Ai3");
            dataGridViewA.Columns.Add("Ai4", "Ai4");
            dataGridViewA.Rows.Add();
            dataGridViewA.Rows.Add();
            dataGridViewA.Rows.Add();
            dataGridViewA.Rows.Add();
            dataGridViewA.Rows[0].Cells[0].Value = "1";
            dataGridViewA.Rows[0].Cells[1].Value = "2";
            dataGridViewA.Rows[0].Cells[2].Value = "6";
            dataGridViewA.Rows[0].Cells[3].Value = "24";
            dataGridViewA.Rows[1].Cells[0].Value = UnPowered(dataGridViewA, 0, 1);
            dataGridViewA.Rows[1].Cells[1].Value = "1";
            dataGridViewA.Rows[1].Cells[2].Value = "2";
            dataGridViewA.Rows[1].Cells[3].Value = "6";
            dataGridViewA.Rows[2].Cells[0].Value = UnPowered(dataGridViewA, 0, 2);
            dataGridViewA.Rows[2].Cells[1].Value = UnPowered(dataGridViewA, 1, 2);
            dataGridViewA.Rows[2].Cells[2].Value = "1";
            dataGridViewA.Rows[2].Cells[3].Value = "2";
            dataGridViewA.Rows[3].Cells[0].Value = UnPowered(dataGridViewA, 0, 3);
            dataGridViewA.Rows[3].Cells[1].Value = UnPowered(dataGridViewA, 1, 3);
            dataGridViewA.Rows[3].Cells[2].Value = UnPowered(dataGridViewA, 2, 3);
            dataGridViewA.Rows[3].Cells[3].Value = "1";
            //21
            dataGridViewA21.Columns.Add("Ai1", "Ai1");
            dataGridViewA21.Columns.Add("Ai2", "Ai2");
            dataGridViewA21.Columns.Add("Ai3", "Ai3");
            dataGridViewA21.Rows.Add();
            dataGridViewA21.Rows.Add();
            dataGridViewA21.Rows.Add();
            dataGridViewA21.Rows[0].Cells[0].Value = "1";
            dataGridViewA21.Rows[0].Cells[1].Value = "3";
            dataGridViewA21.Rows[0].Cells[2].Value = "8";
            dataGridViewA21.Rows[1].Cells[0].Value = UnPowered(dataGridViewA21, 0, 1);
            dataGridViewA21.Rows[1].Cells[1].Value = "1";
            dataGridViewA21.Rows[1].Cells[2].Value = "3";
            dataGridViewA21.Rows[2].Cells[0].Value = UnPowered(dataGridViewA21, 0, 2);
            dataGridViewA21.Rows[2].Cells[1].Value = UnPowered(dataGridViewA21, 1, 2);
            dataGridViewA21.Rows[2].Cells[2].Value = "1";
            //22
            dataGridViewA22.Columns.Add("Ai1", "Ai1");
            dataGridViewA22.Columns.Add("Ai2", "Ai2");
            dataGridViewA22.Columns.Add("Ai3", "Ai3");
            dataGridViewA22.Rows.Add();
            dataGridViewA22.Rows.Add();
            dataGridViewA22.Rows.Add();
            dataGridViewA22.Rows[0].Cells[0].Value = "1";
            dataGridViewA22.Rows[0].Cells[1].Value = "4";
            dataGridViewA22.Rows[0].Cells[2].Value = "9";
            dataGridViewA22.Rows[1].Cells[0].Value = UnPowered(dataGridViewA22, 0, 1);
            dataGridViewA22.Rows[1].Cells[1].Value = "1";
            dataGridViewA22.Rows[1].Cells[2].Value = "4";
            dataGridViewA22.Rows[2].Cells[0].Value = UnPowered(dataGridViewA22, 0, 2);
            dataGridViewA22.Rows[2].Cells[1].Value = UnPowered(dataGridViewA22, 1, 2);
            dataGridViewA22.Rows[2].Cells[2].Value = "1";
            //23
            dataGridViewA23.Columns.Add("Ai1", "Ai1");
            dataGridViewA23.Columns.Add("Ai2", "Ai2");
            dataGridViewA23.Columns.Add("Ai3", "Ai3");
            dataGridViewA23.Rows.Add();
            dataGridViewA23.Rows.Add();
            dataGridViewA23.Rows.Add();
            dataGridViewA23.Rows[0].Cells[0].Value = "1";
            dataGridViewA23.Rows[0].Cells[1].Value = "5";
            dataGridViewA23.Rows[0].Cells[2].Value = "7";
            dataGridViewA23.Rows[1].Cells[0].Value = UnPowered(dataGridViewA23, 0, 1);
            dataGridViewA23.Rows[1].Cells[1].Value = "1";
            dataGridViewA23.Rows[1].Cells[2].Value = "5";
            dataGridViewA23.Rows[2].Cells[0].Value = UnPowered(dataGridViewA23, 0, 2);
            dataGridViewA23.Rows[2].Cells[1].Value = UnPowered(dataGridViewA23, 1, 2);
            dataGridViewA23.Rows[2].Cells[2].Value = "1";
            //24
            dataGridViewA24.Columns.Add("Ai1", "Ai1");
            dataGridViewA24.Columns.Add("Ai2", "Ai2");
            dataGridViewA24.Columns.Add("Ai3", "Ai3");
            dataGridViewA24.Rows.Add();
            dataGridViewA24.Rows.Add();
            dataGridViewA24.Rows.Add();
            dataGridViewA24.Rows[0].Cells[0].Value = "1";
            dataGridViewA24.Rows[0].Cells[1].Value = "6";
            dataGridViewA24.Rows[0].Cells[2].Value = "11";
            dataGridViewA24.Rows[1].Cells[0].Value = UnPowered(dataGridViewA24, 0, 1);
            dataGridViewA24.Rows[1].Cells[1].Value = "1";
            dataGridViewA24.Rows[1].Cells[2].Value = "6";
            dataGridViewA24.Rows[2].Cells[0].Value = UnPowered(dataGridViewA24, 0, 2);
            dataGridViewA24.Rows[2].Cells[1].Value = UnPowered(dataGridViewA24, 1, 2);
            dataGridViewA24.Rows[2].Cells[2].Value = "1";
        }

        private void buttonРешить_Click(object sender, EventArgs e)
        {
            //очистка
            dataGridViewWi.Rows.Clear();
            dataGridViewWi21.Rows.Clear();
            dataGridViewWi22.Rows.Clear();
            dataGridViewWi23.Rows.Clear();
            dataGridViewWi24.Rows.Clear();
            dataGridViewDi.Rows.Clear();
            textBoxLmax21.Clear();
            textBoxLmax22.Clear();
            textBoxLmax23.Clear();
            textBoxLmax24.Clear();
            textBoxIS21.Clear();
            textBoxIS22.Clear();
            textBoxIS23.Clear();
            textBoxIS24.Clear();
            richTextBoxОтвет.Clear();

            List<List<double>> Aij = ReadingDataGrid(dataGridViewA);
            List<double> Wi = FindingWi(Aij);
            FillTheVector(Wi, dataGridViewWi, "W1", "W1`");
            //21
            List<List<double>> Aij21 = ReadingDataGrid(dataGridViewA21);
            List<List<double>> Wi21 = new List<List<double>>();
            Wi21.Add(FindingWi(Aij21));
            FillTheVector(Wi21[0], dataGridViewWi21, "W21", "W21`");
            Wi21.Add(MultMatrixToMetrix(Wi21[0], Aij21));
            FillTheVector(Wi21[1], dataGridViewWi21, "W21", "W21``");
            Wi21.Add(DivVectorToVector(Wi21[1], Wi21[0]));
            FillTheVector(Wi21[2], dataGridViewWi21, "W21", "W21```");
            //
            double Lmax21 = FindigLmax(Wi21[2]);
            textBoxLmax21.Text += Lmax21 + " ";
            double Is21 = FindigIS(Lmax21, Wi21[2].Count);
            textBoxIS21.Text += Is21 + " ";
            //22
            List<List<double>> Aij22 = ReadingDataGrid(dataGridViewA22);
            List<List<double>> Wi22 = new List<List<double>>();
            Wi22.Add(FindingWi(Aij22));
            FillTheVector(Wi22[0], dataGridViewWi22, "W22", "W22`");
            Wi22.Add(MultMatrixToMetrix(Wi22[0], Aij21));
            FillTheVector(Wi22[1], dataGridViewWi22, "W22", "W22``");
            Wi22.Add(DivVectorToVector(Wi22[1], Wi22[0]));
            FillTheVector(Wi22[2], dataGridViewWi22, "W22", "W22```");
            //
            double Lmax22 = FindigLmax(Wi22[2]);
            textBoxLmax22.Text += Lmax22 + " ";
            double Is22 = FindigIS(Lmax22, Wi22[2].Count);
            textBoxIS22.Text += Is22 + " ";
            //23
            List<List<double>> Aij23 = ReadingDataGrid(dataGridViewA23);
            List<List<double>> Wi23 = new List<List<double>>();
            Wi23.Add(FindingWi(Aij23));
            FillTheVector(Wi23[0], dataGridViewWi23, "W23", "W23`");
            Wi23.Add(MultMatrixToMetrix(Wi23[0], Aij23));
            FillTheVector(Wi23[1], dataGridViewWi23, "W23", "W23``");
            Wi23.Add(DivVectorToVector(Wi23[1], Wi23[0]));
            FillTheVector(Wi23[2], dataGridViewWi23, "W23", "W23```");
            //
            double Lmax23 = FindigLmax(Wi23[2]);
            textBoxLmax23.Text += Lmax23 + " ";
            double Is23 = FindigIS(Lmax23, Wi23[2].Count);
            textBoxIS23.Text += Is23 + " ";
            //24
            List<List<double>> Aij24 = ReadingDataGrid(dataGridViewA24);
            List<List<double>> Wi24 = new List<List<double>>();
            Wi24.Add(FindingWi(Aij24));
            FillTheVector(Wi24[0], dataGridViewWi24, "W24", "W24`");
            Wi24.Add(MultMatrixToMetrix(Wi21[0], Aij21));
            FillTheVector(Wi24[1], dataGridViewWi24, "W24", "W24``");
            Wi24.Add(DivVectorToVector(Wi24[1], Wi24[0]));
            FillTheVector(Wi24[2], dataGridViewWi24, "W24", "W24```");
            //
            double Lmax24 = FindigLmax(Wi24[2]);
            textBoxLmax24.Text += Lmax24 + " ";
            double Is24 = FindigIS(Lmax24, Wi24[2].Count);
            textBoxIS24.Text += Is24 + " ";
            List<List<double>> W2ij = new List<List<double>>();
            W2ij.Add(Wi21[2]);
            W2ij.Add(Wi22[2]);
            W2ij.Add(Wi23[2]);
            W2ij.Add(Wi24[2]);
            List<double> D = FindingD(W2ij, Wi);
            FillTheVector(D, dataGridViewDi, "D", "");
            for (int i = 0; i < D.Count; i++)
            {
                if (D[i] == D.Max())
                {
                    richTextBoxОтвет.Text += "D[" + (i + 1) + "] = " + D[i] + "\n";
                }
            }

        }
        public List<double> FindingD(List<List<double>> wij, List<double> wj)
        {
            List<double> D = new List<double>();
            for (int i = 0; i < wij.Count; i++)
            {
                D.Add(0);
                for (int j = 0; j < wij[i].Count; j++)
                {
                    D[i] += wij[i][j] * wj[j];
                }
            }
            return D;
        }
        public double FindigLmax(List<double> Wi2)
        {
            double Lmax = 0;
            for (int i = 0; i < Wi2.Count; i++)
            {
                Lmax += Wi2[i] / Wi2.Count;
            }
            return Lmax;
        }
        public double FindigIS(double Lmax, int n)
        {
            return (Lmax - n) / (n - 1);
        }
        List<List<double>> ReadingDataGrid(DataGridView dataGridView)
        {
            List<List<double>> mtxRead = new List<List<double>>();
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                mtxRead.Add(new List<double>());
                for (int j = 0; j < dataGridView.Rows[i].Cells.Count; j++)
                {
                    mtxRead[i].Add(double.Parse(dataGridView.Rows[i].Cells[j].Value + ""));
                }
            }
            return mtxRead;
        }
        public void FillTheVector(List<double> vect, DataGridView dataGridView, string textColumn, string textRows)
        {
            if (dataGridView.Columns.Count == 0)
            {
                for (int i = 0; i < vect.Count; i++)
                {
                    dataGridView.Columns.Add((i + 1) + textColumn, (i + 1) + textColumn);
                }
            }
            dataGridView.Rows.Add();
            dataGridView.Rows[dataGridView.Rows.Count - 1].HeaderCell.Value = textRows;
            for (int i = 0; i < vect.Count; i++)
            {
                dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[i].Value = vect[i];

            }
        }

        public List<double> FindingWi(List<List<double>> A)
        {
            //1
            List<double> Wi = new List<double>();
            for (int i = 0; i < A.Count; i++)
            {
                Wi.Add(0);
                for (int j = 0; j < A[i].Count; j++)
                {
                    Wi[i] += A[j][i];
                }
                Wi[i] = 1 / Wi[i];
            }
            //2
            double sumObr = 0;
            for (int i = 0; i < A.Count; i++)
            {
                sumObr += Wi[i];
            }
            for (int i = 0; i < A.Count; i++)
            {
                Wi[i] = Wi[i] / sumObr;
            }
            return Wi;
        }

        public List<double> MultMatrixToMetrix(List<double> vector, List<List<double>> matrix)
        {
            List<double> multResult = new List<double>();

            for (int i = 0; i < matrix.Count; i++)
            {
                multResult.Add(0);
                for (int j = 0; j < vector.Count; j++)
                {
                    multResult[i] += vector[i] * matrix[j][i];
                }
            }
            return multResult;
        }

        public List<double> DivVectorToVector(List<double> Vector1, List<double> Vector2)
        {
            List<double> divResult = new List<double>();
            for (int i = 0; i < Vector1.Count; i++)
            {
                divResult.Add(Vector1[i] / Vector2[i]);
            }
            return divResult;
        }


    }
}
