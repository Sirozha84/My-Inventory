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
            this.menuItems = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemsNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemsOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemsMove = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUserNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUserGoToInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsersGoToHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUserDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMisc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOrgData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWebSite = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProgramPage = new System.Windows.Forms.ToolStripMenuItem();
            this.sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPages = new System.Windows.Forms.TabControl();
            this.tabPageInventory = new System.Windows.Forms.TabPage();
            this.listViewInventory = new System.Windows.Forms.ListView();
            this.columnNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmenuItems = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmenuItemsOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenuItemsMove = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenuItemsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripNewItem = new System.Windows.Forms.ToolStrip();
            this.toolТNewItem = new System.Windows.Forms.ToolStripButton();
            this.toolMoveItems = new System.Windows.Forms.ToolStripButton();
            this.toolDelItem = new System.Windows.Forms.ToolStripButton();
            this.sep3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolFind = new System.Windows.Forms.ToolStripLabel();
            this.toolSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolResetItem = new System.Windows.Forms.ToolStripButton();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.listViewUserItems = new System.Windows.Forms.ListView();
            this.columnINum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIDiscription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelUser = new System.Windows.Forms.Panel();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.textBoxDep = new System.Windows.Forms.TextBox();
            this.textBoxOrg = new System.Windows.Forms.TextBox();
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
            this.cmenuUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmenuUsersCard = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenuUsersGoToInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenuUsersGoToHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenuUsersDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripUsers = new System.Windows.Forms.ToolStrip();
            this.toolNewUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolUsersGoToInventory = new System.Windows.Forms.ToolStripButton();
            this.toolUsersGoToHistory = new System.Windows.Forms.ToolStripButton();
            this.toolUsersDelete = new System.Windows.Forms.ToolStripButton();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.listViewLog = new System.Windows.Forms.ListView();
            this.columnLDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripLog = new System.Windows.Forms.ToolStrip();
            this.toolRefreshLog = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFromUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFromPlace = new System.Windows.Forms.ToolStripButton();
            this.tabPageUserHistory = new System.Windows.Forms.TabPage();
            this.listViewUserHistory = new System.Windows.Forms.ListView();
            this.columnUHData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUHNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUHName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUHAction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUHUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUHPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUHComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripUserHistory = new System.Windows.Forms.ToolStrip();
            this.toolRefreshUserHistory = new System.Windows.Forms.ToolStripButton();
            this.toolUserList = new System.Windows.Forms.ToolStripComboBox();
            this.imageListTabs = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusSelected = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuUsersOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenuUsersOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.tabPages.SuspendLayout();
            this.tabPageInventory.SuspendLayout();
            this.cmenuItems.SuspendLayout();
            this.toolStripNewItem.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.cmenuUsers.SuspendLayout();
            this.toolStripUsers.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.toolStripLog.SuspendLayout();
            this.tabPageUserHistory.SuspendLayout();
            this.toolStripUserHistory.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuItems,
            this.menuUsers,
            this.menuMisc,
            this.menuHelp});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(884, 24);
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
            this.menuPrintCard.Image = global::My_Inventory.Properties.Resources.printer;
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
            // menuItems
            // 
            this.menuItems.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemsNew,
            this.menuItemsOpen,
            this.menuItemsMove,
            this.menuItemsDelete});
            this.menuItems.Name = "menuItems";
            this.menuItems.Size = new System.Drawing.Size(78, 20);
            this.menuItems.Text = "Инвентарь";
            // 
            // menuItemsNew
            // 
            this.menuItemsNew.Image = global::My_Inventory.Properties.Resources.plus;
            this.menuItemsNew.Name = "menuItemsNew";
            this.menuItemsNew.Size = new System.Drawing.Size(202, 22);
            this.menuItemsNew.Text = "Новый";
            this.menuItemsNew.Click += new System.EventHandler(this.NewItem);
            // 
            // menuItemsOpen
            // 
            this.menuItemsOpen.Name = "menuItemsOpen";
            this.menuItemsOpen.Size = new System.Drawing.Size(202, 22);
            this.menuItemsOpen.Text = "Открыть";
            this.menuItemsOpen.Click += new System.EventHandler(this.ItemOpen);
            // 
            // menuItemsMove
            // 
            this.menuItemsMove.Image = global::My_Inventory.Properties.Resources.right;
            this.menuItemsMove.Name = "menuItemsMove";
            this.menuItemsMove.Size = new System.Drawing.Size(202, 22);
            this.menuItemsMove.Text = "Переместить комплект";
            this.menuItemsMove.Click += new System.EventHandler(this.MoveItems);
            // 
            // menuItemsDelete
            // 
            this.menuItemsDelete.Image = global::My_Inventory.Properties.Resources.delete;
            this.menuItemsDelete.Name = "menuItemsDelete";
            this.menuItemsDelete.Size = new System.Drawing.Size(202, 22);
            this.menuItemsDelete.Text = "Удалить";
            this.menuItemsDelete.Click += new System.EventHandler(this.DelItem);
            // 
            // menuUsers
            // 
            this.menuUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUserNew,
            this.menuUsersOpen,
            this.menuUserGoToInventory,
            this.menuUsersGoToHistory,
            this.menuUserDelete});
            this.menuUsers.Name = "menuUsers";
            this.menuUsers.Size = new System.Drawing.Size(85, 20);
            this.menuUsers.Text = "Сотрудники";
            // 
            // menuUserNew
            // 
            this.menuUserNew.Image = global::My_Inventory.Properties.Resources.add_user;
            this.menuUserNew.Name = "menuUserNew";
            this.menuUserNew.Size = new System.Drawing.Size(190, 22);
            this.menuUserNew.Text = "Новый";
            this.menuUserNew.Click += new System.EventHandler(this.NewUser);
            // 
            // menuUserGoToInventory
            // 
            this.menuUserGoToInventory.Image = global::My_Inventory.Properties.Resources.home;
            this.menuUserGoToInventory.Name = "menuUserGoToInventory";
            this.menuUserGoToInventory.Size = new System.Drawing.Size(190, 22);
            this.menuUserGoToInventory.Text = "Перейти в инвентарь";
            this.menuUserGoToInventory.Click += new System.EventHandler(this.ToInventory);
            // 
            // menuUsersGoToHistory
            // 
            this.menuUsersGoToHistory.Image = global::My_Inventory.Properties.Resources.history;
            this.menuUsersGoToHistory.Name = "menuUsersGoToHistory";
            this.menuUsersGoToHistory.Size = new System.Drawing.Size(190, 22);
            this.menuUsersGoToHistory.Text = "История сотрудника";
            this.menuUsersGoToHistory.Click += new System.EventHandler(this.ToHistory);
            // 
            // menuUserDelete
            // 
            this.menuUserDelete.Image = global::My_Inventory.Properties.Resources.remove_user;
            this.menuUserDelete.Name = "menuUserDelete";
            this.menuUserDelete.Size = new System.Drawing.Size(190, 22);
            this.menuUserDelete.Text = "Удалить";
            this.menuUserDelete.Click += new System.EventHandler(this.DelUser);
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
            // tabPages
            // 
            this.tabPages.Controls.Add(this.tabPageInventory);
            this.tabPages.Controls.Add(this.tabPageUsers);
            this.tabPages.Controls.Add(this.tabPageLog);
            this.tabPages.Controls.Add(this.tabPageUserHistory);
            this.tabPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPages.ImageList = this.imageListTabs;
            this.tabPages.ItemSize = new System.Drawing.Size(89, 30);
            this.tabPages.Location = new System.Drawing.Point(0, 24);
            this.tabPages.Name = "tabPages";
            this.tabPages.SelectedIndex = 0;
            this.tabPages.Size = new System.Drawing.Size(884, 515);
            this.tabPages.TabIndex = 1;
            // 
            // tabPageInventory
            // 
            this.tabPageInventory.Controls.Add(this.listViewInventory);
            this.tabPageInventory.Controls.Add(this.toolStripNewItem);
            this.tabPageInventory.ImageIndex = 1;
            this.tabPageInventory.Location = new System.Drawing.Point(4, 34);
            this.tabPageInventory.Name = "tabPageInventory";
            this.tabPageInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInventory.Size = new System.Drawing.Size(876, 477);
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
            this.listViewInventory.ContextMenuStrip = this.cmenuItems;
            this.listViewInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewInventory.FullRowSelect = true;
            this.listViewInventory.GridLines = true;
            this.listViewInventory.HideSelection = false;
            this.listViewInventory.Location = new System.Drawing.Point(3, 28);
            this.listViewInventory.Name = "listViewInventory";
            this.listViewInventory.Size = new System.Drawing.Size(870, 447);
            this.listViewInventory.TabIndex = 0;
            this.listViewInventory.UseCompatibleStateImageBehavior = false;
            this.listViewInventory.View = System.Windows.Forms.View.Details;
            this.listViewInventory.SelectedIndexChanged += new System.EventHandler(this.listViewInventory_SelectedIndexChanged);
            this.listViewInventory.DoubleClick += new System.EventHandler(this.ItemOpen);
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
            // cmenuItems
            // 
            this.cmenuItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmenuItemsOpen,
            this.cmenuItemsMove,
            this.cmenuItemsDelete});
            this.cmenuItems.Name = "contextMenuStripItems";
            this.cmenuItems.Size = new System.Drawing.Size(203, 70);
            // 
            // cmenuItemsOpen
            // 
            this.cmenuItemsOpen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmenuItemsOpen.Name = "cmenuItemsOpen";
            this.cmenuItemsOpen.Size = new System.Drawing.Size(202, 22);
            this.cmenuItemsOpen.Text = "Открыть";
            this.cmenuItemsOpen.Click += new System.EventHandler(this.ItemOpen);
            // 
            // cmenuItemsMove
            // 
            this.cmenuItemsMove.Image = global::My_Inventory.Properties.Resources.right;
            this.cmenuItemsMove.Name = "cmenuItemsMove";
            this.cmenuItemsMove.Size = new System.Drawing.Size(202, 22);
            this.cmenuItemsMove.Text = "Переместить комплект";
            this.cmenuItemsMove.Click += new System.EventHandler(this.MoveItems);
            // 
            // cmenuItemsDelete
            // 
            this.cmenuItemsDelete.Image = global::My_Inventory.Properties.Resources.delete;
            this.cmenuItemsDelete.Name = "cmenuItemsDelete";
            this.cmenuItemsDelete.ShortcutKeyDisplayString = "";
            this.cmenuItemsDelete.Size = new System.Drawing.Size(202, 22);
            this.cmenuItemsDelete.Text = "Удалить";
            this.cmenuItemsDelete.Click += new System.EventHandler(this.DelItem);
            // 
            // toolStripNewItem
            // 
            this.toolStripNewItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripNewItem.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripNewItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolТNewItem,
            this.toolMoveItems,
            this.toolDelItem,
            this.sep3,
            this.toolFind,
            this.toolSearch,
            this.toolResetItem});
            this.toolStripNewItem.Location = new System.Drawing.Point(3, 3);
            this.toolStripNewItem.Name = "toolStripNewItem";
            this.toolStripNewItem.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripNewItem.Size = new System.Drawing.Size(870, 25);
            this.toolStripNewItem.TabIndex = 1;
            // 
            // toolТNewItem
            // 
            this.toolТNewItem.Image = global::My_Inventory.Properties.Resources.plus;
            this.toolТNewItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolТNewItem.Name = "toolТNewItem";
            this.toolТNewItem.Size = new System.Drawing.Size(65, 22);
            this.toolТNewItem.Text = "Новый";
            this.toolТNewItem.Click += new System.EventHandler(this.NewItem);
            // 
            // toolMoveItems
            // 
            this.toolMoveItems.Image = global::My_Inventory.Properties.Resources.right;
            this.toolMoveItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMoveItems.Name = "toolMoveItems";
            this.toolMoveItems.Size = new System.Drawing.Size(99, 22);
            this.toolMoveItems.Text = "Переместить";
            this.toolMoveItems.Click += new System.EventHandler(this.MoveItems);
            // 
            // toolDelItem
            // 
            this.toolDelItem.Image = ((System.Drawing.Image)(resources.GetObject("toolDelItem.Image")));
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
            // toolSearch
            // 
            this.toolSearch.BackColor = System.Drawing.SystemColors.Window;
            this.toolSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolSearch.Name = "toolSearch";
            this.toolSearch.Size = new System.Drawing.Size(200, 25);
            this.toolSearch.TextChanged += new System.EventHandler(this.FindTextChange);
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
            this.tabPageUsers.ImageIndex = 0;
            this.tabPageUsers.Location = new System.Drawing.Point(4, 34);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsers.Size = new System.Drawing.Size(876, 477);
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
            this.listViewUserItems.Size = new System.Drawing.Size(632, 358);
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
            this.panelUser.Size = new System.Drawing.Size(632, 88);
            this.panelUser.TabIndex = 5;
            // 
            // textBoxPost
            // 
            this.textBoxPost.Enabled = false;
            this.textBoxPost.Location = new System.Drawing.Point(405, 29);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.ReadOnly = true;
            this.textBoxPost.Size = new System.Drawing.Size(210, 20);
            this.textBoxPost.TabIndex = 19;
            // 
            // textBoxDep
            // 
            this.textBoxDep.Enabled = false;
            this.textBoxDep.Location = new System.Drawing.Point(405, 3);
            this.textBoxDep.Name = "textBoxDep";
            this.textBoxDep.ReadOnly = true;
            this.textBoxDep.Size = new System.Drawing.Size(210, 20);
            this.textBoxDep.TabIndex = 18;
            // 
            // textBoxOrg
            // 
            this.textBoxOrg.Enabled = false;
            this.textBoxOrg.Location = new System.Drawing.Point(86, 29);
            this.textBoxOrg.Name = "textBoxOrg";
            this.textBoxOrg.ReadOnly = true;
            this.textBoxOrg.Size = new System.Drawing.Size(210, 20);
            this.textBoxOrg.TabIndex = 17;
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Location = new System.Drawing.Point(331, 32);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(68, 13);
            this.labelPost.TabIndex = 16;
            this.labelPost.Text = "Должность:";
            // 
            // labelOrg
            // 
            this.labelOrg.AutoSize = true;
            this.labelOrg.Location = new System.Drawing.Point(3, 32);
            this.labelOrg.Name = "labelOrg";
            this.labelOrg.Size = new System.Drawing.Size(77, 13);
            this.labelOrg.TabIndex = 14;
            this.labelOrg.Text = "Организация:";
            // 
            // labelDep
            // 
            this.labelDep.AutoSize = true;
            this.labelDep.Location = new System.Drawing.Point(309, 6);
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
            this.textBoxUser.Location = new System.Drawing.Point(86, 3);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.ReadOnly = true;
            this.textBoxUser.Size = new System.Drawing.Size(210, 20);
            this.textBoxUser.TabIndex = 1;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(28, 6);
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
            this.splitter.Size = new System.Drawing.Size(5, 446);
            this.splitter.TabIndex = 2;
            this.splitter.TabStop = false;
            // 
            // listViewUsers
            // 
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnUUser,
            this.columnUDep});
            this.listViewUsers.ContextMenuStrip = this.cmenuUsers;
            this.listViewUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewUsers.FullRowSelect = true;
            this.listViewUsers.GridLines = true;
            this.listViewUsers.HideSelection = false;
            this.listViewUsers.Location = new System.Drawing.Point(3, 28);
            this.listViewUsers.MultiSelect = false;
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(233, 446);
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
            // cmenuUsers
            // 
            this.cmenuUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmenuUsersOpen,
            this.cmenuUsersCard,
            this.cmenuUsersGoToInventory,
            this.cmenuUsersGoToHistory,
            this.cmenuUsersDelete});
            this.cmenuUsers.Name = "contextMenuStripUsers";
            this.cmenuUsers.Size = new System.Drawing.Size(191, 136);
            // 
            // cmenuUsersCard
            // 
            this.cmenuUsersCard.Enabled = false;
            this.cmenuUsersCard.Image = global::My_Inventory.Properties.Resources.printer;
            this.cmenuUsersCard.Name = "cmenuUsersCard";
            this.cmenuUsersCard.ShortcutKeyDisplayString = "";
            this.cmenuUsersCard.Size = new System.Drawing.Size(190, 22);
            this.cmenuUsersCard.Text = "Карточка учёта";
            this.cmenuUsersCard.Click += new System.EventHandler(this.PrintCard);
            // 
            // cmenuUsersGoToInventory
            // 
            this.cmenuUsersGoToInventory.Enabled = false;
            this.cmenuUsersGoToInventory.Image = global::My_Inventory.Properties.Resources.home;
            this.cmenuUsersGoToInventory.Name = "cmenuUsersGoToInventory";
            this.cmenuUsersGoToInventory.Size = new System.Drawing.Size(190, 22);
            this.cmenuUsersGoToInventory.Text = "Перейти в инвентарь";
            this.cmenuUsersGoToInventory.ToolTipText = "Показать все предметы сотрудника в общем списке инвентаря";
            this.cmenuUsersGoToInventory.Click += new System.EventHandler(this.ToInventory);
            // 
            // cmenuUsersGoToHistory
            // 
            this.cmenuUsersGoToHistory.Image = global::My_Inventory.Properties.Resources.history;
            this.cmenuUsersGoToHistory.Name = "cmenuUsersGoToHistory";
            this.cmenuUsersGoToHistory.Size = new System.Drawing.Size(190, 22);
            this.cmenuUsersGoToHistory.Text = "История сотрудника";
            this.cmenuUsersGoToHistory.Click += new System.EventHandler(this.ToHistory);
            // 
            // cmenuUsersDelete
            // 
            this.cmenuUsersDelete.Enabled = false;
            this.cmenuUsersDelete.Image = global::My_Inventory.Properties.Resources.remove_user;
            this.cmenuUsersDelete.Name = "cmenuUsersDelete";
            this.cmenuUsersDelete.ShortcutKeyDisplayString = "";
            this.cmenuUsersDelete.Size = new System.Drawing.Size(190, 22);
            this.cmenuUsersDelete.Text = "Удалить";
            this.cmenuUsersDelete.Click += new System.EventHandler(this.DelUser);
            // 
            // toolStripUsers
            // 
            this.toolStripUsers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripUsers.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNewUser,
            this.toolStripButtonPrint,
            this.toolUsersGoToInventory,
            this.toolUsersGoToHistory,
            this.toolUsersDelete});
            this.toolStripUsers.Location = new System.Drawing.Point(3, 3);
            this.toolStripUsers.Name = "toolStripUsers";
            this.toolStripUsers.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripUsers.Size = new System.Drawing.Size(870, 25);
            this.toolStripUsers.TabIndex = 0;
            this.toolStripUsers.Text = "toolStrip2";
            // 
            // toolNewUser
            // 
            this.toolNewUser.Image = global::My_Inventory.Properties.Resources.add_user;
            this.toolNewUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNewUser.Name = "toolNewUser";
            this.toolNewUser.Size = new System.Drawing.Size(65, 22);
            this.toolNewUser.Text = "Новый";
            this.toolNewUser.ToolTipText = "Создать нового сотрудника";
            this.toolNewUser.Click += new System.EventHandler(this.NewUser);
            // 
            // toolStripButtonPrint
            // 
            this.toolStripButtonPrint.Image = global::My_Inventory.Properties.Resources.printer;
            this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Size = new System.Drawing.Size(111, 22);
            this.toolStripButtonPrint.Text = "Карточка учёта";
            this.toolStripButtonPrint.Click += new System.EventHandler(this.PrintCard);
            // 
            // toolUsersGoToInventory
            // 
            this.toolUsersGoToInventory.Image = global::My_Inventory.Properties.Resources.home;
            this.toolUsersGoToInventory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUsersGoToInventory.Name = "toolUsersGoToInventory";
            this.toolUsersGoToInventory.Size = new System.Drawing.Size(143, 22);
            this.toolUsersGoToInventory.Text = "Перейти в инвентарь";
            this.toolUsersGoToInventory.ToolTipText = "Показать все предметы сотрудника в общем списке инвентаря";
            this.toolUsersGoToInventory.Click += new System.EventHandler(this.ToInventory);
            // 
            // toolUsersGoToHistory
            // 
            this.toolUsersGoToHistory.Image = global::My_Inventory.Properties.Resources.history;
            this.toolUsersGoToHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUsersGoToHistory.Name = "toolUsersGoToHistory";
            this.toolUsersGoToHistory.Size = new System.Drawing.Size(140, 22);
            this.toolUsersGoToHistory.Text = "История сотрудника";
            this.toolUsersGoToHistory.ToolTipText = "История сотрудника";
            this.toolUsersGoToHistory.Click += new System.EventHandler(this.ToHistory);
            // 
            // toolUsersDelete
            // 
            this.toolUsersDelete.Image = global::My_Inventory.Properties.Resources.remove_user;
            this.toolUsersDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUsersDelete.Name = "toolUsersDelete";
            this.toolUsersDelete.Size = new System.Drawing.Size(71, 22);
            this.toolUsersDelete.Text = "Удалить";
            this.toolUsersDelete.ToolTipText = "Удалить выбранного пользователя";
            this.toolUsersDelete.Click += new System.EventHandler(this.DelUser);
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.listViewLog);
            this.tabPageLog.Controls.Add(this.toolStripLog);
            this.tabPageLog.ImageIndex = 2;
            this.tabPageLog.Location = new System.Drawing.Point(4, 34);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLog.Size = new System.Drawing.Size(876, 477);
            this.tabPageLog.TabIndex = 3;
            this.tabPageLog.Text = "Журнал перемещений";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // listViewLog
            // 
            this.listViewLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnLDate,
            this.columnLNum,
            this.columnLName,
            this.columnLUser,
            this.columnLPlace,
            this.columnLComment});
            this.listViewLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLog.FullRowSelect = true;
            this.listViewLog.GridLines = true;
            this.listViewLog.Location = new System.Drawing.Point(3, 28);
            this.listViewLog.Name = "listViewLog";
            this.listViewLog.Size = new System.Drawing.Size(870, 446);
            this.listViewLog.TabIndex = 1;
            this.listViewLog.UseCompatibleStateImageBehavior = false;
            this.listViewLog.View = System.Windows.Forms.View.Details;
            // 
            // columnLDate
            // 
            this.columnLDate.Text = "Дата";
            this.columnLDate.Width = 70;
            // 
            // columnLNum
            // 
            this.columnLNum.Text = "Инв Н.";
            // 
            // columnLName
            // 
            this.columnLName.Text = "Наименование";
            this.columnLName.Width = 150;
            // 
            // columnLUser
            // 
            this.columnLUser.Text = "Сотрудник";
            this.columnLUser.Width = 150;
            // 
            // columnLPlace
            // 
            this.columnLPlace.Text = "Местоположение";
            this.columnLPlace.Width = 150;
            // 
            // columnLComment
            // 
            this.columnLComment.Text = "Комментарий";
            this.columnLComment.Width = 150;
            // 
            // toolStripLog
            // 
            this.toolStripLog.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripLog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolRefreshLog,
            this.toolStripButtonFromUser,
            this.toolStripButtonFromPlace});
            this.toolStripLog.Location = new System.Drawing.Point(3, 3);
            this.toolStripLog.Name = "toolStripLog";
            this.toolStripLog.Size = new System.Drawing.Size(870, 25);
            this.toolStripLog.TabIndex = 0;
            this.toolStripLog.Text = "toolStrip1";
            // 
            // toolRefreshLog
            // 
            this.toolRefreshLog.Image = global::My_Inventory.Properties.Resources.update;
            this.toolRefreshLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRefreshLog.Name = "toolRefreshLog";
            this.toolRefreshLog.Size = new System.Drawing.Size(111, 22);
            this.toolRefreshLog.Text = "Сформировать";
            this.toolRefreshLog.Click += new System.EventHandler(this.RefreshLog);
            // 
            // toolStripButtonFromUser
            // 
            this.toolStripButtonFromUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonFromUser.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFromUser.Image")));
            this.toolStripButtonFromUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFromUser.Name = "toolStripButtonFromUser";
            this.toolStripButtonFromUser.Size = new System.Drawing.Size(58, 22);
            this.toolStripButtonFromUser.Text = "От кого?";
            this.toolStripButtonFromUser.ToolTipText = "От кого?";
            this.toolStripButtonFromUser.Click += new System.EventHandler(this.toolStripButtonFromUser_Click);
            // 
            // toolStripButtonFromPlace
            // 
            this.toolStripButtonFromPlace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonFromPlace.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFromPlace.Image")));
            this.toolStripButtonFromPlace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFromPlace.Name = "toolStripButtonFromPlace";
            this.toolStripButtonFromPlace.Size = new System.Drawing.Size(54, 22);
            this.toolStripButtonFromPlace.Text = "Откуда?";
            this.toolStripButtonFromPlace.Click += new System.EventHandler(this.toolStripButtonFromPlace_Click);
            // 
            // tabPageUserHistory
            // 
            this.tabPageUserHistory.Controls.Add(this.listViewUserHistory);
            this.tabPageUserHistory.Controls.Add(this.toolStripUserHistory);
            this.tabPageUserHistory.ImageIndex = 3;
            this.tabPageUserHistory.Location = new System.Drawing.Point(4, 34);
            this.tabPageUserHistory.Name = "tabPageUserHistory";
            this.tabPageUserHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUserHistory.Size = new System.Drawing.Size(876, 477);
            this.tabPageUserHistory.TabIndex = 4;
            this.tabPageUserHistory.Text = "История сотрудника";
            this.tabPageUserHistory.UseVisualStyleBackColor = true;
            // 
            // listViewUserHistory
            // 
            this.listViewUserHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnUHData,
            this.columnUHNum,
            this.columnUHName,
            this.columnUHAction,
            this.columnUHUser,
            this.columnUHPlace,
            this.columnUHComment});
            this.listViewUserHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewUserHistory.FullRowSelect = true;
            this.listViewUserHistory.GridLines = true;
            this.listViewUserHistory.Location = new System.Drawing.Point(3, 28);
            this.listViewUserHistory.Name = "listViewUserHistory";
            this.listViewUserHistory.Size = new System.Drawing.Size(870, 446);
            this.listViewUserHistory.TabIndex = 3;
            this.listViewUserHistory.UseCompatibleStateImageBehavior = false;
            this.listViewUserHistory.View = System.Windows.Forms.View.Details;
            // 
            // columnUHData
            // 
            this.columnUHData.Text = "Дата";
            this.columnUHData.Width = 70;
            // 
            // columnUHNum
            // 
            this.columnUHNum.Text = "Инв Н.";
            // 
            // columnUHName
            // 
            this.columnUHName.Text = "Наименование";
            this.columnUHName.Width = 150;
            // 
            // columnUHAction
            // 
            this.columnUHAction.Text = "Действие";
            this.columnUHAction.Width = 100;
            // 
            // columnUHUser
            // 
            this.columnUHUser.Text = "Сотрудник";
            this.columnUHUser.Width = 160;
            // 
            // columnUHPlace
            // 
            this.columnUHPlace.Text = "Местоположение";
            this.columnUHPlace.Width = 140;
            // 
            // columnUHComment
            // 
            this.columnUHComment.Text = "Комментарий";
            this.columnUHComment.Width = 140;
            // 
            // toolStripUserHistory
            // 
            this.toolStripUserHistory.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripUserHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolRefreshUserHistory,
            this.toolUserList});
            this.toolStripUserHistory.Location = new System.Drawing.Point(3, 3);
            this.toolStripUserHistory.Name = "toolStripUserHistory";
            this.toolStripUserHistory.Size = new System.Drawing.Size(870, 25);
            this.toolStripUserHistory.TabIndex = 2;
            this.toolStripUserHistory.Text = "toolStripUserHistory";
            // 
            // toolRefreshUserHistory
            // 
            this.toolRefreshUserHistory.Image = global::My_Inventory.Properties.Resources.update;
            this.toolRefreshUserHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRefreshUserHistory.Name = "toolRefreshUserHistory";
            this.toolRefreshUserHistory.Size = new System.Drawing.Size(111, 22);
            this.toolRefreshUserHistory.Text = "Сформировать";
            this.toolRefreshUserHistory.Click += new System.EventHandler(this.toolRefreshUserHistory_Click);
            // 
            // toolUserList
            // 
            this.toolUserList.Name = "toolUserList";
            this.toolUserList.Size = new System.Drawing.Size(200, 25);
            // 
            // imageListTabs
            // 
            this.imageListTabs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTabs.ImageStream")));
            this.imageListTabs.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTabs.Images.SetKeyName(0, "user.png");
            this.imageListTabs.Images.SetKeyName(1, "home.png");
            this.imageListTabs.Images.SetKeyName(2, "book 1.png");
            this.imageListTabs.Images.SetKeyName(3, "history.png");
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusSelected});
            this.statusStrip.Location = new System.Drawing.Point(0, 539);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(884, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusSelected
            // 
            this.statusSelected.Name = "statusSelected";
            this.statusSelected.Size = new System.Drawing.Size(122, 17);
            this.statusSelected.Text = "Выбрано элементов:";
            // 
            // menuUsersOpen
            // 
            this.menuUsersOpen.Name = "menuUsersOpen";
            this.menuUsersOpen.Size = new System.Drawing.Size(190, 22);
            this.menuUsersOpen.Text = "Открыть";
            this.menuUsersOpen.Click += new System.EventHandler(this.EditUser);
            // 
            // cmenuUsersOpen
            // 
            this.cmenuUsersOpen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmenuUsersOpen.Name = "cmenuUsersOpen";
            this.cmenuUsersOpen.Size = new System.Drawing.Size(190, 22);
            this.cmenuUsersOpen.Text = "Открыть";
            this.cmenuUsersOpen.Click += new System.EventHandler(this.EditUser);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tabPages);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FormMain";
            this.Text = "My Inventory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabPages.ResumeLayout(false);
            this.tabPageInventory.ResumeLayout(false);
            this.tabPageInventory.PerformLayout();
            this.cmenuItems.ResumeLayout(false);
            this.toolStripNewItem.ResumeLayout(false);
            this.toolStripNewItem.PerformLayout();
            this.tabPageUsers.ResumeLayout(false);
            this.tabPageUsers.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.cmenuUsers.ResumeLayout(false);
            this.toolStripUsers.ResumeLayout(false);
            this.toolStripUsers.PerformLayout();
            this.tabPageLog.ResumeLayout(false);
            this.tabPageLog.PerformLayout();
            this.toolStripLog.ResumeLayout(false);
            this.toolStripLog.PerformLayout();
            this.tabPageUserHistory.ResumeLayout(false);
            this.tabPageUserHistory.PerformLayout();
            this.toolStripUserHistory.ResumeLayout(false);
            this.toolStripUserHistory.PerformLayout();
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
        private System.Windows.Forms.TabControl tabPages;
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
        private System.Windows.Forms.ContextMenuStrip cmenuItems;
        private System.Windows.Forms.ToolStripMenuItem cmenuItemsDelete;
        private System.Windows.Forms.ToolStripButton toolUsersDelete;
        private System.Windows.Forms.ContextMenuStrip cmenuUsers;
        private System.Windows.Forms.ToolStripMenuItem cmenuUsersDelete;
        private System.Windows.Forms.Label labelOrg;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.ToolStripMenuItem menuPrintCard;
        private System.Windows.Forms.ToolStripSeparator sep1;
        private System.Windows.Forms.ToolStripMenuItem cmenuUsersCard;
        private System.Windows.Forms.ToolStripStatusLabel statusSelected;
        private System.Windows.Forms.ToolStripButton toolUsersGoToInventory;
        private System.Windows.Forms.ToolStripMenuItem cmenuUsersGoToInventory;
        private System.Windows.Forms.ToolStripMenuItem menuMisc;
        private System.Windows.Forms.ColumnHeader columnIPlace;
        private System.Windows.Forms.ToolStripMenuItem menuOrgData;
        private System.Windows.Forms.ToolStripTextBox toolSearch;
        private System.Windows.Forms.ToolStripLabel toolFind;
        private System.Windows.Forms.ToolStripSeparator sep3;
        private System.Windows.Forms.ToolStripButton toolResetItem;
        private System.Windows.Forms.ToolStripMenuItem menuWebSite;
        private System.Windows.Forms.ToolStripSeparator sep2;
        private System.Windows.Forms.ToolStripMenuItem menuProgramPage;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.TextBox textBoxDep;
        private System.Windows.Forms.TextBox textBoxOrg;
        private System.Windows.Forms.ToolStripMenuItem cmenuItemsMove;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.ToolStrip toolStripLog;
        private System.Windows.Forms.ToolStripButton toolRefreshLog;
        private System.Windows.Forms.ListView listViewLog;
        private System.Windows.Forms.ColumnHeader columnLDate;
        private System.Windows.Forms.ColumnHeader columnLNum;
        private System.Windows.Forms.ColumnHeader columnLName;
        private System.Windows.Forms.ColumnHeader columnLUser;
        private System.Windows.Forms.ColumnHeader columnLPlace;
        private System.Windows.Forms.ColumnHeader columnLComment;
        private System.Windows.Forms.ToolStripButton toolStripButtonFromUser;
        private System.Windows.Forms.ToolStripButton toolStripButtonFromPlace;
        private System.Windows.Forms.TabPage tabPageUserHistory;
        private System.Windows.Forms.ListView listViewUserHistory;
        private System.Windows.Forms.ColumnHeader columnUHData;
        private System.Windows.Forms.ColumnHeader columnUHNum;
        private System.Windows.Forms.ColumnHeader columnUHName;
        private System.Windows.Forms.ColumnHeader columnUHAction;
        private System.Windows.Forms.ColumnHeader columnUHPlace;
        private System.Windows.Forms.ColumnHeader columnUHComment;
        private System.Windows.Forms.ToolStrip toolStripUserHistory;
        private System.Windows.Forms.ToolStripButton toolRefreshUserHistory;
        private System.Windows.Forms.ToolStripComboBox toolUserList;
        private System.Windows.Forms.ColumnHeader columnUHUser;
        private System.Windows.Forms.ToolStripMenuItem menuItems;
        private System.Windows.Forms.ToolStripMenuItem menuItemsNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemsDelete;
        private System.Windows.Forms.ToolStripMenuItem menuItemsMove;
        private System.Windows.Forms.ToolStripButton toolMoveItems;
        private System.Windows.Forms.ToolStripMenuItem menuUsers;
        private System.Windows.Forms.ToolStripMenuItem menuUserNew;
        private System.Windows.Forms.ToolStripMenuItem menuUserGoToInventory;
        private System.Windows.Forms.ToolStripMenuItem menuUsersGoToHistory;
        private System.Windows.Forms.ToolStripMenuItem menuUserDelete;
        private System.Windows.Forms.ImageList imageListTabs;
        private System.Windows.Forms.ToolStripMenuItem cmenuUsersGoToHistory;
        private System.Windows.Forms.ToolStripButton toolUsersGoToHistory;
        private System.Windows.Forms.ToolStripMenuItem menuItemsOpen;
        private System.Windows.Forms.ToolStripMenuItem cmenuItemsOpen;
        private System.Windows.Forms.ToolStripMenuItem menuUsersOpen;
        private System.Windows.Forms.ToolStripMenuItem cmenuUsersOpen;
    }
}

