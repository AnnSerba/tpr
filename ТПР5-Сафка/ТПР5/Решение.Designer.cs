namespace ТПР5
{
    partial class Solution
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewUnmatchedSolutions = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDistanceToTheIdealPoint = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewUtopiaPointValue = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonВыход = new System.Windows.Forms.Button();
            this.buttonВычислить = new System.Windows.Forms.Button();
            this.buttonУдалитьКритерий = new System.Windows.Forms.Button();
            this.buttonДобавитьКритерий = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBoxSearchDirection = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnmatchedSolutions)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDistanceToTheIdealPoint)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtopiaPointValue)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 212F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 494F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(673, 572);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewUnmatchedSolutions);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 206);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Недоминируемые решения (Множество Парето)";
            // 
            // dataGridViewНесравнимыеРешения
            // 
            this.dataGridViewUnmatchedSolutions.AllowUserToAddRows = false;
            this.dataGridViewUnmatchedSolutions.AllowUserToDeleteRows = false;
            this.dataGridViewUnmatchedSolutions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUnmatchedSolutions.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewUnmatchedSolutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnmatchedSolutions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUnmatchedSolutions.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewUnmatchedSolutions.Name = "dataGridViewНесравнимыеРешения";
            this.dataGridViewUnmatchedSolutions.ReadOnly = true;
            this.dataGridViewUnmatchedSolutions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewUnmatchedSolutions.Size = new System.Drawing.Size(446, 185);
            this.dataGridViewUnmatchedSolutions.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewDistanceToTheIdealPoint);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(461, 363);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(209, 206);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Растояние до точки утопии";
            // 
            // dataGridViewРастояниеДоИдеальнойТочки
            // 
            this.dataGridViewDistanceToTheIdealPoint.AllowUserToAddRows = false;
            this.dataGridViewDistanceToTheIdealPoint.AllowUserToDeleteRows = false;
            this.dataGridViewDistanceToTheIdealPoint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDistanceToTheIdealPoint.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewDistanceToTheIdealPoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDistanceToTheIdealPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDistanceToTheIdealPoint.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewDistanceToTheIdealPoint.MultiSelect = false;
            this.dataGridViewDistanceToTheIdealPoint.Name = "dataGridViewРастояниеДоИдеальнойТочки";
            this.dataGridViewDistanceToTheIdealPoint.ReadOnly = true;
            this.dataGridViewDistanceToTheIdealPoint.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewDistanceToTheIdealPoint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewDistanceToTheIdealPoint.Size = new System.Drawing.Size(203, 185);
            this.dataGridViewDistanceToTheIdealPoint.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(452, 354);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewUtopiaPointValue);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 64);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Точка утопии";
            // 
            // dataGridViewЗначенияТочкиУтопии
            // 
            this.dataGridViewUtopiaPointValue.AllowUserToAddRows = false;
            this.dataGridViewUtopiaPointValue.AllowUserToDeleteRows = false;
            this.dataGridViewUtopiaPointValue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUtopiaPointValue.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewUtopiaPointValue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUtopiaPointValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUtopiaPointValue.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewUtopiaPointValue.Name = "dataGridViewЗначенияТочкиУтопии";
            this.dataGridViewUtopiaPointValue.ReadOnly = true;
            this.dataGridViewUtopiaPointValue.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewUtopiaPointValue.Size = new System.Drawing.Size(440, 43);
            this.dataGridViewUtopiaPointValue.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 278);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Значение критериев";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 18);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView.Size = new System.Drawing.Size(440, 257);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_RowsAdded);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox6, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(461, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.53672F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.46328F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(209, 354);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonВыход);
            this.groupBox6.Controls.Add(this.buttonВычислить);
            this.groupBox6.Controls.Add(this.buttonУдалитьКритерий);
            this.groupBox6.Controls.Add(this.buttonДобавитьКритерий);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 57);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(203, 294);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Изменения";
            // 
            // buttonВыход
            // 
            this.buttonВыход.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonВыход.Location = new System.Drawing.Point(3, 268);
            this.buttonВыход.Name = "buttonВыход";
            this.buttonВыход.Size = new System.Drawing.Size(197, 23);
            this.buttonВыход.TabIndex = 5;
            this.buttonВыход.Text = "Выход";
            this.buttonВыход.UseVisualStyleBackColor = true;
            this.buttonВыход.Click += new System.EventHandler(this.buttonВыход_Click);
            // 
            // buttonВычислить
            // 
            this.buttonВычислить.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonВычислить.Location = new System.Drawing.Point(3, 98);
            this.buttonВычислить.Name = "buttonВычислить";
            this.buttonВычислить.Size = new System.Drawing.Size(197, 40);
            this.buttonВычислить.TabIndex = 4;
            this.buttonВычислить.Text = "Вычислить";
            this.buttonВычислить.UseVisualStyleBackColor = true;
            this.buttonВычислить.Click += new System.EventHandler(this.buttonВычислить_Click);
            // 
            // buttonУдалитьКритерий
            // 
            this.buttonУдалитьКритерий.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonУдалитьКритерий.Location = new System.Drawing.Point(3, 58);
            this.buttonУдалитьКритерий.Name = "buttonУдалитьКритерий";
            this.buttonУдалитьКритерий.Size = new System.Drawing.Size(197, 40);
            this.buttonУдалитьКритерий.TabIndex = 3;
            this.buttonУдалитьКритерий.Text = "Удалить критерий";
            this.buttonУдалитьКритерий.UseVisualStyleBackColor = true;
            this.buttonУдалитьКритерий.Click += new System.EventHandler(this.buttonУдалитьКритерий_Click);
            // 
            // buttonДобавитьКритерий
            // 
            this.buttonДобавитьКритерий.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonДобавитьКритерий.Location = new System.Drawing.Point(3, 18);
            this.buttonДобавитьКритерий.Name = "buttonДобавитьКритерий";
            this.buttonДобавитьКритерий.Size = new System.Drawing.Size(197, 40);
            this.buttonДобавитьКритерий.TabIndex = 2;
            this.buttonДобавитьКритерий.Text = "Добавить критерий";
            this.buttonДобавитьКритерий.UseVisualStyleBackColor = true;
            this.buttonДобавитьКритерий.Click += new System.EventHandler(this.buttonДобавитьКритерий_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBoxSearchDirection);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(203, 48);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Направление поиска";
            // 
            // comboBoxНаправлениеПоиска
            // 
            this.comboBoxSearchDirection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSearchDirection.FormattingEnabled = true;
            this.comboBoxSearchDirection.Items.AddRange(new object[] {
            "Минимум",
            "Максимум"});
            this.comboBoxSearchDirection.Location = new System.Drawing.Point(3, 18);
            this.comboBoxSearchDirection.Name = "comboBoxНаправлениеПоиска";
            this.comboBoxSearchDirection.Size = new System.Drawing.Size(197, 21);
            this.comboBoxSearchDirection.TabIndex = 0;
            this.comboBoxSearchDirection.Text = "Максимум";
            // 
            // ТПР 5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 572);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "ТПР 5";
            this.Text = "ТПР 5";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnmatchedSolutions)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDistanceToTheIdealPoint)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtopiaPointValue)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewUtopiaPointValue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewUnmatchedSolutions;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewDistanceToTheIdealPoint;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonВыход;
        private System.Windows.Forms.Button buttonВычислить;
        private System.Windows.Forms.Button buttonУдалитьКритерий;
        private System.Windows.Forms.Button buttonДобавитьКритерий;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBoxSearchDirection;
    }
}