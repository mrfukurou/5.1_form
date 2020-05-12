using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double f(double x)
        {
            try
            {
                if (Math.Abs(Math.Pow(x, 3) + 8) == 0) throw new Exception();
                else return 3 / (Math.Abs(Math.Pow(x, 3) + 8));
            }
            catch
            {
                throw;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(Aa.Text);
                double b = double.Parse(Bb.Text);
                double h = double.Parse(Hh.Text);
                if (b < a || h < 0) throw new Exception();
                for (double i = a; i <= b; i += h)
                    try
                    {
                        rez.Text += "y(";
                        rez.Text += i;
                        rez.Text += ") = ";
                        rez.Text += f(i);
                        rez.Text += Environment.NewLine;
                    }
                    catch
                    {
                        rez.Text += "error";
                        rez.Text += Environment.NewLine;
                    }
            }
            catch (FormatException)
            {
                rez.Text += Convert.ToString("Неверный формат ввода данных");
            }
            catch
            {
                rez.Text += Convert.ToString("Некорректный ввод данных!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Aa.Clear();
            Bb.Clear();
            Hh.Clear();
            rez.Clear();
        }
    }
}
