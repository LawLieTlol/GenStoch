using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenStoch
{
    public partial class Form2 : Form
    {
        
        int razm = Form1.count;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Show_Matrix(Form1.Round_Matrix(Form1.EigenVec));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        //double[,] Round_Matrix(double[,] M)
        //{
        //    double[,] rez = new double[razm,razm];
        //    for (int i = 0; i < razm; i++)
        //        for (int j = 0; j < razm; j++)
        //            rez[i, j] = Math.Round(M[i, j], 4);
        //    return rez;
        //}

        public void Show_Matrix(double[,] M)
        {
            dataGridView1.RowCount = M.GetLength(0);
            dataGridView1.ColumnCount = M.GetLength(1);
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(0); j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = M[i, j];
                    dataGridView1.Columns[j].HeaderText = (j + 1).ToString();
                }
                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.Save_Matrix(Form1.Round_Matrix(Form1.EigenVec), 99);
        }
    }
}
