namespace tpr2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewK2 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxШагПробега = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxВерхнийПределПробега = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxНижнийПределПробега = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxШагЦены = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxВерхнийПределЦены = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxНижнийПределЦены = new System.Windows.Forms.TextBox();
            this.dataGridViewK1 = new System.Windows.Forms.DataGridView();
            this.textBoxLimitK1 = new System.Windows.Forms.TextBox();
            this.textBoxLimitK2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Вариант = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цена = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Пробег = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uk1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uk2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uk1k2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonПосчитать = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewK2)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewK1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.44715F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(487, 422);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.buttonПосчитать, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewK2, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewK1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxLimitK1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxLimitK2, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(481, 416);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dataGridViewK2
            // 
            this.dataGridViewK2.AllowUserToAddRows = false;
            this.dataGridViewK2.AllowUserToDeleteRows = false;
            this.dataGridViewK2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewK2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewK2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewK2.Location = new System.Drawing.Point(3, 323);
            this.dataGridViewK2.Name = "dataGridViewK2";
            this.dataGridViewK2.ReadOnly = true;
            this.dataGridViewK2.RowHeadersVisible = false;
            this.dataGridViewK2.Size = new System.Drawing.Size(475, 44);
            this.dataGridViewK2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox6, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox5, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.34615F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.13514F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(475, 94);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxШагПробега);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(319, 53);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(153, 38);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Шаг пробега";
            // 
            // textBoxШагПробега
            // 
            this.textBoxШагПробега.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxШагПробега.Location = new System.Drawing.Point(3, 16);
            this.textBoxШагПробега.Name = "textBoxШагПробега";
            this.textBoxШагПробега.Size = new System.Drawing.Size(147, 20);
            this.textBoxШагПробега.TabIndex = 0;
            this.textBoxШагПробега.Text = "20";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxВерхнийПределПробега);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(161, 53);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(152, 38);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Верхний предел пробега";
            // 
            // textBoxВерхнийПределПробега
            // 
            this.textBoxВерхнийПределПробега.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxВерхнийПределПробега.Location = new System.Drawing.Point(3, 16);
            this.textBoxВерхнийПределПробега.Name = "textBoxВерхнийПределПробега";
            this.textBoxВерхнийПределПробега.Size = new System.Drawing.Size(146, 20);
            this.textBoxВерхнийПределПробега.TabIndex = 0;
            this.textBoxВерхнийПределПробега.Text = "80";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxНижнийПределПробега);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 53);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(152, 38);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Нижний предел пробега";
            // 
            // textBoxНижнийПределПробега
            // 
            this.textBoxНижнийПределПробега.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxНижнийПределПробега.Location = new System.Drawing.Point(3, 16);
            this.textBoxНижнийПределПробега.Name = "textBoxНижнийПределПробега";
            this.textBoxНижнийПределПробега.Size = new System.Drawing.Size(146, 20);
            this.textBoxНижнийПределПробега.TabIndex = 0;
            this.textBoxНижнийПределПробега.Text = "20";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxШагЦены);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(319, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 44);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Шаг цены";
            // 
            // textBoxШагЦены
            // 
            this.textBoxШагЦены.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxШагЦены.Location = new System.Drawing.Point(3, 16);
            this.textBoxШагЦены.Name = "textBoxШагЦены";
            this.textBoxШагЦены.Size = new System.Drawing.Size(147, 20);
            this.textBoxШагЦены.TabIndex = 0;
            this.textBoxШагЦены.Text = "25";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxВерхнийПределЦены);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(161, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 44);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Верхний предел цены";
            // 
            // textBoxВерхнийПределЦены
            // 
            this.textBoxВерхнийПределЦены.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxВерхнийПределЦены.Location = new System.Drawing.Point(3, 16);
            this.textBoxВерхнийПределЦены.Name = "textBoxВерхнийПределЦены";
            this.textBoxВерхнийПределЦены.Size = new System.Drawing.Size(146, 20);
            this.textBoxВерхнийПределЦены.TabIndex = 0;
            this.textBoxВерхнийПределЦены.Text = "100";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxНижнийПределЦены);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 44);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Нижний предел цены";
            // 
            // textBoxНижнийПределЦены
            // 
            this.textBoxНижнийПределЦены.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxНижнийПределЦены.Location = new System.Drawing.Point(3, 16);
            this.textBoxНижнийПределЦены.Name = "textBoxНижнийПределЦены";
            this.textBoxНижнийПределЦены.Size = new System.Drawing.Size(146, 20);
            this.textBoxНижнийПределЦены.TabIndex = 0;
            this.textBoxНижнийПределЦены.Text = "25";
            // 
            // dataGridViewK1
            // 
            this.dataGridViewK1.AllowUserToAddRows = false;
            this.dataGridViewK1.AllowUserToDeleteRows = false;
            this.dataGridViewK1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewK1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewK1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewK1.Location = new System.Drawing.Point(3, 253);
            this.dataGridViewK1.Name = "dataGridViewK1";
            this.dataGridViewK1.ReadOnly = true;
            this.dataGridViewK1.RowHeadersVisible = false;
            this.dataGridViewK1.Size = new System.Drawing.Size(475, 44);
            this.dataGridViewK1.TabIndex = 4;
            // 
            // textBoxLimitK1
            // 
            this.textBoxLimitK1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLimitK1.Location = new System.Drawing.Point(3, 303);
            this.textBoxLimitK1.Name = "textBoxLimitK1";
            this.textBoxLimitK1.Size = new System.Drawing.Size(475, 20);
            this.textBoxLimitK1.TabIndex = 6;
            this.textBoxLimitK1.Text = "Предел измениения k1=";
            // 
            // textBoxLimitK2
            // 
            this.textBoxLimitK2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLimitK2.Location = new System.Drawing.Point(3, 373);
            this.textBoxLimitK2.Name = "textBoxLimitK2";
            this.textBoxLimitK2.Size = new System.Drawing.Size(475, 20);
            this.textBoxLimitK2.TabIndex = 7;
            this.textBoxLimitK2.Text = "Предел изменения k2=";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Вариант,
            this.Цена,
            this.Пробег,
            this.Uk1,
            this.Uk2,
            this.Uk1k2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(475, 144);
            this.dataGridView1.TabIndex = 9;
            // 
            // Вариант
            // 
            this.Вариант.HeaderText = "Вариант";
            this.Вариант.Name = "Вариант";
            // 
            // Цена
            // 
            this.Цена.HeaderText = "Цена";
            this.Цена.Name = "Цена";
            // 
            // Пробег
            // 
            this.Пробег.HeaderText = "Пробег";
            this.Пробег.Name = "Пробег";
            // 
            // Uk1
            // 
            this.Uk1.HeaderText = "U(k1)";
            this.Uk1.Name = "Uk1";
            // 
            // Uk2
            // 
            this.Uk2.HeaderText = "U(k2)";
            this.Uk2.Name = "Uk2";
            // 
            // Uk1k2
            // 
            this.Uk1k2.HeaderText = "U(k1,k2)";
            this.Uk1k2.Name = "Uk1k2";
            // 
            // buttonПосчитать
            // 
            this.buttonПосчитать.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonПосчитать.Location = new System.Drawing.Point(3, 393);
            this.buttonПосчитать.Name = "buttonПосчитать";
            this.buttonПосчитать.Size = new System.Drawing.Size(475, 20);
            this.buttonПосчитать.TabIndex = 10;
            this.buttonПосчитать.Text = "Посчитать";
            this.buttonПосчитать.UseVisualStyleBackColor = true;
            this.buttonПосчитать.Click += new System.EventHandler(this.buttonПосчитать_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 422);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewK2)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewK1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridViewK2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBoxШагПробега;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxВерхнийПределПробега;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxНижнийПределПробега;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxШагЦены;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxВерхнийПределЦены;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxНижнийПределЦены;
        private System.Windows.Forms.DataGridView dataGridViewK1;
        private System.Windows.Forms.TextBox textBoxLimitK1;
        private System.Windows.Forms.TextBox textBoxLimitK2;
        private System.Windows.Forms.Button buttonПосчитать;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Вариант;
        private System.Windows.Forms.DataGridViewTextBoxColumn Цена;
        private System.Windows.Forms.DataGridViewTextBoxColumn Пробег;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uk1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uk2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uk1k2;


    }
}

