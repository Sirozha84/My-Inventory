namespace My_Inventory
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageInventory = new System.Windows.Forms.TabPage();
            this.listViewInventory = new System.Windows.Forms.ListView();
            this.columnHeaderNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDiscription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripItems = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemNewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panelItem = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxDiscription = new System.Windows.Forms.TextBox();
            this.labelDiscription = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.labelDep = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.labelNum = new System.Windows.Forms.Label();
            this.toolStripNewItem = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNewItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelItem = new System.Windows.Forms.ToolStripButton();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.listViewUserItems = new System.Windows.Forms.ListView();
            this.columnHeaderINum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIDiscription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.panelUser = new System.Windows.Forms.Panel();
            this.labelDepartament = new System.Windows.Forms.Label();
            this.buttonUSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUUser = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.columnHeaderUUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUDep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDelUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripUsers = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNewUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelUser = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.comboBoxDepartament = new System.Windows.Forms.ComboBox();
            this.menuStripMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageInventory.SuspendLayout();
            this.contextMenuStripItems.SuspendLayout();
            this.panelItem.SuspendLayout();
            this.toolStripNewItem.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.contextMenuStripUsers.SuspendLayout();
            this.toolStripUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(841, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageInventory);
            this.tabControlMain.Controls.Add(this.tabPageUsers);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 24);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(841, 474);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageInventory
            // 
            this.tabPageInventory.Controls.Add(this.listViewInventory);
            this.tabPageInventory.Controls.Add(this.splitter2);
            this.tabPageInventory.Controls.Add(this.panelItem);
            this.tabPageInventory.Controls.Add(this.toolStripNewItem);
            this.tabPageInventory.Location = new System.Drawing.Point(4, 22);
            this.tabPageInventory.Name = "tabPageInventory";
            this.tabPageInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInventory.Size = new System.Drawing.Size(833, 448);
            this.tabPageInventory.TabIndex = 0;
            this.tabPageInventory.Text = "Инвентарь";
            this.tabPageInventory.UseVisualStyleBackColor = true;
            // 
            // listViewInventory
            // 
            this.listViewInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNum,
            this.columnHeaderName,
            this.columnHeaderUser,
            this.columnHeaderDep,
            this.columnHeaderDate,
            this.columnHeaderDiscription});
            this.listViewInventory.ContextMenuStrip = this.contextMenuStripItems;
            this.listViewInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewInventory.FullRowSelect = true;
            this.listViewInventory.GridLines = true;
            this.listViewInventory.HideSelection = false;
            this.listViewInventory.Location = new System.Drawing.Point(3, 28);
            this.listViewInventory.Name = "listViewInventory";
            this.listViewInventory.Size = new System.Drawing.Size(652, 417);
            this.listViewInventory.TabIndex = 0;
            this.listViewInventory.UseCompatibleStateImageBehavior = false;
            this.listViewInventory.View = System.Windows.Forms.View.Details;
            this.listViewInventory.SelectedIndexChanged += new System.EventHandler(this.listViewInventory_SelectedIndexChanged);
            // 
            // columnHeaderNum
            // 
            this.columnHeaderNum.Text = "Номер";
            this.columnHeaderNum.Width = 68;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Наименование";
            this.columnHeaderName.Width = 116;
            // 
            // columnHeaderUser
            // 
            this.columnHeaderUser.Text = "Сотрудник";
            this.columnHeaderUser.Width = 118;
            // 
            // columnHeaderDep
            // 
            this.columnHeaderDep.Text = "Подразделение";
            this.columnHeaderDep.Width = 130;
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Дата выдачи";
            this.columnHeaderDate.Width = 82;
            // 
            // columnHeaderDiscription
            // 
            this.columnHeaderDiscription.Text = "Примечание";
            this.columnHeaderDiscription.Width = 102;
            // 
            // contextMenuStripItems
            // 
            this.contextMenuStripItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNewItem,
            this.toolStripMenuItemDel});
            this.contextMenuStripItems.Name = "contextMenuStripItems";
            this.contextMenuStripItems.Size = new System.Drawing.Size(162, 48);
            // 
            // toolStripMenuItemNewItem
            // 
            this.toolStripMenuItemNewItem.Image = global::My_Inventory.Properties.Resources.New;
            this.toolStripMenuItemNewItem.Name = "toolStripMenuItemNewItem";
            this.toolStripMenuItemNewItem.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItemNewItem.Text = "Новый предмет";
            this.toolStripMenuItemNewItem.Click += new System.EventHandler(this.toolStripMenuItemNewItem_Click);
            // 
            // toolStripMenuItemDel
            // 
            this.toolStripMenuItemDel.Enabled = false;
            this.toolStripMenuItemDel.Image = global::My_Inventory.Properties.Resources.delete;
            this.toolStripMenuItemDel.Name = "toolStripMenuItemDel";
            this.toolStripMenuItemDel.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItemDel.Text = "Удалить";
            this.toolStripMenuItemDel.Click += new System.EventHandler(this.toolStripMenuItemDel_Click);
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(655, 28);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(5, 417);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // panelItem
            // 
            this.panelItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelItem.Controls.Add(this.buttonSave);
            this.panelItem.Controls.Add(this.textBoxDiscription);
            this.panelItem.Controls.Add(this.labelDiscription);
            this.panelItem.Controls.Add(this.labelDate);
            this.panelItem.Controls.Add(this.dateTimePickerDate);
            this.panelItem.Controls.Add(this.comboBoxUsers);
            this.panelItem.Controls.Add(this.labelDep);
            this.panelItem.Controls.Add(this.textBoxName);
            this.panelItem.Controls.Add(this.labelName);
            this.panelItem.Controls.Add(this.textBoxNum);
            this.panelItem.Controls.Add(this.labelNum);
            this.panelItem.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelItem.Location = new System.Drawing.Point(660, 28);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(170, 417);
            this.panelItem.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(78, 391);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(87, 23);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxDiscription
            // 
            this.textBoxDiscription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDiscription.Enabled = false;
            this.textBoxDiscription.Location = new System.Drawing.Point(6, 175);
            this.textBoxDiscription.Multiline = true;
            this.textBoxDiscription.Name = "textBoxDiscription";
            this.textBoxDiscription.Size = new System.Drawing.Size(159, 210);
            this.textBoxDiscription.TabIndex = 9;
            this.textBoxDiscription.TextChanged += new System.EventHandler(this.textBoxDiscription_TextChanged);
            // 
            // labelDiscription
            // 
            this.labelDiscription.AutoSize = true;
            this.labelDiscription.Location = new System.Drawing.Point(6, 159);
            this.labelDiscription.Name = "labelDiscription";
            this.labelDiscription.Size = new System.Drawing.Size(73, 13);
            this.labelDiscription.TabIndex = 8;
            this.labelDiscription.Text = "Примечание:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(6, 120);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(76, 13);
            this.labelDate.TabIndex = 7;
            this.labelDate.Text = "Дата выдачи:";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDate.Enabled = false;
            this.dateTimePickerDate.Location = new System.Drawing.Point(6, 136);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(159, 20);
            this.dateTimePickerDate.TabIndex = 6;
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePickerDate_ValueChanged);
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxUsers.Enabled = false;
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(6, 96);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(159, 21);
            this.comboBoxUsers.TabIndex = 5;
            this.comboBoxUsers.TextChanged += new System.EventHandler(this.comboBoxUsers_TextChanged);
            // 
            // labelDep
            // 
            this.labelDep.AutoSize = true;
            this.labelDep.Location = new System.Drawing.Point(6, 80);
            this.labelDep.Name = "labelDep";
            this.labelDep.Size = new System.Drawing.Size(63, 13);
            this.labelDep.TabIndex = 4;
            this.labelDep.Text = "Сотрудник:";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(6, 56);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(159, 20);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 40);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(86, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Наименование:";
            // 
            // textBoxNum
            // 
            this.textBoxNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNum.Enabled = false;
            this.textBoxNum.Location = new System.Drawing.Point(6, 17);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(159, 20);
            this.textBoxNum.TabIndex = 1;
            this.textBoxNum.TextChanged += new System.EventHandler(this.textBoxNum_TextChanged);
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(6, 0);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(114, 13);
            this.labelNum.TabIndex = 0;
            this.labelNum.Text = "Инвентарный номер:";
            // 
            // toolStripNewItem
            // 
            this.toolStripNewItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripNewItem.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripNewItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNewItem,
            this.toolStripButtonDelItem});
            this.toolStripNewItem.Location = new System.Drawing.Point(3, 3);
            this.toolStripNewItem.Name = "toolStripNewItem";
            this.toolStripNewItem.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripNewItem.Size = new System.Drawing.Size(827, 25);
            this.toolStripNewItem.TabIndex = 1;
            // 
            // toolStripButtonNewItem
            // 
            this.toolStripButtonNewItem.Image = global::My_Inventory.Properties.Resources.New;
            this.toolStripButtonNewItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewItem.Name = "toolStripButtonNewItem";
            this.toolStripButtonNewItem.Size = new System.Drawing.Size(114, 22);
            this.toolStripButtonNewItem.Text = "Новый предмет";
            this.toolStripButtonNewItem.ToolTipText = "Создать новый предмет";
            this.toolStripButtonNewItem.Click += new System.EventHandler(this.toolStripButtonNewItem_Click);
            // 
            // toolStripButtonDelItem
            // 
            this.toolStripButtonDelItem.Enabled = false;
            this.toolStripButtonDelItem.Image = global::My_Inventory.Properties.Resources.delete;
            this.toolStripButtonDelItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelItem.Name = "toolStripButtonDelItem";
            this.toolStripButtonDelItem.Size = new System.Drawing.Size(71, 22);
            this.toolStripButtonDelItem.Text = "Удалить";
            this.toolStripButtonDelItem.ToolTipText = "Удалить выбранные предметы";
            this.toolStripButtonDelItem.Click += new System.EventHandler(this.toolStripButtonDelItem_Click);
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.Controls.Add(this.listViewUserItems);
            this.tabPageUsers.Controls.Add(this.splitter3);
            this.tabPageUsers.Controls.Add(this.panelUser);
            this.tabPageUsers.Controls.Add(this.splitter1);
            this.tabPageUsers.Controls.Add(this.listViewUsers);
            this.tabPageUsers.Controls.Add(this.toolStripUsers);
            this.tabPageUsers.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsers.Size = new System.Drawing.Size(833, 448);
            this.tabPageUsers.TabIndex = 2;
            this.tabPageUsers.Text = "Сотрудники";
            this.tabPageUsers.UseVisualStyleBackColor = true;
            // 
            // listViewUserItems
            // 
            this.listViewUserItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderINum,
            this.columnHeaderIName,
            this.columnHeaderIDate,
            this.columnHeaderIDiscription});
            this.listViewUserItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewUserItems.Enabled = false;
            this.listViewUserItems.FullRowSelect = true;
            this.listViewUserItems.GridLines = true;
            this.listViewUserItems.Location = new System.Drawing.Point(237, 103);
            this.listViewUserItems.Name = "listViewUserItems";
            this.listViewUserItems.Size = new System.Drawing.Size(593, 342);
            this.listViewUserItems.TabIndex = 3;
            this.listViewUserItems.UseCompatibleStateImageBehavior = false;
            this.listViewUserItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderINum
            // 
            this.columnHeaderINum.Text = "Номер";
            this.columnHeaderINum.Width = 66;
            // 
            // columnHeaderIName
            // 
            this.columnHeaderIName.Text = "Наименование";
            this.columnHeaderIName.Width = 142;
            // 
            // columnHeaderIDate
            // 
            this.columnHeaderIDate.Text = "Дата выдачи";
            this.columnHeaderIDate.Width = 150;
            // 
            // columnHeaderIDiscription
            // 
            this.columnHeaderIDiscription.Text = "Примечание";
            this.columnHeaderIDiscription.Width = 134;
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Enabled = false;
            this.splitter3.Location = new System.Drawing.Point(237, 98);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(593, 5);
            this.splitter3.TabIndex = 6;
            this.splitter3.TabStop = false;
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.comboBoxDepartament);
            this.panelUser.Controls.Add(this.labelDepartament);
            this.panelUser.Controls.Add(this.buttonUSave);
            this.panelUser.Controls.Add(this.label1);
            this.panelUser.Controls.Add(this.textBoxUUser);
            this.panelUser.Controls.Add(this.labelUser);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUser.Location = new System.Drawing.Point(237, 28);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(593, 70);
            this.panelUser.TabIndex = 5;
            // 
            // labelDepartament
            // 
            this.labelDepartament.AutoSize = true;
            this.labelDepartament.Location = new System.Drawing.Point(267, 12);
            this.labelDepartament.Name = "labelDepartament";
            this.labelDepartament.Size = new System.Drawing.Size(90, 13);
            this.labelDepartament.TabIndex = 12;
            this.labelDepartament.Text = "Подразделение:";
            // 
            // buttonUSave
            // 
            this.buttonUSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUSave.Enabled = false;
            this.buttonUSave.Location = new System.Drawing.Point(501, 41);
            this.buttonUSave.Name = "buttonUSave";
            this.buttonUSave.Size = new System.Drawing.Size(87, 23);
            this.buttonUSave.TabIndex = 11;
            this.buttonUSave.Text = "Сохранить";
            this.buttonUSave.UseVisualStyleBackColor = true;
            this.buttonUSave.Click += new System.EventHandler(this.buttonUSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Закреплённый инвентарь:";
            // 
            // textBoxUUser
            // 
            this.textBoxUUser.Enabled = false;
            this.textBoxUUser.Location = new System.Drawing.Point(99, 9);
            this.textBoxUUser.Name = "textBoxUUser";
            this.textBoxUUser.Size = new System.Drawing.Size(162, 20);
            this.textBoxUUser.TabIndex = 1;
            this.textBoxUUser.TextChanged += new System.EventHandler(this.textBoxUUser_TextChanged);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(6, 12);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(87, 13);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "Фамилия И. О.:";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitter1.Location = new System.Drawing.Point(232, 28);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 417);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // listViewUsers
            // 
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderUUser,
            this.columnHeaderUDep});
            this.listViewUsers.ContextMenuStrip = this.contextMenuStripUsers;
            this.listViewUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewUsers.FullRowSelect = true;
            this.listViewUsers.GridLines = true;
            this.listViewUsers.HideSelection = false;
            this.listViewUsers.Location = new System.Drawing.Point(3, 28);
            this.listViewUsers.MultiSelect = false;
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(229, 417);
            this.listViewUsers.TabIndex = 4;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            this.listViewUsers.SelectedIndexChanged += new System.EventHandler(this.listViewUsers_SelectedIndexChanged);
            // 
            // columnHeaderUUser
            // 
            this.columnHeaderUUser.Text = "Сотрудник";
            this.columnHeaderUUser.Width = 94;
            // 
            // columnHeaderUDep
            // 
            this.columnHeaderUDep.Text = "Подразделение";
            this.columnHeaderUDep.Width = 100;
            // 
            // contextMenuStripUsers
            // 
            this.contextMenuStripUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNewUser,
            this.ToolStripMenuItemDelUser});
            this.contextMenuStripUsers.Name = "contextMenuStripUsers";
            this.contextMenuStripUsers.Size = new System.Drawing.Size(173, 48);
            // 
            // ToolStripMenuItemNewUser
            // 
            this.ToolStripMenuItemNewUser.Image = global::My_Inventory.Properties.Resources.New;
            this.ToolStripMenuItemNewUser.Name = "ToolStripMenuItemNewUser";
            this.ToolStripMenuItemNewUser.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuItemNewUser.Text = "Новый сотрудник";
            this.ToolStripMenuItemNewUser.Click += new System.EventHandler(this.ToolStripMenuItemNewUser_Click);
            // 
            // ToolStripMenuItemDelUser
            // 
            this.ToolStripMenuItemDelUser.Enabled = false;
            this.ToolStripMenuItemDelUser.Image = global::My_Inventory.Properties.Resources.delete;
            this.ToolStripMenuItemDelUser.Name = "ToolStripMenuItemDelUser";
            this.ToolStripMenuItemDelUser.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuItemDelUser.Text = "Удалить";
            this.ToolStripMenuItemDelUser.Click += new System.EventHandler(this.ToolStripMenuItemDelUser_Click);
            // 
            // toolStripUsers
            // 
            this.toolStripUsers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripUsers.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNewUser,
            this.toolStripButtonDelUser});
            this.toolStripUsers.Location = new System.Drawing.Point(3, 3);
            this.toolStripUsers.Name = "toolStripUsers";
            this.toolStripUsers.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripUsers.Size = new System.Drawing.Size(827, 25);
            this.toolStripUsers.TabIndex = 0;
            this.toolStripUsers.Text = "toolStrip2";
            // 
            // toolStripButtonNewUser
            // 
            this.toolStripButtonNewUser.Image = global::My_Inventory.Properties.Resources.New;
            this.toolStripButtonNewUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewUser.Name = "toolStripButtonNewUser";
            this.toolStripButtonNewUser.Size = new System.Drawing.Size(125, 22);
            this.toolStripButtonNewUser.Text = "Новый сотрудник";
            this.toolStripButtonNewUser.ToolTipText = "Создать нового сотрудника";
            this.toolStripButtonNewUser.Click += new System.EventHandler(this.toolStripButtonNewUser_Click);
            // 
            // toolStripButtonDelUser
            // 
            this.toolStripButtonDelUser.Enabled = false;
            this.toolStripButtonDelUser.Image = global::My_Inventory.Properties.Resources.delete;
            this.toolStripButtonDelUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelUser.Name = "toolStripButtonDelUser";
            this.toolStripButtonDelUser.Size = new System.Drawing.Size(71, 22);
            this.toolStripButtonDelUser.Text = "Удалить";
            this.toolStripButtonDelUser.ToolTipText = "Удалить выбранного пользователя";
            this.toolStripButtonDelUser.Click += new System.EventHandler(this.toolStripButtonDelUser_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Location = new System.Drawing.Point(0, 498);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(841, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // comboBoxDepartament
            // 
            this.comboBoxDepartament.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDepartament.Enabled = false;
            this.comboBoxDepartament.FormattingEnabled = true;
            this.comboBoxDepartament.Location = new System.Drawing.Point(363, 9);
            this.comboBoxDepartament.Name = "comboBoxDepartament";
            this.comboBoxDepartament.Size = new System.Drawing.Size(162, 21);
            this.comboBoxDepartament.TabIndex = 13;
            this.comboBoxDepartament.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartament_SelectedIndexChanged);
            this.comboBoxDepartament.TextChanged += new System.EventHandler(this.comboBoxDepartament_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 520);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "My Inventory";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageInventory.ResumeLayout(false);
            this.tabPageInventory.PerformLayout();
            this.contextMenuStripItems.ResumeLayout(false);
            this.panelItem.ResumeLayout(false);
            this.panelItem.PerformLayout();
            this.toolStripNewItem.ResumeLayout(false);
            this.toolStripNewItem.PerformLayout();
            this.tabPageUsers.ResumeLayout(false);
            this.tabPageUsers.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.contextMenuStripUsers.ResumeLayout(false);
            this.toolStripUsers.ResumeLayout(false);
            this.toolStripUsers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageInventory;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListView listViewInventory;
        private System.Windows.Forms.ToolStrip toolStripNewItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewItem;
        private System.Windows.Forms.ColumnHeader columnHeaderNum;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderDep;
        private System.Windows.Forms.ColumnHeader columnHeaderUser;
        private System.Windows.Forms.ColumnHeader columnHeaderDiscription;
        private System.Windows.Forms.ListView listViewUserItems;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStrip toolStripUsers;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewUser;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panelItem;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderINum;
        private System.Windows.Forms.ColumnHeader columnHeaderIName;
        private System.Windows.Forms.ColumnHeader columnHeaderIDiscription;
        private System.Windows.Forms.ColumnHeader columnHeaderIDate;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label labelDep;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelDiscription;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxDiscription;
        private System.Windows.Forms.TextBox textBoxUUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeaderUUser;
        private System.Windows.Forms.ColumnHeader columnHeaderUDep;
        private System.Windows.Forms.Button buttonUSave;
        private System.Windows.Forms.Label labelDepartament;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripItems;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNewItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDel;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelUser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripUsers;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNewUser;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDelUser;
        private System.Windows.Forms.ComboBox comboBoxDepartament;
    }
}

