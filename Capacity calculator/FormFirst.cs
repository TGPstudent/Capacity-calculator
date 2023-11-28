using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Capacity_calculator
{
    public partial class FormFirst : MetroForm
    {
        public FormFirst()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            FormTank1 formTank1 = new FormTank1();
            formTank1.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hide();
            FormTank2 formTank2 = new FormTank2();
            formTank2.Show();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Hide();
            FormTank3 formTank3 = new FormTank3();
            formTank3.Show();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Hide();
            FormTank4 formTank4 = new FormTank4();
            formTank4.Show();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Hide();
            FormTank5 formTank5 = new FormTank5();
            formTank5.Show();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Hide();
            FormTank6 formTank6 = new FormTank6();
            formTank6.Show();
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {

            DialogResult result = CustomMessageBox.Show("При виході з програми всі розраховані Вами дані будуть вилучені з архіву. Ви впевнені, що зберегли потрібне?",
"УВАГА", "Так", "Ні", Color.Red);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        private void button_Arhive_Click(object sender, EventArgs e)
        {

            if (Globals.arr.Count != 0)
            {
                FormArchive formArchive = new FormArchive();
                formArchive.Show();
            }
            else
                CustomMessageBox.Show("В архіві відсутня інформація. Помістіть в архів хоча б один результат обрахунку.", "ПУСТИЙ АРХІВ!", "ОК", Color.Blue);
        }
        private void button_Info_Click(object sender, EventArgs e)
        {
            Form_Info form_Info = new Form_Info();
            form_Info.Show();
        }
       
    }
}
