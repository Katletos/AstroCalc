namespace astranomija
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.calculate = new MetroFramework.Controls.MetroButton();
            this.kepler = new MetroFramework.Controls.MetroRadioButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.satellite = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton3 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton4 = new MetroFramework.Controls.MetroRadioButton();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton5 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton6 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton7 = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox6 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox7 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox8 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox9 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox10 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox11 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox12 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox13 = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(20, 452);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(164, 35);
            this.calculate.TabIndex = 0;
            this.calculate.Text = "Падлічыць";
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // kepler
            // 
            this.kepler.AutoSize = true;
            this.kepler.Location = new System.Drawing.Point(20, 60);
            this.kepler.Name = "kepler";
            this.kepler.Size = new System.Drawing.Size(114, 15);
            this.kepler.Style = MetroFramework.MetroColorStyle.Red;
            this.kepler.TabIndex = 4;
            this.kepler.TabStop = true;
            this.kepler.Text = "Законы Кеплера";
            this.kepler.UseVisualStyleBackColor = true;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.AccessibleDescription = "";
            this.metroTextBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.metroTextBox1.Location = new System.Drawing.Point(330, 60);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(120, 23);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox1.TabIndex = 5;
            this.metroTextBox1.Tag = "";
            this.metroTextBox1.Text = "Паўвось 1";
            this.metroTextBox1.Enter += new System.EventHandler(this.metroTextBox1_Enter);
            this.metroTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox1_KeyPress);
            this.metroTextBox1.Leave += new System.EventHandler(this.metroTextBox1_Leave);
            // 
            // satellite
            // 
            this.satellite.AutoSize = true;
            this.satellite.Location = new System.Drawing.Point(20, 80);
            this.satellite.Name = "satellite";
            this.satellite.Size = new System.Drawing.Size(98, 15);
            this.satellite.Style = MetroFramework.MetroColorStyle.Red;
            this.satellite.TabIndex = 6;
            this.satellite.TabStop = true;
            this.satellite.Text = "Спадарожнікі";
            this.satellite.UseVisualStyleBackColor = true;
            // 
            // metroRadioButton3
            // 
            this.metroRadioButton3.AutoSize = true;
            this.metroRadioButton3.Location = new System.Drawing.Point(20, 100);
            this.metroRadioButton3.Name = "metroRadioButton3";
            this.metroRadioButton3.Size = new System.Drawing.Size(127, 15);
            this.metroRadioButton3.TabIndex = 7;
            this.metroRadioButton3.TabStop = true;
            this.metroRadioButton3.Text = "metroRadioButton3";
            this.metroRadioButton3.UseVisualStyleBackColor = true;
            // 
            // metroRadioButton4
            // 
            this.metroRadioButton4.AutoSize = true;
            this.metroRadioButton4.Location = new System.Drawing.Point(20, 120);
            this.metroRadioButton4.Name = "metroRadioButton4";
            this.metroRadioButton4.Size = new System.Drawing.Size(127, 15);
            this.metroRadioButton4.TabIndex = 8;
            this.metroRadioButton4.TabStop = true;
            this.metroRadioButton4.Text = "metroRadioButton4";
            this.metroRadioButton4.UseVisualStyleBackColor = true;
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(771, 319);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(117, 23);
            this.metroTextBox2.TabIndex = 9;
            this.metroTextBox2.Tag = "";
            this.metroTextBox2.Text = "Паўвось 2";
            this.metroTextBox2.Enter += new System.EventHandler(this.metroTextBox2_Enter);
            this.metroTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox2_KeyPress);
            this.metroTextBox2.Leave += new System.EventHandler(this.metroTextBox2_Leave);
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(20, 140);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(127, 15);
            this.metroRadioButton1.TabIndex = 11;
            this.metroRadioButton1.TabStop = true;
            this.metroRadioButton1.Text = "metroRadioButton1";
            this.metroRadioButton1.UseVisualStyleBackColor = true;
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(20, 160);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(127, 15);
            this.metroRadioButton2.TabIndex = 12;
            this.metroRadioButton2.TabStop = true;
            this.metroRadioButton2.Text = "metroRadioButton2";
            this.metroRadioButton2.UseVisualStyleBackColor = true;
            // 
            // metroRadioButton5
            // 
            this.metroRadioButton5.AutoSize = true;
            this.metroRadioButton5.Location = new System.Drawing.Point(20, 180);
            this.metroRadioButton5.Name = "metroRadioButton5";
            this.metroRadioButton5.Size = new System.Drawing.Size(127, 15);
            this.metroRadioButton5.TabIndex = 13;
            this.metroRadioButton5.TabStop = true;
            this.metroRadioButton5.Text = "metroRadioButton5";
            this.metroRadioButton5.UseVisualStyleBackColor = true;
            // 
            // metroRadioButton6
            // 
            this.metroRadioButton6.AutoSize = true;
            this.metroRadioButton6.Location = new System.Drawing.Point(20, 200);
            this.metroRadioButton6.Name = "metroRadioButton6";
            this.metroRadioButton6.Size = new System.Drawing.Size(127, 15);
            this.metroRadioButton6.TabIndex = 14;
            this.metroRadioButton6.TabStop = true;
            this.metroRadioButton6.Text = "metroRadioButton6";
            this.metroRadioButton6.UseVisualStyleBackColor = true;
            // 
            // metroRadioButton7
            // 
            this.metroRadioButton7.AutoSize = true;
            this.metroRadioButton7.Location = new System.Drawing.Point(20, 220);
            this.metroRadioButton7.Name = "metroRadioButton7";
            this.metroRadioButton7.Size = new System.Drawing.Size(127, 15);
            this.metroRadioButton7.TabIndex = 15;
            this.metroRadioButton7.TabStop = true;
            this.metroRadioButton7.Text = "metroRadioButton7";
            this.metroRadioButton7.UseVisualStyleBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(450, 100);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(0, 0);
            this.metroLabel4.TabIndex = 17;
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.Location = new System.Drawing.Point(330, 100);
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.Size = new System.Drawing.Size(120, 23);
            this.metroTextBox3.TabIndex = 19;
            this.metroTextBox3.Text = "Перыяд 1";
            this.metroTextBox3.Enter += new System.EventHandler(this.metroTextBox3_Enter);
            this.metroTextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox3_KeyPress);
            this.metroTextBox3.Leave += new System.EventHandler(this.metroTextBox3_Leave);
            // 
            // metroTextBox4
            // 
            this.metroTextBox4.Location = new System.Drawing.Point(771, 348);
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.Size = new System.Drawing.Size(117, 23);
            this.metroTextBox4.TabIndex = 20;
            this.metroTextBox4.Text = "Перыяд 2";
            this.metroTextBox4.Enter += new System.EventHandler(this.metroTextBox4_Enter);
            this.metroTextBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox4_KeyPress);
            this.metroTextBox4.Leave += new System.EventHandler(this.metroTextBox4_Leave);
            // 
            // metroTextBox5
            // 
            this.metroTextBox5.Location = new System.Drawing.Point(330, 140);
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.Size = new System.Drawing.Size(120, 23);
            this.metroTextBox5.TabIndex = 21;
            this.metroTextBox5.Text = "Апацэнтар 1";
            this.metroTextBox5.Enter += new System.EventHandler(this.metroTextBox5_Enter);
            this.metroTextBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox5_KeyPress);
            this.metroTextBox5.Leave += new System.EventHandler(this.metroTextBox5_Leave);
            // 
            // metroTextBox6
            // 
            this.metroTextBox6.Location = new System.Drawing.Point(771, 377);
            this.metroTextBox6.Name = "metroTextBox6";
            this.metroTextBox6.Size = new System.Drawing.Size(117, 23);
            this.metroTextBox6.TabIndex = 22;
            this.metroTextBox6.Text = "Апацэнтар 2";
            this.metroTextBox6.Enter += new System.EventHandler(this.metroTextBox6_Enter);
            this.metroTextBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox6_KeyPress);
            this.metroTextBox6.Leave += new System.EventHandler(this.metroTextBox6_Leave);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(450, 140);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(0, 0);
            this.metroLabel6.TabIndex = 23;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(450, 180);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(0, 0);
            this.metroLabel8.TabIndex = 25;
            // 
            // metroTextBox7
            // 
            this.metroTextBox7.Location = new System.Drawing.Point(330, 180);
            this.metroTextBox7.Name = "metroTextBox7";
            this.metroTextBox7.Size = new System.Drawing.Size(120, 23);
            this.metroTextBox7.TabIndex = 26;
            this.metroTextBox7.Text = "Перыцэнтар 1";
            this.metroTextBox7.Enter += new System.EventHandler(this.metroTextBox7_Enter);
            this.metroTextBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox7_KeyPress);
            this.metroTextBox7.Leave += new System.EventHandler(this.metroTextBox7_Leave);
            // 
            // metroTextBox8
            // 
            this.metroTextBox8.Location = new System.Drawing.Point(771, 406);
            this.metroTextBox8.Name = "metroTextBox8";
            this.metroTextBox8.Size = new System.Drawing.Size(117, 23);
            this.metroTextBox8.TabIndex = 27;
            this.metroTextBox8.Text = "Перыцэнтар 2";
            this.metroTextBox8.Enter += new System.EventHandler(this.metroTextBox8_Enter);
            this.metroTextBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox8_KeyPress);
            this.metroTextBox8.Leave += new System.EventHandler(this.metroTextBox8_Leave);
            // 
            // metroTextBox9
            // 
            this.metroTextBox9.Location = new System.Drawing.Point(330, 220);
            this.metroTextBox9.Name = "metroTextBox9";
            this.metroTextBox9.Size = new System.Drawing.Size(120, 23);
            this.metroTextBox9.TabIndex = 28;
            this.metroTextBox9.Text = "Эксцэнтрысітэт 1";
            this.metroTextBox9.Enter += new System.EventHandler(this.metroTextBox9_Enter);
            this.metroTextBox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox9_KeyPress);
            this.metroTextBox9.Leave += new System.EventHandler(this.metroTextBox9_Leave);
            // 
            // metroTextBox10
            // 
            this.metroTextBox10.Location = new System.Drawing.Point(771, 435);
            this.metroTextBox10.Name = "metroTextBox10";
            this.metroTextBox10.Size = new System.Drawing.Size(117, 23);
            this.metroTextBox10.TabIndex = 29;
            this.metroTextBox10.Text = "Эксцэнтрысітэт 2";
            this.metroTextBox10.Enter += new System.EventHandler(this.metroTextBox10_Enter);
            this.metroTextBox10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox10_KeyPress);
            this.metroTextBox10.Leave += new System.EventHandler(this.metroTextBox10_Leave);
            // 
            // metroTextBox11
            // 
            this.metroTextBox11.Location = new System.Drawing.Point(330, 260);
            this.metroTextBox11.Name = "metroTextBox11";
            this.metroTextBox11.Size = new System.Drawing.Size(120, 23);
            this.metroTextBox11.TabIndex = 30;
            this.metroTextBox11.Text = "Маса 1";
            this.metroTextBox11.Enter += new System.EventHandler(this.metroTextBox11_Enter);
            this.metroTextBox11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox11_KeyPress);
            this.metroTextBox11.Leave += new System.EventHandler(this.metroTextBox11_Leave);
            // 
            // metroTextBox12
            // 
            this.metroTextBox12.Location = new System.Drawing.Point(771, 464);
            this.metroTextBox12.Name = "metroTextBox12";
            this.metroTextBox12.Size = new System.Drawing.Size(117, 23);
            this.metroTextBox12.TabIndex = 31;
            this.metroTextBox12.Text = "Маса 2";
            this.metroTextBox12.Enter += new System.EventHandler(this.metroTextBox12_Enter);
            this.metroTextBox12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox12_KeyPress);
            this.metroTextBox12.Leave += new System.EventHandler(this.metroTextBox12_Leave);
            // 
            // metroTextBox13
            // 
            this.metroTextBox13.Location = new System.Drawing.Point(456, 260);
            this.metroTextBox13.Name = "metroTextBox13";
            this.metroTextBox13.Size = new System.Drawing.Size(59, 23);
            this.metroTextBox13.TabIndex = 32;
            this.metroTextBox13.Text = "10^n";
            this.metroTextBox13.Enter += new System.EventHandler(this.metroTextBox13_Enter);
            this.metroTextBox13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox13_KeyPress);
            this.metroTextBox13.Leave += new System.EventHandler(this.metroTextBox13_Leave);
            // 
            // Form1
            // 
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 510);
            this.Controls.Add(this.metroTextBox13);
            this.Controls.Add(this.metroTextBox12);
            this.Controls.Add(this.metroTextBox11);
            this.Controls.Add(this.metroTextBox10);
            this.Controls.Add(this.metroTextBox9);
            this.Controls.Add(this.metroTextBox8);
            this.Controls.Add(this.metroTextBox7);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroTextBox6);
            this.Controls.Add(this.metroTextBox5);
            this.Controls.Add(this.metroTextBox4);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroRadioButton7);
            this.Controls.Add(this.metroRadioButton6);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroRadioButton5);
            this.Controls.Add(this.metroRadioButton2);
            this.Controls.Add(this.metroRadioButton1);
            this.Controls.Add(this.metroRadioButton4);
            this.Controls.Add(this.metroRadioButton3);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.satellite);
            this.Controls.Add(this.kepler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Tag = "";
            this.Text = "Астракалькулятар";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton calculate;
        private MetroFramework.Controls.MetroRadioButton kepler;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroRadioButton satellite;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton3;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton4;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton5;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton6;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton7;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private MetroFramework.Controls.MetroTextBox metroTextBox6;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox metroTextBox7;
        private MetroFramework.Controls.MetroTextBox metroTextBox8;
        private MetroFramework.Controls.MetroTextBox metroTextBox9;
        private MetroFramework.Controls.MetroTextBox metroTextBox10;
        private MetroFramework.Controls.MetroTextBox metroTextBox11;
        private MetroFramework.Controls.MetroTextBox metroTextBox12;
        private MetroFramework.Controls.MetroTextBox metroTextBox13;
    }
}

