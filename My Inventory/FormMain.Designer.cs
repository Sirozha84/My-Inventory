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
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrintCard = new System.Windows.Forms.ToolStripMenuItem();
            this.sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMisc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOrgData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWebSite = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProgramPage = new System.Windows.Forms.ToolStripMenuItem();
            this.sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageInventory = new System.Windows.Forms.TabPage();
            this.listViewInventory = new System.Windows.Forms.ListView();
            this.columnNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripItems = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemNewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripNewItem = new System.Windows.Forms.ToolStrip();
            this.toolТNewItem = new System.Windows.Forms.ToolStripButton();
            this.toolDelItem = new System.Windows.Forms.ToolStripButton();
            this.sep3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolFind = new System.Windows.Forms.ToolStripLabel();
            this.toolFindItem = new System.Windows.Forms.ToolStripTextBox();
            this.toolResetItem = new System.Windows.Forms.ToolStripButton();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.listViewUserItems = new System.Windows.Forms.ListView();
            this.columnINum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIDiscription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelUser = new System.Windows.Forms.Panel();
            this.labelPost = new System.Windows.Forms.Label();
            this.labelOrg = new System.Windows.Forms.Label();
            this.labelDep = new System.Windows.Forms.Label();
            this.labelInv = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.splitter = new System.Windows.Forms.Splitter();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.columnUUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUDep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.перейтиВИнвентарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDelUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripUsers = new System.Windows.Forms.ToolStrip();
            this.toolNewUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonToInventory = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelUser = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusSelected = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxOrg = new System.Windows.Forms.TextBox();
            this.textBoxDep = new System.Windows.Forms.TextBox();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.menuStripMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageInventory.SuspendLayout();
            this.contextMenuStripItems.SuspendLayout();
            this.toolStripNewItem.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.contextMenuStripUsers.SuspendLayout();
            this.toolStripUsers.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuMisc,
            this.menuHelp});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(784, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrintCard,
            this.sep1,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(48, 20);
            this.menuFile.Text = "Файл";
            // 
            // menuPrintCard
            // 
            this.menuPrintCard.Enabled = false;
            this.menuPrintCard.Image = global::My_Inventory.Properties.Resources.Printer;
            this.menuPrintCard.Name = "menuPrintCard";
            this.menuPrintCard.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuPrintCard.Size = new System.Drawing.Size(241, 22);
            this.menuPrintCard.Text = "Печать карточки учёта";
            this.menuPrintCard.Click += new System.EventHandler(this.PrintCard);
            // 
            // sep1
            // 
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(238, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuExit.Size = new System.Drawing.Size(241, 22);
            this.menuExit.Text = "Выход";
            this.menuExit.Click += new System.EventHandler(this.Quit);
            // 
            // menuMisc
            // 
            this.menuMisc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOrgData});
            this.menuMisc.Name = "menuMisc";
            this.menuMisc.Size = new System.Drawing.Size(59, 20);
            this.menuMisc.Text = "Сервис";
            // 
            // menuOrgData
            // 
            this.menuOrgData.Name = "menuOrgData";
            this.menuOrgData.Size = new System.Drawing.Size(191, 22);
            this.menuOrgData.Text = "Данные предприятия";
            this.menuOrgData.Click += new System.EventHandler(this.CompanyOptions);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuWebSite,
            this.menuProgramPage,
            this.sep2,
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(65, 20);
            this.menuHelp.Text = "Справка";
            // 
            // menuWebSite
            // 
            this.menuWebSite.Name = "menuWebSite";
            this.menuWebSite.Size = new System.Drawing.Size(196, 22);
            this.menuWebSite.Text = "Сайт разработчика";
            this.menuWebSite.Click += new System.EventHandler(this.WebSite);
            // 
            // menuProgramPage
            // 
            this.menuProgramPage.Name = "menuProgramPage";
            this.menuProgramPage.Size = new System.Drawing.Size(196, 22);
            this.menuProgramPage.Text = "Страница программы";
            this.menuProgramPage.Click += new System.EventHandler(this.ProgramPage);
            // 
            // sep2
            // 
            this.sep2.Name = "sep2";
            this.sep2.Size = new System.Drawing.Size(193, 6);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(196, 22);
            this.menuAbout.Text = "О программе";
            this.menuAbout.Click += new System.EventHandler(this.About);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageInventory);
            this.tabControlMain.Controls.Add(this.tabPageUsers);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 24);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(784, 415);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageInventory
            // 
            this.tabPageInventory.Controls.Add(this.listViewInventory);
            this.tabPageInventory.Controls.Add(this.toolStripNewItem);
            this.tabPageInventory.Location = new System.Drawing.Point(4, 22);
            this.tabPageInventory.Name = "tabPageInventory";
            this.tabPageInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInventory.Size = new System.Drawing.Size(776, 389);
            this.tabPageInventory.TabIndex = 0;
            this.tabPageInventory.Text = "Инвентарь";
            this.tabPageInventory.UseVisualStyleBackColor = true;
            // 
            // listViewInventory
            // 
            this.listViewInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNum,
            this.columnName,
            this.columnUser,
            this.columnDate,
            this.columnPlace,
            this.columnComment});
            this.listViewInventory.ContextMenuStrip = this.contextMenuStripItems;
            this.listViewInventory.FullRowSelect = true;
            this.listViewInventory.GridLines = true;
            this.listViewInventory.HideSelection = false;
            this.listViewInventory.Location = new System.Drawing.Point(3, 28);
            this.listViewInventory.Name = "listViewInventory";
            this.listViewInventory.Size = new System.Drawing.Size(770, 358);
            this.listViewInventory.TabIndex = 0;
            this.listViewInventory.UseCompatibleStateImageBehavior = false;
            this.listViewInventory.View = System.Windows.Forms.View.Details;
            this.listViewInventory.SelectedIndexChanged += new System.EventHandler(this.listViewInventory_SelectedIndexChanged);
            this.listViewInventory.DoubleClick += new System.EventHandler(this.EditItem);
            // 
            // columnNum
            // 
            this.columnNum.Text = "Номер";
            this.columnNum.Width = 68;
            // 
            // columnName
            // 
            this.columnName.Text = "Наименование";
            this.columnName.Width = 116;
            // 
            // columnUser
            // 
            this.columnUser.Text = "Сотрудник";
            this.columnUser.Width = 118;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Дата выдачи";
            this.columnDate.Width = 82;
            // 
            // columnPlace
            // 
            this.columnPlace.Text = "Местоположение";
            this.columnPlace.Width = 130;
            // 
            // columnComment
            // 
            this.columnComment.Text = "Примечание";
            this.columnComment.Width = 102;
            // 
            // contextMenuStripItems
            // 
            this.contextMenuStripItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNewItem,
            this.toolStripMenuItemDel});
            this.contextMenuStripItems.Name = "contextMenuStripItems";
            this.contextMenuStripItems.Size = new System.Drawing.Size(203, 70);
            // 
            // toolStripMenuItemNewItem
            // 
            this.toolStripMenuItemNewItem.Name = "toolStripMenuItemNewItem";
            this.toolStripMenuItemNewItem.ShortcutKeyDisplayString = "Ctrl + N";
            this.toolStripMenuItemNewItem.Size = new System.Drawing.Size(202, 22);
            this.toolStripMenuItemNewItem.Text = "Новый объект";
            this.toolStripMenuItemNewItem.Click += new System.EventHandler(this.NewItem);
            // 
            // toolStripMenuItemDel
            // 
            this.toolStripMenuItemDel.Enabled = false;
            this.toolStripMenuItemDel.Name = "toolStripMenuItemDel";
            this.toolStripMenuItemDel.ShortcutKeyDisplayString = "Shift + Del";
            this.toolStripMenuItemDel.Size = new System.Drawing.Size(210, 22);
            this.toolStripMenuItemDel.Text = "Удалить";
            this.toolStripMenuItemDel.Click += new System.EventHandler(this.DelItem);
            // 
            // toolStripNewItem
            // 
            this.toolStripNewItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripNewItem.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripNewItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolТNewItem,
            this.toolDelItem,
            this.sep3,
            this.toolFind,
            this.toolFindItem,
            this.toolResetItem});
            this.toolStripNewItem.Location = new System.Drawing.Point(3, 3);
            this.toolStripNewItem.Name = "toolStripNewItem";
            this.toolStripNewItem.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripNewItem.Size = new System.Drawing.Size(770, 25);
            this.toolStripNewItem.TabIndex = 1;
            // 
            // toolТNewItem
            // 
            this.toolТNewItem.Image = global::My_Inventory.Properties.Resources.New;
            this.toolТNewItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolТNewItem.Name = "toolТNewItem";
            this.toolТNewItem.Size = new System.Drawing.Size(65, 22);
            this.toolТNewItem.Text = "Новый";
            this.toolТNewItem.Click += new System.EventHandler(this.NewItem);
            // 
            // toolDelItem
            // 
            this.toolDelItem.Enabled = false;
            this.toolDelItem.Image = global::My_Inventory.Properties.Resources.delete;
            this.toolDelItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDelItem.Name = "toolDelItem";
            this.toolDelItem.Size = new System.Drawing.Size(71, 22);
            this.toolDelItem.Text = "Удалить";
            this.toolDelItem.ToolTipText = "Удалить выбранные предметы";
            this.toolDelItem.Click += new System.EventHandler(this.DelItem);
            // 
            // sep3
            // 
            this.sep3.Name = "sep3";
            this.sep3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolFind
            // 
            this.toolFind.Name = "toolFind";
            this.toolFind.Size = new System.Drawing.Size(45, 22);
            this.toolFind.Text = "Поиск:";
            // 
            // toolFindItem
            // 
            this.toolFindItem.BackColor = System.Drawing.SystemColors.Window;
            this.toolFindItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolFindItem.Name = "toolFindItem";
            this.toolFindItem.Size = new System.Drawing.Size(200, 25);
            this.toolFindItem.TextChanged += new System.EventHandler(this.FindTextChange);
            // 
            // toolResetItem
            // 
            this.toolResetItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolResetItem.Enabled = false;
            this.toolResetItem.Image = ((System.Drawing.Image)(resources.GetObject("toolResetItem.Image")));
            this.toolResetItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolResetItem.Name = "toolResetItem";
            this.toolResetItem.Size = new System.Drawing.Size(46, 22);
            this.toolResetItem.Text = "Сброс";
            this.toolResetItem.Click += new System.EventHandler(this.ResetFindItem);
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.Controls.Add(this.listViewUserItems);
            this.tabPageUsers.Controls.Add(this.panelUser);
            this.tabPageUsers.Controls.Add(this.splitter);
            this.tabPageUsers.Controls.Add(this.listViewUsers);
            this.tabPageUsers.Controls.Add(this.toolStripUsers);
            this.tabPageUsers.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsers.Size = new System.Drawing.Size(776, 389);
            this.tabPageUsers.TabIndex = 2;
            this.tabPageUsers.Text = "Сотрудники";
            this.tabPageUsers.UseVisualStyleBackColor = true;
            // 
            // listViewUserItems
            // 
            this.listViewUserItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnINum,
            this.columnIName,
            this.columnIDate,
            this.columnIPlace,
            this.columnIDiscription});
            this.listViewUserItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewUserItems.Enabled = false;
            this.listViewUserItems.FullRowSelect = true;
            this.listViewUserItems.GridLines = true;
            this.listViewUserItems.Location = new System.Drawing.Point(241, 116);
            this.listViewUserItems.Name = "listViewUserItems";
            this.listViewUserItems.Size = new System.Drawing.Size(532, 270);
            this.listViewUserItems.TabIndex = 6;
            this.listViewUserItems.UseCompatibleStateImageBehavior = false;
            this.listViewUserItems.View = System.Windows.Forms.View.Details;
            // 
            // columnINum
            // 
            this.columnINum.Text = "Номер";
            this.columnINum.Width = 66;
            // 
            // columnIName
            // 
            this.columnIName.Text = "Наименование";
            this.columnIName.Width = 142;
            // 
            // columnIDate
            // 
            this.columnIDate.Text = "Дата выдачи";
            this.columnIDate.Width = 150;
            // 
            // columnIPlace
            // 
            this.columnIPlace.Text = "Местоположение";
            // 
            // columnIDiscription
            // 
            this.columnIDiscription.Text = "Примечание";
            this.columnIDiscription.Width = 134;
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.textBoxPost);
            this.panelUser.Controls.Add(this.textBoxDep);
            this.panelUser.Controls.Add(this.textBoxOrg);
            this.panelUser.Controls.Add(this.labelPost);
            this.panelUser.Controls.Add(this.labelOrg);
            this.panelUser.Controls.Add(this.labelDep);
            this.panelUser.Controls.Add(this.labelInv);
            this.panelUser.Controls.Add(this.textBoxUser);
            this.panelUser.Controls.Add(this.labelUser);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUser.Location = new System.Drawing.Point(241, 28);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(532, 88);
            this.panelUser.TabIndex = 5;
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Location = new System.Drawing.Point(271, 32);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(68, 13);
            this.labelPost.TabIndex = 16;
            this.labelPost.Text = "Должность:";
            // 
            // labelOrg
            // 
            this.labelOrg.AutoSize = true;
            this.labelOrg.Location = new System.Drawing.Point(7, 32);
            this.labelOrg.Name = "labelOrg";
            this.labelOrg.Size = new System.Drawing.Size(77, 13);
            this.labelOrg.TabIndex = 14;
            this.labelOrg.Text = "Организация:";
            // 
            // labelDep
            // 
            this.labelDep.AutoSize = true;
            this.labelDep.Location = new System.Drawing.Point(249, 6);
            this.labelDep.Name = "labelDep";
            this.labelDep.Size = new System.Drawing.Size(90, 13);
            this.labelDep.TabIndex = 12;
            this.labelDep.Text = "Подразделение:";
            // 
            // labelInv
            // 
            this.labelInv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelInv.AutoSize = true;
            this.labelInv.Location = new System.Drawing.Point(6, 68);
            this.labelInv.Name = "labelInv";
            this.labelInv.Size = new System.Drawing.Size(138, 13);
            this.labelInv.TabIndex = 2;
            this.labelInv.Text = "Закреплённый инвентарь";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Enabled = false;
            this.textBoxUser.Location = new System.Drawing.Point(90, 3);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.ReadOnly = true;
            this.textBoxUser.Size = new System.Drawing.Size(149, 20);
            this.textBoxUser.TabIndex = 1;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(32, 6);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(52, 13);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "Ф. И. О.:";
            // 
            // splitter
            // 
            this.splitter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitter.Location = new System.Drawing.Point(236, 28);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(5, 358);
            this.splitter.TabIndex = 2;
            this.splitter.TabStop = false;
            // 
            // listViewUsers
            // 
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnUUser,
            this.columnUDep});
            this.listViewUsers.ContextMenuStrip = this.contextMenuStripUsers;
            this.listViewUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewUsers.FullRowSelect = true;
            this.listViewUsers.GridLines = true;
            this.listViewUsers.HideSelection = false;
            this.listViewUsers.Location = new System.Drawing.Point(3, 28);
            this.listViewUsers.MultiSelect = false;
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(233, 358);
            this.listViewUsers.TabIndex = 0;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            this.listViewUsers.SelectedIndexChanged += new System.EventHandler(this.listViewUsers_SelectedIndexChanged);
            this.listViewUsers.DoubleClick += new System.EventHandler(this.EditUser);
            // 
            // columnUUser
            // 
            this.columnUUser.Text = "Сотрудник";
            this.columnUUser.Width = 94;
            // 
            // columnUDep
            // 
            this.columnUDep.Text = "Подразделение";
            this.columnUDep.Width = 100;
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
            this.ToolStripMenuItemNewUser.Name = "ToolStripMenuItemNewUser";
            this.ToolStripMenuItemNewUser.ShortcutKeyDisplayString = "Ctrl + Shift + N";
            this.ToolStripMenuItemNewUser.Size = new System.Drawing.Size(259, 22);
            this.ToolStripMenuItemNewUser.Text = "Новый сотрудник";
            this.ToolStripMenuItemNewUser.Click += new System.EventHandler(this.NewUser);
            // 
            // ToolStripMenuItemPrint
            // 
            this.ToolStripMenuItemPrint.Enabled = false;
            this.ToolStripMenuItemPrint.Name = "ToolStripMenuItemPrint";
            this.ToolStripMenuItemPrint.ShortcutKeyDisplayString = "Ctrl + P";
            this.ToolStripMenuItemPrint.Size = new System.Drawing.Size(259, 22);
            this.ToolStripMenuItemPrint.Text = "Карточка учёта";
            this.ToolStripMenuItemPrint.Click += new System.EventHandler(this.PrintCard);
            // 
            // перейтиВИнвентарьToolStripMenuItem
            // 
            this.перейтиВИнвентарьToolStripMenuItem.Enabled = false;
            this.перейтиВИнвентарьToolStripMenuItem.Name = "перейтиВИнвентарьToolStripMenuItem";
            this.перейтиВИнвентарьToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.перейтиВИнвентарьToolStripMenuItem.Text = "Перейти в инвентарь";
            this.перейтиВИнвентарьToolStripMenuItem.ToolTipText = "Показать все предметы сотрудника в общем списке инвентаря";
            this.перейтиВИнвентарьToolStripMenuItem.Click += new System.EventHandler(this.ToInventory);
            // 
            // ToolStripMenuItemDelUser
            // 
            this.ToolStripMenuItemDelUser.Enabled = false;
            this.ToolStripMenuItemDelUser.Name = "ToolStripMenuItemDelUser";
            this.ToolStripMenuItemDelUser.ShortcutKeyDisplayString = "Shift + Del";
            this.ToolStripMenuItemDelUser.Size = new System.Drawing.Size(259, 22);
            this.ToolStripMenuItemDelUser.Text = "Удалить";
            this.ToolStripMenuItemDelUser.Click += new System.EventHandler(this.DelUser);
            // 
            // toolStripUsers
            // 
            this.toolStripUsers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripUsers.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNewUser,
            this.toolStripButtonPrint,
            this.toolStripButtonToInventory,
            this.toolStripButtonDelUser});
            this.toolStripUsers.Location = new System.Drawing.Point(3, 3);
            this.toolStripUsers.Name = "toolStripUsers";
            this.toolStripUsers.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripUsers.Size = new System.Drawing.Size(770, 25);
            this.toolStripUsers.TabIndex = 0;
            this.toolStripUsers.Text = "toolStrip2";
            // 
            // toolNewUser
            // 
            this.toolNewUser.Image = global::My_Inventory.Properties.Resources.New;
            this.toolNewUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNewUser.Name = "toolNewUser";
            this.toolNewUser.Size = new System.Drawing.Size(65, 22);
            this.toolNewUser.Text = "Новый";
            this.toolNewUser.ToolTipText = "Создать нового сотрудника";
            this.toolNewUser.Click += new System.EventHandler(this.NewUser);
            // 
            // toolStripButtonPrint
            // 
            this.toolStripButtonPrint.Enabled = false;
            this.toolStripButtonPrint.Image = global::My_Inventory.Properties.Resources.Printer;
            this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Size = new System.Drawing.Size(111, 22);
            this.toolStripButtonPrint.Text = "Карточка учёта";
            this.toolStripButtonPrint.Click += new System.EventHandler(this.PrintCard);
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
            this.toolStripButtonToInventory.Click += new System.EventHandler(this.ToInventory);
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
            this.toolStripButtonDelUser.Click += new System.EventHandler(this.DelUser);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusSelected});
            this.statusStrip.Location = new System.Drawing.Point(0, 439);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusSelected
            // 
            this.statusSelected.Name = "statusSelected";
            this.statusSelected.Size = new System.Drawing.Size(122, 17);
            this.statusSelected.Text = "Выбрано элементов:";
            // 
            // textBoxOrg
            // 
            this.textBoxOrg.Enabled = false;
            this.textBoxOrg.Location = new System.Drawing.Point(90, 29);
            this.textBoxOrg.Name = "textBoxOrg";
            this.textBoxOrg.ReadOnly = true;
            this.textBoxOrg.Size = new System.Drawing.Size(149, 20);
            this.textBoxOrg.TabIndex = 17;
            // 
            // textBoxDep
            // 
            this.textBoxDep.Enabled = false;
            this.textBoxDep.Location = new System.Drawing.Point(345, 3);
            this.textBoxDep.Name = "textBoxDep";
            this.textBoxDep.ReadOnly = true;
            this.textBoxDep.Size = new System.Drawing.Size(149, 20);
            this.textBoxDep.TabIndex = 18;
            // 
            // textBoxPost
            // 
            this.textBoxPost.Enabled = false;
            this.textBoxPost.Location = new System.Drawing.Point(345, 29);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.ReadOnly = true;
            this.textBoxPost.Size = new System.Drawing.Size(149, 20);
            this.textBoxPost.TabIndex = 19;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(800, 500);
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
            this.toolStripNewItem.ResumeLayout(false);
            this.toolStripNewItem.PerformLayout();
            this.tabPageUsers.ResumeLayout(false);
            this.tabPageUsers.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.contextMenuStripUsers.ResumeLayout(false);
            this.toolStripUsers.ResumeLayout(false);
            this.toolStripUsers.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageInventory;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ListView listViewInventory;
        private System.Windows.Forms.ToolStrip toolStripNewItem;
        private System.Windows.Forms.ToolStripButton toolТNewItem;
        private System.Windows.Forms.ColumnHeader columnNum;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnPlace;
        private System.Windows.Forms.ColumnHeader columnUser;
        private System.Windows.Forms.ColumnHeader columnComment;
        private System.Windows.Forms.ListView listViewUserItems;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.ToolStrip toolStripUsers;
        private System.Windows.Forms.ToolStripButton toolNewUser;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnINum;
        private System.Windows.Forms.ColumnHeader columnIName;
        private System.Windows.Forms.ColumnHeader columnIDiscription;
        private System.Windows.Forms.ColumnHeader columnIDate;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelInv;
        private System.Windows.Forms.ColumnHeader columnUUser;
        private System.Windows.Forms.ColumnHeader columnUDep;
        private System.Windows.Forms.Label labelDep;
        private System.Windows.Forms.ToolStripButton toolDelItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripItems;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNewItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDel;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelUser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripUsers;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNewUser;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDelUser;
        private System.Windows.Forms.Label labelOrg;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.ToolStripMenuItem menuPrintCard;
        private System.Windows.Forms.ToolStripSeparator sep1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPrint;
        private System.Windows.Forms.ToolStripStatusLabel statusSelected;
        private System.Windows.Forms.ToolStripButton toolStripButtonToInventory;
        private System.Windows.Forms.ToolStripMenuItem перейтиВИнвентарьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuMisc;
        private System.Windows.Forms.ColumnHeader columnIPlace;
        private System.Windows.Forms.ToolStripMenuItem menuOrgData;
        private System.Windows.Forms.ToolStripTextBox toolFindItem;
        private System.Windows.Forms.ToolStripLabel toolFind;
        private System.Windows.Forms.ToolStripSeparator sep3;
        private System.Windows.Forms.ToolStripButton toolResetItem;
        private System.Windows.Forms.ToolStripMenuItem menuWebSite;
        private System.Windows.Forms.ToolStripSeparator sep2;
        private System.Windows.Forms.ToolStripMenuItem menuProgramPage;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.TextBox textBoxDep;
        private System.Windows.Forms.TextBox textBoxOrg;
    }
}

