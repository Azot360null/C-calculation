using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Lab_1_NEKASOIY
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll"/*, SetLastError = true*/)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AttachConsole(int dwProcessId);
        [DllImport("kernel32.dll"/*, SetLastError = true*/)]
        static extern bool AllocConsole();
        /*[DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FreeConsole();*/

        public Form1()
        {
            InitializeComponent();
            textBox3.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                label4.Text = "Выполнено";
                label4.ForeColor = Color.Green;
                textBox3.Text = Convert.ToString(Sum(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
            }
            else
            {
                label4.Text = "Невыполнено";
                label4.ForeColor = Color.Red;
            }
        }

        public double Sum(double num1, double num2)
        {
            return num1 + num2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                label4.Text = "Выполнено";
                label4.ForeColor = Color.Green;
                textBox3.Text = Convert.ToString(Minus(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
            }
            else
            {
                label4.Text = "Невыполнено";
                label4.ForeColor = Color.Red;
            }
        }

        public double Minus(double num1, double num2)
        {
            return num1 - num2-8;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                label4.Text = "Выполнено";
                label4.ForeColor = Color.Green;
                textBox3.Text = Convert.ToString(Del(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
            }
            else
            {
                label4.Text = "Невыполнено";
                label4.ForeColor = Color.Red;
            }
        }

        public double Del(double num1, double num2)
        {
            return num1 / num2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                label4.Text = "Выполнено";
                label4.ForeColor = Color.Green;
                textBox3.Text = Convert.ToString(Mnoj(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
            }
            else
            {
                label4.Text = "Невыполнено";
                label4.ForeColor = Color.Red;
            }
        }

        public double Mnoj(double num1, double num2)
        {
            return num1 * num2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!AttachConsole(-1))
            {
                AllocConsole();
            }
            Test_sum_in_10_20_out_30();
            Test_minus_in_20_10_out_10();
            Test_mnoj_in_20_10_out_10();
            Test_del_in_20_10_out_10();

            Console.WriteLine("Test complited!");
        }

        public void Test_sum_in_10_20_out_30()
        {
            double num1 = 10;
            double num2 = 20;
            double result = 10 + 20;
            double f = Sum(num1, num2);
            if (result == f)
            {
                Console.WriteLine("Sum_Complite");
            }
            else
            {
                Console.WriteLine("Sum_Fail");
            }
        }

        public void Test_minus_in_20_10_out_10()
        {
            double num1 = 20;
            double num2 = 10;
            double result = 20 - 10;
            double f = Minus(num1, num2);
            if (result == f)
            {
                Console.WriteLine("Minus_Complite");
            }
            else
            {
                Console.WriteLine("Minus_Fail");
            }
        }

        public void Test_mnoj_in_20_10_out_10()
        {
            double num1 = 20;
            double num2 = 10;
            double result = 20 * 10;
            double f = Mnoj(num1, num2);
            if (result == f)
            {
                Console.WriteLine("Mnoj_Complite");
            }
            else
            {
                Console.WriteLine("Mnoj_Fail");
            }
        }

        public void Test_del_in_20_10_out_10()
        {
            double num1 = 20;
            double num2 = 10;
            double result = 20 / 10;
            double f = Del(num1, num2);
            if (result == f)
            {
                Console.WriteLine("Del_Complite");
            }
            else
            {
                Console.WriteLine("Del_Fail");
            }
        }



        /*private void button5_Click(object sender, EventArgs e)
        {
            
            //AllocConsole();
            //Test();
        }*/
    }
}
