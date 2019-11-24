using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Functions2
{
    public partial class Form1 : Form
    {
        Random r;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public double delenie(int first, int second)
        {
            return Convert.ToDouble(first) / Convert.ToDouble(second);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = delenie(5, 2).ToString();
        }
        
        public double ostatok (int a, int b)
        {
            return a % b;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = ostatok(37, 24).ToString();
        }

        public void ChisloMax (int i, int j)
        {
            if(i > j)
            {
                richTextBox1.Text = i.ToString();
            }
            else
            {
                richTextBox1.Text = j.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChisloMax(10, 8);
        }

        public int Stroka(string stroka)
        {
            return stroka.Length;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Stroka("Hello world!").ToString();
        }

        public void Massive(List<int> mas)
        {
            for (int i = 0; i < mas.Count; i++)
            {
                richTextBox1.Text += mas[i] + "\n";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            r = new Random();
            List<int> list1 = new List<int>();
            for (int i = 0; i < 15; i++)
            {
                list1.Add(r.Next(-100, 100));
            }
            Massive(list1);
        }
        /*Создать функцию которая принимает массив из 5 чисел от -1000 до 1000.
         * 
          
         */
    }
}
