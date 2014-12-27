namespace TPR3
{
    partial class FormТеорияВажности
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewСкалярныеОценки = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonУдалитьКритерий = new System.Windows.Forms.Button();
            this.buttonДобавитьКритерий = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewВажности = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonВыход = new System.Windows.Forms.Button();
            this.buttonВычислить = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewСкалярныеОценки)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewВажности)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.0219F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.9781F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(498, 424);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewСкалярныеОценки);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Скалярные оценки kij  критериев Kj  для решений xi";
            // 
            // dataGridViewСкалярныеОценки
            // 
            this.dataGridViewСкалярныеОценки.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewСкалярныеОценки.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewСкалярныеОценки.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewСкалярныеОценки.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewСкалярныеОценки.Name = "dataGridViewСкалярныеОценки";
            this.dataGridViewСкалярныеОценки.Size = new System.Drawing.Size(391, 329);
            this.dataGridViewСкалярныеОценки.TabIndex = 0;
            this.dataGridViewСкалярныеОценки.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewСкалярныеОценки_RowsAdded);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonУдалитьКритерий);
            this.groupBox2.Controls.Add(this.buttonДобавитьКритерий);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(406, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(89, 348);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изменения";
            // 
            // buttonУдалитьКритерий
            // 
            this.buttonУдалитьКритерий.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonУдалитьКритерий.Location = new System.Drawing.Point(3, 53);
            this.buttonУдалитьКритерий.Name = "buttonУдалитьКритерий";
            this.buttonУдалитьКритерий.Size = new System.Drawing.Size(83, 38);
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
            this.buttonДобавитьКритерий.Size = new System.Drawing.Size(83, 37);
            this.buttonДобавитьКритерий.TabIndex = 2;
            this.buttonДобавитьКритерий.Text = "Добавить критерий";
            this.buttonДобавитьКритерий.UseVisualStyleBackColor = true;
            this.buttonДобавитьКритерий.Click += new System.EventHandler(this.buttonДобавитьКритерий_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewВажности);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 64);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Важность критериев";
            // 
            // dataGridViewВажности
            // 
            this.dataGridViewВажности.AllowUserToAddRows = false;
            this.dataGridViewВажности.AllowUserToDeleteRows = false;
            this.dataGridViewВажности.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewВажности.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewВажности.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewВажности.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewВажности.Name = "dataGridViewВажности";
            this.dataGridViewВажности.Size = new System.Drawing.Size(391, 45);
            this.dataGridViewВажности.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonВыход);
            this.groupBox4.Controls.Add(this.buttonВычислить);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(406, 357);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(89, 64);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // buttonВыход
            // 
            this.buttonВыход.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonВыход.Location = new System.Drawing.Point(3, 38);
            this.buttonВыход.Name = "buttonВыход";
            this.buttonВыход.Size = new System.Drawing.Size(83, 23);
            this.buttonВыход.TabIndex = 1;
            this.buttonВыход.Text = "Выход";
            this.buttonВыход.UseVisualStyleBackColor = true;
            this.buttonВыход.Click += new System.EventHandler(this.buttonВыход_Click);
            // 
            // buttonВычислить
            // 
            this.buttonВычислить.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonВычислить.Location = new System.Drawing.Point(3, 16);
            this.buttonВычислить.Name = "buttonВычислить";
            this.buttonВычислить.Size = new System.Drawing.Size(83, 23);
            this.buttonВычислить.TabIndex = 0;
            this.buttonВычислить.Text = "Вычислить";
            this.buttonВычислить.UseVisualStyleBackColor = true;
            this.buttonВычислить.Click += new System.EventHandler(this.buttonВычислить_Click);
            // 
            // FormТеорияВажности
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 424);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "FormТеорияВажности";
            this.Text = "ИССЛЕДОВАНИЕ ПРИМЕНЕНИЯ ТЕОРИИ ВАЖНОСТИ КРИТЕРИЕВ ДЛЯ РЕШЕНИЯ ЗАДАЧИ ВЫБОРА АЛЬТЕ" +
    "РНАТИВ ";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewСкалярныеОценки)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewВажности)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewСкалярныеОценки;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonУдалитьКритерий;
        private System.Windows.Forms.Button buttonДобавитьКритерий;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewВажности;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonВыход;
        private System.Windows.Forms.Button buttonВычислить;


    }
}

