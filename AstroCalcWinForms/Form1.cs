using System;
using System.Windows.Forms;
using static System.Math;

namespace AstroCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kepler.Select();
        }

        void Combobox_clear()
        {
            comboBox1.Items.Clear();
            comboBox1.Text = null;
            comboBox3.Items.Clear();
            comboBox3.Text = null;
            comboBox5.Items.Clear();
            comboBox5.Text = null;
            comboBox7.Items.Clear();
            comboBox7.Text = null;

            comboBox2.Items.Clear();
            comboBox2.Text = null;
            comboBox4.Items.Clear();
            comboBox4.Text = null;
            comboBox6.Items.Clear();
            comboBox6.Text = null;
            comboBox8.Items.Clear();
            comboBox8.Text = null;
            comboBox10.Items.Clear();
            comboBox10.Text = null;
        }

        void Combobox_zeroitem()
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
            comboBox8.SelectedIndex = 0;
            comboBox10.SelectedIndex = 0;
        }

        void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            textBox8.Text = null;
            textBox9.Text = null;
            textBox10.Text = null;
            textBox11.Text = null;
            textBox12.Text = null;
            textBox13.Text = null;
            textBox14.Text = null;
        }

        void Errormessage(object parameter)
        {
            MessageBox.Show("Абмыла ў парамэтры " + parameter, "Абмыла");
        }

        void Converting(double x, int n)
        {
            if (kepler.Checked)
            {
                if (n == 1)
                {
                    if (comboBox1.SelectedIndex == 1)
                    {
                        textBox1.Text = Convert.ToString(Round(x, 5));
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        textBox1.Text = Convert.ToString(Round(x / 1000, 5));
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        textBox1.Text = Convert.ToString(Round(x / 149597870700, 5));
                    }
                }
                else if (n == 2)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        textBox2.Text = Convert.ToString(Round(x, 5));
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {
                        textBox2.Text = Convert.ToString(Round(x / 1000, 5));
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {
                        textBox2.Text = Convert.ToString(Round(x / 149597870700, 5));
                    }
                }
                else if (n == 3)
                {
                    if (comboBox3.SelectedIndex == 0)
                    {
                        textBox3.Text = Convert.ToString(Round(x, 5));
                    }
                    else if (comboBox3.SelectedIndex == 1)
                    {
                        textBox3.Text = Convert.ToString(Round(x / 3600, 5));
                    }
                    else if (comboBox3.SelectedIndex == 2)
                    {
                        textBox3.Text = Convert.ToString(Round(x / 86164, 5));
                    }
                    else if (comboBox3.SelectedIndex == 3)
                    {
                        textBox3.Text = Convert.ToString(Round(x / 31470774.5, 5));
                    }
                }
                else if (n == 4)
                {
                    if (comboBox4.SelectedIndex == 0)
                    {
                        textBox4.Text = Convert.ToString(Round(x, 5));
                    }
                    else if (comboBox4.SelectedIndex == 1)
                    {
                        textBox4.Text = Convert.ToString(Round(x / 3600, 5));
                    }
                    else if (comboBox4.SelectedIndex == 2)
                    {
                        textBox4.Text = Convert.ToString(Round(x / 86164, 5));
                    }
                    else if (comboBox4.SelectedIndex == 3)
                    {
                        textBox4.Text = Convert.ToString(Round(x / 31470774.5, 5));
                    }
                }
                else if (n == 5)
                {
                    if (comboBox5.SelectedIndex == 0)
                    {
                        textBox5.Text = Convert.ToString(Round(x, 5));
                    }
                    else if (comboBox5.SelectedIndex == 1)
                    {
                        textBox5.Text = Convert.ToString(Round(x / 1000, 5));
                    }
                    else if (comboBox5.SelectedIndex == 2)
                    {
                        textBox5.Text = Convert.ToString(Round(x / 149597870700, 5));
                    }
                }
                else if (n == 6)
                {
                    if (comboBox6.SelectedIndex == 0)
                    {
                        textBox6.Text = Convert.ToString(Round(x, 5));
                    }
                    else if (comboBox6.SelectedIndex == 1)
                    {
                        textBox6.Text = Convert.ToString(Round(x / 1000, 5));
                    }
                    else if (comboBox6.SelectedIndex == 2)
                    {
                        textBox6.Text = Convert.ToString(Round(x / 149597870700, 5));
                    }
                }
                else if (n == 7)
                {
                    if (comboBox7.SelectedIndex == 0)
                    {
                        textBox7.Text = Convert.ToString(Round(x, 5));
                    }
                    else if (comboBox7.SelectedIndex == 1)
                    {
                        textBox7.Text = Convert.ToString(Round(x / 1000, 5));
                    }
                    else if (comboBox7.SelectedIndex == 2)
                    {
                        textBox7.Text = Convert.ToString(Round(x / 149597870700, 5));
                    }
                }
                else if (n == 8)
                {
                    if (comboBox8.SelectedIndex == 0)
                    {
                        textBox8.Text = Convert.ToString(Round(x, 5));
                    }
                    else if (comboBox8.SelectedIndex == 1)
                    {
                        textBox8.Text = Convert.ToString(Round(x / 1000, 5));
                    }
                    else if (comboBox8.SelectedIndex == 2)
                    {
                        textBox8.Text = Convert.ToString(Round(x / 149597870700, 5));
                    }
                }
            }
            else if (satellite.Checked)
            {
                if (n == 1)
                {
                    if (comboBox1.SelectedIndex == 1)
                    {
                        textBox1.Text = Convert.ToString(Round(x, 5));
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        textBox1.Text = Convert.ToString(Round(x / 1000, 5));
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        textBox1.Text = Convert.ToString(Round(x / 149597870700, 5));
                    }
                }
                else if (n == 2)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        textBox2.Text = Convert.ToString(Round(x, 5));
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {
                        textBox2.Text = Convert.ToString(Round(x / 1000, 5));
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {
                        textBox2.Text = Convert.ToString(Round(x * 3.6, 5));
                    }
                }
                else if (n == 3)
                {
                    if (comboBox3.SelectedIndex == 0)
                    {
                        textBox3.Text = Convert.ToString(Round(x, 5));
                    }
                    else if (comboBox3.SelectedIndex == 1)
                    {
                        textBox3.Text = Convert.ToString(Round(x / 3600, 5));
                    }
                    else if (comboBox3.SelectedIndex == 2)
                    {
                        textBox3.Text = Convert.ToString(Round(x / 86164, 5));
                    }
                    else if (comboBox3.SelectedIndex == 3)
                    {
                        textBox3.Text = Convert.ToString(Round(x / 31470774.5, 5));
                    }
                }
                else if (n == 4)
                {
                    if (comboBox4.SelectedIndex == 0)
                    {
                        textBox4.Text = Convert.ToString(Round(x, 5));
                    }
                    else if (comboBox4.SelectedIndex == 1)
                    {
                        textBox4.Text = Convert.ToString(Round(x / 1000, 5));
                    }
                    else if (comboBox4.SelectedIndex == 2)
                    {
                        textBox4.Text = Convert.ToString(Round(x * 3.6, 5));
                    }
                }
                else if (n == 5)
                {
                    if (comboBox5.SelectedIndex == 0)
                    {
                        textBox5.Text = Convert.ToString(Round(x, 5));
                    }
                    else if (comboBox5.SelectedIndex == 1)
                    {
                        textBox5.Text = Convert.ToString(Round(x / 1000, 5));
                    }
                    else if (comboBox5.SelectedIndex == 2)
                    {
                        textBox5.Text = Convert.ToString(Round(x / 149597870700, 5));
                    }
                }
                else if (n == 6)
                {
                    if (comboBox6.SelectedIndex == 0)
                    {
                        textBox6.Text = Convert.ToString(Round(x, 5));
                    }
                    else if (comboBox6.SelectedIndex == 1)
                    {
                        textBox6.Text = Convert.ToString(Round(x / 1000, 5));
                    }
                    else if (comboBox6.SelectedIndex == 2)
                    {
                        textBox6.Text = Convert.ToString(Round(x * 3.6, 5));
                    }
                }
                else if (n == 7)
                {
                    if (comboBox7.SelectedIndex == 0)
                    {
                        textBox7.Text = Convert.ToString(Round(x, 5));
                    }
                    else if (comboBox7.SelectedIndex == 1)
                    {
                        textBox7.Text = Convert.ToString(Round(x / 1000, 5));
                    }
                    else if (comboBox7.SelectedIndex == 2)
                    {
                        textBox7.Text = Convert.ToString(Round(x / 149597870700, 5));
                    }
                }
                else if (n == 8)
                {
                    if (comboBox8.SelectedIndex == 0)
                    {
                        textBox8.Text = Convert.ToString(Round(x, 5));
                    }
                    else if (comboBox8.SelectedIndex == 1)
                    {
                        textBox8.Text = Convert.ToString(Round(x / 1000, 5));
                    }
                    else if (comboBox8.SelectedIndex == 2)
                    {
                        textBox8.Text = Convert.ToString(Round(x * 3.6, 5));
                    }
                }
                else if (n == 10)
                {
                    if (comboBox10.SelectedIndex == 0)
                    {
                        textBox10.Text = Convert.ToString(Round(x, 5));
                    }
                    else if (comboBox10.SelectedIndex == 1)
                    {
                        textBox10.Text = Convert.ToString(Round(x / 1000, 5));
                    }
                    else if (comboBox10.SelectedIndex == 2)
                    {
                        textBox10.Text = Convert.ToString(Round(x / 149597870700, 5));
                    }
                }
            }
        }

        public void Calculate_Click(object sender, EventArgs e)
        {
            double G = 6.67430 * Pow(10, -11);
            double c = 299792458;
            double b = 0.002897;

            if (satellite.Checked)
            {
                double.TryParse(textBox1.Text, out double a);
                double.TryParse(textBox2.Text, out double V0);
                double.TryParse(textBox3.Text, out double T);
                double.TryParse(textBox4.Text, out double VQ);
                double.TryParse(textBox5.Text, out double Q);
                double.TryParse(textBox6.Text, out double Vq);
                double.TryParse(textBox7.Text, out double q);
                double.TryParse(textBox8.Text, out double Vr);
                double.TryParse(textBox9.Text, out double E);
                double.TryParse(textBox10.Text, out double r);
                double.TryParse(textBox11.Text, out double M);
                int.TryParse(textBox13.Text, out int n);

                M *= Pow(10, n);

                try
                {
                    if (comboBox1.SelectedIndex == 1)
                    {
                        a *= 1000;
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        a *= 149597870700;
                    }

                    if (comboBox2.SelectedIndex == 1)
                    {
                        V0 *= 1000;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {
                        V0 /= 3.6;
                    }

                    if (comboBox3.SelectedIndex == 1)
                    {
                        T *= 3600;
                    }
                    else if (comboBox3.SelectedIndex == 2)
                    {
                        T *= 86164;
                    }
                    else if (comboBox3.SelectedIndex == 3)
                    {
                        T *= 31556925.9747;
                    }

                    if (comboBox4.SelectedIndex == 1)
                    {
                        VQ *= 1000;
                    }
                    else if (comboBox4.SelectedIndex == 2)
                    {
                        VQ /= 3.6;
                    }

                    if (comboBox5.SelectedIndex == 1)
                    {
                        Q *= 1000;
                    }
                    else if (comboBox5.SelectedIndex == 2)
                    {
                        Q *= 149597870700;
                    }

                    if (comboBox6.SelectedIndex == 1)
                    {
                        Vq *= 1000;
                    }
                    else if (comboBox6.SelectedIndex == 2)
                    {
                        Vq /= 3.6;
                    }

                    if (comboBox7.SelectedIndex == 1)
                    {
                        q *= 1000;
                    }
                    else if (comboBox7.SelectedIndex == 2)
                    {
                        q *= 149597870700;
                    }

                    if (comboBox8.SelectedIndex == 1)
                    {
                        Vr *= 1000;
                    }
                    else if (comboBox8.SelectedIndex == 2)
                    {
                        Vr /= 3.6;
                    }

                    if (comboBox7.SelectedIndex == 1)
                    {
                        r *= 1000;
                    }
                    else if (comboBox7.SelectedIndex == 2)
                    {
                        r *= 149597870700;
                    }

                    if (T == 0)
                    {
                        if (a != 0 & M != 0)
                        {
                            T = Sqrt(Pow(a, 3) * 4 * Pow(PI, 2) / G / M);
                            Converting(T, 3);
                        }
                    }

                    if (a == 0)
                    {
                        if (M != 0 & T != 0)
                        {
                            a = Pow(((G * M * Pow(T, 2)) / 4 / Pow(PI, 2)), 1.0 / 3);
                            Converting(a, 1);
                        }
                        else if (q != 0 & E != 0)
                        {
                            a = q / (1 - E);
                            Converting(a, 1);
                        }
                        else if (Q != 0 & E != 0)
                        {
                            a = Q / (1 - E);
                            Converting(a, 1);
                        }
                        else if (q != 0 & Q != 0)
                        {
                            a = (q + Q) / 2;
                            Converting(a, 1);
                        }
                    }

                    if (E == 0)
                    {
                        if (a != 0 & q != 0)
                        {
                            E = 1 - (q / a);
                            textBox9.Text = Convert.ToString(Round(E, 5));
                        }
                        else if (a != 0 & Q != 0)
                        {
                            E = (Q / a) - 1;
                            textBox9.Text = Convert.ToString(Round(E, 5));
                        }
                    }

                    if (q == 0)
                    {
                        if (a != 0 & E != 0)
                        {
                            q = a * (1 - E);
                            Converting(q, 7);
                        }
                        else if (a != 0 & Q != 0)
                        {
                            q = 2 * a - Q;
                            Converting(q, 7);
                        }
                    }

                    if (Q == 0)
                    {
                        if (a != 0 & E != 0)
                        {
                            Q = a * (1 + E);
                            Converting(Q, 5);
                        }
                        else if (a != 0 & q != 0)
                        {
                            Q = 2 * a - q;
                            Converting(Q, 5);
                        }
                    }

                    if (M == 0)
                    {
                        if (a != 0 & T != 0)
                        {
                            M = (4 * Pow(PI, 2) * Pow(a, 3)) / (Pow(T, 2) * G);
                            int k = (int)Math.Log10(Round(M)) + 1;
                            textBox11.Text = Convert.ToString(Round(M / Pow(10, (k - 1)), 5));
                            textBox13.Text = Convert.ToString(k - 1);
                        }
                    }

                    if (V0 == 0)
                    {
                        if (a != 0 & T != 0 & E != 0)
                        {
                            V0 = (Sqrt(1 - Pow(E, 2)) * (4 * PI * a - 1) + 1) / (1 + Sqrt(1 - Pow(E, 2))) / T;
                            Converting(V0, 2);
                        }
                    }

                    if (VQ == 0)
                    {
                        if (Q != 0 & a != 0 & M != 0)
                        {
                            VQ = Sqrt(G * M * (2 / Q - 1 / a));
                            Converting(VQ, 4);
                        }
                    }

                    if (Vq == 0)
                    {
                        if (q != 0 & a != 0 & M != 0)
                        {
                            Vq = Sqrt(G * M * (2 / q - 1 / a));
                            Converting(Vq, 6);
                        }
                    }

                    if (Vr == 0)
                    {
                        if (a != 0 & M != 0 & r != 0)
                        {
                            Vr = Sqrt(G * M * ((2 / r) - (1 / a)));
                            Converting(Vr, 8);
                        }
                    }

                    if (r == 0)
                    {
                        if (M != 0 & a != 0 & Vr != 0)
                        {
                            r = 2 * G * M * a / (Pow(Vr, 2) * a + G * M);
                            Converting(r, 10);
                        }
                    }
                }
                finally
                {
                    double[] arr = { a, Q, q, T, M, E, Vq, VQ, r, V0, Vr };
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = 0;
                    }
                }
            }//++

            if (kepler.Checked)
            {
                double.TryParse(textBox1.Text, out double a1);
                double.TryParse(textBox2.Text, out double a2);
                double.TryParse(textBox3.Text, out double T1);
                double.TryParse(textBox4.Text, out double T2);
                double.TryParse(textBox5.Text, out double Q1);
                double.TryParse(textBox6.Text, out double Q2);
                double.TryParse(textBox7.Text, out double q1);
                double.TryParse(textBox8.Text, out double q2);
                double.TryParse(textBox9.Text, out double e1);
                double.TryParse(textBox10.Text, out double e2);
                double.TryParse(textBox11.Text, out double M1);
                double.TryParse(textBox12.Text, out double M2);
                int.TryParse(textBox13.Text, out int n1);
                int.TryParse(textBox14.Text, out int n2);

                M1 *= Pow(10, n1);
                M2 *= Pow(10, n2);

                if (comboBox1.SelectedIndex == 1)
                {
                    a1 *= 1000;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    a1 *= 149597870700;
                }

                if (comboBox2.SelectedIndex == 1)
                {
                    a2 *= 1000;
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    a2 *= 149597870700;
                }

                if (comboBox3.SelectedIndex == 1)
                {
                    T1 *= 3600;
                }
                else if (comboBox3.SelectedIndex == 2)
                {
                    T1 *= 86164;
                }
                else if (comboBox3.SelectedIndex == 3)
                {
                    T1 *= 31556925.9747;
                }

                if (comboBox4.SelectedIndex == 1)
                {
                    T2 *= 3600;
                }
                else if (comboBox4.SelectedIndex == 2)
                {
                    T2 *= 86164;
                }
                else if (comboBox4.SelectedIndex == 3)
                {
                    T2 *= 31556925.9747;
                }

                if (comboBox5.SelectedIndex == 1)
                {
                    Q1 *= 1000;
                }
                else if (comboBox5.SelectedIndex == 2)
                {
                    Q1 *= 149597870700;
                }

                if (comboBox6.SelectedIndex == 1)
                {
                    Q2 *= 1000;
                }
                else if (comboBox6.SelectedIndex == 2)
                {
                    Q2 *= 149597870700;
                }

                if (comboBox7.SelectedIndex == 1)
                {
                    q1 *= 1000;
                }
                else if (comboBox7.SelectedIndex == 2)
                {
                    q1 *= 149597870700;
                }

                if (comboBox8.SelectedIndex == 1)
                {
                    q2 *= 1000;
                }
                else if (comboBox8.SelectedIndex == 2)
                {
                    q2 *= 149597870700;
                }

                try
                {
                    if (a1 == 0)
                    {
                        if (M1 != 0 & T1 != 0)
                        {
                            a1 = Pow(((G * M1 * Pow(T1, 2)) / 4 / Pow(PI, 2)), 1.0 / 3);
                            Converting(a1, 1);
                        }
                        else if (q1 != 0 & e1 != 0)
                        {
                            a1 = q1 / (1 - e1);
                            Converting(a1, 1);
                        }
                        else if (Q1 != 0 & e1 != 0)
                        {
                            a1 = Q1 / (1 - e1);
                            Converting(a1, 1);
                        }
                        else if (q1 != 0 & Q1 != 0)
                        {
                            a1 = (q1 + Q1) / 2;
                            Converting(a1, 1);
                        }

                        if (M1 != 0 & M2 != 0 & a2 != 0)
                        {
                            a1 = M2 * a2 / M1;
                            Converting(a1, 1);
                        }
                    }

                    if (e1 == 0)
                    {
                        if (a1 != 0 & q1 != 0)
                        {
                            e1 = 1 - (q1 / a1);
                            textBox9.Text = Convert.ToString(Round(e1, 5));
                        }
                        else if (a1 != 0 & Q1 != 0)
                        {
                            e1 = (Q1 / a1) - 1;
                            textBox9.Text = Convert.ToString(Round(e1, 5));
                        }
                    }

                    if (q1 == 0)
                    {
                        if (a1 != 0 & e1 != 0)
                        {
                            q1 = a1 * (1 - e1);
                            Converting(q1, 7);
                        }
                        else if (a1 != 0 & Q1 != 0)
                        {
                            q1 = 2 * a1 - Q1;
                            Converting(q1, 7);
                        }
                    }

                    if (Q1 == 0)
                    {
                        if (a1 != 0 & e1 != 0)
                        {
                            Q1 = a1 * (1 + e1);
                            Converting(Q1, 5);
                        }
                        else if (a1 != 0 & q1 != 0)
                        {
                            Q1 = 2 * a1 - q1;
                            Converting(Q1, 5);
                        }
                    }

                    if (a2 == 0)
                    {
                        if (M2 != 0 & T2 != 0)
                        {
                            a2 = Pow(((G * M2 * Pow(T2, 2)) / 4 / Pow(PI, 2)), 1.0 / 3);
                            Converting(a2, 2);
                        }
                        else if (q2 != 0 & e2 != 0)
                        {
                            a2 = q2 / (1 - e2);
                            Converting(a2, 2);
                        }
                        else if (Q2 != 0 & e2 != 0)
                        {
                            a2 = Q2 / (1 - e2);
                            Converting(a2, 2);
                        }
                        else if (q2 != 0 & Q2 != 0)
                        {
                            a2 = (q2 + Q2) / 2;
                            Converting(a2, 2);
                        }

                        if (a1 != 0 & M1 != 0 & M2 != 0)
                        {
                            a2 = M1 * a1 / M2;
                            Converting(a2, 2);
                        }
                    }

                    if (e2 == 0)
                    {
                        if (a2 != 0 & q2 != 0)
                        {
                            e2 = 1 - (q2 / a2);
                            textBox10.Text = Convert.ToString(Round(e2, 5));
                        }
                        else if (a2 != 0 & Q2 != 0)
                        {
                            e2 = (Q2 / a2) - 1;
                            textBox10.Text = Convert.ToString(Round(e2, 5));
                        }
                    }

                    if (q2 == 0)
                    {
                        int n = 8;
                        if (a2 != 0 & e2 != 0)
                        {
                            q2 = a2 * (1 - e2);
                            Converting(q2, n);
                        }
                        else if (a2 != 0 & Q2 != 0)
                        {
                            q2 = 2 * a2 - Q2;
                            Converting(q2, n);
                        }
                    }

                    if (Q2 == 0)
                    {
                        int n = 6;
                        if (a2 != 0 & e2 != 0)
                        {
                            Q2 = a2 * (1 + e2);
                            Converting(Q2, n);
                        }
                        else if (a2 != 0 & q2 != 0)
                        {
                            Q2 = 2 * a2 - q2;
                            Converting(Q2, n);
                        }
                    }

                    if (M1 == 0)
                    {
                        if (a1 != 0 & T1 != 0)
                        {
                            M1 = (4 * Pow(PI, 2) * Pow(a1, 3)) / (Pow(T1, 2) * G);
                            int n = (int)Math.Log10(Round(M1)) + 1;
                            textBox11.Text = Convert.ToString(Round(M1 / Pow(10, (n - 1)), 5));
                            textBox13.Text = Convert.ToString(n - 1);
                        }
                        else if (a1 != 0 & a2 != 0 & M2 != 0)
                        {
                            M1 = M2 * a2 / a1;
                            int n = (int)Math.Log10(Round(M1)) + 1;
                            textBox11.Text = Convert.ToString(Round(M1 / Pow(10, (n - 1)), 5));
                            textBox13.Text = Convert.ToString(n - 1);
                        }
                    }

                    if (M2 == 0)
                    {
                        if (a2 != 0 & T2 != 0)
                        {
                            M2 = (4 * Pow(PI, 2) * Pow(a2, 3)) / Pow(T2, 2) / G;
                            int n = (int)Math.Log10(Round(M1)) + 1;
                            textBox12.Text = Convert.ToString(Round(M2 / Pow(10, n - 1), 5));
                            textBox14.Text = Convert.ToString(n - 1);
                        }
                        else if (a1 != 0 & a2 != 0 & M1 != 0)
                        {
                            M2 = M1 * a1 / a2;
                            int n = (int)Math.Log10(Round(M1)) + 1;
                            textBox12.Text = Convert.ToString(Round(M1 / Pow(10, n - 1), 5));
                            textBox14.Text = Convert.ToString(n - 1);
                        }
                    }

                    if (a1 != 0 & M1 != 0 & T1 == 0)
                    {
                        T1 = Sqrt(Pow(a1, 3) * 4 * Pow(PI, 2) / G / M1);
                        Converting(T1, 3);
                    }

                    if (a2 != 0 & M2 != 0 & T2 == 0)
                    {
                        T2 = Sqrt(Pow(a2, 3) * 4 * Pow(PI, 2) / G / M2);
                        Converting(T2, 4);
                    }
                }
                finally
                {
                    double[] arr = {a1, T1, Q1, q1, e1, M1,
                                    a2, T2, Q2, q2, e2, M2};
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = 0;
                    }
                }
            }//++

            if (dopler.Checked)
            {
                double.TryParse(textBox1.Text, out double lambda);
                double.TryParse(textBox2.Text, out double r);
                double.TryParse(textBox3.Text, out double lambda0);
                double.TryParse(textBox5.Text, out double T);
                double.TryParse(textBox7.Text, out double Vr);
                double.TryParse(textBox11.Text, out double z);
                double.TryParse(textBox13.Text, out double H);

                lambda *= Pow(10, -9);
                lambda0 *= Pow(10, -9);

                try
                {
                    if (lambda == 0)
                    {
                        if (lambda != 0 & lambda0 != 0)
                        {
                            lambda = (lambda0 * (1 + z)) / z;
                            textBox1.Text = Convert.ToString(Round(lambda, 5));
                        }
                    }

                    if (T == 0 & lambda0 != 0)
                    {
                        T = b / lambda0;
                        textBox5.Text = Convert.ToString(Round(T, 5));
                    }

                    if (z == 0 & Vr != 0)
                    {
                        z = Vr / c;
                        textBox9.Text = Convert.ToString(Round(z, 5));
                    }

                    if (Vr == 0)
                    {
                        if (z != 0 & z > 0.2)
                        {
                            Vr = c * (Pow(z + 1, 2) - 1) / (Pow(z + 1, 2) + 1);
                            textBox7.Text = Convert.ToString(Round(Vr, 5));
                        }
                        else if (z != 0)
                        {
                            Vr = z * c;
                            textBox7.Text = Convert.ToString(Round(Vr, 5));
                        }
                        else if (H != 0 & r != 0)
                        {
                            Vr = H * r;
                            textBox7.Text = Convert.ToString(Round(Vr, 5));
                        }
                    }

                    if (z == 0 & lambda != 0 & lambda0 != 0)
                    {
                        z = (lambda - lambda0) / lambda0;
                        textBox9.Text = Convert.ToString(Round(z, 5));
                    }

                    if (lambda0 == 0)
                    {
                        if (T != 0)
                        {
                            lambda0 = b / T;
                            textBox3.Text = Convert.ToString(lambda0);
                        }
                        else if (lambda != 0 & z != 0)
                        {
                            lambda0 = (z * lambda) / (1 + z);
                            textBox3.Text = Convert.ToString(lambda0);
                        }
                    }

                    if (r == 0)
                    {
                        if (Vr != 0 & H != 0)
                        {
                            r = Vr / H;
                            textBox2.Text = Convert.ToString(Round(r, 5));
                        }
                    }
                }
                finally
                {
                    double[] arr = { z, lambda, lambda0, Vr, H, T, r };
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = 0;
                    }
                }
            }//+-

            if (telescopes.Checked)
            {
                double.TryParse(textBox1.Text, out double D);
                double.TryParse(textBox2.Text, out double A);
                double.TryParse(textBox3.Text, out double d);
                double.TryParse(textBox4.Text, out double Anum);
                double.TryParse(textBox5.Text, out double F);
                double.TryParse(textBox6.Text, out double alpha);
                double.TryParse(textBox7.Text, out double f);
                double.TryParse(textBox9.Text, out double n);
                double.TryParse(textBox11.Text, out double m);

                try
                {
                    if (n == 0)
                    {
                        if (F != 0 & f != 0)
                        {
                            n = F / f;
                            textBox9.Text = Convert.ToString(n);
                        }
                        else if (D != 0 & d != 0)
                        {
                            n = D / d;
                            textBox9.Text = Convert.ToString(n);
                        }
                    }

                    if (F == 0)
                    {
                        if (n != 0 & f != 0)
                        {
                            F = n * f;
                            textBox5.Text = Convert.ToString(F);
                        }
                    }

                    if (f == 0)
                    {
                        if (n != 0 & F != 0)
                        {
                            f = F / n;
                            textBox7.Text = Convert.ToString(f);
                        }
                    }

                    if (D == 0)
                    {
                        if (n != 0 & d != 0)
                        {
                            D = n * d;
                            textBox1.Text = Convert.ToString(D);
                        }
                        else if (m != 0)
                        {
                            if (m == 0)
                            {
                                D = Pow(10, 0.42);
                            }
                            else
                            {
                                D = Pow(10, (m - 2.1) / 5);
                            }

                            textBox1.Text = Convert.ToString(Round(D, 3));
                        }

                        if (alpha != 0)
                        {
                            D = 138 / alpha;
                            textBox1.Text = Convert.ToString(D);
                        }
                    }

                    if (d == 0)
                    {
                        if (n != 0 & D != 0)
                        {
                            d = D / n;
                            textBox1.Text = Convert.ToString(d);
                        }
                    }

                    if (alpha == 0)
                    {
                        alpha = 138 / D;
                        textBox6.Text = Convert.ToString(Round(alpha, 5));
                    }

                    if (m == 0)
                    {
                        if (D != 0)
                        {
                            m = 2.1 + 5 * Log10(D);
                            textBox11.Text = Convert.ToString(Round(m, 5));
                        }
                    }

                    if (A == 0)
                    {
                        if (D != 0 & F != 0)
                        {
                            A = D / F;
                            textBox2.Text = Convert.ToString(A);
                        }
                        else if (Anum != 0)
                        {
                            A = 1 / Anum;
                            textBox2.Text = Convert.ToString(A);
                        }
                    }

                    if (Anum == 0)
                    {
                        if (D != 0 & F != 0)
                        {
                            Anum = F / D;
                            textBox4.Text = Convert.ToString(Anum);
                        }
                        else if (A != 0)
                        {
                            Anum = 1 / A;
                            textBox4.Text = Convert.ToString(Anum);
                        }
                    }
                }
                finally
                {
                    double[] arr = { D, d, F, f, n, alpha, m, A, Anum };
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = 0;
                    }
                }
            }//+-
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void TextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void TextBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void TextBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void TextBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void TextBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 45)
            {
                e.Handled = true;
            }
        }

        private void TextBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 45)
            {
                e.Handled = true;
            }
        }

        private void TextBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void TextBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void Kepler_CheckedChanged(object sender, EventArgs e)
        {
            Clear_Click(sender, e);

            textBox13.Visible = true;

            textBox2.Visible = true;
            textBox4.Visible = true;
            textBox6.Visible = true;
            textBox8.Visible = true;
            textBox10.Visible = true;
            textBox12.Visible = true;
            textBox14.Visible = true;

            comboBox1.Visible = true;
            comboBox3.Visible = true;
            comboBox5.Visible = true;
            comboBox7.Visible = true;
            comboBox2.Visible = true;
            comboBox4.Visible = true;
            comboBox6.Visible = true;
            comboBox8.Visible = true;
            comboBox10.Visible = false;

            label2.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            label8.Visible = true;
            label10.Visible = true;
            label12.Visible = true;

            label1.Text = "a =";
            label3.Text = "T =";
            label5.Text = "Q =";
            label7.Text = "q =";
            label9.Text = "e =";
            label11.Text = "M =";

            label2.Text = "a =";
            label4.Text = "T =";
            label6.Text = "Q =";
            label8.Text = "q =";
            label10.Text = "e =";
            label12.Text = "M =";

            Combobox_clear();

            comboBox1.Items.AddRange(new string[] { "Мэтар", "Кілямэтр", "a.a." });
            comboBox3.Items.AddRange(new string[] { "Сэкунда", "Гадзіна", "Содні", "Год" });
            comboBox5.Items.AddRange(new string[] { "Мэтар", "Кілямэтр", "a.a." });
            comboBox7.Items.AddRange(new string[] { "Мэтар", "Кілямэтр", "a.a." });

            comboBox2.Items.AddRange(new string[] { "Мэтар", "Кілямэтр", "a.a." });
            comboBox4.Items.AddRange(new string[] { "Сэкунда", "Гадзіна", "Содні", "Год" });
            comboBox6.Items.AddRange(new string[] { "Мэтар", "Кілямэтр", "a.a." });
            comboBox8.Items.AddRange(new string[] { "Мэтар", "Кілямэтр", "a.a." });
            comboBox10.Items.AddRange(new string[] { "Мэтар", "Кілямэтр", "a.a." });

            Combobox_zeroitem();
        }

        private void Satellite_CheckedChanged(object sender, EventArgs e)
        {
            Clear_Click(sender, e);
            Combobox_clear();

            textBox13.Visible = true;

            textBox2.Visible = true;
            textBox4.Visible = true;
            textBox6.Visible = true;
            textBox8.Visible = true;
            textBox10.Visible = true;
            textBox12.Visible = false;
            textBox14.Visible = false;

            comboBox1.Visible = true;
            comboBox3.Visible = true;
            comboBox5.Visible = true;
            comboBox7.Visible = true;
            comboBox2.Visible = true;
            comboBox4.Visible = true;
            comboBox6.Visible = true;
            comboBox8.Visible = true;
            comboBox10.Visible = true;

            label2.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            label8.Visible = true;
            label10.Visible = true;
            label12.Visible = false;

            label1.Text = "a =";
            label3.Text = "T =";
            label5.Text = "Q =";
            label7.Text = "q =";
            label9.Text = "e =";
            label11.Text = "M =";

            label2.Text = "V0 =";
            label4.Text = "VQ =";
            label6.Text = "Vq =";
            label8.Text = "Vr =";
            label10.Text = "r =";

            comboBox1.Items.AddRange(new string[] { "Мэтар", "Кілямэтр", "a.a." });
            comboBox3.Items.AddRange(new string[] { "Сэкунда", "Гадзіна", "Содні", "Год" });
            comboBox5.Items.AddRange(new string[] { "Мэтар", "Кілямэтр", "a.a." });
            comboBox7.Items.AddRange(new string[] { "Мэтар", "Кілямэтр", "a.a." });

            comboBox2.Items.AddRange(new string[] { "м/с", "км/с", "км/г" });
            comboBox4.Items.AddRange(new string[] { "м/с", "км/с", "км/г" });
            comboBox6.Items.AddRange(new string[] { "м/с", "км/с", "км/г" });
            comboBox8.Items.AddRange(new string[] { "м/с", "км/с", "км/г" });
            comboBox10.Items.AddRange(new string[] { "Мэтар", "Кілямэтр", "a.a." });

            Combobox_zeroitem();
        }

        private void Dopler_CheckedChanged(object sender, EventArgs e)
        {
            Clear_Click(sender, e);

            textBox13.Visible = false;

            textBox2.Visible = true;
            textBox4.Visible = false;
            textBox6.Visible = false;
            textBox8.Visible = false;
            textBox10.Visible = false;
            textBox12.Visible = false;
            textBox14.Visible = false;

            comboBox1.Visible = false;
            comboBox3.Visible = false;
            comboBox5.Visible = false;
            comboBox7.Visible = false;
            comboBox2.Visible = false;
            comboBox4.Visible = false;
            comboBox6.Visible = false;
            comboBox8.Visible = false;
            comboBox10.Visible = false;

            label2.Visible = true;
            label4.Visible = false;
            label6.Visible = false;
            label8.Visible = false;
            label10.Visible = false;
            label12.Visible = false;

            label1.Text = "λ =";
            label3.Text = "λ0 =";
            label5.Text = "T =";
            label7.Text = "Vr =";
            label9.Text = "Z =";
            label11.Text = "H =";

            label2.Text = "r =";
            label4.Text = "";
            label6.Text = "";
            label8.Text = "";
            label10.Text = "";
            label12.Text = "";

            Combobox_clear();
        }

        private void Telescopes_CheckedChanged(object sender, EventArgs e)
        {
            Clear_Click(sender, e);
            label1.Text = "D =";
            label3.Text = "d =";
            label5.Text = "F =";
            label7.Text = "f =";
            label9.Text = "n =";
            label11.Text = "m =";

            label2.Text = "A =";
            label4.Text = "Ɐ =";
            label6.Text = "α″ =";

            textBox13.Visible = false;

            textBox2.Visible = true;
            textBox4.Visible = true;
            textBox6.Visible = true;
            textBox8.Visible = false;
            textBox10.Visible = false;
            textBox12.Visible = false;
            textBox14.Visible = false;

            comboBox1.Visible = false;
            comboBox3.Visible = false;
            comboBox5.Visible = false;
            comboBox7.Visible = false;
            comboBox2.Visible = false;
            comboBox4.Visible = false;
            comboBox6.Visible = false;
            comboBox8.Visible = false;
            comboBox10.Visible = false;

            label2.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            label8.Visible = false;
            label10.Visible = false;
            label12.Visible = false;

            Combobox_clear();
        }

        private void Coordinates_CheckedChanged(object sender, EventArgs e)
        {
            Clear_Click(sender, e);

            label1.Text = "Φ =";
            label3.Text = "δ =";
            label5.Text = "h =";
            label7.Text = "A =";
            label9.Text = "t =";
            label11.Text = "";

            label2.Text = "";
            label4.Text = "";
            label6.Text = "";
            label8.Text = "";
            label10.Text = "";
            label12.Text = "";

            textBox13.Visible = false;

            textBox2.Visible = true;
            textBox4.Visible = true;
            textBox6.Visible = true;
            textBox8.Visible = false;
            textBox10.Visible = false;
            textBox12.Visible = false;
            textBox14.Visible = false;

            comboBox1.Visible = false;
            comboBox3.Visible = false;
            comboBox5.Visible = false;
            comboBox7.Visible = false;
            comboBox2.Visible = false;
            comboBox4.Visible = false;
            comboBox6.Visible = false;
            comboBox8.Visible = false;
            comboBox10.Visible = false;

            label2.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            label8.Visible = false;
            label10.Visible = false;
            label12.Visible = false;

            Combobox_clear();
        }

        private void _CheckedChanged(object sender, EventArgs e)
        {
            Clear_Click(sender, e);

            label1.Text = "";
            label3.Text = "";
            label5.Text = "";
            label7.Text = "";
            label9.Text = "";
            label11.Text = "";

            label2.Text = "";
            label4.Text = "";
            label6.Text = "";
            label8.Text = "";
            label10.Text = "";
            label12.Text = "";

            Combobox_clear();
        }
    }
}