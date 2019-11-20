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

namespace Lab_4
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

        private void button2_Click(object sender, EventArgs e) // Поиск слова
        {
            string word = this.textBox2.Text.Trim();
            if(!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            {
                string wordUpper = word.ToUpper();
                List<string> tempList = new List<string>();
                Stopwatch t = new Stopwatch();
                t.Start();

                foreach (string str in list)
                {
                    if (str.ToUpper().Contains(wordUpper)){
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

        
    }
}
