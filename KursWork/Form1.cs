using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == '-')) && !((e.KeyChar == ',')))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == '-')) && !((e.KeyChar == ',')))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == '-')) && !((e.KeyChar == ',')))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == '-')) && !((e.KeyChar == ',')))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count1 = 0, count2 = 0;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            Random rnd = new Random();
            double xmin, xmax, dx, x, a, q, f;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Заповніть всі поля даними!","Помилка!");
            }
            else
            {
                xmin = Convert.ToDouble(textBox1.Text);
                xmax = Convert.ToDouble(textBox2.Text);
                dx = Convert.ToDouble(textBox3.Text);
                a = Convert.ToDouble(textBox4.Text);
                q = rnd.NextDouble() * 1.1;
                textBox7.Text = Convert.ToString(q);
                if (q <= 0 || q > 1)
                {
                    MessageBox.Show("Значення змінної q не відповідає параметрам для розрахунку.", "Помилка!");
                }
                else
                {
                    for (x = xmin; x <= xmax; x += dx)
                    {
                        if (q > 0 && q <= 0.5)
                        {
                            if (q * Math.Sin(x) < 0)
                            {
                                listBox1.Items.Add("x = " + x.ToString() + " - Помилка ОДЗ! ");
                                //MessageBox.Show("Помилка ОДЗ! q * sin(x) менше 0.", "Помилка!");
                            }
                            else
                            {
                                f = Math.Pow(q * Math.Sin(x), 1.0 / 3);
                                listBox1.Items.Add("x = " + x.ToString() + " f1 = " + f.ToString() + "  ");
                                count1++;
                                textBox5.Text = Convert.ToString(count1);
                                textBox6.Text = Convert.ToString(count2);
                            }
                        }
                        else if (q > 0.5 && q <= 1)
                        {
                            if (x < 0 && a == x)
                            {
                                listBox1.Items.Add("x = " + x.ToString() + " - Помилка ОДЗ! ");
                                //MessageBox.Show("Помилка ОДЗ! x менше 0 та a дорівнює x.", "Помилка!");
                            }
                            else
                            {
                                f = Math.Log(x) / a - x;
                                listBox2.Items.Add("x = " + x.ToString() + " f2 = " + f.ToString() + "  ");
                                count2++;
                                textBox6.Text = Convert.ToString(count2);
                                textBox5.Text = Convert.ToString(count1);
                            }
                        }
                    }
                }
            }
        }
    }
}
