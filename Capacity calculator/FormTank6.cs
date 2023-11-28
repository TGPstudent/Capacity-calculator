using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Capacity_calculator
{
    public partial class FormTank6 : MetroForm
    {
        string _In, _Out, temp = "";
        private void ColorLabel(TextBox tB, Label l)
        {
            for (int i = tB.Text.Length - 1; i >= 0; i--)
            {
                if (char.IsNumber(tB.Text[i])) l.ForeColor = Color.Blue;
                else l.ForeColor = Color.Red;
            }
        }
        public FormTank6()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            foreach (var ctrl in groupBox1.Controls)
            if (ctrl is TextBox) (ctrl as TextBox).Clear();
            foreach (var ctrl in groupBox2.Controls)
            if (ctrl is TextBox) (ctrl as TextBox).Clear();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }

        private void textBox_A_TextChanged(object sender, EventArgs e)
        {
            ColorLabel(textBox_A, label_A);
        }

        private void textBox_B_TextChanged(object sender, EventArgs e)
        {
            ColorLabel(textBox_B, label_B);
        }

        private void textBox_H_TextChanged(object sender, EventArgs e)
        {
            ColorLabel(textBox_H, label_H);
        }

        private void textBox_H2_TextChanged(object sender, EventArgs e)
        {
            ColorLabel(textBox_H2, label_H2);
        }

        private void textBox_A1_TextChanged(object sender, EventArgs e)
        {
            ColorLabel(textBox_A1, label_A1);
        }

        private void textBox_B1_TextChanged(object sender, EventArgs e)
        {
            ColorLabel(textBox_B1, label_B1);
        }

        private void textBox_H1_TextChanged(object sender, EventArgs e)
        {
            ColorLabel(textBox_H1, label_H1);
        }

        private void button_Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                Tank6 tank6 = new Tank6(textBox_A.Text, textBox_B.Text, textBox_H.Text, textBox_H1.Text, textBox_H2.Text, textBox_A1.Text, textBox_B1.Text);
                textBox_Rez.Text = tank6.Print();
                _In = tank6.InArh();
                _Out = tank6.OutArh();
            }
            catch (FormatException)
            {
                CustomMessageBox.Show("Введені Вами дані некоректні, чи не заповнено обов'язкові поля! Спробуйте ще раз.", "УВАГА!", "ОК", Color.Red);
            }
            catch (Exception zx)
            {
                CustomMessageBox.Show("Упс! Сталась помилка" + zx.Message, "ПОМИЛКА!", "ОК", Color.Red);
            }
        }

        private void button_InArchive_Click(object sender, EventArgs e)
        {
            if (_In != temp)
            {
                if (textBox_Rez.Text != "")
                {
                    Globals.arr.Add(new Archive(pictureBox1.Image, _In, _Out));
                    temp = _In;
                    CustomMessageBox.Show("Інформацію успішно відправлено в архів", "В АРХІВ", "ОК", Color.Blue);
                }
                else
                    CustomMessageBox.Show("Упс! Не проведено розрахунок. Натисність кнопку (ОБЧИСЛИТИ) а потім додайте інформацію в архів ", "ПОМИЛКА!", "ОК", Color.Red);
            }
            else
                CustomMessageBox.Show("Упс! Ця інформація вже відправлялась в архів. Змініть вхідні дані і виконайте обчислення", "ПОМИЛКА!", "ОК", Color.Red);
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
            FormFirst formFirst = new FormFirst();
            formFirst.Show();
        }

        private void button_Clean_Click(object sender, EventArgs e)
        {
            foreach (var ctrl in groupBox1.Controls)
            if (ctrl is TextBox) (ctrl as TextBox).Clear();
            foreach (var ctrl in groupBox2.Controls)
            if (ctrl is TextBox) (ctrl as TextBox).Clear();
            temp = "";
        }
    }
}
