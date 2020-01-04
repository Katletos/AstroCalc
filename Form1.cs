using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;
using System.Runtime.InteropServices;
using System.Globalization;

namespace astranomija
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kepler.Select();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double G = Pow(6.67430, -11);

            if (kepler.Checked)
            {
                double a1, T1, Q1, q1, e1, M1,
                       a2, T2, Q2, q2, e2, M2;
                int x;

                double.TryParse(metroTextBox2.Text, out a2);
                double.TryParse(metroTextBox4.Text, out T2);
                double.TryParse(metroTextBox6.Text, out Q2);
                double.TryParse(metroTextBox8.Text, out q2);
                double.TryParse(metroTextBox10.Text, out e2);
                double.TryParse(metroTextBox12.Text, out M2);

                double.TryParse(metroTextBox1.Text, out a1);                
                double.TryParse(metroTextBox3.Text, out T1);              
                double.TryParse(metroTextBox5.Text, out Q1);               
                double.TryParse(metroTextBox7.Text, out q1);               
                double.TryParse(metroTextBox9.Text, out e1);               
                double.TryParse(metroTextBox11.Text, out M1);
                
                int.TryParse(metroTextBox13.Text, out x);

                M1 = M1 * Pow(10, x);

                try
                {
                    if (M1 != 0 & T1 != 0)
                    { 
                        a1 = Round(Pow(((G * M1 * Pow(T1, 2)) / 4 / Pow(PI, 2)), 1.0 / 3), 5);
                        metroTextBox1.Text = Convert.ToString(a1);
                    }

                    if (q1 != 0 & e1 != 0)
                    {
                        a1 = Round(q1 / (1 - e1), 5);                          
                        metroTextBox1.Text = Convert.ToString(a1);
                    }

                    if (Q1 != 0 & e1 != 0)
                    {
                        a1 = Round(Q1 / (1 - e1), 5);
                        metroTextBox1.Text = Convert.ToString(a1);
                    }

                    if (q1 != 0 & Q1 != 0)
                    {
                        a1 = Round((q1 + Q1) / 2, 5);
                        metroTextBox1.Text = Convert.ToString(a1);
                    }

                    if (T1 != 0)
                    {
                        a1 = Round(Pow(Pow(T1, 2), 1.0 / 3), 5);
                        metroTextBox1.Text = Convert.ToString(a1);
                    }
                    

                    
                    if (a1 != 0 & q1 != 0)
                    {
                         e1 = Round(1 - (q1 / a1), 5);                           
                        metroTextBox9.Text = Convert.ToString(e1);
                    }

                    if (a1 != 0 & Q1 != 0)
                    {
                        e1 = Round(1 - (Q1 / a1), 5);
                        metroTextBox9.Text = Convert.ToString(e1);
                    }
                      
                    if (a1 != 0 & e1 != 0)
                    {
                        q1 = Round(a1 * (1 - e1), 5);
                        metroTextBox7.Text = Convert.ToString(q1);
                    }

                    if (a1 != 0 & Q1 != 0)
                    {
                        q1 = Round(2 * a1 - Q1, 5);
                        metroTextBox7.Text = Convert.ToString(q1);
                    }
    
                    if (a1 != 0 & e1 != 0)
                    {
                        Q1 = Round(a1 * (1 + e1), 5);
                        metroTextBox5.Text = Convert.ToString(Q1);
                    }

                    if (a1 != 0 & q1 != 0)
                    {
                        Q1 = Round(2 * a1 - q1, 5);
                        metroTextBox5.Text = Convert.ToString(Q1);
                    }
                    
                    if (a1 != 0 & T1 != 0)
                    {
                        M1 = Round((4 * Pow(PI, 2) * Pow(a1, 3)) / Pow(T1, 2) / G, 5);
                        metroTextBox11.Text = Convert.ToString(M1);
                    }
                    
                    if (a1 != 0 & M1 != 0)
                    {
                        T1 = Round(Sqrt(Pow(a1, 3) * 4 * Pow(PI, 2) / G / M1), 5);
                         metroTextBox3.Text = Convert.ToString(T1);
                    }                   
                }
                catch 
                { 
                
                }
            }
           
            if (satellite.Checked)
            {
              
            }
        }

        private void metroTextBox1_Enter(object sender, EventArgs e)
        {
            if (kepler.Checked)
            {
                if (metroTextBox1.Text == "Паўвось 1")
                {
                    metroTextBox1.Text = "";
                }
            }

            if (satellite.Checked)
            {
                if (metroTextBox1.Text == "")
                {
                    metroTextBox1.Text = "";
                }
            }
        }

        private void metroTextBox1_Leave(object sender, EventArgs e)
        {
            if (kepler.Checked)
            {
                if (metroTextBox1.Text == "")
                {
                    metroTextBox1.Text = "Паўвось 1";               
                }
            }

            if (satellite.Checked)
            {
                if (metroTextBox1.Text == "")
                {
                    metroTextBox1.Text = "";
                }
            }      
        }

        private void metroTextBox2_Enter(object sender, EventArgs e)
        {
            if (kepler.Checked)
            {
                if (metroTextBox2.Text == "Паўвось 2")
                {
                    metroTextBox2.Text = "";
                }
            }

            if (satellite.Checked)
            {
                if (metroTextBox2.Text == null)
                {
                    metroTextBox2.Text = "";
                }
            }
        }

        private void metroTextBox2_Leave(object sender, EventArgs e)
        {
            if (kepler.Checked)
            {
                if (metroTextBox2.Text == "")
                {
                    metroTextBox2.Text = "Паўвось 2";
                }
            }

            if (satellite.Checked)
            {
                if (metroTextBox2.Text == "")
                {
                    metroTextBox2.Text = "";
                }
            }
        }

        private void metroTextBox3_Enter(object sender, EventArgs e)
        {
            if (kepler.Checked)
            {
                if (metroTextBox3.Text == "Перыяд 1") 
                {
                    metroTextBox3.Text = "";
                }
            }

            if (satellite.Checked)
            {
                if (metroTextBox3.Text == "")
                {
                    metroTextBox3.Text = "";
                }
            }
        }

        private void metroTextBox3_Leave(object sender, EventArgs e)
        {
            if (kepler.Checked)
            {
                if (metroTextBox3.Text == "")
                {
                    metroTextBox3.Text = "Перыяд 1";
                }
            }

            if (satellite.Checked)
            {
                if (metroTextBox3.Text == "")
                {
                    metroTextBox3.Text = "";
                }
            }
        }

        private void metroTextBox4_Enter(object sender, EventArgs e)
        {
            if (kepler.Checked)
            {
                if (metroTextBox4.Text == "Перыяд 2")
                {
                    metroTextBox4.Text = "";
                }
            }

            if (satellite.Checked)
            {
                if (metroTextBox4.Text == "")
                {
                    metroTextBox4.Text = "";
                }
            }
        }

        private void metroTextBox4_Leave(object sender, EventArgs e)
        {
            if (kepler.Checked)
            {
                if (metroTextBox4.Text == "")
                {
                    metroTextBox4.Text = "Перыяд 2";
                }
            }

            if (satellite.Checked)
            {
                if (metroTextBox4.Text == "")
                {
                    metroTextBox4.Text = "";
                }
            }
        }

        private void metroTextBox5_Enter(object sender, EventArgs e)
        {
            if (kepler.Checked)
            {
                if (metroTextBox5.Text == "Апацэнтар 1")
                {
                    metroTextBox5.Text = "";
                }
            }

            if (satellite.Checked)
            {
                if (metroTextBox5.Text == "")
                {
                    metroTextBox5.Text = "";
                }
            }
        }

        private void metroTextBox5_Leave(object sender, EventArgs e)
        {
            if (kepler.Checked)
            {
                if (metroTextBox5.Text == "")
                {
                    metroTextBox5.Text = "Апацэнтар 1";
                }
            }

            if (satellite.Checked)
            {
                if (metroTextBox5.Text == "")
                {
                    metroTextBox5.Text = "";
                }
            }
        }

        private void metroTextBox6_Enter(object sender, EventArgs e)
        {
            if (kepler.Checked)
            {
                if (metroTextBox6.Text == "Апацэнтар 2")
                {
                    metroTextBox6.Text = "";
                }
            }

            if (satellite.Checked)
            {
                if (metroTextBox6.Text == "")
                {
                    metroTextBox6.Text = "";
                }
            }
        }

        private void metroTextBox6_Leave(object sender, EventArgs e)
        {
            if (kepler.Checked)
            {
                if (metroTextBox6.Text == "")
                {
                    metroTextBox6.Text = "Апацэнтар 2";
                }
            }

            if (satellite.Checked)
            {
                if (metroTextBox6.Text == "")
                {
                    metroTextBox6.Text = "";
                }
            }
        }

        private void metroTextBox7_Enter(object sender, EventArgs e)
        {
            if (kepler.Checked)
            {
                if (metroTextBox7.Text == "Перыцэнтар 1")
                {
                    metroTextBox7.Text = "";
                }
            }

            if (satellite.Checked)
            {
                if (metroTextBox7.Text == "")
                {
                    metroTextBox7.Text = "";
                }
            }
        }

        private void metroTextBox7_Leave(object sender, EventArgs e)
        {
            if (kepler.Checked)
            {
                if (metroTextBox7.Text == "")
                {
                    metroTextBox7.Text = "Перыцэнтар 1";
                }
            }

            if (satellite.Checked)
            {
                if (metroTextBox7.Text == "")
                {
                    metroTextBox7.Text = "";
                }
            }
        }

        private void metroTextBox8_Enter(object sender, EventArgs e)
        {
            if (kepler.Checked)
            {
                if (metroTextBox8.Text == "Перыцэнтар 2")
                {
                    metroTextBox8.Text = "";
                }
            }

            if (satellite.Checked)
            {
                if (metroTextBox8.Text == "")
                {
                    metroTextBox8.Text = "";
                }
            }
        }

        private void metroTextBox8_Leave(object sender, EventArgs e)
        {
            if (kepler.Checked)
            {
                if (metroTextBox8.Text == "")
                {
                    metroTextBox8.Text = "Перыцэнтар 2";
                }
            }

            if (satellite.Checked)
            {
                if (metroTextBox8.Text == "")
                {
                    metroTextBox8.Text = "";
                }
            }
        }

        private void metroTextBox9_Enter(object sender, EventArgs e)
        {
            if (kepler.Checked)
            {
                if (metroTextBox9.Text == "Эксцэнтрысітэт 1")
                {
                    metroTextBox9.Text = "";
                }
            }

            if (satellite.Checked)
            {
                if (metroTextBox9.Text == "")
                {
                    metroTextBox9.Text = "";
                }
            }
        }

        private void metroTextBox9_Leave(object sender, EventArgs e)
        {
            if (kepler.Checked)
            {
                if (metroTextBox9.Text == "")
                {
                    metroTextBox9.Text = "Эксцэнтрысітэт 1";
                }
            }

            if (satellite.Checked)
            {
                if (metroTextBox9.Text == "")
                {
                    metroTextBox9.Text = "";
                }
            }
        }

        private void metroTextBox10_Enter(object sender, EventArgs e)
        {
            if (kepler.Checked)
            {
                if (metroTextBox10.Text == "Эксцэнтрысітэт 2")
                {
                    metroTextBox10.Text = "";
                }
            }

            if (satellite.Checked)
            {
                if (metroTextBox10.Text == "")
                {
                    metroTextBox10.Text = "";
                }
            }
        }

        private void metroTextBox10_Leave(object sender, EventArgs e)
        {
            if (kepler.Checked)
            {
                if (metroTextBox10.Text == "")
                {
                    metroTextBox10.Text = "Эксцэнтрысітэт 2";
                }
            }

            if (satellite.Checked)
            {
                if (metroTextBox10.Text == "")
                {
                    metroTextBox10.Text = "";
                }
            }
        }

        private void metroTextBox11_Enter(object sender, EventArgs e)
        {
            if (kepler.Checked)
            {
                if (metroTextBox11.Text == "Маса 1")
                {
                    metroTextBox11.Text = "";
                }
            }

            if (satellite.Checked)
            {
                if (metroTextBox11.Text == "")
                {
                    metroTextBox11.Text = "";
                }
            }
        }

        private void metroTextBox11_Leave(object sender, EventArgs e)
        {
            if (kepler.Checked)
            {
                if (metroTextBox11.Text == "")
                {
                    metroTextBox11.Text = "Маса 1";
                }
            }

            if (satellite.Checked)
            {
                if (metroTextBox11.Text == "")
                {
                    metroTextBox11.Text = "";
                }
            }
        }

        private void metroTextBox12_Enter(object sender, EventArgs e)
        {
            if (kepler.Checked)
            {
                if (metroTextBox12.Text == "Маса 2")
                {
                    metroTextBox12.Text = "";
                }
            }

            if (satellite.Checked)
            {
                if (metroTextBox12.Text == "")
                {
                    metroTextBox12.Text = "";
                }
            }
        }

        private void metroTextBox12_Leave(object sender, EventArgs e)
        {
            if (kepler.Checked)
            {
                if (metroTextBox12.Text == "")
                {
                    metroTextBox12.Text = "Маса 2";
                }
            }

            if (satellite.Checked)
            {
                if (metroTextBox12.Text == "")
                {
                    metroTextBox12.Text = "";
                }
            }
        }

        private void metroTextBox13_Enter(object sender, EventArgs e)
        {
            if (kepler.Checked)
            {
                if (metroTextBox13.Text == "10^n")
                {
                    metroTextBox13.Text = "";
                }
            }

            if (satellite.Checked)
            {
                if (metroTextBox13.Text == "")
                {
                    metroTextBox13.Text = "";
                }
            }
        }

        private void metroTextBox13_Leave(object sender, EventArgs e)
        {
            if (kepler.Checked)
            {
                if (metroTextBox13.Text == "")
                {
                    metroTextBox13.Text = "10^n";
                }
            }

            if (satellite.Checked)
            {
                if (metroTextBox13.Text == "")
                {
                    metroTextBox13.Text = "";
                }
            }
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void metroTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void metroTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void metroTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void metroTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void metroTextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void metroTextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void metroTextBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void metroTextBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void metroTextBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void metroTextBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void metroTextBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void metroTextBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
    }
}