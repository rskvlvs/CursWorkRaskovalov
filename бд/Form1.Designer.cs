namespace бд
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            calcBtn = new Button();
            label1 = new Label();
            textBoxu = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBoxKhl = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            textBoxEa = new TextBox();
            label14 = new Label();
            textBoxFt = new TextBox();
            label16 = new Label();
            boxKhb = new ComboBox();
            label17 = new Label();
            textBoxb = new TextBox();
            label19 = new Label();
            boxg0 = new ComboBox();
            label20 = new Label();
            textBoxVm = new TextBox();
            label21 = new Label();
            textBoxRe = new TextBox();
            label22 = new Label();
            textBoxdm1 = new TextBox();
            label23 = new Label();
            textBoxsigmah = new TextBox();
            textBoxsigmahp = new TextBox();
            Boxsigmastr = new ComboBox();
            label4 = new Label();
            textBoxResult = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label9 = new Label();
            label13 = new Label();
            label15 = new Label();
            label24 = new Label();
            boxAngle = new ComboBox();
            BoxCoefficient = new ComboBox();
            boxMaterial = new ComboBox();
            TextBoxHardness = new TextBox();
            BoxTeethType = new ComboBox();
            SuspendLayout();
            // 
            // calcBtn
            // 
            calcBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            calcBtn.Location = new Point(929, 228);
            calcBtn.Name = "calcBtn";
            calcBtn.Size = new Size(171, 85);
            calcBtn.TabIndex = 0;
            calcBtn.Text = "Рассчитать";
            calcBtn.UseVisualStyleBackColor = true;
            calcBtn.Click += calcBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label1.Location = new Point(12, 77);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 1;
            label1.Text = "Передаточное число u";
            // 
            // textBoxu
            // 
            textBoxu.Font = new Font("Times New Roman", 9.75F);
            textBoxu.Location = new Point(304, 77);
            textBoxu.Name = "textBoxu";
            textBoxu.Size = new Size(100, 22);
            textBoxu.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(929, 37);
            label7.Name = "label7";
            label7.Size = new Size(171, 19);
            label7.TabIndex = 12;
            label7.Text = "Выходные параметры";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label8.Location = new Point(8, 229);
            label8.Name = "label8";
            label8.Size = new Size(204, 15);
            label8.TabIndex = 13;
            label8.Text = "Коэффициента долговечности Khl ";
            // 
            // textBoxKhl
            // 
            textBoxKhl.Font = new Font("Times New Roman", 9.75F);
            textBoxKhl.Location = new Point(304, 229);
            textBoxKhl.Name = "textBoxKhl";
            textBoxKhl.Size = new Size(100, 22);
            textBoxKhl.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label10.Location = new Point(816, 116);
            label10.Name = "label10";
            label10.Size = new Size(243, 15);
            label10.TabIndex = 15;
            label10.Text = "Значение допускаемого напряжения, σHP";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label11.Location = new Point(112, 37);
            label11.Name = "label11";
            label11.Size = new Size(158, 19);
            label11.TabIndex = 16;
            label11.Text = "Входные параметры";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label12.Location = new Point(8, 263);
            label12.Name = "label12";
            label12.Size = new Size(98, 15);
            label12.TabIndex = 17;
            label12.Text = "Определение Ea";
            // 
            // textBoxEa
            // 
            textBoxEa.Font = new Font("Times New Roman", 9.75F);
            textBoxEa.Location = new Point(304, 263);
            textBoxEa.Name = "textBoxEa";
            textBoxEa.Size = new Size(100, 22);
            textBoxEa.TabIndex = 18;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label14.Location = new Point(8, 291);
            label14.Name = "label14";
            label14.Size = new Size(164, 15);
            label14.TabIndex = 20;
            label14.Text = "Исходная расчётная сила Ft";
            // 
            // textBoxFt
            // 
            textBoxFt.Font = new Font("Times New Roman", 9.75F);
            textBoxFt.Location = new Point(304, 291);
            textBoxFt.Name = "textBoxFt";
            textBoxFt.Size = new Size(100, 22);
            textBoxFt.TabIndex = 21;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label16.Location = new Point(8, 329);
            label16.Name = "label16";
            label16.Size = new Size(110, 15);
            label16.TabIndex = 26;
            label16.Text = "Коэффициент Khb";
            // 
            // boxKhb
            // 
            boxKhb.DropDownStyle = ComboBoxStyle.DropDownList;
            boxKhb.Font = new Font("Times New Roman", 9.75F);
            boxKhb.FormattingEnabled = true;
            boxKhb.Items.AddRange(new object[] { "1,16", "1,37", "1,58", "1,8", "1,08", "1,18", "1,29", "1,4", "1,07", "1,14", "1,23", "1,34", "1", "1,2", "1,32", "1,44", "1,55", "1,04", "1,1", "1,15", "1,22", "1,28", "1,13" });
            boxKhb.Location = new Point(304, 329);
            boxKhb.Name = "boxKhb";
            boxKhb.Size = new Size(100, 23);
            boxKhb.TabIndex = 27;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label17.Location = new Point(8, 369);
            label17.Name = "label17";
            label17.Size = new Size(101, 15);
            label17.TabIndex = 30;
            label17.Text = "Ширина ремня b";
            // 
            // textBoxb
            // 
            textBoxb.Font = new Font("Times New Roman", 9.75F);
            textBoxb.Location = new Point(304, 369);
            textBoxb.Name = "textBoxb";
            textBoxb.Size = new Size(100, 22);
            textBoxb.TabIndex = 31;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label19.Location = new Point(12, 414);
            label19.Name = "label19";
            label19.Size = new Size(21, 15);
            label19.TabIndex = 34;
            label19.Text = "g0";
            // 
            // boxg0
            // 
            boxg0.DropDownStyle = ComboBoxStyle.DropDownList;
            boxg0.Font = new Font("Times New Roman", 9.75F);
            boxg0.FormattingEnabled = true;
            boxg0.Items.AddRange(new object[] { "17", "28", "38", "47", "56", "22", "31", "42", "53", "61", "82", "37", "48", "64", "73", "100" });
            boxg0.Location = new Point(307, 414);
            boxg0.Name = "boxg0";
            boxg0.Size = new Size(100, 23);
            boxg0.TabIndex = 35;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label20.Location = new Point(446, 353);
            label20.Name = "label20";
            label20.Size = new Size(138, 15);
            label20.TabIndex = 36;
            label20.Text = "Окружная скоростьVm";
            // 
            // textBoxVm
            // 
            textBoxVm.Font = new Font("Times New Roman", 9.75F);
            textBoxVm.Location = new Point(657, 353);
            textBoxVm.Name = "textBoxVm";
            textBoxVm.Size = new Size(100, 22);
            textBoxVm.TabIndex = 37;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label21.Location = new Point(446, 308);
            label21.Name = "label21";
            label21.Size = new Size(196, 15);
            label21.TabIndex = 38;
            label21.Text = "Внешнее конусное расстояние Re";
            // 
            // textBoxRe
            // 
            textBoxRe.Font = new Font("Times New Roman", 9.75F);
            textBoxRe.Location = new Point(657, 308);
            textBoxRe.Name = "textBoxRe";
            textBoxRe.Size = new Size(100, 22);
            textBoxRe.TabIndex = 39;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label22.Location = new Point(446, 246);
            label22.Name = "label22";
            label22.Size = new Size(165, 15);
            label22.TabIndex = 42;
            label22.Text = "Делительный диаметр dm1 ";
            // 
            // textBoxdm1
            // 
            textBoxdm1.Font = new Font("Times New Roman", 9.75F);
            textBoxdm1.Location = new Point(657, 246);
            textBoxdm1.Name = "textBoxdm1";
            textBoxdm1.Size = new Size(100, 22);
            textBoxdm1.TabIndex = 43;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label23.Location = new Point(816, 77);
            label23.Name = "label23";
            label23.Size = new Size(164, 15);
            label23.TabIndex = 44;
            label23.Text = "Значение действующего σH";
            // 
            // textBoxsigmah
            // 
            textBoxsigmah.Font = new Font("Times New Roman", 9.75F);
            textBoxsigmah.Location = new Point(1083, 77);
            textBoxsigmah.Name = "textBoxsigmah";
            textBoxsigmah.ReadOnly = true;
            textBoxsigmah.Size = new Size(100, 22);
            textBoxsigmah.TabIndex = 45;
            // 
            // textBoxsigmahp
            // 
            textBoxsigmahp.Font = new Font("Times New Roman", 9.75F);
            textBoxsigmahp.Location = new Point(1083, 116);
            textBoxsigmahp.Name = "textBoxsigmahp";
            textBoxsigmahp.ReadOnly = true;
            textBoxsigmahp.Size = new Size(100, 22);
            textBoxsigmahp.TabIndex = 46;
            // 
            // Boxsigmastr
            // 
            Boxsigmastr.DropDownStyle = ComboBoxStyle.DropDownList;
            Boxsigmastr.Font = new Font("Times New Roman", 9.75F);
            Boxsigmastr.FormattingEnabled = true;
            Boxsigmastr.Items.AddRange(new object[] { "550", "600", "650", "800", "900", "1000", "1100", "1150", "1150" });
            Boxsigmastr.Location = new Point(283, 191);
            Boxsigmastr.Name = "Boxsigmastr";
            Boxsigmastr.Size = new Size(121, 23);
            Boxsigmastr.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label4.Location = new Point(8, 191);
            label4.Name = "label4";
            label4.Size = new Size(254, 15);
            label4.TabIndex = 49;
            label4.Text = "Допускаемое контактное напряжение, σ`HP";
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Times New Roman", 9.75F);
            textBoxResult.Location = new Point(816, 167);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(284, 22);
            textBoxResult.TabIndex = 50;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.Location = new Point(413, 4);
            label5.Name = "label5";
            label5.Size = new Size(394, 80);
            label5.TabIndex = 51;
            label5.Text = "Проверочный расчёт для конической зубчатой передачи на контактную выносливость рабочих поверхностей зубьев";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label6.Location = new Point(12, 119);
            label6.Name = "label6";
            label6.Size = new Size(148, 15);
            label6.TabIndex = 52;
            label6.Text = "Угол наклона линии зуба";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label9.Location = new Point(12, 156);
            label9.Name = "label9";
            label9.Size = new Size(187, 15);
            label9.TabIndex = 53;
            label9.Text = "Относ. коэф. смещения контура";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label13.Location = new Point(12, 456);
            label13.Name = "label13";
            label13.Size = new Size(170, 15);
            label13.TabIndex = 54;
            label13.Text = "Материал шестерни и колеса";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label15.Location = new Point(446, 399);
            label15.Name = "label15";
            label15.Size = new Size(184, 15);
            label15.TabIndex = 55;
            label15.Text = "Твердость поверхностей зубьев";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label24.Location = new Point(446, 443);
            label24.Name = "label24";
            label24.Size = new Size(70, 15);
            label24.TabIndex = 56;
            label24.Text = "Вид зубьев";
            // 
            // boxAngle
            // 
            boxAngle.FormattingEnabled = true;
            boxAngle.Items.AddRange(new object[] { "0", "10", "15", "20", "25", "30", "35", "40" });
            boxAngle.Location = new Point(307, 119);
            boxAngle.Name = "boxAngle";
            boxAngle.Size = new Size(97, 23);
            boxAngle.TabIndex = 57;
            // 
            // BoxCoefficient
            // 
            BoxCoefficient.FormattingEnabled = true;
            BoxCoefficient.Items.AddRange(new object[] { "0,08", "0,05", "0,03", "0,02", "0,01", "0,005", "0", "-0,005", "-0,01", "-0,015", "-0,02" });
            BoxCoefficient.Location = new Point(299, 156);
            BoxCoefficient.Name = "BoxCoefficient";
            BoxCoefficient.Size = new Size(105, 23);
            BoxCoefficient.TabIndex = 58;
            // 
            // boxMaterial
            // 
            boxMaterial.FormattingEnabled = true;
            boxMaterial.Items.AddRange(new object[] { "Сталь-сталь", "Сталь-чугун", "Сталь-бронза", "Чугун-чугун", "Текстолит-сталь", "ДСП-сталь", "Полиамид-сталь" });
            boxMaterial.Location = new Point(272, 453);
            boxMaterial.Name = "boxMaterial";
            boxMaterial.Size = new Size(135, 23);
            boxMaterial.TabIndex = 59;
            // 
            // TextBoxHardness
            // 
            TextBoxHardness.Location = new Point(653, 396);
            TextBoxHardness.Name = "TextBoxHardness";
            TextBoxHardness.Size = new Size(104, 23);
            TextBoxHardness.TabIndex = 60;
            // 
            // BoxTeethType
            // 
            BoxTeethType.FormattingEnabled = true;
            BoxTeethType.Items.AddRange(new object[] { "Прямые без модификации головки", "Прямые с модификацией головки", "Косые" });
            BoxTeethType.Location = new Point(643, 435);
            BoxTeethType.Name = "BoxTeethType";
            BoxTeethType.Size = new Size(114, 23);
            BoxTeethType.TabIndex = 61;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(1270, 648);
            Controls.Add(BoxTeethType);
            Controls.Add(TextBoxHardness);
            Controls.Add(boxMaterial);
            Controls.Add(BoxCoefficient);
            Controls.Add(boxAngle);
            Controls.Add(label24);
            Controls.Add(label15);
            Controls.Add(label13);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxResult);
            Controls.Add(label4);
            Controls.Add(Boxsigmastr);
            Controls.Add(textBoxsigmahp);
            Controls.Add(textBoxsigmah);
            Controls.Add(label23);
            Controls.Add(textBoxdm1);
            Controls.Add(label22);
            Controls.Add(textBoxRe);
            Controls.Add(label21);
            Controls.Add(textBoxVm);
            Controls.Add(label20);
            Controls.Add(boxg0);
            Controls.Add(label19);
            Controls.Add(textBoxb);
            Controls.Add(label17);
            Controls.Add(boxKhb);
            Controls.Add(label16);
            Controls.Add(textBoxFt);
            Controls.Add(label14);
            Controls.Add(textBoxEa);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(textBoxKhl);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBoxu);
            Controls.Add(label1);
            Controls.Add(calcBtn);
            Name = "Form1";
            Text = "Курсовая";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calcBtn;
        private Label label1;
        private TextBox textBoxu;
        private Label label7;
        private Label label8;
        private TextBox textBoxKhl;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBoxEa;
        private Label label14;
        private TextBox textBoxFt;
        private Label label16;
        private ComboBox boxKhb;
        private Label label17;
        private TextBox textBoxb;
        private Label label19;
        private ComboBox boxg0;
        private Label label20;
        private TextBox textBoxVm;
        private Label label21;
        private TextBox textBoxRe;
        private Label label22;
        private TextBox textBoxdm1;
        private Label label23;
        private TextBox textBoxsigmah;
        private TextBox textBoxsigmahp;
        private ComboBox Boxsigmastr;
        private Label label4;
        private TextBox textBoxResult;
        private Label label5;
        private Label label6;
        private Label label9;
        private Label label13;
        private Label label15;
        private Label label24;
        private ComboBox boxAngle;
        private ComboBox BoxCoefficient;
        private ComboBox boxMaterial;
        private TextBox TextBoxHardness;
        private ComboBox BoxTeethType;
    }
}