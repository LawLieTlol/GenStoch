namespace GenStoch
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начальнуюПСПToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.гПСЧToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стандартныйRandomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.алгоритмаЛемераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.алгоритмВичманаХиллаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.линейныйКонгруэнтныйАлгоритмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.алгоритмФибоначчиСЗапаздываниямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Расчет выборок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(79, 79);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Задать вручную";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(122, 54);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 48);
            this.button7.TabIndex = 10;
            this.button7.Text = "Править ручную выборку";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "16",
            "32"});
            this.comboBox1.Location = new System.Drawing.Point(130, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(42, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 108);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные базиса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Размерность базиса";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(384, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 108);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Расчет ансамбля";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(9, 54);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 48);
            this.button8.TabIndex = 11;
            this.button8.Text = "Расчет ручной выборки";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(198, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 134);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ГПСЧ";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(6, 105);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 4;
            this.button11.Text = "Загрузить";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(98, 105);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 3;
            this.button10.Text = "Сохранить";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 76);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(167, 23);
            this.button9.TabIndex = 2;
            this.button9.Text = "Сгенерировать выборки";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Количество выборок";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.гПСЧToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начальнуюПСПToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // начальнуюПСПToolStripMenuItem
            // 
            this.начальнуюПСПToolStripMenuItem.Name = "начальнуюПСПToolStripMenuItem";
            this.начальнуюПСПToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.начальнуюПСПToolStripMenuItem.Text = "Начальную ПСП";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 48);
            this.button2.TabIndex = 16;
            this.button2.Text = "Тест";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(393, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 49);
            this.button3.TabIndex = 17;
            this.button3.Text = "Сгенерировать конечную выборку";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(312, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "ClassRng";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // гПСЧToolStripMenuItem
            // 
            this.гПСЧToolStripMenuItem.CheckOnClick = true;
            this.гПСЧToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стандартныйRandomToolStripMenuItem,
            this.алгоритмаЛемераToolStripMenuItem,
            this.алгоритмВичманаХиллаToolStripMenuItem,
            this.линейныйКонгруэнтныйАлгоритмToolStripMenuItem,
            this.алгоритмФибоначчиСЗапаздываниямиToolStripMenuItem});
            this.гПСЧToolStripMenuItem.Name = "гПСЧToolStripMenuItem";
            this.гПСЧToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.гПСЧToolStripMenuItem.Text = "ГПСЧ";
            // 
            // стандартныйRandomToolStripMenuItem
            // 
            this.стандартныйRandomToolStripMenuItem.Name = "стандартныйRandomToolStripMenuItem";
            this.стандартныйRandomToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.стандартныйRandomToolStripMenuItem.Text = "Стандартный Random";
            // 
            // алгоритмаЛемераToolStripMenuItem
            // 
            this.алгоритмаЛемераToolStripMenuItem.Name = "алгоритмаЛемераToolStripMenuItem";
            this.алгоритмаЛемераToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.алгоритмаЛемераToolStripMenuItem.Text = "Алгоритма Лемера";
            this.алгоритмаЛемераToolStripMenuItem.Click += new System.EventHandler(this.алгоритмаЛемераToolStripMenuItem_Click);
            // 
            // алгоритмВичманаХиллаToolStripMenuItem
            // 
            this.алгоритмВичманаХиллаToolStripMenuItem.Name = "алгоритмВичманаХиллаToolStripMenuItem";
            this.алгоритмВичманаХиллаToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.алгоритмВичманаХиллаToolStripMenuItem.Text = "Алгоритм Вичмана-Хилла";
            this.алгоритмВичманаХиллаToolStripMenuItem.Click += new System.EventHandler(this.алгоритмВичманаХиллаToolStripMenuItem_Click);
            // 
            // линейныйКонгруэнтныйАлгоритмToolStripMenuItem
            // 
            this.линейныйКонгруэнтныйАлгоритмToolStripMenuItem.Name = "линейныйКонгруэнтныйАлгоритмToolStripMenuItem";
            this.линейныйКонгруэнтныйАлгоритмToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.линейныйКонгруэнтныйАлгоритмToolStripMenuItem.Text = "Линейный конгруэнтный алгоритм";
            this.линейныйКонгруэнтныйАлгоритмToolStripMenuItem.Click += new System.EventHandler(this.линейныйКонгруэнтныйАлгоритмToolStripMenuItem_Click);
            // 
            // алгоритмФибоначчиСЗапаздываниямиToolStripMenuItem
            // 
            this.алгоритмФибоначчиСЗапаздываниямиToolStripMenuItem.Name = "алгоритмФибоначчиСЗапаздываниямиToolStripMenuItem";
            this.алгоритмФибоначчиСЗапаздываниямиToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.алгоритмФибоначчиСЗапаздываниямиToolStripMenuItem.Text = "Алгоритм Фибоначчи с запаздываниями";
            this.алгоритмФибоначчиСЗапаздываниямиToolStripMenuItem.Click += new System.EventHandler(this.алгоритмФибоначчиСЗапаздываниямиToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(618, 206);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Анализ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem начальнуюПСПToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem гПСЧToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стандартныйRandomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem алгоритмаЛемераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem алгоритмВичманаХиллаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem линейныйКонгруэнтныйАлгоритмToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem алгоритмФибоначчиСЗапаздываниямиToolStripMenuItem;
        private System.Windows.Forms.Label label4;
    }
}

