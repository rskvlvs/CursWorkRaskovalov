using DataBaseLogic.Repositories;
using DataBaseStorage;
using DataBaseStorage.entities;
using System;

namespace бд
{
    public partial class Form1 : Form
    {
        private detailRepository _detailRepository;
        private resultEntityRepository _resultEntityRepository;
        private unitRepository _unitRepository;
        private context _context;
        public Form1()
        {
            context _context = new context();
            _detailRepository = new detailRepository(_context);
            _resultEntityRepository = new resultEntityRepository(_context);
            _unitRepository = new unitRepository(_context);
            InitializeComponent();
        }

        private async void calcBtn_Click(object sender, EventArgs e)
        {

            //проверка на пустые текстбоксы
            checkempty();
            //задаю значения и считываю данные
            double Kha;
            double Khv;
            double Ft = Convert.ToDouble(textBoxFt.Text);
            string type = "Конические";
            double Khb = Convert.ToDouble(boxKhb.Text);
            double Ea = Convert.ToDouble(textBoxEa.Text);
            double Ze = 0;
            double b = Convert.ToDouble(textBoxb.Text);
            double u = Convert.ToDouble(textBoxu.Text);

            double HB = Convert.ToDouble(TextBoxHardness.Text);
            string teethType = Convert.ToString(BoxTeethType.Text);
            deltaHClass DeltaHClass = new deltaHClass(teethType, HB);
            double delta_h = DeltaHClass.deltaH;
            double g0 = Convert.ToDouble(boxg0.Text);
            double Vm = Convert.ToDouble(textBoxVm.Text);
            double Re = Convert.ToDouble(textBoxRe.Text);


            double omegaHT = 0;
            double omegaHV = 0;

            Kha = 1;
            Khv = Khv_calc(Kha, Ft, Khb, b, u, ref omegaHT, delta_h, g0, Vm, Re, ref omegaHV);
            Ze = Math.Sqrt((4 - Ea) / 3);


            double dm1 = Convert.ToDouble(textBoxdm1.Text);
            double Kh = Kha * Khb * Khv;
            string material = Convert.ToString(boxMaterial.Text);
            ZmClass zmClass = new ZmClass(material);
            double Zm = zmClass.zm;

            double angle = Convert.ToDouble(boxAngle.Text);
            double coefficient = Convert.ToDouble(BoxCoefficient.Text);
            string filePath = "zhValue.json";
            ZhClass zhClass = new ZhClass(angle, coefficient, filePath);

            double Zh = zhClass.zh ?? 0;
            double Khl = Convert.ToDouble(textBoxKhl.Text);
            double sigmastr = Convert.ToDouble(Boxsigmastr.Text);

            double sigmaH = Zh * Zm * Ze * Math.Sqrt(Ft * Kh * Math.Sqrt(u * u + 1 / (0.85 * b * dm1 * u)));
            double sigmaHP = sigmastr * Khl;

            textBoxsigmah.Text = Convert.ToString(sigmaH);
            textBoxsigmahp.Text = Convert.ToString(sigmaHP);

            double def_sigmaH_sigmaHP = sigmaHP - sigmaH;

            const string success_result = "Условие на контактную выносливость выполняются";
            const string bad_result = "Условие на контактную выносливость не выполняются";


            if (def_sigmaH_sigmaHP >= 0)
            {
                var detailId = await _detailRepository.Create(dm1, delta_h, Vm, sigmastr, u, type, Khl, Ze);
                var unitId = await _unitRepository.Create(Kh, Kha, Khv, Khb, omegaHT, omegaHV, g0, sigmaH, sigmaHP, Zh, Zm, Ft, b, Ea, Re, def_sigmaH_sigmaHP);
                _resultEntityRepository.Create("Условия выполняются", sigmaH, sigmaHP, detailId, unitId);
                Task.WaitAll();
                textBoxResult.Text = success_result;
            }
            else
            {
                var detailId = await _detailRepository.Create(dm1, delta_h, Vm, sigmastr, u, type, Khl, Ze);
                var unitId = await _unitRepository.Create(Kh, Kha, Khv, Khb, omegaHT, omegaHV, g0, sigmaH, sigmaHP, Zh, Zm, Ft, b, Ea, Re, def_sigmaH_sigmaHP);
                _resultEntityRepository.Create("Условия не выполняются", sigmaH, sigmaHP, detailId, unitId);
                Task.WaitAll();
                textBoxResult.Text = bad_result;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private double Khv_calc(double Kha, double Ft, double Khb, double b, double u,
            ref double OmegaHT, double delta_h, double g0, double Vm, double Re, ref double OmegaHV)
        {
            double result;

            OmegaHT = (Ft * Kha * Khb) / b;
            OmegaHV = delta_h * g0 * Vm * Math.Sqrt((Re - 0.5 * b) / u);
            result = 1 + OmegaHV / OmegaHT;

            return result;
        }


        private void checkempty()
        {
            TextBox[] textBoxes = { textBoxu, textBoxKhl, textBoxEa, textBoxFt, textBoxb, textBoxVm, textBoxRe, textBoxdm1, TextBoxHardness};
            const string default_value = "1,00";

            foreach (TextBox textBox in textBoxes)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = default_value;
                }

            }

            ComboBox[] comboBoxes = { Boxsigmastr, boxKhb, boxg0, boxAngle, BoxCoefficient, boxMaterial, BoxTeethType};

            foreach (ComboBox comboBox in comboBoxes)
            {
                if (comboBox.SelectedItem == null)
                {
                    comboBox.SelectedIndex = 0;
                }
            }
        }
    }
}