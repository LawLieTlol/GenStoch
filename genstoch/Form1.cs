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
        public static int n;
        public static double[,] M;
        public static double[] EigenNumbers;
        public static double[,] EigenVec;
        StreamWriter str;
        string path = "Results/";
        //RNG vars
        int hi = 10;
        int lo = 0;
        int[] rngseq;
        int rndcount;
        int seed;
        int range = 1000;
        string curRng;

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 3;
            //maskedTextBox1.Mask = "000";
        }
        //Заполнение транспанированной матрицы
        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0, q = 1;
            //bool succes;
            double[,] tmp = new double[count, count];

            while (k < rngseq.Length)
            {
                for (int i = 0; i < count; i++)
                    for (int j = 0; j < count; j++)
                        if (i == j) tmp[i, j] = 0;
                        else if (i < j && (j - i) == 1) tmp[i, j] = rngseq[k + i];
                        else tmp[i, j] = tmp[j, i];

                smatrixevd(tmp, count, 1, true, ref EigenNumbers, ref EigenVec);

                Save_Matrix(Round_Matrix(EigenVec), q);
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
        //Округление значение входной матрицы до 4 знаков
        public static double[,] Round_Matrix(double[,] M)
        {
            double[,] rez = new double[count, count];
            for (int i = 0; i < count; i++)
                for (int j = 0; j < count; j++)
                    rez[i, j] = Math.Round(M[i, j], 4);
            return rez;
        }
        //Запись вектора в файл
        public void Save_Vec(int[] vec, string rngMethod)
        {
            for (int i = 0; i < vec.Length; i++)
                File.AppendAllText(path + $"{rngMethod}_{rndcount}.txt", vec[i].ToString().Replace(',', '.') + Environment.NewLine);
        }

        //Запись матрицы в файл 
        public static void Save_Matrix(double[,] matrix, int k)
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
        //Запись первой строки симметрической матрицы в файл
        public void Save_Matrix_Row(double[,] matrix, string currentRng)
        {
            for (int i = 0; i < count; i++)
                File.AppendAllText(path + $"output_{currentRng}_{count * n}.txt", matrix[i, 0].ToString().Replace(',', '.') + Environment.NewLine);
        }

        //Открытие формы 3 для задания значений матрицы вручную
        private void button5_Click(object sender, EventArgs e)
        {
            M = new double[count, count];
            if ((new Form3()).ShowDialog() == DialogResult.OK)
            {
                label1.Text = M[1, 0].ToString();
                label1.Text = "Значения базиса заданы.";
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
                label1.Text = ex.Message;
            }
        }
        //Задать разммерность базиса
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MatrixFunc.SetMatrix(Convert.ToInt32(comboBox1.SelectedItem));
            count = Convert.ToInt32(comboBox1.SelectedItem);
        }
        //Удалить все txt и dat файлы в path
        private void button9_Click(object sender, EventArgs e)
        {
            string supportedExtensions = "*.txt,*.dat";
            bool del = false;
            foreach (string file in Directory.GetFiles(path, "*.*",
                SearchOption.AllDirectories).Where(s => supportedExtensions.Contains(Path.GetExtension(s).ToLower())))
            {
                File.Delete(file);
                del = true;
            }
            if (del)
                label1.Text = "Все файлы *.dat и *.txt удалены.";
            else label1.Text = "В папке Results нет ни одного файла";

        }
        //Поменять расширение у всех файлов в папке Results.
        private void button10_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(path, "*.*");
            try
            {
                foreach (string file in files)
                    if (file.Contains(".dat"))
                        continue;
                    else File.Copy(file, $"{file.Substring(0, file.Length - 3)}" + "dat", true);
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }
        //Загрузка вектора из файла
        private void button11_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = String.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = File.ReadAllText(openFileDialog1.FileName);
                rngseq = file.Split(new char[] { '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //Test btn
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
        //Рассчет конечной выборки!
        private void button3_Click(object sender, EventArgs e)
        {
            int k = 0, q = 1;
            bool succes;
            double[,] tmp = new double[count, count];

            while (k < rngseq.Length)
            {
                for (int i = 0; i < count; i++)
                    for (int j = 0; j < count; j++)
                        if (i == j) tmp[i, j] = 0;
                        else if (i < j && (j - i) == 1) tmp[i, j] = rngseq[k + i];
                        else tmp[i, j] = tmp[j, i];

                succes = smatrixevd(tmp, count, 1, true, ref EigenNumbers, ref EigenVec);

                if (succes)
                {
                    Save_Matrix_Row(Round_Matrix(EigenVec), curRng);
                    q++;
                    k += count - 1;
                }
                else label1.Text = "Ошибка генерации";
            }
        }

        private void алгоритмаЛемераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LehmerRNG
            seed = Environment.TickCount;
            label4.Text = seed.ToString();
            LehmerRng lehmer = new LehmerRng(seed);
            rngseq = new int[rndcount];
            for (int i = 0; i < rndcount; i++)
            {
                double x = lehmer.Next();
                //int ri = (int)((hi - lo) * x + lo); // 0 to 9
                rngseq[i] = (int)(x * range);
            }

            curRng = "LehmerRng";
            Save_Vec(rngseq, curRng);
        }

        private void алгоритмФибоначчиСЗапаздываниямиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LaggedFibRNG
            seed = Environment.TickCount;
            LaggedFibRng laggedfib = new LaggedFibRng(seed);
            rngseq = new int[rndcount];
            for (int i = 0; i < rndcount; ++i)
            {
                double x = laggedfib.Next();
                //int ri = (int)((hi - lo) * x + lo); // 0 to 9
                rngseq[i] = (int)(x * range);
            }

            curRng = "LaggedFibRng";
            Save_Vec(rngseq, curRng);
        }

        private void линейныйКонгруэнтныйАлгоритмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LinearConRNG
            seed = Environment.TickCount;
            LinearConRng lincon = new LinearConRng(seed);
            rngseq = new int[rndcount];
            for (int i = 0; i < rndcount; ++i)
            {
                double x = lincon.Next();
                //int ri = (int)((hi - lo) * x + lo); // 0 to 9
                rngseq[i] = (int)(x * range);
            }

            curRng = "LinearConRng";
            Save_Vec(rngseq, curRng);
        }

        private void алгоритмВичманаХиллаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //WichmannRNG
            seed = Environment.TickCount;
            WichmannRng wich = new WichmannRng(seed / 30000);
            rngseq = new int[rndcount];
            for (int i = 0; i < rndcount; ++i)
            {
                double x = wich.Next();
                //int ri = (int)((hi - lo) * x + lo); // от 0 до 9
                rngseq[i] = (int)(x * range);
            }

            curRng = "WichmannRng";
            Save_Vec(rngseq, curRng);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            n = Convert.ToInt32(textBox1.Text);
            rndcount = n * (count - 1);
            label4.Text = rndcount.ToString();
        }

        private void стандартныйRandomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                rngseq = MatrixFunc.GetRndInt(rndcount, 0, range);
                curRng = "DefaultRng";
                Save_Vec(rngseq, curRng);
                label1.Text = "Выборки сгенерированны.";
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label4.Visible = true;
                button4.Visible = true;
            }
            else
            {
                label4.Visible = false;
                button4.Visible = false;
            }
        }
        //Фильтр ввода данных в txtBox
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if (Directory.GetFiles(path, "*.*")
            //    .Where(s => "*.dat".Contains(Path.GetExtension(s).ToLower())))
        }
    }
}
