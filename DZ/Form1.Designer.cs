namespace DZ
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
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxMaxDistanceNechet = new System.Windows.Forms.TextBox();
            this.labelMaxDistanceNechet = new System.Windows.Forms.Label();
            this.buttonNechetFind = new System.Windows.Forms.Button();
            this.textBoxNumberOfPotoks1 = new System.Windows.Forms.TextBox();
            this.labelNumberOfPotoks1 = new System.Windows.Forms.Label();
            this.labelNumberOfPotoks2 = new System.Windows.Forms.Label();
            this.textBoxNumberOfPotoks2 = new System.Windows.Forms.TextBox();
            this.textBoxTimeNechetFind = new System.Windows.Forms.TextBox();
            this.labelTimeNechetFind = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выбрать файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Время чтения из файла";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(364, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(177, 22);
            this.textBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Четкий Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Слово для поиска";
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(364, 118);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(177, 22);
            this.textBoxFind.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Время четкого поиска";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(186, 175);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(141, 22);
            this.textBox3.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 215);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(591, 292);
            this.listBox1.TabIndex = 8;
            // 
            // textBoxMaxDistanceNechet
            // 
            this.textBoxMaxDistanceNechet.Location = new System.Drawing.Point(880, 215);
            this.textBoxMaxDistanceNechet.Name = "textBoxMaxDistanceNechet";
            this.textBoxMaxDistanceNechet.Size = new System.Drawing.Size(136, 22);
            this.textBoxMaxDistanceNechet.TabIndex = 10;
            // 
            // labelMaxDistanceNechet
            // 
            this.labelMaxDistanceNechet.AutoSize = true;
            this.labelMaxDistanceNechet.ForeColor = System.Drawing.Color.Black;
            this.labelMaxDistanceNechet.Location = new System.Drawing.Point(677, 175);
            this.labelMaxDistanceNechet.Name = "labelMaxDistanceNechet";
            this.labelMaxDistanceNechet.Size = new System.Drawing.Size(339, 17);
            this.labelMaxDistanceNechet.TabIndex = 11;
            this.labelMaxDistanceNechet.Text = "Максимальное расстояние для нечеткого поиска:\r\n";
            // 
            // buttonNechetFind
            // 
            this.buttonNechetFind.Location = new System.Drawing.Point(778, 108);
            this.buttonNechetFind.Name = "buttonNechetFind";
            this.buttonNechetFind.Size = new System.Drawing.Size(126, 51);
            this.buttonNechetFind.TabIndex = 12;
            this.buttonNechetFind.Text = "Параллельный нечеткий поиск";
            this.buttonNechetFind.UseVisualStyleBackColor = true;
            this.buttonNechetFind.Click += new System.EventHandler(this.buttonNechetFind_Click);
            // 
            // textBoxNumberOfPotoks1
            // 
            this.textBoxNumberOfPotoks1.Location = new System.Drawing.Point(916, 292);
            this.textBoxNumberOfPotoks1.Name = "textBoxNumberOfPotoks1";
            this.textBoxNumberOfPotoks1.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumberOfPotoks1.TabIndex = 13;
            // 
            // labelNumberOfPotoks1
            // 
            this.labelNumberOfPotoks1.AutoSize = true;
            this.labelNumberOfPotoks1.Location = new System.Drawing.Point(775, 257);
            this.labelNumberOfPotoks1.Name = "labelNumberOfPotoks1";
            this.labelNumberOfPotoks1.Size = new System.Drawing.Size(143, 17);
            this.labelNumberOfPotoks1.TabIndex = 14;
            this.labelNumberOfPotoks1.Text = "Количество потоков";
            // 
            // labelNumberOfPotoks2
            // 
            this.labelNumberOfPotoks2.AutoSize = true;
            this.labelNumberOfPotoks2.Location = new System.Drawing.Point(731, 333);
            this.labelNumberOfPotoks2.Name = "labelNumberOfPotoks2";
            this.labelNumberOfPotoks2.Size = new System.Drawing.Size(235, 17);
            this.labelNumberOfPotoks2.TabIndex = 15;
            this.labelNumberOfPotoks2.Text = "Вычисленное количество потоков\r\n";
            // 
            // textBoxNumberOfPotoks2
            // 
            this.textBoxNumberOfPotoks2.Location = new System.Drawing.Point(915, 361);
            this.textBoxNumberOfPotoks2.Name = "textBoxNumberOfPotoks2";
            this.textBoxNumberOfPotoks2.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumberOfPotoks2.TabIndex = 16;
            // 
            // textBoxTimeNechetFind
            // 
            this.textBoxTimeNechetFind.Location = new System.Drawing.Point(916, 433);
            this.textBoxTimeNechetFind.Name = "textBoxTimeNechetFind";
            this.textBoxTimeNechetFind.Size = new System.Drawing.Size(100, 22);
            this.textBoxTimeNechetFind.TabIndex = 17;
            // 
            // labelTimeNechetFind
            // 
            this.labelTimeNechetFind.AutoSize = true;
            this.labelTimeNechetFind.Location = new System.Drawing.Point(775, 402);
            this.labelTimeNechetFind.Name = "labelTimeNechetFind";
            this.labelTimeNechetFind.Size = new System.Drawing.Size(171, 17);
            this.labelTimeNechetFind.TabIndex = 18;
            this.labelTimeNechetFind.Text = "Время нечеткого поиска";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 673);
            this.Controls.Add(this.labelTimeNechetFind);
            this.Controls.Add(this.textBoxTimeNechetFind);
            this.Controls.Add(this.textBoxNumberOfPotoks2);
            this.Controls.Add(this.labelNumberOfPotoks2);
            this.Controls.Add(this.labelNumberOfPotoks1);
            this.Controls.Add(this.textBoxNumberOfPotoks1);
            this.Controls.Add(this.buttonNechetFind);
            this.Controls.Add(this.labelMaxDistanceNechet);
            this.Controls.Add(this.textBoxMaxDistanceNechet);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxMaxDistanceNechet;
        private System.Windows.Forms.Label labelMaxDistanceNechet;
        private System.Windows.Forms.Button buttonNechetFind;
        private System.Windows.Forms.TextBox textBoxNumberOfPotoks1;
        private System.Windows.Forms.Label labelNumberOfPotoks1;
        private System.Windows.Forms.Label labelNumberOfPotoks2;
        private System.Windows.Forms.TextBox textBoxNumberOfPotoks2;
        private System.Windows.Forms.TextBox textBoxTimeNechetFind;
        private System.Windows.Forms.Label labelTimeNechetFind;
    }
}

