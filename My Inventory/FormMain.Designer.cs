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
            this.печатьКарточкиУчётаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инвентарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйПредметToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйСотрудникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеПредприятияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очисткаЖурналаПеремещенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сайтРазработчикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageInventory = new System.Windows.Forms.TabPage();
            this.listViewInventory = new System.Windows.Forms.ListView();
            this.columnHeaderNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDiscription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripItems = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemNewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panelItem = new System.Windows.Forms.Panel();
            this.buttonSaveToday = new System.Windows.Forms.Button();
            this.comboBoxPlace = new System.Windows.Forms.ComboBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.textBoxSerial = new System.Windows.Forms.TextBox();
            this.labelSerial = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.labelModel = new System.Windows.Forms.Label();
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
            this.toolStripButtonCrib = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonResetFilter = new System.Windows.Forms.ToolStripButton();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.listViewUserItems = new System.Windows.Forms.ListView();
            this.columnHeaderINum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIDiscription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelUser = new System.Windows.Forms.Panel();
            this.comboBoxPost = new System.Windows.Forms.ComboBox();
            this.labelPost = new System.Windows.Forms.Label();
            this.comboBoxOrg = new System.Windows.Forms.ComboBox();
            this.labelOrg = new System.Windows.Forms.Label();
            this.comboBoxDepartament = new System.Windows.Forms.ComboBox();
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
            this.ToolStripMenuItemPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.перейтиВИнвентарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDelUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripUsers = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNewUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonToInventory = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelUser = new System.Windows.Forms.ToolStripButton();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.listViewLog = new System.Windows.Forms.ListView();
            this.columnHeaderLDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLMove = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.страницаПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tabPageLog.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.инвентарьToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.сервисToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(932, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.печатьКарточкиУчётаToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // печатьКарточкиУчётаToolStripMenuItem
            // 
            this.печатьКарточкиУчётаToolStripMenuItem.Enabled = false;
            this.печатьКарточкиУчётаToolStripMenuItem.Image = global::My_Inventory.Properties.Resources.Printer;
            this.печатьКарточкиУчётаToolStripMenuItem.Name = "печатьКарточкиУчётаToolStripMenuItem";
            this.печатьКарточкиУчётаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.печатьКарточкиУчётаToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.печатьКарточкиУчётаToolStripMenuItem.Text = "Печать карточки учёта";
            this.печатьКарточкиУчётаToolStripMenuItem.Click += new System.EventHandler(this.печатьКарточкиУчётаToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(238, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // инвентарьToolStripMenuItem
            // 
            this.инвентарьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйПредметToolStripMenuItem,
            this.списатьToolStripMenuItem1,
            this.удалитьToolStripMenuItem});
            this.инвентарьToolStripMenuItem.Name = "инвентарьToolStripMenuItem";
            this.инвентарьToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.инвентарьToolStripMenuItem.Text = "Инвентарь";
            // 
            // новыйПредметToolStripMenuItem
            // 
            this.новыйПредметToolStripMenuItem.Image = global::My_Inventory.Properties.Resources.New;
            this.новыйПредметToolStripMenuItem.Name = "новыйПредметToolStripMenuItem";
            this.новыйПредметToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.новыйПредметToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.новыйПредметToolStripMenuItem.Text = "Новый предмет";
            this.новыйПредметToolStripMenuItem.Click += new System.EventHandler(this.новыйПредметToolStripMenuItem_Click);
            // 
            // списатьToolStripMenuItem1
            // 
            this.списатьToolStripMenuItem1.Enabled = false;
            this.списатьToolStripMenuItem1.Image = global::My_Inventory.Properties.Resources.delete;
            this.списатьToolStripMenuItem1.Name = "списатьToolStripMenuItem1";
            this.списатьToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.списатьToolStripMenuItem1.Text = "Списать";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Enabled = false;
            this.удалитьToolStripMenuItem.Image = global::My_Inventory.Properties.Resources.delete;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйСотрудникToolStripMenuItem,
            this.удалитьToolStripMenuItem1});
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // новыйСотрудникToolStripMenuItem
            // 
            this.новыйСотрудникToolStripMenuItem.Image = global::My_Inventory.Properties.Resources.New;
            this.новыйСотрудникToolStripMenuItem.Name = "новыйСотрудникToolStripMenuItem";
            this.новыйСотрудникToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.новыйСотрудникToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.новыйСотрудникToolStripMenuItem.Text = "Новый сотрудник";
            this.новыйСотрудникToolStripMenuItem.Click += new System.EventHandler(this.новыйСотрудникToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Enabled = false;
            this.удалитьToolStripMenuItem1.Image = global::My_Inventory.Properties.Resources.delete;
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(247, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.данныеПредприятияToolStripMenuItem,
            this.очисткаЖурналаПеремещенийToolStripMenuItem});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // данныеПредприятияToolStripMenuItem
            // 
            this.данныеПредприятияToolStripMenuItem.Name = "данныеПредприятияToolStripMenuItem";
            this.данныеПредприятияToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.данныеПредприятияToolStripMenuItem.Text = "Данные предприятия";
            this.данныеПредприятияToolStripMenuItem.Click += new System.EventHandler(this.данныеПредприятияToolStripMenuItem_Click);
            // 
            // очисткаЖурналаПеремещенийToolStripMenuItem
            // 
            this.очисткаЖурналаПеремещенийToolStripMenuItem.Name = "очисткаЖурналаПеремещенийToolStripMenuItem";
            this.очисткаЖурналаПеремещенийToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.очисткаЖурналаПеремещенийToolStripMenuItem.Text = "Очистка журнала перемещений";
            this.очисткаЖурналаПеремещенийToolStripMenuItem.Click += new System.EventHandler(this.очисткаЖурналаПеремещенийToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сайтРазработчикаToolStripMenuItem,
            this.страницаПрограммыToolStripMenuItem,
            this.toolStripMenuItem2,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // сайтРазработчикаToolStripMenuItem
            // 
            this.сайтРазработчикаToolStripMenuItem.Name = "сайтРазработчикаToolStripMenuItem";
            this.сайтРазработчикаToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.сайтРазработчикаToolStripMenuItem.Text = "Сайт разработчика";
            this.сайтРазработчикаToolStripMenuItem.Click += new System.EventHandler(this.сайтРазработчикаToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(193, 6);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageInventory);
            this.tabControlMain.Controls.Add(this.tabPageUsers);
            this.tabControlMain.Controls.Add(this.tabPageLog);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 24);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(932, 482);
            this.tabControlMain.TabIndex = 1;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
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
            this.tabPageInventory.Size = new System.Drawing.Size(924, 456);
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
            this.columnHeaderDate,
            this.columnHeaderPlace,
            this.columnHeaderDiscription});
            this.listViewInventory.ContextMenuStrip = this.contextMenuStripItems;
            this.listViewInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewInventory.FullRowSelect = true;
            this.listViewInventory.GridLines = true;
            this.listViewInventory.HideSelection = false;
            this.listViewInventory.Location = new System.Drawing.Point(3, 28);
            this.listViewInventory.Name = "listViewInventory";
            this.listViewInventory.Size = new System.Drawing.Size(738, 425);
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
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Дата выдачи";
            this.columnHeaderDate.Width = 82;
            // 
            // columnHeaderPlace
            // 
            this.columnHeaderPlace.Text = "Местоположение";
            this.columnHeaderPlace.Width = 130;
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
            this.списатьToolStripMenuItem,
            this.toolStripMenuItemDel});
            this.contextMenuStripItems.Name = "contextMenuStripItems";
            this.contextMenuStripItems.Size = new System.Drawing.Size(211, 70);
            // 
            // toolStripMenuItemNewItem
            // 
            this.toolStripMenuItemNewItem.Image = global::My_Inventory.Properties.Resources.New;
            this.toolStripMenuItemNewItem.Name = "toolStripMenuItemNewItem";
            this.toolStripMenuItemNewItem.ShortcutKeyDisplayString = "Ctrl + N";
            this.toolStripMenuItemNewItem.Size = new System.Drawing.Size(210, 22);
            this.toolStripMenuItemNewItem.Text = "Новый предмет";
            this.toolStripMenuItemNewItem.Click += new System.EventHandler(this.toolStripMenuItemNewItem_Click);
            // 
            // списатьToolStripMenuItem
            // 
            this.списатьToolStripMenuItem.Enabled = false;
            this.списатьToolStripMenuItem.Image = global::My_Inventory.Properties.Resources.delete;
            this.списатьToolStripMenuItem.Name = "списатьToolStripMenuItem";
            this.списатьToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.списатьToolStripMenuItem.Text = "Списать";
            this.списатьToolStripMenuItem.Click += new System.EventHandler(this.списатьToolStripMenuItem_Click);
            // 
            // toolStripMenuItemDel
            // 
            this.toolStripMenuItemDel.Enabled = false;
            this.toolStripMenuItemDel.Image = global::My_Inventory.Properties.Resources.delete;
            this.toolStripMenuItemDel.Name = "toolStripMenuItemDel";
            this.toolStripMenuItemDel.ShortcutKeyDisplayString = "Shift + Del";
            this.toolStripMenuItemDel.Size = new System.Drawing.Size(210, 22);
            this.toolStripMenuItemDel.Text = "Удалить";
            this.toolStripMenuItemDel.Click += new System.EventHandler(this.toolStripMenuItemDel_Click);
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(741, 28);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(5, 425);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // panelItem
            // 
            this.panelItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelItem.Controls.Add(this.buttonSaveToday);
            this.panelItem.Controls.Add(this.comboBoxPlace);
            this.panelItem.Controls.Add(this.labelPlace);
            this.panelItem.Controls.Add(this.textBoxSerial);
            this.panelItem.Controls.Add(this.labelSerial);
            this.panelItem.Controls.Add(this.textBoxModel);
            this.panelItem.Controls.Add(this.labelModel);
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
            this.panelItem.Location = new System.Drawing.Point(746, 28);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(175, 425);
            this.panelItem.TabIndex = 3;
            // 
            // buttonSaveToday
            // 
            this.buttonSaveToday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveToday.Enabled = false;
            this.buttonSaveToday.Location = new System.Drawing.Point(6, 374);
            this.buttonSaveToday.Name = "buttonSaveToday";
            this.buttonSaveToday.Size = new System.Drawing.Size(164, 48);
            this.buttonSaveToday.TabIndex = 15;
            this.buttonSaveToday.Text = "Переместить";
            this.buttonSaveToday.UseVisualStyleBackColor = true;
            this.buttonSaveToday.Click += new System.EventHandler(this.buttonSaveToday_Click);
            // 
            // comboBoxPlace
            // 
            this.comboBoxPlace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPlace.Enabled = false;
            this.comboBoxPlace.FormattingEnabled = true;
            this.comboBoxPlace.Location = new System.Drawing.Point(6, 213);
            this.comboBoxPlace.Name = "comboBoxPlace";
            this.comboBoxPlace.Size = new System.Drawing.Size(164, 21);
            this.comboBoxPlace.TabIndex = 6;
            this.comboBoxPlace.TextChanged += new System.EventHandler(this.comboBoxPlace_TextChanged);
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(6, 197);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(95, 13);
            this.labelPlace.TabIndex = 14;
            this.labelPlace.Text = "Местоположение";
            // 
            // textBoxSerial
            // 
            this.textBoxSerial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSerial.Enabled = false;
            this.textBoxSerial.Location = new System.Drawing.Point(6, 134);
            this.textBoxSerial.Name = "textBoxSerial";
            this.textBoxSerial.Size = new System.Drawing.Size(164, 20);
            this.textBoxSerial.TabIndex = 4;
            this.textBoxSerial.TextChanged += new System.EventHandler(this.textBoxSerial_TextChanged);
            // 
            // labelSerial
            // 
            this.labelSerial.AutoSize = true;
            this.labelSerial.Location = new System.Drawing.Point(6, 118);
            this.labelSerial.Name = "labelSerial";
            this.labelSerial.Size = new System.Drawing.Size(93, 13);
            this.labelSerial.TabIndex = 13;
            this.labelSerial.Text = "Серийный номер";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModel.Enabled = false;
            this.textBoxModel.Location = new System.Drawing.Point(6, 95);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(164, 20);
            this.textBoxModel.TabIndex = 3;
            this.textBoxModel.TextChanged += new System.EventHandler(this.textBoxModel_TextChanged);
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(6, 79);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(46, 13);
            this.labelModel.TabIndex = 11;
            this.labelModel.Text = "Модель";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(6, 345);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(164, 23);
            this.buttonSave.TabIndex = 9;
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
            this.textBoxDiscription.Location = new System.Drawing.Point(6, 292);
            this.textBoxDiscription.Name = "textBoxDiscription";
            this.textBoxDiscription.Size = new System.Drawing.Size(164, 20);
            this.textBoxDiscription.TabIndex = 8;
            this.textBoxDiscription.TextChanged += new System.EventHandler(this.textBoxDiscription_TextChanged);
            // 
            // labelDiscription
            // 
            this.labelDiscription.AutoSize = true;
            this.labelDiscription.Location = new System.Drawing.Point(3, 276);
            this.labelDiscription.Name = "labelDiscription";
            this.labelDiscription.Size = new System.Drawing.Size(70, 13);
            this.labelDiscription.TabIndex = 8;
            this.labelDiscription.Text = "Примечание";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(3, 237);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(73, 13);
            this.labelDate.TabIndex = 7;
            this.labelDate.Text = "Дата выдачи";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDate.Enabled = false;
            this.dateTimePickerDate.Location = new System.Drawing.Point(6, 253);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(164, 20);
            this.dateTimePickerDate.TabIndex = 7;
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePickerDate_ValueChanged);
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxUsers.Enabled = false;
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(6, 173);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(164, 21);
            this.comboBoxUsers.TabIndex = 5;
            this.comboBoxUsers.TextChanged += new System.EventHandler(this.comboBoxUsers_TextChanged);
            // 
            // labelDep
            // 
            this.labelDep.AutoSize = true;
            this.labelDep.Location = new System.Drawing.Point(6, 157);
            this.labelDep.Name = "labelDep";
            this.labelDep.Size = new System.Drawing.Size(60, 13);
            this.labelDep.TabIndex = 4;
            this.labelDep.Text = "Сотрудник";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(6, 56);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(164, 20);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 40);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Наименование";
            // 
            // textBoxNum
            // 
            this.textBoxNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNum.Enabled = false;
            this.textBoxNum.Location = new System.Drawing.Point(6, 17);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(164, 20);
            this.textBoxNum.TabIndex = 1;
            this.textBoxNum.TextChanged += new System.EventHandler(this.textBoxNum_TextChanged);
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(6, 0);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(111, 13);
            this.labelNum.TabIndex = 0;
            this.labelNum.Text = "Инвентарный номер";
            // 
            // toolStripNewItem
            // 
            this.toolStripNewItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripNewItem.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripNewItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNewItem,
            this.toolStripButtonCrib,
            this.toolStripButtonDelItem,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripTextBoxFilter,
            this.toolStripButtonResetFilter});
            this.toolStripNewItem.Location = new System.Drawing.Point(3, 3);
            this.toolStripNewItem.Name = "toolStripNewItem";
            this.toolStripNewItem.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripNewItem.Size = new System.Drawing.Size(918, 25);
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
            // toolStripButtonCrib
            // 
            this.toolStripButtonCrib.Enabled = false;
            this.toolStripButtonCrib.Image = global::My_Inventory.Properties.Resources.delete;
            this.toolStripButtonCrib.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCrib.Name = "toolStripButtonCrib";
            this.toolStripButtonCrib.Size = new System.Drawing.Size(72, 22);
            this.toolStripButtonCrib.Text = "Списать";
            this.toolStripButtonCrib.ToolTipText = "Списать";
            this.toolStripButtonCrib.Click += new System.EventHandler(this.toolStripButtonCrib_Click);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel1.Text = "Поиск:";
            // 
            // toolStripTextBoxFilter
            // 
            this.toolStripTextBoxFilter.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripTextBoxFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxFilter.Name = "toolStripTextBoxFilter";
            this.toolStripTextBoxFilter.Size = new System.Drawing.Size(200, 25);
            this.toolStripTextBoxFilter.TextChanged += new System.EventHandler(this.toolStripTextBoxFilter_TextChanged);
            // 
            // toolStripButtonResetFilter
            // 
            this.toolStripButtonResetFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonResetFilter.Enabled = false;
            this.toolStripButtonResetFilter.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonResetFilter.Image")));
            this.toolStripButtonResetFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonResetFilter.Name = "toolStripButtonResetFilter";
            this.toolStripButtonResetFilter.Size = new System.Drawing.Size(46, 22);
            this.toolStripButtonResetFilter.Text = "Сброс";
            this.toolStripButtonResetFilter.Click += new System.EventHandler(this.toolStripButtonResetFilter_Click);
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.Controls.Add(this.listViewUserItems);
            this.tabPageUsers.Controls.Add(this.panelUser);
            this.tabPageUsers.Controls.Add(this.splitter1);
            this.tabPageUsers.Controls.Add(this.listViewUsers);
            this.tabPageUsers.Controls.Add(this.toolStripUsers);
            this.tabPageUsers.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsers.Size = new System.Drawing.Size(924, 456);
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
            this.columnHeaderIPlace,
            this.columnHeaderIDiscription});
            this.listViewUserItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewUserItems.Enabled = false;
            this.listViewUserItems.FullRowSelect = true;
            this.listViewUserItems.GridLines = true;
            this.listViewUserItems.Location = new System.Drawing.Point(241, 116);
            this.listViewUserItems.Name = "listViewUserItems";
            this.listViewUserItems.Size = new System.Drawing.Size(680, 337);
            this.listViewUserItems.TabIndex = 6;
            this.listViewUserItems.UseCompatibleStateImageBehavior = false;
            this.listViewUserItems.View = System.Windows.Forms.View.Details;
            this.listViewUserItems.SelectedIndexChanged += new System.EventHandler(this.listViewUserItems_SelectedIndexChanged);
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
            // columnHeaderIPlace
            // 
            this.columnHeaderIPlace.Text = "Местоположение";
            // 
            // columnHeaderIDiscription
            // 
            this.columnHeaderIDiscription.Text = "Примечание";
            this.columnHeaderIDiscription.Width = 134;
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.comboBoxPost);
            this.panelUser.Controls.Add(this.labelPost);
            this.panelUser.Controls.Add(this.comboBoxOrg);
            this.panelUser.Controls.Add(this.labelOrg);
            this.panelUser.Controls.Add(this.comboBoxDepartament);
            this.panelUser.Controls.Add(this.labelDepartament);
            this.panelUser.Controls.Add(this.buttonUSave);
            this.panelUser.Controls.Add(this.label1);
            this.panelUser.Controls.Add(this.textBoxUUser);
            this.panelUser.Controls.Add(this.labelUser);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUser.Location = new System.Drawing.Point(241, 28);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(680, 88);
            this.panelUser.TabIndex = 5;
            // 
            // comboBoxPost
            // 
            this.comboBoxPost.Enabled = false;
            this.comboBoxPost.FormattingEnabled = true;
            this.comboBoxPost.Location = new System.Drawing.Point(111, 29);
            this.comboBoxPost.Name = "comboBoxPost";
            this.comboBoxPost.Size = new System.Drawing.Size(176, 21);
            this.comboBoxPost.TabIndex = 2;
            this.comboBoxPost.SelectedIndexChanged += new System.EventHandler(this.comboBoxPost_SelectedIndexChanged);
            this.comboBoxPost.TextChanged += new System.EventHandler(this.comboBoxPost_TextChanged);
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Location = new System.Drawing.Point(37, 32);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(65, 13);
            this.labelPost.TabIndex = 16;
            this.labelPost.Text = "Должность";
            // 
            // comboBoxOrg
            // 
            this.comboBoxOrg.Enabled = false;
            this.comboBoxOrg.FormattingEnabled = true;
            this.comboBoxOrg.Location = new System.Drawing.Point(400, 2);
            this.comboBoxOrg.Name = "comboBoxOrg";
            this.comboBoxOrg.Size = new System.Drawing.Size(176, 21);
            this.comboBoxOrg.TabIndex = 3;
            this.comboBoxOrg.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrg_SelectedIndexChanged);
            this.comboBoxOrg.TextChanged += new System.EventHandler(this.comboBoxOrg_TextChanged);
            // 
            // labelOrg
            // 
            this.labelOrg.AutoSize = true;
            this.labelOrg.Location = new System.Drawing.Point(317, 6);
            this.labelOrg.Name = "labelOrg";
            this.labelOrg.Size = new System.Drawing.Size(74, 13);
            this.labelOrg.TabIndex = 14;
            this.labelOrg.Text = "Организация";
            // 
            // comboBoxDepartament
            // 
            this.comboBoxDepartament.Enabled = false;
            this.comboBoxDepartament.FormattingEnabled = true;
            this.comboBoxDepartament.Location = new System.Drawing.Point(400, 29);
            this.comboBoxDepartament.Name = "comboBoxDepartament";
            this.comboBoxDepartament.Size = new System.Drawing.Size(176, 21);
            this.comboBoxDepartament.TabIndex = 4;
            this.comboBoxDepartament.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartament_SelectedIndexChanged);
            this.comboBoxDepartament.TextChanged += new System.EventHandler(this.comboBoxDepartament_TextChanged);
            // 
            // labelDepartament
            // 
            this.labelDepartament.AutoSize = true;
            this.labelDepartament.Location = new System.Drawing.Point(307, 32);
            this.labelDepartament.Name = "labelDepartament";
            this.labelDepartament.Size = new System.Drawing.Size(87, 13);
            this.labelDepartament.TabIndex = 12;
            this.labelDepartament.Text = "Подразделение";
            // 
            // buttonUSave
            // 
            this.buttonUSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUSave.Enabled = false;
            this.buttonUSave.Location = new System.Drawing.Point(588, 59);
            this.buttonUSave.Name = "buttonUSave";
            this.buttonUSave.Size = new System.Drawing.Size(87, 23);
            this.buttonUSave.TabIndex = 5;
            this.buttonUSave.Text = "Сохранить";
            this.buttonUSave.UseVisualStyleBackColor = true;
            this.buttonUSave.Click += new System.EventHandler(this.buttonUSave_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Закреплённый инвентарь";
            // 
            // textBoxUUser
            // 
            this.textBoxUUser.Enabled = false;
            this.textBoxUUser.Location = new System.Drawing.Point(111, 3);
            this.textBoxUUser.Name = "textBoxUUser";
            this.textBoxUUser.Size = new System.Drawing.Size(176, 20);
            this.textBoxUUser.TabIndex = 1;
            this.textBoxUUser.TextChanged += new System.EventHandler(this.textBoxUUser_TextChanged);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(18, 6);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(84, 13);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "Фамилия И. О.";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitter1.Location = new System.Drawing.Point(236, 28);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 425);
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
            this.listViewUsers.Size = new System.Drawing.Size(233, 425);
            this.listViewUsers.TabIndex = 0;
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
            this.ToolStripMenuItemPrint,
            this.перейтиВИнвентарьToolStripMenuItem,
            this.ToolStripMenuItemDelUser});
            this.contextMenuStripUsers.Name = "contextMenuStripUsers";
            this.contextMenuStripUsers.Size = new System.Drawing.Size(260, 92);
            // 
            // ToolStripMenuItemNewUser
            // 
            this.ToolStripMenuItemNewUser.Image = global::My_Inventory.Properties.Resources.New;
            this.ToolStripMenuItemNewUser.Name = "ToolStripMenuItemNewUser";
            this.ToolStripMenuItemNewUser.ShortcutKeyDisplayString = "Ctrl + Shift + N";
            this.ToolStripMenuItemNewUser.Size = new System.Drawing.Size(259, 22);
            this.ToolStripMenuItemNewUser.Text = "Новый сотрудник";
            this.ToolStripMenuItemNewUser.Click += new System.EventHandler(this.ToolStripMenuItemNewUser_Click);
            // 
            // ToolStripMenuItemPrint
            // 
            this.ToolStripMenuItemPrint.Enabled = false;
            this.ToolStripMenuItemPrint.Image = global::My_Inventory.Properties.Resources.Printer;
            this.ToolStripMenuItemPrint.Name = "ToolStripMenuItemPrint";
            this.ToolStripMenuItemPrint.ShortcutKeyDisplayString = "Ctrl + P";
            this.ToolStripMenuItemPrint.Size = new System.Drawing.Size(259, 22);
            this.ToolStripMenuItemPrint.Text = "Карточка учёта";
            this.ToolStripMenuItemPrint.Click += new System.EventHandler(this.ToolStripMenuItemPrint_Click);
            // 
            // перейтиВИнвентарьToolStripMenuItem
            // 
            this.перейтиВИнвентарьToolStripMenuItem.Enabled = false;
            this.перейтиВИнвентарьToolStripMenuItem.Name = "перейтиВИнвентарьToolStripMenuItem";
            this.перейтиВИнвентарьToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.перейтиВИнвентарьToolStripMenuItem.Text = "Перейти в инвентарь";
            this.перейтиВИнвентарьToolStripMenuItem.ToolTipText = "Показать все предметы сотрудника в общем списке инвентаря";
            this.перейтиВИнвентарьToolStripMenuItem.Click += new System.EventHandler(this.перейтиВИнвентарьToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemDelUser
            // 
            this.ToolStripMenuItemDelUser.Enabled = false;
            this.ToolStripMenuItemDelUser.Image = global::My_Inventory.Properties.Resources.delete;
            this.ToolStripMenuItemDelUser.Name = "ToolStripMenuItemDelUser";
            this.ToolStripMenuItemDelUser.ShortcutKeyDisplayString = "Shift + Del";
            this.ToolStripMenuItemDelUser.Size = new System.Drawing.Size(259, 22);
            this.ToolStripMenuItemDelUser.Text = "Удалить";
            this.ToolStripMenuItemDelUser.Click += new System.EventHandler(this.ToolStripMenuItemDelUser_Click);
            // 
            // toolStripUsers
            // 
            this.toolStripUsers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripUsers.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNewUser,
            this.toolStripButtonPrint,
            this.toolStripButtonToInventory,
            this.toolStripButtonDelUser});
            this.toolStripUsers.Location = new System.Drawing.Point(3, 3);
            this.toolStripUsers.Name = "toolStripUsers";
            this.toolStripUsers.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripUsers.Size = new System.Drawing.Size(918, 25);
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
            // toolStripButtonPrint
            // 
            this.toolStripButtonPrint.Enabled = false;
            this.toolStripButtonPrint.Image = global::My_Inventory.Properties.Resources.Printer;
            this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Size = new System.Drawing.Size(111, 22);
            this.toolStripButtonPrint.Text = "Карточка учёта";
            this.toolStripButtonPrint.Click += new System.EventHandler(this.toolStripButtonPrint_Click);
            // 
            // toolStripButtonToInventory
            // 
            this.toolStripButtonToInventory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonToInventory.Enabled = false;
            this.toolStripButtonToInventory.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonToInventory.Image")));
            this.toolStripButtonToInventory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonToInventory.Name = "toolStripButtonToInventory";
            this.toolStripButtonToInventory.Size = new System.Drawing.Size(127, 22);
            this.toolStripButtonToInventory.Text = "Перейти в инвентарь";
            this.toolStripButtonToInventory.ToolTipText = "Показать все предметы сотрудника в общем списке инвентаря";
            this.toolStripButtonToInventory.Click += new System.EventHandler(this.toolStripButtonToInventory_Click);
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
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.listViewLog);
            this.tabPageLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLog.Size = new System.Drawing.Size(924, 456);
            this.tabPageLog.TabIndex = 3;
            this.tabPageLog.Text = "Журнал перемещений";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // listViewLog
            // 
            this.listViewLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderLDate,
            this.columnHeaderLNum,
            this.columnHeaderLName,
            this.columnHeaderLMove});
            this.listViewLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLog.FullRowSelect = true;
            this.listViewLog.GridLines = true;
            this.listViewLog.Location = new System.Drawing.Point(3, 3);
            this.listViewLog.Name = "listViewLog";
            this.listViewLog.Size = new System.Drawing.Size(918, 450);
            this.listViewLog.TabIndex = 0;
            this.listViewLog.UseCompatibleStateImageBehavior = false;
            this.listViewLog.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderLDate
            // 
            this.columnHeaderLDate.Text = "Дата";
            this.columnHeaderLDate.Width = 111;
            // 
            // columnHeaderLNum
            // 
            this.columnHeaderLNum.Text = "Ннв. №";
            this.columnHeaderLNum.Width = 66;
            // 
            // columnHeaderLName
            // 
            this.columnHeaderLName.Text = "Наименование";
            // 
            // columnHeaderLMove
            // 
            this.columnHeaderLMove.Text = "Перемещение";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 506);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(932, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(122, 17);
            this.toolStripStatusLabel1.Text = "Выбрано элементов:";
            // 
            // страницаПрограммыToolStripMenuItem
            // 
            this.страницаПрограммыToolStripMenuItem.Name = "страницаПрограммыToolStripMenuItem";
            this.страницаПрограммыToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.страницаПрограммыToolStripMenuItem.Text = "Страница программы";
            this.страницаПрограммыToolStripMenuItem.Click += new System.EventHandler(this.страницаПрограммыToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 528);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "FormMain";
            this.Text = "My Inventory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
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
            this.tabPageLog.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ColumnHeader columnHeaderPlace;
        private System.Windows.Forms.ColumnHeader columnHeaderUser;
        private System.Windows.Forms.ColumnHeader columnHeaderDiscription;
        private System.Windows.Forms.ListView listViewUserItems;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStrip toolStripUsers;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewUser;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panelItem;
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
        private System.Windows.Forms.TextBox textBoxSerial;
        private System.Windows.Forms.Label labelSerial;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.ComboBox comboBoxOrg;
        private System.Windows.Forms.Label labelOrg;
        private System.Windows.Forms.ComboBox comboBoxPost;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.ToolStripMenuItem инвентарьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйПредметToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxPlace;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.ToolStripMenuItem печатьКарточкиУчётаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPrint;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButtonToInventory;
        private System.Windows.Forms.ToolStripMenuItem перейтиВИнвентарьToolStripMenuItem;
        private System.Windows.Forms.Button buttonSaveToday;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.ListView listViewLog;
        private System.Windows.Forms.ColumnHeader columnHeaderLDate;
        private System.Windows.Forms.ColumnHeader columnHeaderLNum;
        private System.Windows.Forms.ColumnHeader columnHeaderLName;
        private System.Windows.Forms.ColumnHeader columnHeaderLMove;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очисткаЖурналаПеремещенийToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeaderIPlace;
        private System.Windows.Forms.ToolStripButton toolStripButtonCrib;
        private System.Windows.Forms.ToolStripMenuItem списатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem данныеПредприятияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйСотрудникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem списатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFilter;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonResetFilter;
        private System.Windows.Forms.ToolStripMenuItem сайтРазработчикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem страницаПрограммыToolStripMenuItem;
    }
}

