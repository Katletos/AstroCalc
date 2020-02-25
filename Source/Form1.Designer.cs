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
            this.dopler = new MetroFramework.Controls.MetroRadioButton();
            this.telescopes = new MetroFramework.Controls.MetroRadioButton();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.coordinates = new MetroFramework.Controls.MetroRadioButton();
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
            this.metroTextBox7 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox8 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox9 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox10 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox11 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox12 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox13 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox14 = new MetroFramework.Controls.MetroTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.clear = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
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
            this.kepler.CheckedChanged += new System.EventHandler(this.kepler_CheckedChanged);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.AccessibleDescription = "";
            this.metroTextBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.metroTextBox1.Location = new System.Drawing.Point(330, 60);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(119, 21);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox1.TabIndex = 5;
            this.metroTextBox1.Tag = "";
            this.metroTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox1_KeyPress);
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
            this.satellite.CheckedChanged += new System.EventHandler(this.satellite_CheckedChanged);
            // 
            // dopler
            // 
            this.dopler.AutoSize = true;
            this.dopler.Location = new System.Drawing.Point(20, 121);
            this.dopler.Name = "dopler";
            this.dopler.Size = new System.Drawing.Size(107, 15);
            this.dopler.TabIndex = 7;
            this.dopler.TabStop = true;
            this.dopler.Text = "Эфэкт Доплера";
            this.dopler.UseVisualStyleBackColor = true;
            this.dopler.CheckedChanged += new System.EventHandler(this.dopler_CheckedChanged);
            // 
            // telescopes
            // 
            this.telescopes.AutoSize = true;
            this.telescopes.Location = new System.Drawing.Point(20, 100);
            this.telescopes.Name = "telescopes";
            this.telescopes.Size = new System.Drawing.Size(84, 15);
            this.telescopes.TabIndex = 8;
            this.telescopes.TabStop = true;
            this.telescopes.Text = "Тэлескопы";
            this.telescopes.UseVisualStyleBackColor = true;
            this.telescopes.CheckedChanged += new System.EventHandler(this.telescopes_CheckedChanged);
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(625, 60);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(117, 23);
            this.metroTextBox2.TabIndex = 9;
            this.metroTextBox2.Tag = "";
            this.metroTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox2_KeyPress);
            // 
            // coordinates
            // 
            this.coordinates.AutoSize = true;
            this.coordinates.Location = new System.Drawing.Point(20, 140);
            this.coordinates.Name = "coordinates";
            this.coordinates.Size = new System.Drawing.Size(149, 15);
            this.coordinates.TabIndex = 11;
            this.coordinates.TabStop = true;
            this.coordinates.Text = "Нябесныя каардынаты";
            this.coordinates.UseVisualStyleBackColor = true;
            this.coordinates.CheckedChanged += new System.EventHandler(this.coordinates_CheckedChanged);
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
            this.metroLabel4.BackColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(579, 100);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(29, 19);
            this.metroLabel4.TabIndex = 39;
            this.metroLabel4.Text = "T =";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.Location = new System.Drawing.Point(330, 100);
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.Size = new System.Drawing.Size(120, 21);
            this.metroTextBox3.TabIndex = 19;
            this.metroTextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox3_KeyPress);
            // 
            // metroTextBox4
            // 
            this.metroTextBox4.Location = new System.Drawing.Point(625, 100);
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.Size = new System.Drawing.Size(117, 23);
            this.metroTextBox4.TabIndex = 20;
            this.metroTextBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox4_KeyPress);
            // 
            // metroTextBox5
            // 
            this.metroTextBox5.Location = new System.Drawing.Point(330, 140);
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.Size = new System.Drawing.Size(120, 21);
            this.metroTextBox5.TabIndex = 21;
            this.metroTextBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox5_KeyPress);
            // 
            // metroTextBox6
            // 
            this.metroTextBox6.Location = new System.Drawing.Point(625, 140);
            this.metroTextBox6.Name = "metroTextBox6";
            this.metroTextBox6.Size = new System.Drawing.Size(117, 23);
            this.metroTextBox6.TabIndex = 22;
            this.metroTextBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox6_KeyPress);
            // 
            // metroLabel6
            // 
            this.metroLabel6.Location = new System.Drawing.Point(568, 140);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(40, 23);
            this.metroLabel6.TabIndex = 38;
            this.metroLabel6.Text = "Q =";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroTextBox7
            // 
            this.metroTextBox7.Location = new System.Drawing.Point(330, 180);
            this.metroTextBox7.Name = "metroTextBox7";
            this.metroTextBox7.Size = new System.Drawing.Size(120, 23);
            this.metroTextBox7.TabIndex = 26;
            this.metroTextBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox7_KeyPress);
            // 
            // metroTextBox8
            // 
            this.metroTextBox8.Location = new System.Drawing.Point(625, 180);
            this.metroTextBox8.Name = "metroTextBox8";
            this.metroTextBox8.Size = new System.Drawing.Size(117, 23);
            this.metroTextBox8.TabIndex = 27;
            this.metroTextBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox8_KeyPress);
            // 
            // metroTextBox9
            // 
            this.metroTextBox9.Location = new System.Drawing.Point(330, 220);
            this.metroTextBox9.Name = "metroTextBox9";
            this.metroTextBox9.Size = new System.Drawing.Size(120, 23);
            this.metroTextBox9.TabIndex = 28;
            this.metroTextBox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox9_KeyPress);
            // 
            // metroTextBox10
            // 
            this.metroTextBox10.Location = new System.Drawing.Point(625, 220);
            this.metroTextBox10.Name = "metroTextBox10";
            this.metroTextBox10.Size = new System.Drawing.Size(117, 23);
            this.metroTextBox10.TabIndex = 29;
            this.metroTextBox10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox10_KeyPress);
            // 
            // metroTextBox11
            // 
            this.metroTextBox11.Location = new System.Drawing.Point(330, 260);
            this.metroTextBox11.Name = "metroTextBox11";
            this.metroTextBox11.Size = new System.Drawing.Size(120, 23);
            this.metroTextBox11.TabIndex = 30;
            this.metroTextBox11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox11_KeyPress);
            // 
            // metroTextBox12
            // 
            this.metroTextBox12.Location = new System.Drawing.Point(625, 260);
            this.metroTextBox12.Name = "metroTextBox12";
            this.metroTextBox12.Size = new System.Drawing.Size(117, 23);
            this.metroTextBox12.TabIndex = 31;
            this.metroTextBox12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox12_KeyPress);
            // 
            // metroTextBox13
            // 
            this.metroTextBox13.Location = new System.Drawing.Point(455, 260);
            this.metroTextBox13.Name = "metroTextBox13";
            this.metroTextBox13.Size = new System.Drawing.Size(50, 23);
            this.metroTextBox13.TabIndex = 32;
            this.metroTextBox13.Text = "10^n";
            this.metroTextBox13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox13_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(295, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(29, 19);
            this.metroLabel1.TabIndex = 33;
            this.metroLabel1.Text = "a =";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(579, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(29, 19);
            this.metroLabel2.TabIndex = 34;
            this.metroLabel2.Text = "a =";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(295, 100);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(29, 19);
            this.metroLabel3.TabIndex = 35;
            this.metroLabel3.Text = "T =";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(291, 140);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(33, 19);
            this.metroLabel5.TabIndex = 36;
            this.metroLabel5.Text = "Q =";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroTextBox14
            // 
            this.metroTextBox14.Location = new System.Drawing.Point(750, 260);
            this.metroTextBox14.Name = "metroTextBox14";
            this.metroTextBox14.Size = new System.Drawing.Size(50, 23);
            this.metroTextBox14.TabIndex = 40;
            this.metroTextBox14.Text = "10^n";
            this.metroTextBox14.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox14_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Мэтар",
            "Кілямэтр",
            "а. а."});
            this.comboBox1.Location = new System.Drawing.Point(455, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(80, 21);
            this.comboBox1.TabIndex = 41;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Сэкунда",
            "Гадзіна",
            "Содні",
            "Год"});
            this.comboBox3.Location = new System.Drawing.Point(455, 100);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(80, 21);
            this.comboBox3.TabIndex = 42;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(455, 140);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(80, 21);
            this.comboBox5.TabIndex = 43;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(455, 180);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(80, 21);
            this.comboBox7.TabIndex = 44;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(750, 60);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 45;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(750, 100);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 46;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(750, 140);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 47;
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(750, 180);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(121, 21);
            this.comboBox8.TabIndex = 48;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(20, 408);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(164, 38);
            this.clear.TabIndex = 49;
            this.clear.Text = "Скінуць";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(294, 180);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(30, 19);
            this.metroLabel7.TabIndex = 50;
            this.metroLabel7.Text = "q =";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(579, 180);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(30, 19);
            this.metroLabel8.TabIndex = 51;
            this.metroLabel8.Text = "q =";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(295, 220);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(29, 19);
            this.metroLabel9.TabIndex = 52;
            this.metroLabel9.Text = "e =";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(579, 220);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(29, 19);
            this.metroLabel10.TabIndex = 53;
            this.metroLabel10.Text = "e =";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(290, 260);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(34, 19);
            this.metroLabel11.TabIndex = 54;
            this.metroLabel11.Text = "M =";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(568, 260);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(34, 19);
            this.metroLabel12.TabIndex = 55;
            this.metroLabel12.Text = "M =";
            this.metroLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 510);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.metroTextBox14);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBox13);
            this.Controls.Add(this.metroTextBox12);
            this.Controls.Add(this.metroTextBox11);
            this.Controls.Add(this.metroTextBox10);
            this.Controls.Add(this.metroTextBox9);
            this.Controls.Add(this.metroTextBox8);
            this.Controls.Add(this.metroTextBox7);
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
            this.Controls.Add(this.coordinates);
            this.Controls.Add(this.telescopes);
            this.Controls.Add(this.dopler);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.satellite);
            this.Controls.Add(this.kepler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Tag = "";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton calculate;
        private MetroFramework.Controls.MetroRadioButton kepler;        
        private MetroFramework.Controls.MetroRadioButton satellite;
        private MetroFramework.Controls.MetroRadioButton dopler;
        private MetroFramework.Controls.MetroRadioButton telescopes;      
        private MetroFramework.Controls.MetroRadioButton coordinates;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton5;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton6;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton7;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private MetroFramework.Controls.MetroTextBox metroTextBox6;       
        private MetroFramework.Controls.MetroTextBox metroTextBox7;
        private MetroFramework.Controls.MetroTextBox metroTextBox8;
        private MetroFramework.Controls.MetroTextBox metroTextBox9;
        private MetroFramework.Controls.MetroTextBox metroTextBox10;
        private MetroFramework.Controls.MetroTextBox metroTextBox11;
        private MetroFramework.Controls.MetroTextBox metroTextBox12;
        private MetroFramework.Controls.MetroTextBox metroTextBox13;
        private MetroFramework.Controls.MetroTextBox metroTextBox14;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox8;
        private MetroFramework.Controls.MetroButton clear;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroLabel metroLabel4;
        public MetroFramework.Controls.MetroLabel metroLabel5;
        public MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
    }
}