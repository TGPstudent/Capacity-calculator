using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Capacity_calculator
{
    public partial class FormTank1 : MetroForm
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
        public FormTank1()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            foreach (var ctrl in groupBox1.Controls)
            if (ctrl is TextBox) (ctrl as TextBox).Clear();
            foreach (var ctrl in groupBox2.Controls)
            if (ctrl is TextBox) (ctrl as TextBox).Clear();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }
        private void textBox_H_TextChanged(object sender, EventArgs e)
        {
            ColorLabel(textBox_H, label_H);
        }

        private void textBox_D_TextChanged(object sender, EventArgs e)
        {
            ColorLabel(textBox_D, label_D);
        }

        private void textBox_H1_TextChanged(object sender, EventArgs e)
        {
            ColorLabel(textBox_H1, label_H1);
        }
        
        private void button_Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                Tank1 tank1 = new Tank1(textBox_D.Text, textBox_H.Text, textBox_H1.Text);
                textBox_Rez.Text = tank1.Print();
                _In = tank1.InArh();
                _Out = tank1.OutArh();
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

             private void button_Clear_Click(object sender, EventArgs e)
        {
            foreach (var ctrl in groupBox1.Controls)
            if (ctrl is TextBox) (ctrl as TextBox).Clear();
            foreach (var ctrl in groupBox2.Controls)
            if (ctrl is TextBox) (ctrl as TextBox).Clear();
            temp = "";
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
            FormFirst formFirst = new FormFirst();
            formFirst.Show();
        }
    }
}
