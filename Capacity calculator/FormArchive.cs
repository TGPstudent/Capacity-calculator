using System;
using System.Drawing;
using System.Windows.Forms;
using Aspose.Words;
using MetroFramework.Forms;

namespace Capacity_calculator
{
    public partial class FormArchive : MetroForm
    {
        private CurrencyManager currencyManager = null;
        public FormArchive()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }
        private void Visual(int Ind)
        {
                pictureBox1.Image = (Image)dataGridView1[0, Ind].Value;
                textBox2.Text = (string)dataGridView1[1, Ind].Value;
                textBox3.Text = (string)dataGridView1[2, Ind].Value;
                textBox4.Text = (string)dataGridView1[3, Ind].Value;
        }
        private void Visual()
        {
            pictureBox1.Image = null;
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormFirst fr1 = new FormFirst();
            fr1.Show();
        }

        private void FormArchive_Load(object sender, EventArgs e)
        {
            for (int j = 0; j < Globals.arr.Count; j++)
            dataGridView1.Rows.Add(Globals.arr[j].Eskiz, Globals.arr[j].Date, Globals.arr[j].Inbox, Globals.arr[j].Outbox, Globals.arr[j].Chek);
            currencyManager = (CurrencyManager)BindingContext[dataGridView1.Rows];
            currencyManager.Position = 0;
            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
            Visual(0);
        }
        private void button_First_Click(object sender, EventArgs e)
        {
            currencyManager.Position = 0;
            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
            Visual(0);
        }

        private void button_Up_Click(object sender, EventArgs e)
        {
            currencyManager.Position--;
            dataGridView1.CurrentCell = dataGridView1.Rows[currencyManager.Position].Cells[0];
            Visual(currencyManager.Position);
        }

        private void button_Down_Click(object sender, EventArgs e)
        {
            currencyManager.Position++;
            dataGridView1.CurrentCell = dataGridView1.Rows[currencyManager.Position].Cells[0];
            Visual(currencyManager.Position);
        }

        private void button_Last_Click(object sender, EventArgs e)
        {
            currencyManager.Position = dataGridView1.RowCount - 1;
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0];
            Visual(currencyManager.Position);
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Globals.arr.Clear();
            Visual();
        }

        private void button_DeleteSelection_Click(object sender, EventArgs e)
        {
            DialogResult vibor = CustomMessageBox.Show("Ви впевнені в необхідності видалення цих записів ТАК/НІ", "ВИДАЛИТИ?", "Так", "Ні", Color.Red);

            if (vibor == DialogResult.Yes)
            {
                for (int j = dataGridView1.RowCount - 1; j >= 0; j--)
                {
                    if ((bool)dataGridView1[4, j].Value == true)
                    {
                        dataGridView1.Rows.RemoveAt(j);
                        Globals.arr.RemoveAt(j);
                    }
                }

                if (dataGridView1.RowCount == 0)
                    Visual();
                else
                    Visual(0);
            }
        }
        private void button_SaveInFile_Click(object sender, EventArgs e)
        {
            
                //Відсутня ліцензія на Aspose.Words, при наявності вставити назву файлу ліцензії і розкоментити
                //Aspose.Words.License setupToCreateTable = new Aspose.Words.License();
                //setupToCreateTable.SetLicense("Назва файла ліцензії.lic");

                //Діалог збереження файлу
                SaveFileDialog sFD = new SaveFileDialog();
                sFD.InitialDirectory = @"C:\Users\PS\Desktop\";
                sFD.FileName = "Результат_обчислень.doc";
                sFD.DefaultExt = "doc";
                sFD.Filter = "Word files (*.doc)|*.doc";
                sFD.RestoreDirectory = true;

                if (sFD.ShowDialog() == DialogResult.OK)
                {
                    // Объект Document Builder для створення таблиці в документі Word
                    DocumentBuilder TableInWord = new DocumentBuilder();
                    //Параметри сторінки
                    TableInWord.PageSetup.PaperSize = PaperSize.A4;
                    TableInWord.PageSetup.Orientation = Aspose.Words.Orientation.Portrait;
                    TableInWord.PageSetup.TopMargin = ConvertUtil.MillimeterToPoint(15);
                    TableInWord.PageSetup.BottomMargin = ConvertUtil.MillimeterToPoint(15);
                    TableInWord.PageSetup.LeftMargin = ConvertUtil.MillimeterToPoint(10);
                    TableInWord.PageSetup.RightMargin = ConvertUtil.MillimeterToPoint(5);
                    TableInWord.PageSetup.HeaderDistance = ConvertUtil.MillimeterToPoint(5);
                    TableInWord.PageSetup.FooterDistance = ConvertUtil.MillimeterToPoint(5);

                    Aspose.Words.Font font = TableInWord.Font;
                    font.Size = 12;
                    font.Bold = true;
                    font.Color = Color.Black;
                    font.Name = "Times New Roman";
                    TableInWord.ParagraphFormat.Alignment = ParagraphAlignment.Center;
                    TableInWord.Write("Звіт за результатами обрахунку з Архіва.\n");
                    // Відмічаємо початок таблиці Word
                    TableInWord.StartTable();
                    // Вставляємо рядок та першу комірку в таблицю Word
                    TableInWord.InsertCell();
                     // Запис тексту в першу комірку
                    TableInWord.Write("Тип Ємності");
                    // Додаємо нову комірку в цей же рядок
                    TableInWord.InsertCell();
                    // Запис тексту в комірку
                    TableInWord.Write("Дата та час");
                    TableInWord.InsertCell();
                    TableInWord.Write("Отримані дані, м");
                    TableInWord.InsertCell();
                    TableInWord.Write("Отриманий результат");
                    // Відмічаємо кінець таблиці
                    TableInWord.EndRow();

                    TableInWord.ParagraphFormat.Alignment = ParagraphAlignment.Left;
                    font.Size = 11;
                    font.Bold = false;
                    font.Color = Color.Blue;

                    for (int i = 1; i < dataGridView1.RowCount + 1; i++)
                    {
                        TableInWord.InsertCell();
                        Image ImBuf = (Image)dataGridView1.Rows[i - 1].Cells[0].Value;// Вставляємо зображення в комірку таблиці Word
                        TableInWord.InsertImage(ImBuf, ConvertUtil.PixelToPoint(120), ConvertUtil.PixelToPoint(120));
                        TableInWord.InsertCell();
                        TableInWord.Write(dataGridView1.Rows[i - 1].Cells[1].Value.ToString());
                        TableInWord.InsertCell();
                        TableInWord.Write(dataGridView1.Rows[i - 1].Cells[2].Value.ToString());
                        TableInWord.InsertCell();
                        TableInWord.Write(dataGridView1.Rows[i - 1].Cells[3].Value.ToString());
                        TableInWord.EndRow();
                    }
                    TableInWord.EndTable();
                    try
                    {
                        TableInWord.Document.Save(sFD.FileName);
                        CustomMessageBox.Show("Інформацію успішно записана у файл", "Все ок!", "ОК", Color.Blue);
                    }
                    catch
                    {
                        CustomMessageBox.Show("Не вдалось зберегти інформацію в файл. Спробуйте закрити редактор Word і посторити спробу.", "БІДА!", "ОК", Color.Red);
                    }
                }
        }
       
        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
            FormFirst formFirst = new FormFirst();
            formFirst.Show();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            DialogResult vibor = CustomMessageBox.Show("При виході з програми всі розраховані Вами дані будуть вилучені з архіву. Ви впевнені, що зберегли потрібне ?  ТАК/НІ?", "УВАГА", "Так", "Ні", Color.Red);
            if (vibor == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            Visual(dataGridView1.CurrentCell.RowIndex);
        }
    }
}
