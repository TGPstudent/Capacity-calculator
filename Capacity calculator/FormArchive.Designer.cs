namespace Capacity_calculator
{
    partial class FormArchive
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArchive));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_First = new System.Windows.Forms.Button();
            this.button_Last = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button_Down = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button_Up = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_SaveInFile = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_DeleteSelection = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button_First);
            this.groupBox1.Controls.Add(this.button_Last);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.button_Down);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.button_Up);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(2, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 189);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ПЕРЕГЛЯД ОБРАНОГО";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.Color.Blue;
            this.textBox2.Location = new System.Drawing.Point(170, 143);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(242, 38);
            this.textBox2.TabIndex = 19;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_First
            // 
            this.button_First.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_First.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_First.FlatAppearance.BorderSize = 0;
            this.button_First.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_First.Image = global::Capacity_calculator.Properties.Resources._12;
            this.button_First.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_First.Location = new System.Drawing.Point(564, 143);
            this.button_First.Name = "button_First";
            this.button_First.Size = new System.Drawing.Size(40, 40);
            this.button_First.TabIndex = 14;
            this.button_First.UseVisualStyleBackColor = true;
            this.button_First.Click += new System.EventHandler(this.button_First_Click);
            // 
            // button_Last
            // 
            this.button_Last.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Last.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Last.FlatAppearance.BorderSize = 0;
            this.button_Last.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Last.Image = global::Capacity_calculator.Properties.Resources._44;
            this.button_Last.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_Last.Location = new System.Drawing.Point(702, 143);
            this.button_Last.Name = "button_Last";
            this.button_Last.Size = new System.Drawing.Size(40, 40);
            this.button_Last.TabIndex = 17;
            this.button_Last.UseVisualStyleBackColor = true;
            this.button_Last.Click += new System.EventHandler(this.button_Last_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBox4.ForeColor = System.Drawing.Color.Blue;
            this.textBox4.Location = new System.Drawing.Point(170, 92);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(574, 45);
            this.textBox4.TabIndex = 22;
            // 
            // button_Down
            // 
            this.button_Down.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Down.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Down.FlatAppearance.BorderSize = 0;
            this.button_Down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Down.Image = global::Capacity_calculator.Properties.Resources._33;
            this.button_Down.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_Down.Location = new System.Drawing.Point(656, 143);
            this.button_Down.Name = "button_Down";
            this.button_Down.Size = new System.Drawing.Size(40, 40);
            this.button_Down.TabIndex = 16;
            this.button_Down.UseVisualStyleBackColor = true;
            this.button_Down.Click += new System.EventHandler(this.button_Down_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBox3.ForeColor = System.Drawing.Color.Blue;
            this.textBox3.Location = new System.Drawing.Point(170, 19);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(574, 69);
            this.textBox3.TabIndex = 21;
            // 
            // button_Up
            // 
            this.button_Up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Up.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Up.FlatAppearance.BorderSize = 0;
            this.button_Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Up.Image = global::Capacity_calculator.Properties.Resources._22;
            this.button_Up.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_Up.Location = new System.Drawing.Point(610, 143);
            this.button_Up.Name = "button_Up";
            this.button_Up.Size = new System.Drawing.Size(40, 40);
            this.button_Up.TabIndex = 15;
            this.button_Up.UseVisualStyleBackColor = true;
            this.button_Up.Click += new System.EventHandler(this.button_Up_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button_Exit);
            this.panel2.Controls.Add(this.button_SaveInFile);
            this.panel2.Controls.Add(this.button_Close);
            this.panel2.Controls.Add(this.button_Clear);
            this.panel2.Controls.Add(this.button_DeleteSelection);
            this.panel2.Location = new System.Drawing.Point(0, 554);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 55);
            this.panel2.TabIndex = 28;
            // 
            // button_Exit
            // 
            this.button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Exit.ForeColor = System.Drawing.Color.Navy;
            this.button_Exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_Exit.Location = new System.Drawing.Point(607, 3);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(145, 45);
            this.button_Exit.TabIndex = 14;
            this.button_Exit.Text = "&ЗАКРИТИ";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_SaveInFile
            // 
            this.button_SaveInFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SaveInFile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_SaveInFile.FlatAppearance.BorderSize = 0;
            this.button_SaveInFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SaveInFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_SaveInFile.ForeColor = System.Drawing.Color.Navy;
            this.button_SaveInFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_SaveInFile.Location = new System.Drawing.Point(309, 3);
            this.button_SaveInFile.Name = "button_SaveInFile";
            this.button_SaveInFile.Size = new System.Drawing.Size(145, 45);
            this.button_SaveInFile.TabIndex = 1;
            this.button_SaveInFile.Text = "ЗБЕРЕГТИ У &ФАЙЛ";
            this.button_SaveInFile.UseVisualStyleBackColor = true;
            this.button_SaveInFile.Click += new System.EventHandler(this.button_SaveInFile_Click);
            // 
            // button_Close
            // 
            this.button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Close.ForeColor = System.Drawing.Color.Navy;
            this.button_Close.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_Close.Location = new System.Drawing.Point(458, 3);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(145, 45);
            this.button_Close.TabIndex = 0;
            this.button_Close.Text = "&ВИХІД";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Clear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Clear.FlatAppearance.BorderSize = 0;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Clear.ForeColor = System.Drawing.Color.Navy;
            this.button_Clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_Clear.Location = new System.Drawing.Point(11, 3);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(145, 45);
            this.button_Clear.TabIndex = 3;
            this.button_Clear.Text = "&ОЧИСТИТИ";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_DeleteSelection
            // 
            this.button_DeleteSelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_DeleteSelection.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_DeleteSelection.FlatAppearance.BorderSize = 0;
            this.button_DeleteSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DeleteSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_DeleteSelection.ForeColor = System.Drawing.Color.Navy;
            this.button_DeleteSelection.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_DeleteSelection.Location = new System.Drawing.Point(160, 3);
            this.button_DeleteSelection.Name = "button_DeleteSelection";
            this.button_DeleteSelection.Size = new System.Drawing.Size(145, 45);
            this.button_DeleteSelection.TabIndex = 2;
            this.button_DeleteSelection.Text = "ВИЛУ&ЧИТИ ВИДІЛЕНІ";
            this.button_DeleteSelection.UseVisualStyleBackColor = true;
            this.button_DeleteSelection.Click += new System.EventHandler(this.button_DeleteSelection_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataGridView1.Location = new System.Drawing.Point(10, 230);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(742, 319);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Тип";
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.Name = "Column1";
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Дата та час";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Задані дані, м";
            this.Column3.Name = "Column3";
            this.Column3.Width = 225;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Отриманий результат";
            this.Column4.Name = "Column4";
            this.Column4.Width = 225;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ключ";
            this.Column5.Name = "Column5";
            this.Column5.Width = 60;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // FormArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(761, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "FormArchive";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.FormArchive_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_First;
        private System.Windows.Forms.Button button_Last;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button_Down;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button_Up;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_SaveInFile;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_DeleteSelection;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}