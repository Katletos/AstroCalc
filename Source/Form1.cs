using System;
using System.Windows.Forms;
using static System.Math;

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

            if (dopler.Checked)
            {
                metroLabel1.Text = " ";
                metroLabel2.Text = "";
                metroLabel3.Text = "";
                metroLabel4.Text = "";
                metroLabel5.Text = "";
                metroLabel6.Text = "";
            }
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double G = Pow(6.67430, -11);
            double c = 299792458;
            double b = 0.002897;

            if (kepler.Checked)
            {
                double a1, T1, Q1, q1, e1, M1,
                       a2, T2, Q2, q2, e2, M2;
                int n1, n2;

                bool v1 = double.TryParse(metroTextBox1.Text, out a1);
                bool v2 = double.TryParse(metroTextBox2.Text, out a2);
                bool v3 = double.TryParse(metroTextBox3.Text, out T1);
                bool v4 = double.TryParse(metroTextBox4.Text, out T2);
                bool v5 = double.TryParse(metroTextBox5.Text, out Q1);
                bool v6 = double.TryParse(metroTextBox6.Text, out Q2);
                bool v7 = double.TryParse(metroTextBox7.Text, out q1);
                bool v8 = double.TryParse(metroTextBox8.Text, out q2);
                bool v9 = double.TryParse(metroTextBox9.Text, out e1);
                bool v10 = double.TryParse(metroTextBox10.Text, out e2);
                bool v11 = double.TryParse(metroTextBox11.Text, out M1);
                bool v12 = double.TryParse(metroTextBox12.Text, out M2);
                bool v13 = int.TryParse(metroTextBox13.Text, out n1);
                bool v14 = int.TryParse(metroTextBox14.Text, out n2);

                M1 = M1 * Pow(10, n1);
                M2 = M2 * Pow(10, n2);

                try
                {
                    if (M1 != 0 & T1 != 0 & a1 == 0)
                    {
                        a1 = Pow(((G * M1 * Pow(T1, 2)) / 4 / Pow(PI, 2)), 1.0 / 3);
                        metroTextBox1.Text = Convert.ToString(Round(a1, 5));
                    }

                    if (q1 != 0 & e1 != 0 & a1 == 0)
                    {
                        a1 = q1 / (1 - e1);
                        metroTextBox1.Text = Convert.ToString(a1);
                    }

                    if (Q1 != 0 & e1 != 0 & a1 == 0)
                    {
                        a1 = Q1 / (1 - e1);
                        metroTextBox1.Text = Convert.ToString(a1);
                    }

                    if (q1 != 0 & Q1 != 0 & a1 == 0)
                    {
                        a1 = (q1 + Q1) / 2;
                        metroTextBox1.Text = Convert.ToString(a1);
                    }

                    if (a1 != 0 & q1 != 0 & e1 == 0)
                    {
                        e1 = 1 - (q1 / a1);
                        metroTextBox9.Text = Convert.ToString(Round(e1, 5));
                    }

                    if (a1 != 0 & Q1 != 0 & e1 == 0)
                    {
                        e1 = 1 - (Q1 / a1);
                        metroTextBox9.Text = Convert.ToString(Round(e1, 5));
                    }

                    if (a1 != 0 & e1 != 0 & q1 == 0)
                    {
                        q1 = a1 * (1 - e1);
                        metroTextBox7.Text = Convert.ToString(q1);
                    }

                    if (a1 != 0 & Q1 != 0 & q1 == 0)
                    {
                        q1 = 2 * a1 - Q1;
                        metroTextBox7.Text = Convert.ToString(q1);
                    }

                    if (a1 != 0 & e1 != 0 & Q1 == 0)
                    {
                        Q1 = a1 * (1 + e1);
                        metroTextBox5.Text = Convert.ToString(Q1);
                    }

                    if (a1 != 0 & q1 != 0 & Q1 == 0)
                    {
                        Q1 = 2 * a1 - q1;
                        metroTextBox5.Text = Convert.ToString(Q1);
                    }

                    if (a1 != 0 & T1 != 0 & M1 == 0)
                    {
                        M1 = (4 * Pow(PI, 2) * Pow(a1, 3)) / Pow(T1, 2) / G;
                        metroTextBox11.Text = Convert.ToString(Round(M1, 5));
                    }

                    if (a1 != 0 & M1 != 0 & T1 == 0)
                    {
                        T1 = Sqrt(Pow(a1, 3) * 4 * Pow(PI, 2) / G / M1);
                        metroTextBox3.Text = Convert.ToString(Round(T1, 5));
                    }

                    if (M2 != 0 & T2 != 0 & a2 == 0)
                    {
                        a2 = Pow(((G * M2 * Pow(T2, 2)) / 4 / Pow(PI, 2)), 1.0 / 3);
                        metroTextBox2.Text = Convert.ToString(Round(a2, 5));
                    }

                    if (q2 != 0 & e2 != 0 & a2 == 0)
                    {
                        a2 = q2 / (1 - e2);
                        metroTextBox2.Text = Convert.ToString(a2);
                    }

                    if (Q2 != 0 & e2 != 0 & a2 == 0)
                    {
                        a2 = Q2 / (1 - e2);
                        metroTextBox2.Text = Convert.ToString(a2);
                    }

                    if (q2 != 0 & Q2 != 0 & a2 == 0)
                    {
                        a2 = (q2 + Q2) / 2;
                        metroTextBox2.Text = Convert.ToString(a2);
                    }

                    if (a2 != 0 & q2 != 0 & e2 == 0)
                    {
                        e2 = 1 - (q2 / a2);
                        metroTextBox10.Text = Convert.ToString(Round(e2, 5));
                    }

                    if (a2 != 0 & Q2 != 0 & e2 == 0)
                    {
                        e2 = 1 - (Q2 / a2);
                        metroTextBox10.Text = Convert.ToString(Round(e2, 5));
                    }

                    if (a2 != 0 & e2 != 0 & q2 == 0)
                    {
                        q2 = a2 * (1 - e2);
                        metroTextBox8.Text = Convert.ToString(q2);
                    }

                    if (a2 != 0 & Q2 != 0 & q2 == 0)
                    {
                        q2 = 2 * a2 - Q2;
                        metroTextBox8.Text = Convert.ToString(q2);
                    }

                    if (a2 != 0 & e2 != 0 & Q2 == 0)
                    {
                        Q2 = a2 * (1 + e2);
                        metroTextBox6.Text = Convert.ToString(Q2);
                    }

                    if (a2 != 0 & q2 != 0 & Q2 == 0)
                    {
                        Q2 = 2 * a2 - 21;
                        metroTextBox6.Text = Convert.ToString(Q2);
                    }

                    if (a2 != 0 & T2 != 0 & M2 == 0)
                    {
                        M2 = (4 * Pow(PI, 2) * Pow(a2, 3)) / Pow(T2, 2) / G;
                        metroTextBox12.Text = Convert.ToString(Round(M2, 5));
                    }

                    if (a2 != 0 & M2 != 0 & T2 == 0)
                    {
                        T2 = Sqrt(Pow(a2, 3) * 4 * Pow(PI, 2) / G / M2);
                        metroTextBox4.Text = Convert.ToString(Round(T2, 5));
                    }

                    if (a1 == 0 & M1 != 0 & M2 != 0 & a2 != 0)
                    {
                        a1 = M2 * a2 / M1;
                        metroTextBox1.Text = Convert.ToString(a1);
                    }

                    if (a2 == 0 & a1 != 0 & M1 != 0 & M2 != 0)
                    {
                        a2 = M1 * a1 / M2;
                        metroTextBox2.Text = Convert.ToString(a2);
                    }

                    if (M1 == 0 & a1 != 0 & a2 != 0 & M2 != 0)
                    {
                        M1 = M2 * a2 / a1;
                        double n = Convert.ToString(Round(M1)).Length;
                        metroTextBox11.Text = Convert.ToString(Round(n / ((n - 1) * 10), 5));
                        metroTextBox13.Text = Convert.ToString(n);
                    }

                    if (M2 == 0 & a1 != 0 & a2 != 0 & M1 != 0)
                    {
                        M2 = M1 * a1 / a2;
                        double k = Convert.ToString(Round(M2)).Length;
                        metroTextBox12.Text = Convert.ToString(Round(k / ((k - 1) * 10), 5));
                        metroTextBox14.Text = Convert.ToString(k);
                    }
                }
                finally
                {

                }
            }

            if (satellite.Checked)
            {

            }

            if (dopler.Checked)
            {
                double z, lambda, lambda0, V, Vr, H, T;

                bool v1 = double.TryParse(metroTextBox1.Text, out lambda);
                bool v2 = double.TryParse(metroTextBox3.Text, out lambda0);
                bool v3 = double.TryParse(metroTextBox5.Text, out T);
                bool v4 = double.TryParse(metroTextBox7.Text, out V);
                bool v5 = double.TryParse(metroTextBox9.Text, out Vr);
                bool v6 = double.TryParse(metroTextBox11.Text, out z);

                if (v1 == false | v2 == false | v3 == false | v4 == false | v5 == false | v6 == false)
                {
                    MessageBox.Show("Праверце ўведзеныя дадзеныя", "Абмыла!");
                }

                try
                {
                    if (lambda == 0 & T != 0)
                    {
                        lambda = b / T;
                        metroTextBox1.Text = Convert.ToString(lambda);
                    }

                    if (T == 0 & lambda != 0)
                    {
                        T = b / lambda;
                        metroTextBox5.Text = Convert.ToString(T);
                    }

                    if (z == 0 & V != 0)
                    {
                        z = V / c;
                        metroTextBox11.Text = Convert.ToString(z);
                    }

                    if (V == 0 & z != 0)
                    {
                        V = z * c;
                        metroTextBox7.Text = Convert.ToString(V);
                    }

                    if (z == 0 & lambda != 0 & lambda0 != 0)
                    {
                        z = (lambda - lambda0) / lambda0;
                        metroTextBox11.Text = Convert.ToString(z);
                    }

                    if (lambda == 0 & lambda != 0 & lambda0 != 0)
                    {
                        lambda = (lambda0 * (1 + z)) / z;
                        metroTextBox1.Text = Convert.ToString(lambda);
                    }

                    if (lambda0 == 0 & lambda != 0 & z != 0)
                    {
                        lambda0 = (z * lambda) / (1 + z);
                        metroTextBox3.Text = Convert.ToString(lambda0); 
                    }
                }
                finally
                {

                }
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
                if (string.IsNullOrEmpty(metroTextBox1.Text))
                {
                    metroTextBox1.Text = "Паўвось 1";
                }
            }

            if (satellite.Checked)
            {
                if (string.IsNullOrEmpty(metroTextBox1.Text))
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
                if (string.IsNullOrEmpty(metroTextBox2.Text))
                {
                    metroTextBox2.Text = "Паўвось 2";
                }
            }

            if (satellite.Checked)
            {
                if (string.IsNullOrEmpty(metroTextBox2.Text))
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
                if (string.IsNullOrEmpty(metroTextBox3.Text))
                {
                    metroTextBox3.Text = "Перыяд 1";
                }
            }

            if (satellite.Checked)
            {
                if (string.IsNullOrEmpty(metroTextBox3.Text))
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
                if (string.IsNullOrEmpty(metroTextBox4.Text))
                {
                    metroTextBox4.Text = "Перыяд 2";
                }
            }

            if (satellite.Checked)
            {
                if (string.IsNullOrEmpty(metroTextBox4.Text))
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
                if (string.IsNullOrEmpty(metroTextBox5.Text))
                {
                    metroTextBox5.Text = "Апацэнтар 1";
                }
            }

            if (satellite.Checked)
            {
                if (string.IsNullOrEmpty(metroTextBox5.Text))
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
                if (string.IsNullOrEmpty(metroTextBox6.Text))
                {
                    metroTextBox6.Text = "Апацэнтар 2";
                }
            }

            if (satellite.Checked)
            {
                if (string.IsNullOrEmpty(metroTextBox6.Text))
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
                if (string.IsNullOrEmpty(metroTextBox7.Text))
                {
                    metroTextBox7.Text = "Перыцэнтар 1";
                }
            }

            if (satellite.Checked)
            {
                if (string.IsNullOrEmpty(metroTextBox7.Text))
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
                if (string.IsNullOrEmpty(metroTextBox8.Text))
                {
                    metroTextBox8.Text = "Перыцэнтар 2";
                }
            }

            if (satellite.Checked)
            {
                if (string.IsNullOrEmpty(metroTextBox8.Text))
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
                if (string.IsNullOrEmpty(metroTextBox9.Text))
                {
                    metroTextBox9.Text = "Эксцэнтрысітэт 1";
                }
            }

            if (satellite.Checked)
            {
                if (string.IsNullOrEmpty(metroTextBox9.Text))
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
                if (string.IsNullOrEmpty(metroTextBox10.Text))
                {
                    metroTextBox10.Text = "Эксцэнтрысітэт 2";
                }
            }

            if (satellite.Checked)
            {
                if (string.IsNullOrEmpty(metroTextBox10.Text))
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
                if (string.IsNullOrEmpty(metroTextBox11.Text))
                {
                    metroTextBox11.Text = "Маса 1";
                }
            }

            if (satellite.Checked)
            {
                if (string.IsNullOrEmpty(metroTextBox11.Text))
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
                if (string.IsNullOrEmpty(metroTextBox12.Text))
                {
                    metroTextBox12.Text = "Маса 2";
                }
            }

            if (satellite.Checked)
            {
                if (string.IsNullOrEmpty(metroTextBox12.Text))
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
                if (string.IsNullOrEmpty(metroTextBox13.Text))
                {
                    metroTextBox13.Text = "10^n";
                }
            }

            if (satellite.Checked)
            {
                if (string.IsNullOrEmpty(metroTextBox13.Text))
                {
                    metroTextBox13.Text = "";
                }
            }
        }

        private void metroTextBox14_Enter(object sender, EventArgs e)
        {
            if (kepler.Checked)
            {
                if (metroTextBox14.Text == "10^n")
                {
                    metroTextBox14.Text = "";
                }
            }

            if (satellite.Checked)
            {
                if (metroTextBox14.Text == "")
                {
                    metroTextBox14.Text = "";
                }
            }
        }

        private void metroTextBox14_Leave(object sender, EventArgs e)
        {
            if (kepler.Checked)
            {
                if (string.IsNullOrEmpty(metroTextBox14.Text))
                {
                    metroTextBox14.Text = "10^n";
                }
            }

            if (satellite.Checked)
            {
                if (string.IsNullOrEmpty(metroTextBox14.Text))
                {
                    metroTextBox14.Text = "";
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
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void metroTextBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}