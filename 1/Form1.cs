using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "2,1"; 
            textBox2.Text = "0,17"; 
            textBox3.Text = "14,59";
                                    
            textBox4.Text = "Лабораторная работа № 2 Щербаненко";
        }
        
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                // Считывание значения X 
                double x = double.Parse(textBox1.Text);
                // Вывод значения X в окно 
                textBox4.Text += Environment.NewLine +
                "X = " + x.ToString();
                // Считывание значения Y 
                double y = double.Parse(textBox2.Text);
                // Вывод значения Y в окно 
                textBox4.Text += Environment.NewLine +
                "Y = " + y.ToString();
                // Считывание значения Z 
                double z = double.Parse(textBox3.Text);
                // Вывод значения Z в окно 
                textBox4.Text += Environment.NewLine +
                "Z = " + z.ToString();
                // Вычисляем арифметическое выражение 
                double a = Math.Tan(x + y) * Math.Tan(x + y);
                double b = Math.Exp(y - z);
                double c = Math.Sqrt(Math.Cos(x * x) + Math.Sin(z * z));
                double u = a - b * c;
                // Выводим результат в окно 
                textBox4.Text += Environment.NewLine +
                "Результат U = " + u.ToString();
            }
        }
    }
}