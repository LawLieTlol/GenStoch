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
            this.btnCalcSampling = new System.Windows.Forms.Button();
            this.lbStatusbar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnManualinput = new System.Windows.Forms.Button();
            this.btnEditSample = new System.Windows.Forms.Button();
            this.cmboxDim = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCalcSample = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnGenerateSampling = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcSampling
            // 
            this.btnCalcSampling.Location = new System.Drawing.Point(5, 18);
            this.btnCalcSampling.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcSampling.Name = "btnCalcSampling";
            this.btnCalcSampling.Size = new System.Drawing.Size(188, 23);
            this.btnCalcSampling.TabIndex = 1;
            this.btnCalcSampling.Text = "Расчет выборок";
            this.btnCalcSampling.UseVisualStyleBackColor = true;
            this.btnCalcSampling.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbStatusbar
            // 
            this.lbStatusbar.AutoSize = true;
            this.lbStatusbar.Location = new System.Drawing.Point(12, 147);
            this.lbStatusbar.Name = "lbStatusbar";
            this.lbStatusbar.Size = new System.Drawing.Size(0, 13);
            this.lbStatusbar.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnManualinput
            // 
            this.btnManualinput.Location = new System.Drawing.Point(79, 79);
            this.btnManualinput.Name = "btnManualinput";
            this.btnManualinput.Size = new System.Drawing.Size(95, 23);
            this.btnManualinput.TabIndex = 8;
            this.btnManualinput.Text = "Задать вручную";
            this.btnManualinput.UseVisualStyleBackColor = true;
            this.btnManualinput.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnEditSample
            // 
            this.btnEditSample.Location = new System.Drawing.Point(102, 46);
            this.btnEditSample.Name = "btnEditSample";
            this.btnEditSample.Size = new System.Drawing.Size(90, 56);
            this.btnEditSample.TabIndex = 10;
            this.btnEditSample.Text = "Править ручную выборки";
            this.btnEditSample.UseVisualStyleBackColor = true;
            this.btnEditSample.Click += new System.EventHandler(this.button7_Click);
            // 
            // cmboxDim
            // 
            this.cmboxDim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxDim.FormattingEnabled = true;
            this.cmboxDim.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmboxDim.Location = new System.Drawing.Point(130, 19);
            this.cmboxDim.Name = "cmboxDim";
            this.cmboxDim.Size = new System.Drawing.Size(42, 21);
            this.cmboxDim.TabIndex = 11;
            this.cmboxDim.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmboxDim);
            this.groupBox1.Controls.Add(this.btnManualinput);
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
            this.groupBox2.Controls.Add(this.btnCalcSample);
            this.groupBox2.Controls.Add(this.btnEditSample);
            this.groupBox2.Controls.Add(this.btnCalcSampling);
            this.groupBox2.Location = new System.Drawing.Point(384, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 108);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Расчет ансамбля";
            // 
            // btnCalcSample
            // 
            this.btnCalcSample.Location = new System.Drawing.Point(6, 46);
            this.btnCalcSample.Name = "btnCalcSample";
            this.btnCalcSample.Size = new System.Drawing.Size(90, 56);
            this.btnCalcSample.TabIndex = 11;
            this.btnCalcSample.Text = "Расчет ручной выборки ";
            this.btnCalcSample.UseVisualStyleBackColor = true;
            this.btnCalcSample.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.btnGenerateSampling);
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(198, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 108);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ГПСЧ";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(6, 79);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 4;
            this.button11.Text = "Загрузить";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(98, 79);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 3;
            this.button10.Text = "Сохранить";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnGenerateSampling
            // 
            this.btnGenerateSampling.Location = new System.Drawing.Point(6, 51);
            this.btnGenerateSampling.Name = "btnGenerateSampling";
            this.btnGenerateSampling.Size = new System.Drawing.Size(167, 23);
            this.btnGenerateSampling.TabIndex = 2;
            this.btnGenerateSampling.Text = "Сгенерировать выборки";
            this.btnGenerateSampling.UseVisualStyleBackColor = true;
            this.btnGenerateSampling.Click += new System.EventHandler(this.BtnGenerateSampling_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 26);
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
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 24);
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
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начальнуюПСПToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(535, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 38);
            this.button2.TabIndex = 16;
            this.button2.Text = "Тест";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(384, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 38);
            this.button3.TabIndex = 17;
            this.button3.Text = "Сгенерировать конечную выборку";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(594, 197);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbStatusbar);
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

        private System.Windows.Forms.Button btnCalcSampling;
        private System.Windows.Forms.Label lbStatusbar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnManualinput;
        private System.Windows.Forms.Button btnEditSample;
        private System.Windows.Forms.ComboBox cmboxDim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCalcSample;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGenerateSampling;
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
    }
}

