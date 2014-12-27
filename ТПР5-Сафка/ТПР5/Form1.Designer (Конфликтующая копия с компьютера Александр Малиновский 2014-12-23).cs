namespace ТПР5
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.f1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonВыход = new System.Windows.Forms.Button();
            this.buttonВычислить = new System.Windows.Forms.Button();
            this.buttonУдалитьКритерий = new System.Windows.Forms.Button();
            this.buttonДобавитьКритерий = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxНаправлениеПоиска = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.62302F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.37698F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(681, 307);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Значение решений и критериев";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.f1,
            this.f2,
            this.f3});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 16);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "x1";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView.Size = new System.Drawing.Size(455, 282);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_RowsAdded);
            // 
            // f1
            // 
            this.f1.HeaderText = "f1";
            this.f1.Name = "f1";
            // 
            // f2
            // 
            this.f2.HeaderText = "f2";
            this.f2.Name = "f2";
            // 
            // f3
            // 
            this.f3.HeaderText = "f3";
            this.f3.Name = "f3";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(470, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.94352F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.05648F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(208, 301);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonВыход);
            this.groupBox2.Controls.Add(this.buttonВычислить);
            this.groupBox2.Controls.Add(this.buttonУдалитьКритерий);
            this.groupBox2.Controls.Add(this.buttonДобавитьКритерий);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 245);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изменения";
            // 
            // buttonВыход
            // 
            this.buttonВыход.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonВыход.Location = new System.Drawing.Point(3, 219);
            this.buttonВыход.Name = "buttonВыход";
            this.buttonВыход.Size = new System.Drawing.Size(196, 23);
            this.buttonВыход.TabIndex = 5;
            this.buttonВыход.Text = "Выход";
            this.buttonВыход.UseVisualStyleBackColor = true;
            this.buttonВыход.Click += new System.EventHandler(this.buttonВыход_Click);
            // 
            // buttonВычислить
            // 
            this.buttonВычислить.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonВычислить.Location = new System.Drawing.Point(3, 91);
            this.buttonВычислить.Name = "buttonВычислить";
            this.buttonВычислить.Size = new System.Drawing.Size(196, 23);
            this.buttonВычислить.TabIndex = 4;
            this.buttonВычислить.Text = "Вычислить";
            this.buttonВычислить.UseVisualStyleBackColor = true;
            this.buttonВычислить.Click += new System.EventHandler(this.buttonВычислить_Click);
            // 
            // buttonУдалитьКритерий
            // 
            this.buttonУдалитьКритерий.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonУдалитьКритерий.Location = new System.Drawing.Point(3, 53);
            this.buttonУдалитьКритерий.Name = "buttonУдалитьКритерий";
            this.buttonУдалитьКритерий.Size = new System.Drawing.Size(196, 38);
            this.buttonУдалитьКритерий.TabIndex = 3;
            this.buttonУдалитьКритерий.Text = "Удалить критерий";
            this.buttonУдалитьКритерий.UseVisualStyleBackColor = true;
            this.buttonУдалитьКритерий.Click += new System.EventHandler(this.buttonУдалитьКритерий_Click);
            // 
            // buttonДобавитьКритерий
            // 
            this.buttonДобавитьКритерий.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonДобавитьКритерий.Location = new System.Drawing.Point(3, 16);
            this.buttonДобавитьКритерий.Name = "buttonДобавитьКритерий";
            this.buttonДобавитьКритерий.Size = new System.Drawing.Size(196, 37);
            this.buttonДобавитьКритерий.TabIndex = 2;
            this.buttonДобавитьКритерий.Text = "Добавить критерий";
            this.buttonДобавитьКритерий.UseVisualStyleBackColor = true;
            this.buttonДобавитьКритерий.Click += new System.EventHandler(this.buttonДобавитьКритерий_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxНаправлениеПоиска);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 44);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Направление поиска";
            // 
            // comboBoxНаправлениеПоиска
            // 
            this.comboBoxНаправлениеПоиска.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxНаправлениеПоиска.FormattingEnabled = true;
            this.comboBoxНаправлениеПоиска.Items.AddRange(new object[] {
            "Минимум",
            "Максимум"});
            this.comboBoxНаправлениеПоиска.Location = new System.Drawing.Point(3, 16);
            this.comboBoxНаправлениеПоиска.Name = "comboBoxНаправлениеПоиска";
            this.comboBoxНаправлениеПоиска.Size = new System.Drawing.Size(196, 21);
            this.comboBoxНаправлениеПоиска.TabIndex = 0;
            this.comboBoxНаправлениеПоиска.Text = "Максимум";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 307);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn f1;
        private System.Windows.Forms.DataGridViewTextBoxColumn f2;
        private System.Windows.Forms.DataGridViewTextBoxColumn f3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonВыход;
        private System.Windows.Forms.Button buttonВычислить;
        private System.Windows.Forms.Button buttonУдалитьКритерий;
        private System.Windows.Forms.Button buttonДобавитьКритерий;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxНаправлениеПоиска;

    }
}

