using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxX.TextChanged += (s, e) => ValidateInputs();
            textBoxEpsilon.TextChanged += (s, e) => ValidateInputs();
        }

        private void ValidateInputs()
        {
            buttonCalculate.Enabled = 
                !string.IsNullOrWhiteSpace(textBoxX.Text) && 
                !string.IsNullOrWhiteSpace(textBoxEpsilon.Text);
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxX.Text, out double x) || 
                !double.TryParse(textBoxEpsilon.Text, out double epsilon))
            {
                MessageBox.Show("Ошибка ввода! Введите числа.");
                return;
            }

            double sum = 0;
            double term = x; // Первый член ряда (n=0)
            int n = 0;
            
            while (Math.Abs(term) >= epsilon)
            {
                sum += term;
                n++;
                term = -term * x * x / ((2 * n) * (2 * n + 1));
            }

            // Вывод результатов
            labelSinResult.Text = $"Sin(x) = {Math.Sin(x):F15}";
            labelSumResult.Text = $"Сумма ряда = {sum:F15}";
            labelTermsCount.Text = $"Количество членов ряда = {n+1}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}