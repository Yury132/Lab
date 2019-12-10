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
using System.Diagnostics;
using Lab_5;

namespace DZ
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Выбор файла
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "текстовые файлы|*.txt";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Stopwatch t = new Stopwatch(); 
                t.Start();
                string text = File.ReadAllText(fd.FileName);
                char[] separators = new char[] { ' ', '.', ',', '!', '?', '/', '\t', '\n' };
                string[] textArray = text.Split(separators);
                foreach (string strTemp in textArray)
                {
                    string str = strTemp.Trim();
                    if (!list.Contains(str)) list.Add(str);
                }
                t.Stop(); 
                this.textBox1.Text = t.Elapsed.ToString(); 
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл!");
            }
        }

        private void button2_Click(object sender, EventArgs e) // Четкий поиск
        {
            string word = this.textBoxFind.Text.Trim();
            Levenshtein L = new Levenshtein();

            if(!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            {
                    string wordUpper = word.ToUpper();               
                    List<string> tempList = new List<string>();
                    Stopwatch t = new Stopwatch();
                    t.Start();

                    foreach (string str in list)
                    {
                        if (str.ToUpper().Contains(wordUpper))
                        {
                            tempList.Add(str);
                        }
                    }
                    t.Stop();

                    if (tempList.Count == 0)
                    {
                        this.textBox3.Text = "Слово не найдено!";
                    }
                    else
                    {
                        this.textBox3.Text = t.Elapsed.ToString();
                    }

                    this.listBox1.BeginUpdate();
                    this.listBox1.Items.Clear();
                    foreach (string str in tempList)
                    {
                        this.listBox1.Items.Add(str);
                    }
                    this.listBox1.EndUpdate();                               
            }
            else
            {
                MessageBox.Show("Введите файл и слово для поиска!");
            }
        }

        private void buttonNechetFind_Click(object sender, EventArgs e)
        {
            string word = this.textBoxFind.Text.Trim();

            if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            {
                int maxDist;
                if (!int.TryParse(this.textBoxMaxDistanceNechet.Text.Trim(), out maxDist))
                {
                    MessageBox.Show("Необходимо указать максимальное расстояние");
                    return;
                }
                if (maxDist < 1 || maxDist > 5)
                {
                    MessageBox.Show("Максимальное расстояние должно быть в диапазоне от 1 до 5");
                    return;
                }
                int ThreadCount;
                if (!int.TryParse(this.textBoxNumberOfPotoks1.Text.Trim(), out ThreadCount))
                {
                    MessageBox.Show("Необходимо указать количество потоков");
                    return;
                }
                Stopwatch timer = new Stopwatch(); 
                timer.Start();

                List<ParallelSearchResult> Result = new List<ParallelSearchResult>();




            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска");
            }
        }
    }
}
