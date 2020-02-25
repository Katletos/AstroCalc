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
        }

        void clear_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = null;
            metroTextBox2.Text = null;
            metroTextBox3.Text = null;
            metroTextBox4.Text = null;
            metroTextBox5.Text = null;
            metroTextBox6.Text = null;
            metroTextBox7.Text = null;
            metroTextBox8.Text = null;
            metroTextBox9.Text = null;
            metroTextBox10.Text = null;
            metroTextBox11.Text = null;
            metroTextBox12.Text = null;
            metroTextBox13.Text = null;
            metroTextBox14.Text = null;
        }

        void errormessage(object parameter)
        {
            MessageBox.Show("Абмыла ў парамэтры " + parameter, "Абмыла");
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double G = Pow(6.67430, -11);
            double c = 299792458;
            double b = 0.002897;

            if (satellite.Checked)
            {
                double a, Q, q, T, M, E, Vq, VQ, h, V0, Vh;
                int n;

                bool v1 = double.TryParse(metroTextBox1.Text, out a);
                bool v2 = double.TryParse(metroTextBox2.Text, out V0);
                bool v3 = double.TryParse(metroTextBox3.Text, out T);
                bool v4 = double.TryParse(metroTextBox4.Text, out VQ);
                bool v5 = double.TryParse(metroTextBox5.Text, out Q);
                bool v6 = double.TryParse(metroTextBox6.Text, out Vq);
                bool v7 = double.TryParse(metroTextBox7.Text, out q);
                bool v8 = double.TryParse(metroTextBox8.Text, out Vh);
                bool v9 = double.TryParse(metroTextBox9.Text, out E);
                bool v10 = double.TryParse(metroTextBox10.Text, out h);
                bool v11 = double.TryParse(metroTextBox11.Text, out M);
                //bool v12 = double.TryParse(metroTextBox12.Text, out );
                bool v13 = int.TryParse(metroTextBox13.Text, out n);

                M = M * Pow(10, n);


                try
                {
                    if (T == 0)
                    {
                        if (a != 0 & M != 0)
                        {
                            T = Sqrt(Pow(a, 3) * 4 * Pow(PI, 2) / G / M);
                            metroTextBox3.Text = Convert.ToString(Round(T, 5));
                        }
                    }

                    if (a == 0)
                    {
                        if (M != 0 & T != 0)
                        {
                            a = Pow(((G * M * Pow(T, 2)) / 4 / Pow(PI, 2)), 1.0 / 3);
                            metroTextBox1.Text = Convert.ToString(Round(a, 5));
                        }

                        if (q != 0 & E != 0)
                        {
                            a = q / (1 - E);
                            metroTextBox1.Text = Convert.ToString(Round(a, 5));
                        }

                        if (Q != 0 & E != 0)
                        {
                            a = Q / (1 - E);
                            metroTextBox1.Text = Convert.ToString(Round(a, 5));
                        }

                        if (q != 0 & Q != 0)
                        {
                            a = (q + Q) / 2;
                            metroTextBox1.Text = Convert.ToString(Round(a, 5));
                        }
                    }

                    if (E == 0)
                    {
                        if (a != 0 & q != 0)
                        {
                            E = 1 - (q / a);
                            metroTextBox9.Text = Convert.ToString(Round(E, 5));
                        }

                        if (a != 0 & Q != 0)
                        {
                            E = (Q / a) - 2;
                            metroTextBox9.Text = Convert.ToString(Round(E, 5));
                        }
                    }

                    if (q == 0)
                    {
                        if (a != 0 & E != 0)
                        {
                            q = a * (1 - E);
                            metroTextBox7.Text = Convert.ToString(Round(q, 5));
                        }

                        if (a != 0 & Q != 0)
                        {
                            q = 2 * a - Q;
                            metroTextBox7.Text = Convert.ToString(Round(q, 5));
                        }
                    }

                    if (Q == 0)
                    {
                        if (a != 0 & E != 0)
                        {
                            Q = a * (1 + E);
                            metroTextBox5.Text = Convert.ToString(Round(Q, 5));
                        }

                        if (a != 0 & q != 0)
                        {
                            Q = 2 * a - q;
                            metroTextBox5.Text = Convert.ToString(Round(Q, 5));
                        }
                    }

                    if (V0 == 0)
                    {
                        if (a != 0 & T != 0)
                        {
                            V0 = 2 * PI * a / T;
                            metroTextBox2.Text = Convert.ToString(Round(V0, 5));
                        }
                    }

                    if (VQ == 0)
                    {
                        if (Q != 0 & a != 0 & M != 0)
                        {
                            VQ = Sqrt(G * M * (2 / Q - 1 / a));
                            metroTextBox4.Text = Convert.ToString(Round(VQ, 5));
                        }
                    }

                    if (Vq == 0)
                    {
                        if (q != 0 & a != 0 & M != 0)
                        {
                            Vq = Sqrt(G * M * (2 / q - 1 / a));
                            metroTextBox6.Text = Convert.ToString(Round(Vq, 5));
                        }
                    }

                    if (Vh == 0)
                    {
                        if (h != 0 & h < Q)
                        {
                            if (a != 0 & M != 0)
                            {
                                Vh = Sqrt(G * M * (2 / h - 1 / a));
                                metroTextBox6.Text = Convert.ToString(Round(Vq, 5));
                            }
                        }
                        else
                        {
                            errormessage("h");
                        }
                    }

                    if (h == 0)
                    {
                        if (h != 0 & h < Q)
                        {
                            if (M != 0 & a != 0 & Vh != 0)
                            {
                                h = 2 * G * M * a / (Pow(Vh, 2) + G * M);
                                metroTextBox10.Text = Convert.ToString(Round(h, 5));
                            }
                        }
                    }
                }
                finally
                {

                }
            }

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


                if (comboBox1.SelectedIndex == 0)
                {

                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    a1 = a1 * 1000;
                   // metroTextBox1.Text = Convert.ToString(Round(a1 * 1000, 5));
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    a1 = a1 * 149597870700;
                  //  metroTextBox1.Text = Convert.ToString(Round(a1 * 149597870700, 5));
                }

                try
                {
                    if (a1 == 0)
                    {
                        if (M1 != 0 & T1 != 0)
                        {
                            a1 = Pow(((G * M1 * Pow(T1, 2)) / 4 / Pow(PI, 2)), 1.0 / 3);
                            metroTextBox1.Text = Convert.ToString(Round(a1, 5));
                        }

                        if (q1 != 0 & e1 != 0)
                        {
                            a1 = q1 / (1 - e1);
                            metroTextBox1.Text = Convert.ToString(Round(a1, 5));
                        }

                        if (Q1 != 0 & e1 != 0)
                        {
                            a1 = Q1 / (1 - e1);
                            metroTextBox1.Text = Convert.ToString(Round(a1, 5));
                        }

                        if (q1 != 0 & Q1 != 0)
                        {
                            a1 = (q1 + Q1) / 2;
                            metroTextBox1.Text = Convert.ToString(Round(a1, 5));
                        }

                        if (M1 != 0 & M2 != 0 & a2 != 0)
                        {
                            a1 = M2 * a2 / M1;
                            metroTextBox1.Text = Convert.ToString(Round(a1, 5));
                        }
                    }

                    if (e1 == 0)
                    {
                        if (a1 != 0 & q1 != 0)
                        {
                            e1 = 1 - (q1 / a1);
                            metroTextBox9.Text = Convert.ToString(Round(e1, 5));
                        }

                        if (a1 != 0 & Q1 != 0)
                        {
                            e1 = (Q1 / a1) - 2;
                            metroTextBox9.Text = Convert.ToString(Round(e1, 5));
                        }
                    }

                    if (q1 == 0)
                    {
                        if (a1 != 0 & e1 != 0)
                        {
                            q1 = a1 * (1 - e1);
                            metroTextBox7.Text = Convert.ToString(Round(q1, 5));
                        }

                        if (a1 != 0 & Q1 != 0)
                        {
                            q1 = 2 * a1 - Q1;
                            metroTextBox7.Text = Convert.ToString(Round(q1, 5));
                        }
                    }

                    if (Q1 == 0)
                    {
                        if (a1 != 0 & e1 != 0)
                        {
                            Q1 = a1 * (1 + e1);
                            metroTextBox5.Text = Convert.ToString(Round(Q1, 5));
                        }

                        if (a1 != 0 & q1 != 0)
                        {
                            Q1 = 2 * a1 - q1;
                            metroTextBox5.Text = Convert.ToString(Round(Q1, 5));
                        }
                    }

                    if (a2 == 0)
                    {
                        if (M2 != 0 & T2 != 0)
                        {
                            a2 = Pow(((G * M2 * Pow(T2, 2)) / 4 / Pow(PI, 2)), 1.0 / 3);
                            metroTextBox2.Text = Convert.ToString(Round(a2, 5));
                        }

                        if (q2 != 0 & e2 != 0)
                        {
                            a2 = q2 / (1 - e2);
                            metroTextBox2.Text = Convert.ToString(Round(a2, 5));
                        }

                        if (Q2 != 0 & e2 != 0)
                        {
                            a2 = Q2 / (1 - e2);
                            metroTextBox2.Text = Convert.ToString(Round(a2, 5));
                        }

                        if (q2 != 0 & Q2 != 0)
                        {
                            a2 = (q2 + Q2) / 2;
                            metroTextBox2.Text = Convert.ToString(Round(a2, 5));
                        }

                        if (a1 != 0 & M1 != 0 & M2 != 0)
                        {
                            a2 = M1 * a1 / M2;
                            metroTextBox2.Text = Convert.ToString(Round(a2, 5));
                        }
                    }

                    if (e2 == 0)
                    {
                        if (a2 != 0 & q2 != 0)
                        {
                            e2 = 1 - (q2 / a2);
                            metroTextBox10.Text = Convert.ToString(Round(e2, 5));
                        }

                        if (a2 != 0 & Q2 != 0)
                        {
                            e2 = (Q2 / a2) - 1;
                            metroTextBox10.Text = Convert.ToString(Round(e2, 5));
                        }
                    }

                    if (q2 == 0)
                    {
                        if (a2 != 0 & e2 != 0)
                        {
                            q2 = a2 * (1 - e2);
                            metroTextBox8.Text = Convert.ToString(Round(q2, 5));
                        }

                        if (a2 != 0 & Q2 != 0)
                        {
                            q2 = 2 * a2 - Q2;
                            metroTextBox8.Text = Convert.ToString(Round(q2, 5));
                        }
                    }

                    if (Q2 == 0)
                    {
                        if (a2 != 0 & e2 != 0)
                        {
                            Q2 = a2 * (1 + e2);
                            metroTextBox6.Text = Convert.ToString(Round(Q2, 5));
                        }

                        if (a2 != 0 & q2 != 0)
                        {
                            Q2 = 2 * a2 - q2;
                            metroTextBox6.Text = Convert.ToString(Round(Q2, 5));
                        }
                    }

                    if (M1 == 0)
                    {
                        if (a1 != 0 & T1 != 0)
                        {
                            M1 = (4 * Pow(PI, 2) * Pow(a1, 3)) / Pow(T1, 2) / G;
                            metroTextBox11.Text = Convert.ToString(Round(M1, 5));
                        }

                        if (a1 != 0 & a2 != 0 & M2 != 0)
                        {
                            M1 = M2 * a2 / a1;
                            double n = Convert.ToString(Round(M1)).Length;
                            metroTextBox11.Text = Convert.ToString(Round(n / ((n - 1) * 10), 5));
                            metroTextBox13.Text = Convert.ToString(n);
                        }
                    }

                    if (M2 == 0)
                    {
                        if (a2 != 0 & T2 != 0)
                        {
                            M2 = (4 * Pow(PI, 2) * Pow(a2, 3)) / Pow(T2, 2) / G;
                            metroTextBox12.Text = Convert.ToString(Round(M2, 5));
                        }

                        if (a1 != 0 & a2 != 0 & M1 != 0)
                        {
                            M2 = M1 * a1 / a2;
                            double k = Convert.ToString(Round(M2)).Length;
                            metroTextBox12.Text = Convert.ToString(Round(k / ((k - 1) * 10), 5));
                            metroTextBox14.Text = Convert.ToString(k);
                        }
                    }

                    if (a1 != 0 & M1 != 0 & T1 == 0)
                    {
                        T1 = Sqrt(Pow(a1, 3) * 4 * Pow(PI, 2) / G / M1);
                        metroTextBox3.Text = Convert.ToString(Round(T1, 5));
                    }

                    if (a2 != 0 & M2 != 0 & T2 == 0)
                    {
                        T2 = Sqrt(Pow(a2, 3) * 4 * Pow(PI, 2) / G / M2);
                        metroTextBox4.Text = Convert.ToString(Round(T2, 5));
                    }
                }
                finally
                {

                }
            }

            if (dopler.Checked)
            {
                double z, lambda, lambda0, Vr, H, T;

                z = 0;
                lambda = 0;
                lambda0 = 0;
                Vr = 0;
                H = 0;
                T = 0;

                bool v1 = double.TryParse(metroTextBox1.Text, out lambda);
                bool v2 = double.TryParse(metroTextBox3.Text, out lambda0);
                bool v3 = double.TryParse(metroTextBox5.Text, out T);
                bool v4 = double.TryParse(metroTextBox7.Text, out Vr);
                bool v5 = double.TryParse(metroTextBox11.Text, out z);

                lambda = lambda * Pow(10, -9);
                lambda0 = lambda0 * Pow(10, -9);

                try
                {
                    if (lambda == 0)
                    {
                        if (T != 0)
                        {
                            lambda = b / T;
                            metroTextBox1.Text = Convert.ToString(Round(lambda, 5));
                        }

                        if (lambda != 0 & lambda0 != 0)
                        {
                            lambda = (lambda0 * (1 + z)) / z;
                            metroTextBox1.Text = Convert.ToString(Round(lambda, 5));
                        }
                    }

                    if (T == 0 & lambda != 0)
                    {
                        T = b / lambda;
                        double k = Convert.ToString(T).Length;
                        metroTextBox5.Text = Convert.ToString(Round(k / ((k - 1) * 10), 5) + " * 10^ " + k);
                    }

                    if (z == 0 & Vr != 0)
                    {
                        z = Vr / c;
                        metroTextBox9.Text = Convert.ToString(Round(z, 5));
                    }

                    if (Vr == 0 & z != 0)
                    {
                        Vr = z * c;
                        metroTextBox7.Text = Convert.ToString(Round(Vr, 5));
                    }

                    if (z == 0 & lambda != 0 & lambda0 != 0)
                    {
                        z = (lambda - lambda0) / lambda0;
                        metroTextBox9.Text = Convert.ToString(Round(z, 5));
                    }

                    if (lambda0 == 0 & lambda != 0 & z != 0)
                    {
                        lambda0 = (z * lambda) / (1 + z);
                        metroTextBox3.Text = Convert.ToString(Round(lambda0, 5));
                    }
                }
                finally
                {

                }
            }

            if (telescopes.Checked)
            {
                double D, d, F, f, n, alpha, m, A, Anum;

                bool v1 = double.TryParse(metroTextBox1.Text, out D);
                bool v2 = double.TryParse(metroTextBox2.Text, out A);
                bool v3 = double.TryParse(metroTextBox3.Text, out d);
                bool v4 = double.TryParse(metroTextBox4.Text, out Anum);
                bool v5 = double.TryParse(metroTextBox5.Text, out F);
                bool v6 = double.TryParse(metroTextBox6.Text, out alpha);
                bool v7 = double.TryParse(metroTextBox7.Text, out f);
                //bool v8 = double.TryParse(metroTextBox8.Text, out );
                bool v9 = double.TryParse(metroTextBox9.Text, out n);
                //bool v10 = double.TryParse(metroTextBox10.Text, out );
                bool v11 = double.TryParse(metroTextBox11.Text, out m);
                //bool v12 = double.TryParse(metroTextBox12.Text, out );
                //bool v13 = int.TryParse(metroTextBox13.Text, out );
                //bool v14 = int.TryParse(metroTextBox14.Text, out );

                try
                {
                    if (n == 0)
                    {
                        if (F != 0 & f != 0)
                        {
                            n = F / f;
                            metroTextBox9.Text = Convert.ToString(n);
                        }

                        if (D != 0 & d != 0)
                        {
                            n = D / d;
                            metroTextBox9.Text = Convert.ToString(n);
                        }
                    }

                    if (F == 0)
                    {
                        if (n != 0 & f != 0)
                        {
                            F = n * f;
                            metroTextBox5.Text = Convert.ToString(F);
                        }
                    }

                    if (f == 0)
                    {
                        if (n != 0 & F != 0)
                        {
                            f = F / n;
                            metroTextBox7.Text = Convert.ToString(f);
                        }
                    }

                    if (D == 0)
                    {
                        if (n != 0 & d != 0)
                        {
                            D = n * d;
                            metroTextBox1.Text = Convert.ToString(D);
                        }

                        if (m != 0)
                        {
                            D = Log10((m - 2.1) / 5);
                            metroTextBox1.Text = Convert.ToString(D);
                        }

                        if (alpha != 0)
                        {
                            D = 138 / alpha;
                            metroTextBox1.Text = Convert.ToString(D);
                        }
                    }

                    if (d == 0)
                    {
                        if (n != 0 & D != 0)
                        {
                            d = D / n;
                            metroTextBox1.Text = Convert.ToString(d);
                        }
                    }

                    if (alpha == 0)
                    {
                        alpha = 138 / D;
                        metroTextBox6.Text = Convert.ToString(Round(alpha, 5));
                    }

                    if (m == 0)
                    {
                        if (D != 0)
                        {
                            m = 2.1 + 5 * Log10(D);
                            metroTextBox11.Text = Convert.ToString(Round(m, 5));
                        }
                    }

                    if (A == 0)
                    {
                        if (D != 0 & F != 0)
                        {
                            A = D / F;
                            metroTextBox2.Text = Convert.ToString(A);
                        }

                        if (Anum != 0)
                        {
                            A = 1 / Anum;
                            metroTextBox2.Text = Convert.ToString(A);
                        }
                    }

                    if (Anum == 0)
                    {
                        if (D != 0 & F != 0)
                        {
                            Anum = F / D;
                            metroTextBox4.Text = Convert.ToString(Anum);
                        }

                        if (A != 0)
                        {
                            Anum = 1 / A;
                            metroTextBox4.Text = Convert.ToString(Anum);
                        }
                    }
                }
                finally
                {

                }
            }

            if (coordinates.Checked)
            {
                double phi, delta, hup, hdown;

                bool v1 = double.TryParse(metroTextBox1.Text, out phi);
                //bool v2 = double.TryParse(metroTextBox2.Text, out );
                bool v3 = double.TryParse(metroTextBox3.Text, out delta);
                //bool v4 = double.TryParse(metroTextBox4.Text, out );
                bool v5 = double.TryParse(metroTextBox5.Text, out hup);
                //bool v6 = double.TryParse(metroTextBox6.Text, out );
                bool v7 = double.TryParse(metroTextBox7.Text, out hdown);
                //bool v8 = double.TryParse(metroTextBox8.Text, out );
                //bool v9 = double.TryParse(metroTextBox9.Text, out );
                //bool v10 = double.TryParse(metroTextBox10.Text, out );
                //bool v11 = double.TryParse(metroTextBox11.Text, out );
                //bool v12 = double.TryParse(metroTextBox12.Text, out );
                //bool v13 = int.TryParse(metroTextBox13.Text, out );
                //bool v14 = int.TryParse(metroTextBox14.Text, out );

                if (phi == 0)
                {
                    if (delta != 0 & hup != 0)
                    {
                        phi = 90 - hup + delta;
                    }


                }
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void kepler_CheckedChanged(object sender, EventArgs e)
        {
            clear_Click(sender, e);
            metroLabel1.Text = "a =";
            metroLabel3.Text = "T =";
            metroLabel5.Text = "Q =";
            metroLabel7.Text = "q =";
            metroLabel9.Text = "e =";
            metroLabel11.Text = "M =";

            metroLabel2.Text = "a =";
            metroLabel4.Text = "T =";
            metroLabel6.Text = "Q =";
            metroLabel8.Text = "q =";
            metroLabel10.Text = "e =";
            metroLabel12.Text = "M =";
        }

        private void satellite_CheckedChanged(object sender, EventArgs e)
        {
            clear_Click(sender, e);
            metroLabel1.Text = "a =";
            metroLabel3.Text = "T =";
            metroLabel5.Text = "Q =";
            metroLabel7.Text = "q =";
            metroLabel9.Text = "e =";
            metroLabel11.Text = "M =";

            metroLabel2.Text = "V0 =";
            metroLabel4.Text = "VQ =";
            metroLabel6.Text = "Vq =";
            metroLabel8.Text = "Vh =";
            metroLabel10.Text = "h =";
            metroLabel12.Text = "";
        }

        private void dopler_CheckedChanged(object sender, EventArgs e)
        {
            clear_Click(sender, e);
            metroLabel1.Text = "λ =";
            metroLabel3.Text = "λ0 =";
            metroLabel5.Text = "T =";
            metroLabel7.Text = "Vr =";
            metroLabel9.Text = "Z =";
            metroLabel11.Text = "";

            metroLabel2.Text = "";
            metroLabel4.Text = "";
            metroLabel6.Text = "";
            metroLabel8.Text = "";
            metroLabel10.Text = "";
            metroLabel12.Text = "";
        }

        private void telescopes_CheckedChanged(object sender, EventArgs e)
        {
            clear_Click(sender, e);
            metroLabel1.Text = "D =";
            metroLabel3.Text = "d =";
            metroLabel5.Text = "F =";
            metroLabel7.Text = "f =";
            metroLabel9.Text = "n =";
            metroLabel11.Text = "m =";

            metroLabel2.Text = "A =";
            metroLabel4.Text = "Ɐ =";
            metroLabel6.Text = "α″ =";
            metroLabel8.Text = "";
            metroLabel10.Text = "";
            metroLabel12.Text = "";
        }

        private void coordinates_CheckedChanged(object sender, EventArgs e)
        {
            clear_Click(sender, e);
            metroLabel1.Text = "";
            metroLabel3.Text = "";
            metroLabel5.Text = "";
            metroLabel7.Text = "";
            metroLabel9.Text = "";
            metroLabel11.Text = "";

            metroLabel2.Text = "";
            metroLabel4.Text = "";
            metroLabel6.Text = "";
            metroLabel8.Text = "";
            metroLabel10.Text = "";
            metroLabel12.Text = "";
        }
    }
}