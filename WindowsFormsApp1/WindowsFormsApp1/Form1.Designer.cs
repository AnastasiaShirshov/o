
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.источникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDSourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.othodDataSet1 = new WindowsFormsApp1.OthodDataSet1();
            this.othodDataSet = new WindowsFormsApp1.OthodDataSet();
            this.sourceTableAdapter = new WindowsFormsApp1.OthodDataSet1TableAdapters.SourceTableAdapter();
            this.othodDataSet2 = new WindowsFormsApp1.OthodDataSet2();
            this.emissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emissionTableAdapter = new WindowsFormsApp1.OthodDataSet2TableAdapters.EmissionTableAdapter();
            this.othodDataSet3 = new WindowsFormsApp1.OthodDataSet3();
            this.emissionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.emissionTableAdapter1 = new WindowsFormsApp1.OthodDataSet3TableAdapters.EmissionTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDEmissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSourseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emissionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.othodDataSet4 = new WindowsFormsApp1.OthodDataSet4();
            this.emissionTableAdapter2 = new WindowsFormsApp1.OthodDataSet4TableAdapters.EmissionTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.едактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.едактироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.минимальныеВыбросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мАксимальныеВыбросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.средниеВыбросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.othodDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.othodDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.othodDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emissionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.othodDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emissionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emissionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.othodDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.источникToolStripMenuItem,
            this.выбросыToolStripMenuItem,
            this.расчетToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1088, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // источникToolStripMenuItem
            // 
            this.источникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.едактироватьToolStripMenuItem});
            this.источникToolStripMenuItem.Name = "источникToolStripMenuItem";
            this.источникToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.источникToolStripMenuItem.Text = "Источник";
            // 
            // выбросыToolStripMenuItem
            // 
            this.выбросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem1,
            this.едактироватьToolStripMenuItem1});
            this.выбросыToolStripMenuItem.Name = "выбросыToolStripMenuItem";
            this.выбросыToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.выбросыToolStripMenuItem.Text = "Выбросы";
            // 
            // расчетToolStripMenuItem
            // 
            this.расчетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.минимальныеВыбросыToolStripMenuItem,
            this.мАксимальныеВыбросыToolStripMenuItem,
            this.средниеВыбросыToolStripMenuItem});
            this.расчетToolStripMenuItem.Name = "расчетToolStripMenuItem";
            this.расчетToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.расчетToolStripMenuItem.Text = "Расчет";
            this.расчетToolStripMenuItem.Click += new System.EventHandler(this.расчетToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Источник выбросов";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выбросы";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSourseDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sourceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(664, 201);
            this.dataGridView1.TabIndex = 3;
            // 
            // iDSourseDataGridViewTextBoxColumn
            // 
            this.iDSourseDataGridViewTextBoxColumn.DataPropertyName = "ID_Sourse";
            this.iDSourseDataGridViewTextBoxColumn.HeaderText = "ID_Sourse";
            this.iDSourseDataGridViewTextBoxColumn.Name = "iDSourseDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // addresDataGridViewTextBoxColumn
            // 
            this.addresDataGridViewTextBoxColumn.DataPropertyName = "Addres";
            this.addresDataGridViewTextBoxColumn.HeaderText = "Addres";
            this.addresDataGridViewTextBoxColumn.Name = "addresDataGridViewTextBoxColumn";
            // 
            // sourceBindingSource
            // 
            this.sourceBindingSource.DataMember = "Source";
            this.sourceBindingSource.DataSource = this.othodDataSet1;
            // 
            // othodDataSet1
            // 
            this.othodDataSet1.DataSetName = "OthodDataSet1";
            this.othodDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // othodDataSet
            // 
            this.othodDataSet.DataSetName = "OthodDataSet";
            this.othodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sourceTableAdapter
            // 
            this.sourceTableAdapter.ClearBeforeFill = true;
            // 
            // othodDataSet2
            // 
            this.othodDataSet2.DataSetName = "OthodDataSet2";
            this.othodDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emissionBindingSource
            // 
            this.emissionBindingSource.DataMember = "Emission";
            this.emissionBindingSource.DataSource = this.othodDataSet2;
            // 
            // emissionTableAdapter
            // 
            this.emissionTableAdapter.ClearBeforeFill = true;
            // 
            // othodDataSet3
            // 
            this.othodDataSet3.DataSetName = "OthodDataSet3";
            this.othodDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emissionBindingSource1
            // 
            this.emissionBindingSource1.DataMember = "Emission";
            this.emissionBindingSource1.DataSource = this.othodDataSet3;
            // 
            // emissionTableAdapter1
            // 
            this.emissionTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDEmissionDataGridViewTextBoxColumn,
            this.iDSourseDataGridViewTextBoxColumn1,
            this.countDataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.emissionBindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(27, 365);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(664, 200);
            this.dataGridView2.TabIndex = 4;
            // 
            // iDEmissionDataGridViewTextBoxColumn
            // 
            this.iDEmissionDataGridViewTextBoxColumn.DataPropertyName = "ID_Emission";
            this.iDEmissionDataGridViewTextBoxColumn.HeaderText = "ID_Emission";
            this.iDEmissionDataGridViewTextBoxColumn.Name = "iDEmissionDataGridViewTextBoxColumn";
            // 
            // iDSourseDataGridViewTextBoxColumn1
            // 
            this.iDSourseDataGridViewTextBoxColumn1.DataPropertyName = "ID_Sourse";
            this.iDSourseDataGridViewTextBoxColumn1.HeaderText = "ID_Sourse";
            this.iDSourseDataGridViewTextBoxColumn1.Name = "iDSourseDataGridViewTextBoxColumn1";
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Text";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // emissionBindingSource2
            // 
            this.emissionBindingSource2.DataMember = "Emission";
            this.emissionBindingSource2.DataSource = this.othodDataSet4;
            // 
            // othodDataSet4
            // 
            this.othodDataSet4.DataSetName = "OthodDataSet4";
            this.othodDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emissionTableAdapter2
            // 
            this.emissionTableAdapter2.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(749, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить источник ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(749, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 45);
            this.button2.TabIndex = 6;
            this.button2.Text = "Редактировать  источник ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(749, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 45);
            this.button3.TabIndex = 7;
            this.button3.Text = "Удалить источник ";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(749, 382);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(218, 45);
            this.button4.TabIndex = 8;
            this.button4.Text = "Добавить выбросы";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkGray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(749, 442);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(218, 45);
            this.button5.TabIndex = 9;
            this.button5.Text = "Удалить выбросы";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkGray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(749, 503);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(218, 45);
            this.button6.TabIndex = 10;
            this.button6.Text = "Редактировать  выбросы";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DarkGray;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(39, 586);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(153, 57);
            this.button9.TabIndex = 13;
            this.button9.Text = "Минимальные выбросы";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkGray;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(217, 586);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(153, 57);
            this.button7.TabIndex = 14;
            this.button7.Text = "Максимальные выбросы";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DarkGray;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(391, 586);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(153, 57);
            this.button8.TabIndex = 15;
            this.button8.Text = "Средние выбросы";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить ";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // едактироватьToolStripMenuItem
            // 
            this.едактироватьToolStripMenuItem.Name = "едактироватьToolStripMenuItem";
            this.едактироватьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.едактироватьToolStripMenuItem.Text = "едактировать";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            // 
            // едактироватьToolStripMenuItem1
            // 
            this.едактироватьToolStripMenuItem1.Name = "едактироватьToolStripMenuItem1";
            this.едактироватьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.едактироватьToolStripMenuItem1.Text = "едактировать";
            // 
            // минимальныеВыбросыToolStripMenuItem
            // 
            this.минимальныеВыбросыToolStripMenuItem.Name = "минимальныеВыбросыToolStripMenuItem";
            this.минимальныеВыбросыToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.минимальныеВыбросыToolStripMenuItem.Text = "Минимальные выбросы";
            // 
            // мАксимальныеВыбросыToolStripMenuItem
            // 
            this.мАксимальныеВыбросыToolStripMenuItem.Name = "мАксимальныеВыбросыToolStripMenuItem";
            this.мАксимальныеВыбросыToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.мАксимальныеВыбросыToolStripMenuItem.Text = "МАксимальные выбросы";
            // 
            // средниеВыбросыToolStripMenuItem
            // 
            this.средниеВыбросыToolStripMenuItem.Name = "средниеВыбросыToolStripMenuItem";
            this.средниеВыбросыToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.средниеВыбросыToolStripMenuItem.Text = "Средние выбросы";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1088, 655);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Программа мониторинга загрязнения окружающей среды";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.othodDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.othodDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.othodDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emissionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.othodDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emissionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emissionBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.othodDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem источникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расчетToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OthodDataSet othodDataSet;
        private OthodDataSet1 othodDataSet1;
        private System.Windows.Forms.BindingSource sourceBindingSource;
        private OthodDataSet1TableAdapters.SourceTableAdapter sourceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresDataGridViewTextBoxColumn;
        private OthodDataSet2 othodDataSet2;
        private System.Windows.Forms.BindingSource emissionBindingSource;
        private OthodDataSet2TableAdapters.EmissionTableAdapter emissionTableAdapter;
        private OthodDataSet3 othodDataSet3;
        private System.Windows.Forms.BindingSource emissionBindingSource1;
        private OthodDataSet3TableAdapters.EmissionTableAdapter emissionTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private OthodDataSet4 othodDataSet4;
        private System.Windows.Forms.BindingSource emissionBindingSource2;
        private OthodDataSet4TableAdapters.EmissionTableAdapter emissionTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEmissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSourseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem едактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem едактироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem минимальныеВыбросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мАксимальныеВыбросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem средниеВыбросыToolStripMenuItem;
    }
}

