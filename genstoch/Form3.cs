using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenStoch
{
    public partial class Form3 : Form
    {
        int razm = Form1.count;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < razm; i++)
                for (int j = 0; j < razm; j++)
                    Form1.M[i, j] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
            Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = razm;
            dataGridView1.ColumnCount = razm;
            for (int i = 0; i < razm; i++)
            {
                dataGridView1.Columns[i].HeaderText = (i + 1).ToString();
                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                for (int j = 0; j < razm; j++)
                    dataGridView1.Rows[i].Cells[j].Value = 0;
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < razm; i++)
                for (int j = 0; j < razm; j++)
                    if (i > j && (i - j) == 1) dataGridView1.Rows[i].Cells[j].Value = dataGridView1.Rows[j].Cells[i].Value;
        }
    }
}
