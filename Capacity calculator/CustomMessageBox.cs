using MetroFramework.Forms;
using MetroFramework.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Capacity_calculator
{
    public class CustomMessageBox : MetroForm
    {
        private MetroPanel panel;
        private Label lblMessage;
        private Button btnYes;
        private Button btnNo;
        // private Button btnOk; // Додано поле для кнопки "ОК"

        private Color messageColor;

        // Конструктор для вікна з двома кнопками
        private CustomMessageBox(string message, string title, string buttonText1, string buttonText2, Color messageColor)
        {
            this.messageColor = messageColor;
            InitializeComponents(message, title, buttonText1, buttonText2);
        }

        // Конструктор для вікна з однією кнопкою
        private CustomMessageBox(string message, string title, string buttonText1, Color messageColor)
        {
            this.messageColor = messageColor;
            InitializeComponents(message, title, buttonText1, string.Empty);
        }

        // Ініціалізація компонентів вікна
        private void InitializeComponents(string message, string title, string buttonText1, string buttonText2)
        {
            this.Text = title;
            this.Resizable = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.ClientSize = new Size(400, 230);

            this.panel = new MetroPanel();
            this.panel.Dock = DockStyle.Fill;

            this.lblMessage = new Label();
            this.lblMessage.Dock = DockStyle.Top;
            this.lblMessage.AutoSize = false;
            this.lblMessage.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.lblMessage.ForeColor = messageColor;
            this.lblMessage.Location = new Point(10, 10);
            this.lblMessage.Size = new Size(420, 90);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = message;

            if (!string.IsNullOrEmpty(buttonText2))
            {
                // Вікно з двома кнопками
                this.btnYes = new Button
                {
                    BackColor = Color.Transparent,
                    Cursor = Cursors.Hand,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, ((byte)(204))),
                    ForeColor = Color.Navy,
                    Location = new Point(this.ClientSize.Width - 113, this.lblMessage.Bottom + 10),
                    Size = new Size(70, 36),
                    TabIndex = 1,
                    Text = buttonText1
                };
                this.btnYes.FlatAppearance.BorderColor = Color.Silver;
                this.btnYes.UseVisualStyleBackColor = false;
                this.btnYes.Click += (sender, e) => { this.DialogResult = DialogResult.Yes; this.Close(); };

                this.btnNo = new Button
                {
                    BackColor = Color.Transparent,
                    Cursor = Cursors.Hand,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, ((byte)(204))),
                    ForeColor = Color.Navy,
                    Location = new Point(this.ClientSize.Width - 193, this.lblMessage.Bottom + 10),
                    Size = new Size(70, 36),
                    TabIndex = 2,
                    Text = buttonText2
                };
                this.btnNo.FlatAppearance.BorderColor = Color.Silver;
                this.btnNo.UseVisualStyleBackColor = false;
                this.btnNo.Click += (sender, e) => { this.DialogResult = DialogResult.No; this.Close(); };

                this.panel.Controls.Add(this.lblMessage);
                this.panel.Controls.Add(this.btnYes);
                this.panel.Controls.Add(this.btnNo);
            }
            else
            {
                // Вікно з однією кнопкою
                this.btnYes = new Button
                {
                    BackColor = Color.Transparent,
                    Cursor = Cursors.Hand,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, ((byte)(204))),
                    ForeColor = Color.Navy,
                    Location = new Point(this.ClientSize.Width - 113, this.lblMessage.Bottom + 10),
                    Size = new Size(70, 36),
                    TabIndex = 1,
                    Text = buttonText1
                };
                btnYes.FlatAppearance.BorderColor = Color.Silver;
                btnYes.UseVisualStyleBackColor = false;
                btnYes.Click += (sender, e) => { this.DialogResult = DialogResult.OK; this.Close(); };

                this.panel.Controls.Add(this.lblMessage);
                this.panel.Controls.Add(btnYes);
            }

            this.Controls.Add(this.panel);
        }

        // Метод для відображення вікна з двома кнопками
        public static DialogResult Show(string message, string title, string buttonText1, string buttonText2, Color messageColor)
        {
            using (CustomMessageBox customMessageBox = new CustomMessageBox(message, title, buttonText1, buttonText2, messageColor))
            {
                return customMessageBox.ShowDialog();
            }
        }

        // Метод для відображення вікна з однією кнопкою
        public static DialogResult Show(string message, string title, string buttonText1, Color messageColor)
        {
            using (CustomMessageBox customMessageBox = new CustomMessageBox(message, title, buttonText1, messageColor))
            {
                return customMessageBox.ShowDialog();
            }
        }
    }
}

