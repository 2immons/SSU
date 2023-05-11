namespace WarehousesUI_task8
{
    partial class TablesListForm
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
            this.buttonChangeTable = new System.Windows.Forms.Button();
            this.myDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.radioProducts = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.radioSupplyLog = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioShippingLog = new System.Windows.Forms.RadioButton();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioTransfers = new System.Windows.Forms.RadioButton();
            this.radioStorage = new System.Windows.Forms.RadioButton();
            this.radioManufacturers = new System.Windows.Forms.RadioButton();
            this.radioSuppliers = new System.Windows.Forms.RadioButton();
            this.radioBuyers = new System.Windows.Forms.RadioButton();
            this.radioStorageMethods = new System.Windows.Forms.RadioButton();
            this.radioWarehouses = new System.Windows.Forms.RadioButton();
            this.radioCategories = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.labelRole = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonChangeTable
            // 
            this.buttonChangeTable.AutoEllipsis = true;
            this.buttonChangeTable.BackColor = System.Drawing.SystemColors.Info;
            this.buttonChangeTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonChangeTable.Location = new System.Drawing.Point(11, 15);
            this.buttonChangeTable.Name = "buttonChangeTable";
            this.buttonChangeTable.Size = new System.Drawing.Size(147, 35);
            this.buttonChangeTable.TabIndex = 70;
            this.buttonChangeTable.Text = "Сменить таблицу";
            this.buttonChangeTable.UseVisualStyleBackColor = false;
            this.buttonChangeTable.Click += new System.EventHandler(this.buttonChangeTable_Click);
            // 
            // myDataGridView
            // 
            this.myDataGridView.AllowUserToAddRows = false;
            this.myDataGridView.AllowUserToDeleteRows = false;
            this.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGridView.Location = new System.Drawing.Point(212, 43);
            this.myDataGridView.Name = "myDataGridView";
            this.myDataGridView.ReadOnly = true;
            this.myDataGridView.Size = new System.Drawing.Size(774, 270);
            this.myDataGridView.TabIndex = 67;
            this.myDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myDataGridView_CellClick);
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonClearFields.Location = new System.Drawing.Point(330, 202);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(81, 20);
            this.buttonClearFields.TabIndex = 66;
            this.buttonClearFields.Text = "Очистка";
            this.buttonClearFields.UseVisualStyleBackColor = true;
            this.buttonClearFields.Click += new System.EventHandler(this.buttonClearFields_Click);
            // 
            // radioProducts
            // 
            this.radioProducts.AutoSize = true;
            this.radioProducts.Location = new System.Drawing.Point(12, 67);
            this.radioProducts.Name = "radioProducts";
            this.radioProducts.Size = new System.Drawing.Size(64, 17);
            this.radioProducts.TabIndex = 68;
            this.radioProducts.TabStop = true;
            this.radioProducts.Text = "Товары";
            this.radioProducts.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(62, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 65;
            this.label6.Text = "ID поставщика";
            // 
            // radioSupplyLog
            // 
            this.radioSupplyLog.AutoSize = true;
            this.radioSupplyLog.Location = new System.Drawing.Point(12, 90);
            this.radioSupplyLog.Name = "radioSupplyLog";
            this.radioSupplyLog.Size = new System.Drawing.Size(115, 17);
            this.radioSupplyLog.TabIndex = 69;
            this.radioSupplyLog.TabStop = true;
            this.radioSupplyLog.Text = "Журнал поставок";
            this.radioSupplyLog.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(62, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 15);
            this.label4.TabIndex = 64;
            this.label4.Text = "ID метода хранения";
            // 
            // buttonCreate
            // 
            this.buttonCreate.AutoEllipsis = true;
            this.buttonCreate.BackColor = System.Drawing.SystemColors.Info;
            this.buttonCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreate.Location = new System.Drawing.Point(525, 15);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(182, 35);
            this.buttonCreate.TabIndex = 47;
            this.buttonCreate.Text = "Добавить запись";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(62, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 15);
            this.label5.TabIndex = 63;
            this.label5.Text = "ID производителя";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.SystemColors.Window;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRefresh.Location = new System.Drawing.Point(212, 15);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(88, 24);
            this.buttonRefresh.TabIndex = 48;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(62, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 62;
            this.label2.Text = "Название";
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(834, 19);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(152, 20);
            this.textBox_search.TabIndex = 49;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(62, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 61;
            this.label3.Text = "ID категории";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(62, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 60;
            this.label1.Text = "ID";
            // 
            // buttonDelete
            // 
            this.buttonDelete.AutoEllipsis = true;
            this.buttonDelete.BackColor = System.Drawing.SystemColors.Info;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.Location = new System.Drawing.Point(525, 59);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(182, 35);
            this.buttonDelete.TabIndex = 51;
            this.buttonDelete.Text = "Удалить запись";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(289, 145);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(170, 20);
            this.textBox6.TabIndex = 59;
            // 
            // buttonSave
            // 
            this.buttonSave.AutoEllipsis = true;
            this.buttonSave.BackColor = System.Drawing.SystemColors.Info;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonSave.Location = new System.Drawing.Point(525, 175);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(182, 34);
            this.buttonSave.TabIndex = 52;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(289, 119);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(170, 20);
            this.textBox5.TabIndex = 58;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.AutoEllipsis = true;
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.Info;
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonUpdate.Location = new System.Drawing.Point(525, 102);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(182, 35);
            this.buttonUpdate.TabIndex = 53;
            this.buttonUpdate.Text = "Изменить запись";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(289, 93);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(170, 20);
            this.textBox4.TabIndex = 57;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(289, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 54;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(289, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(170, 20);
            this.textBox3.TabIndex = 56;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(289, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 20);
            this.textBox2.TabIndex = 55;
            // 
            // radioShippingLog
            // 
            this.radioShippingLog.AutoSize = true;
            this.radioShippingLog.Location = new System.Drawing.Point(12, 113);
            this.radioShippingLog.Name = "radioShippingLog";
            this.radioShippingLog.Size = new System.Drawing.Size(113, 17);
            this.radioShippingLog.TabIndex = 71;
            this.radioShippingLog.TabStop = true;
            this.radioShippingLog.Text = "Журнал отгрузок";
            this.radioShippingLog.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(289, 171);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(170, 20);
            this.textBox7.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(62, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 15);
            this.label7.TabIndex = 73;
            this.label7.Text = "ID поставщика";
            // 
            // radioTransfers
            // 
            this.radioTransfers.AutoSize = true;
            this.radioTransfers.Location = new System.Drawing.Point(12, 136);
            this.radioTransfers.Name = "radioTransfers";
            this.radioTransfers.Size = new System.Drawing.Size(129, 17);
            this.radioTransfers.TabIndex = 74;
            this.radioTransfers.TabStop = true;
            this.radioTransfers.Text = "Журнал трансферов";
            this.radioTransfers.UseVisualStyleBackColor = true;
            // 
            // radioStorage
            // 
            this.radioStorage.AutoSize = true;
            this.radioStorage.Location = new System.Drawing.Point(12, 159);
            this.radioStorage.Name = "radioStorage";
            this.radioStorage.Size = new System.Drawing.Size(118, 17);
            this.radioStorage.TabIndex = 75;
            this.radioStorage.TabStop = true;
            this.radioStorage.Text = "Хранение товаров";
            this.radioStorage.UseVisualStyleBackColor = true;
            // 
            // radioManufacturers
            // 
            this.radioManufacturers.AutoSize = true;
            this.radioManufacturers.Location = new System.Drawing.Point(12, 251);
            this.radioManufacturers.Name = "radioManufacturers";
            this.radioManufacturers.Size = new System.Drawing.Size(104, 17);
            this.radioManufacturers.TabIndex = 76;
            this.radioManufacturers.TabStop = true;
            this.radioManufacturers.Text = "Производители";
            this.radioManufacturers.UseVisualStyleBackColor = true;
            // 
            // radioSuppliers
            // 
            this.radioSuppliers.AutoSize = true;
            this.radioSuppliers.Location = new System.Drawing.Point(12, 205);
            this.radioSuppliers.Name = "radioSuppliers";
            this.radioSuppliers.Size = new System.Drawing.Size(89, 17);
            this.radioSuppliers.TabIndex = 77;
            this.radioSuppliers.TabStop = true;
            this.radioSuppliers.Text = "Поставщики";
            this.radioSuppliers.UseVisualStyleBackColor = true;
            // 
            // radioBuyers
            // 
            this.radioBuyers.AutoSize = true;
            this.radioBuyers.Location = new System.Drawing.Point(12, 228);
            this.radioBuyers.Name = "radioBuyers";
            this.radioBuyers.Size = new System.Drawing.Size(85, 17);
            this.radioBuyers.TabIndex = 78;
            this.radioBuyers.TabStop = true;
            this.radioBuyers.Text = "Покупатели";
            this.radioBuyers.UseVisualStyleBackColor = true;
            // 
            // radioStorageMethods
            // 
            this.radioStorageMethods.AutoSize = true;
            this.radioStorageMethods.Location = new System.Drawing.Point(12, 274);
            this.radioStorageMethods.Name = "radioStorageMethods";
            this.radioStorageMethods.Size = new System.Drawing.Size(115, 17);
            this.radioStorageMethods.TabIndex = 79;
            this.radioStorageMethods.TabStop = true;
            this.radioStorageMethods.Text = "Методы хранения";
            this.radioStorageMethods.UseVisualStyleBackColor = true;
            // 
            // radioWarehouses
            // 
            this.radioWarehouses.AutoSize = true;
            this.radioWarehouses.Location = new System.Drawing.Point(12, 182);
            this.radioWarehouses.Name = "radioWarehouses";
            this.radioWarehouses.Size = new System.Drawing.Size(64, 17);
            this.radioWarehouses.TabIndex = 80;
            this.radioWarehouses.TabStop = true;
            this.radioWarehouses.Text = "Склады";
            this.radioWarehouses.UseVisualStyleBackColor = true;
            // 
            // radioCategories
            // 
            this.radioCategories.AutoSize = true;
            this.radioCategories.Location = new System.Drawing.Point(12, 296);
            this.radioCategories.Name = "radioCategories";
            this.radioCategories.Size = new System.Drawing.Size(122, 17);
            this.radioCategories.TabIndex = 81;
            this.radioCategories.TabStop = true;
            this.radioCategories.Text = "Категории товаров";
            this.radioCategories.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(11, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 24);
            this.button1.TabIndex = 82;
            this.button1.Text = "Отчет по разнице цены";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoEllipsis = true;
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(11, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 24);
            this.button2.TabIndex = 83;
            this.button2.Text = "Отчет по кол-ву на складе";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoEllipsis = true;
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(11, 444);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 24);
            this.button3.TabIndex = 84;
            this.button3.Text = "Отчет о перемещениях за даты";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.AutoEllipsis = true;
            this.button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(11, 384);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 24);
            this.button4.TabIndex = 85;
            this.button4.Text = "Сумма отгрузок за день";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRole.Location = new System.Drawing.Point(529, 15);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(0, 18);
            this.labelRole.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(789, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 87;
            this.label8.Text = "Поиск";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(72, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 88;
            this.label9.Text = "Отчеты";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.buttonCreate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.buttonClearFields);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Location = new System.Drawing.Point(212, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 227);
            this.panel1.TabIndex = 89;
            // 
            // TablesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 551);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioCategories);
            this.Controls.Add(this.radioWarehouses);
            this.Controls.Add(this.radioStorageMethods);
            this.Controls.Add(this.radioBuyers);
            this.Controls.Add(this.radioSuppliers);
            this.Controls.Add(this.radioManufacturers);
            this.Controls.Add(this.radioStorage);
            this.Controls.Add(this.radioTransfers);
            this.Controls.Add(this.radioShippingLog);
            this.Controls.Add(this.buttonChangeTable);
            this.Controls.Add(this.myDataGridView);
            this.Controls.Add(this.radioProducts);
            this.Controls.Add(this.radioSupplyLog);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.textBox_search);
            this.Name = "TablesListForm";
            this.Text = "Просмотр и редактирование таблиц";
            this.Load += new System.EventHandler(this.TablesListAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChangeTable;
        private System.Windows.Forms.DataGridView myDataGridView;
        private System.Windows.Forms.Button buttonClearFields;
        private System.Windows.Forms.RadioButton radioProducts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioSupplyLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioShippingLog;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioTransfers;
        private System.Windows.Forms.RadioButton radioStorage;
        private System.Windows.Forms.RadioButton radioManufacturers;
        private System.Windows.Forms.RadioButton radioSuppliers;
        private System.Windows.Forms.RadioButton radioBuyers;
        private System.Windows.Forms.RadioButton radioStorageMethods;
        private System.Windows.Forms.RadioButton radioWarehouses;
        private System.Windows.Forms.RadioButton radioCategories;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
    }
}