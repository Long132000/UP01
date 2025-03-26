using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ButtonCalculate_Click_1(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBoxX.Text);
                double y = double.Parse(textBoxY.Text);
                double z = Calculator.CalculateZ(x, y);
                labelResult.Text = $"Z = {z}";
            }
            catch (FormatException)
            {
                labelResult.Text = "Ошибка: введите числа!";
            }
            catch (Exception ex)
            {
                labelResult.Text = $"Ошибка: {ex.Message}";
            }
        }
    }
}
