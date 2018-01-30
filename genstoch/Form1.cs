using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static alglib.evd;
using ExtendedFunctions;

namespace GenStoch
{
    public partial class Form1 : Form
    {
        public static int count;
        public static double[,] M;
        public static double[] EigenNumbers;
        public static double[,] EigenVec;
        double[] rndseq;

        public Form1()
        {
            InitializeComponent();
            cmboxDim.SelectedIndex = 0;
        }
        //Заполнение транспанированной матрицы
        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0, q = 1;
            bool succes;
            double[,] tmp = new double[count, count];

            while (k < rndseq.Length)
            {
                for (int i = 0; i < count; i++)
                    for (int j = 0; j < count; j++)
                        if (i == j) tmp[i, j] = 0;
                        else if (i < j && (j - i) == 1) tmp[i, j] = rndseq[k + i];
                        else tmp[i, j] = tmp[j, i];

                succes = smatrixevd(tmp, count, 1, true, ref EigenNumbers, ref EigenVec);

                Save_Matrix_Row(Round_Matrix(EigenVec), q);
                q++;
                k += count - 1;
            }
        }
        //Транспонирование матрицы
        double[,] Transpon(double[,] mat)
        {
            double tmp;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    tmp = mat[i, j];
                    mat[i, j] = mat[j, i];
                    mat[j, i] = tmp;
                }
            }
            return mat;
        }
        //Заполнение массива случайными числами длиной count
        double[] Get_Rnd(int count)
        {
            Random r = new Random();
            double[] outrnd = new double[count];
            for (int i = 0; i < count; i++)
                outrnd[i] = Convert.ToDouble(r.Next(-1000, 1000) / 10.0);
            return outrnd;
        }
        //Округление значение вохдной матрицы до 4 знаков
        public static double[,] Round_Matrix(double[,] M)
        {
            double[,] rez = new double[count, count];
            for (int i = 0; i < count; i++)
                for (int j = 0; j < count; j++)
                    rez[i, j] = Math.Round(M[i, j], 4);
            return rez;
        }
        //Запись вектора в файл
        public void Save_Vec(double[] vec)
        {
            StreamWriter str = new StreamWriter("output.txt");
            for (int i = 0; i < vec.Length; i++)
            {
                str.Write(vec[i] + " ");
            }
            str.Close();
        }
        //Запись матрицы в файл 
        public static void Save_Matrix_Row(double[,] matrix, int k)
        {
            StreamWriter str = new StreamWriter($"output{k}.txt");
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                    str.Write(matrix[i, j] + " ");
                str.WriteLine();
            }
            str.Close();
        }
        public static void Save_Matrix_Row(double[,] matrix)
        {
            for (int i = 0; i < count; i++)
                File.AppendAllText("output_1000.txt", matrix[i, 0].ToString().Replace(',', '.') + Environment.NewLine);
        }
        //Открытие формы 3 для задания значений матрицы вручную
        private void button5_Click(object sender, EventArgs e)
        {
            M = new double[count, count];
            if ((new Form3()).ShowDialog() == DialogResult.OK)
            {
                lbStatusbar.Text = M[1,0].ToString();
                lbStatusbar.Text = "Значения базиса заданы.";
            }
        }
        //Посмотреть значение ансамбля
        private void button7_Click(object sender, EventArgs e)
        {
            if ((new Form2()).ShowDialog() == DialogResult.OK)
            {
                
            }
        }
        //Расчет значений ансамбля
        private void button8_Click(object sender, EventArgs e)
        {
            EigenNumbers = new double[count];
            bool work;

            try
            {
                work = smatrixevd(M, count, 1, true, ref EigenNumbers, ref EigenVec);
            }
            catch (Exception ex)
            {
                lbStatusbar.Text = ex.Message;
            }
        }
        //Задать разммерность базиса
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MatrixFunc.SetMatrix(Convert.ToInt32(cmboxDim.SelectedItem));
            count = Convert.ToInt32(cmboxDim.SelectedItem);
        }
        //Генерация n выборок и случайной последовательности rndseq
        private void BtnGenerateSampling_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBox1.Text);
                int rndcount = n * (count - 1);
                rndseq = MatrixFunc.GetRnd(rndcount, -1000, 1000);

                lbStatusbar.Text = "Выборки сгенерированны.";
            }
            catch (Exception ex)
            {
                lbStatusbar.Text = ex.Message;
            }
                   
        }
        //Сохранение вектора в файл
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < rndseq.Length; i++)
                    File.AppendAllText($"output_rndseqCount_{rndseq.Length}.txt", rndseq[i].ToString() + Environment.NewLine);
            }
            catch (Exception ex)
            {
                lbStatusbar.Text = ex.Message;
            }
            
        }
        //Загрузка вектора из файла
        private void button11_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = String.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = File.ReadAllText(openFileDialog1.FileName);
                rndseq = file.Split(new char[] { '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(n => double.Parse(n)).ToArray();
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double[,] a = new double[4, 4] { { 0, 100, 0, 0 }, { 100, 0, 0.1, 0 }, { 0, 0.1, 0, 99 }, { 0, 0, 99, 0 } };
            double[,] z = new double[4, 4];
            double[] d = new double[4];
            bool work;
            work = smatrixevd(a, 4, 1, true, ref d, ref z);
            if (work)
            {
                StreamWriter vec = new StreamWriter("output_test_vec.txt");
                for (int i = 0; i < d.Length; i++)
                {
                    vec.Write(d[i] + " ");
                }
                vec.Close();

                StreamWriter mat = new StreamWriter("output_test_matrix.txt");
                for (int i = 0; i < count; i++)
                {
                    for (int j = 0; j < count; j++)
                        mat.Write(Round_Matrix(z)[i, j] + " ");
                    mat.WriteLine();
                }
                mat.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int k = 0, q = 1;
            bool succes;
            double[,] tmp = new double[count, count];

            while (k < rndseq.Length)
            {
                for (int i = 0; i < count; i++)
                    for (int j = 0; j < count; j++)
                        if (i == j) tmp[i, j] = 0;
                        else if (i < j && (j - i) == 1) tmp[i, j] = rndseq[k + i];
                        else tmp[i, j] = tmp[j, i];

                succes = smatrixevd(tmp, count, 1, true, ref EigenNumbers, ref EigenVec);

                if (succes)
                {
                    Save_Matrix_Row(Round_Matrix(EigenVec));
                    q++;
                    k += count - 1;
                }
                else lbStatusbar.Text = "Ошибка генерации";
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
