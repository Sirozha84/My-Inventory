using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace My_Inventory
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Left = Properties.Settings.Default.WindowLeft;
            Top = Properties.Settings.Default.WindowTop;
            Width = Properties.Settings.Default.WindowsWidth;
            Height = Properties.Settings.Default.WindowsHeight;
            listViewUsers.Width = Properties.Settings.Default.Splitter2;
            listViewInventory.Columns[0].Width = Properties.Settings.Default.Column00;
            listViewInventory.Columns[1].Width = Properties.Settings.Default.Column01;
            listViewInventory.Columns[2].Width = Properties.Settings.Default.Column02;
            listViewInventory.Columns[3].Width = Properties.Settings.Default.Column03;
            listViewInventory.Columns[4].Width = Properties.Settings.Default.Column04;
            listViewInventory.Columns[5].Width = Properties.Settings.Default.Column05;
            listViewUsers.Columns[0].Width = Properties.Settings.Default.Column10;
            listViewUsers.Columns[1].Width = Properties.Settings.Default.Column07;
            listViewUserItems.Columns[0].Width = Properties.Settings.Default.Column20;
            listViewUserItems.Columns[1].Width = Properties.Settings.Default.Column21;
            listViewUserItems.Columns[2].Width = Properties.Settings.Default.Column22;
            listViewUserItems.Columns[3].Width = Properties.Settings.Default.Column23;
            listViewUserItems.Columns[4].Width = Properties.Settings.Default.Column24;
            Data.Load();
            RefreshData();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.WindowLeft = Left;
            Properties.Settings.Default.WindowTop = Top;
            Properties.Settings.Default.WindowsWidth = Width;
            Properties.Settings.Default.WindowsHeight = Height;
            Properties.Settings.Default.Splitter2 = listViewUsers.Width;
            Properties.Settings.Default.Column00 = listViewInventory.Columns[0].Width;
            Properties.Settings.Default.Column01 = listViewInventory.Columns[1].Width;
            Properties.Settings.Default.Column02 = listViewInventory.Columns[2].Width;
            Properties.Settings.Default.Column03 = listViewInventory.Columns[3].Width;
            Properties.Settings.Default.Column04 = listViewInventory.Columns[4].Width;
            Properties.Settings.Default.Column05 = listViewInventory.Columns[5].Width;
            Properties.Settings.Default.Column10 = listViewUsers.Columns[0].Width;
            Properties.Settings.Default.Column07 = listViewUsers.Columns[1].Width;
            Properties.Settings.Default.Column20 = listViewUserItems.Columns[0].Width;
            Properties.Settings.Default.Column21 = listViewUserItems.Columns[1].Width;
            Properties.Settings.Default.Column22 = listViewUserItems.Columns[2].Width;
            Properties.Settings.Default.Column23 = listViewUserItems.Columns[3].Width;
            Properties.Settings.Default.Column24 = listViewUserItems.Columns[4].Width;
            Properties.Settings.Default.Save();
        }


        #region Меню Файл
        void PrintCard(object sender, EventArgs e)
        {
            if (listViewUsers.SelectedIndices.Count == 1)
                Print.RegistryCard((User)listViewUsers.SelectedItems[0].Tag);
        }

        private void Quit(object sender, EventArgs e) { Close(); }
        #endregion
        
        #region Меню Сервис
        private void CompanyOptions(object sender, EventArgs e)
        {
            FormCompanyOptions form = new FormCompanyOptions();
            form.ShowDialog();
        }
        #endregion

        #region Меню Справка
        private void WebSite(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Program.Site);
        }

        private void ProgramPage(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Program.ProgramPage);
        }

        private void About(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }
        #endregion

        #region Вкладка "Инвентарь"
        //Новый объект
        void NewItem(object sender, EventArgs e)
        {
            Item item = new Item();
            FormItem form = new FormItem(item);
            if (form.ShowDialog() == DialogResult.OK)
            {
                Data.data.items.Add(item);
                Data.Save();
                RefreshData();
            }
        }

        //Редактирование объекта
        private void EditItem(object sender, EventArgs e)
        {
            if (listViewInventory.SelectedItems.Count < 1) return;
            Item item = (Item)listViewInventory.SelectedItems[0].Tag;
            FormItem form = new FormItem(item);
            if (form.ShowDialog() == DialogResult.OK)
            {
                Data.Save();
                RefreshData();
            }
        }
        
        //Перемещение комплекта объектов
        private void MoveItems(object sender, EventArgs e)
        {
            if (listViewInventory.SelectedItems.Count < 1) return;
            Move move = new Move();
            FormMove form = new FormMove(move);
            if (form.ShowDialog() == DialogResult.OK)
            {
                foreach (ListViewItem item in listViewInventory.SelectedItems)
                    ((Item)item.Tag).AddMove(move);
                Data.Save();
                RefreshData();
            }
        }

        //Удаление объекта
        void DelItem(object sender, EventArgs e)
        {
            string ask = "Уверены, что хотите удалить выделенный объект?";
            if (listViewInventory.SelectedIndices.Count > 1)
                ask = "Уверены, что хотите удалить выделенные объекты (" +
                    listViewInventory.SelectedIndices.Count + ")?";
            if (MessageBox.Show(ask, Application.ProductName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < listViewInventory.SelectedItems.Count; i++)
                {
                    Item it = (Item)listViewInventory.SelectedItems[i].Tag;
                    Data.data.items.Remove(it);
                }
                RefreshData();
            }
            Data.Save();
        }

        //Поиск
        private void FindTextChange(object sender, EventArgs e)
        {
            toolResetItem.Enabled = toolFindItem.Text != "";
            DrawItems(toolFindItem.Text.ToLower());
        }

        //Отмена поиска
        private void ResetFindItem(object sender, EventArgs e)
        {
            toolFindItem.Text = "";
            toolResetItem.Enabled = false;
        }

        //Изменение выделения объектов
        private void listViewInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //В соответствии от того сколько строк выделено делаем активными нужные поля
            if (listViewInventory.SelectedIndices.Count == 0)
                statusSelected.Text = "Ничего не выбрано";
            if (listViewInventory.SelectedIndices.Count == 1)
                statusSelected.Text = "Выбран один объект";
            if (listViewInventory.SelectedIndices.Count > 1)
                statusSelected.Text = "Выбрано объект: " + listViewInventory.SelectedIndices.Count;

            //Изменение доступностей кнопок
            bool sel = listViewInventory.SelectedIndices.Count > 0;
            toolDelItem.Enabled = sel;
            cmenuMoveItems.Enabled = sel;
            cmenuDelItem.Enabled = sel;
        }
        #endregion

        #region Вкладка "Сотрудники"
        //Новый сотрудник
        private void NewUser(object sender, EventArgs e) 
        {
            User user = new User();
            FormUser form = new FormUser(user);
            if (form.ShowDialog() == DialogResult.OK)
            {
                Data.data.users.Add(user);
                Data.Save();
                RefreshData();
            }
        }
        //Редактирование сотрудника
        private void EditUser(object sender, EventArgs e)
        {
            if (listViewUsers.SelectedItems.Count < 1) return;
            User user = (User)listViewUsers.SelectedItems[0].Tag;
            FormUser form = new FormUser(user);
            if (form.ShowDialog() == DialogResult.OK)
            {
                Data.Save();
                RefreshData();
            }
        }

        //Удаление сотрудника
        void DelUser(object sender, EventArgs e)
        {
            User user = (User)listViewUsers.SelectedItems[0].Tag;
            if (MessageBox.Show("Уверены, что хотите удалить " + user.name + "?",
                Application.ProductName, MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            string name = user.name;
            Data.data.users.Remove(user);

            //А теперь пометим предметы, которые были прикреплены ничьими
            foreach (Item item in Data.data.items)
                if (item.user == name) item.user = "";

            Data.Save();
            RefreshData();
        }
        
        //Переход к инвентарю
        void ToInventory(object sender, EventArgs e)
        {
            tabPages.SelectedIndex = 0;
            User user = (User)listViewUsers.SelectedItems[0].Tag;
            foreach (ListViewItem item in listViewInventory.Items)
            {
                Item i = (Item)(item.Tag);
                item.Selected = i.user == user.name;
            }
        }
        #endregion

        #region Вкладка "Журнал перемещений"
        //Формирование журнала перемещений
        void RefreshLog(object sender, EventArgs e)
        {
            List<LogRecord> log = new List<LogRecord>();
            foreach (Item item in Data.data.items)
                foreach (Move move in item.history)
                    log.Add(new LogRecord(item, move));
            log.Sort((o1, o2) => o1.date.CompareTo(o2.date));
            listViewLog.BeginUpdate();
            listViewLog.Items.Clear();
            foreach (LogRecord rec in log)
                listViewLog.Items.Add(rec.GetListItem());
            listViewLog.EndUpdate();
        }
        #endregion

        //Обновление всех данных на форме
        void RefreshData()
        {
            Data.Sort();
            
            //Вкладка инвентаря
            DrawItems("");
            
            //Вкладка сотрудников
            listViewUsers.BeginUpdate();
            listViewUsers.Items.Clear();
            foreach (User u in Data.data.users) listViewUsers.Items.Add(u.GetListVievItem());
            listViewUsers.EndUpdate();
        }
        
        //Вывод только списка объектов (с учётом поиска)
        void DrawItems(string Filter)
        {
            listViewInventory.BeginUpdate();
            listViewInventory.Items.Clear();
            foreach (Item item in Data.data.items)
            {
                if (Filter == "" ||
                    (item.number.ToLower().Contains(Filter) | item.name.ToLower().Contains(Filter) |
                    item.model.ToLower().Contains(Filter) | item.user.ToLower().Contains(Filter) |
                    item.place.ToLower().Contains(Filter) | item.discription.ToLower().Contains(Filter)))
                    listViewInventory.Items.Add(item.GetListItem());
            }
            listViewInventory.EndUpdate();
            listViewInventory_SelectedIndexChanged(null, null);
        }

        //Изменение выделения списка сотрудников
        private void listViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool sel = listViewUsers.SelectedIndices.Count == 1;

            listViewUserItems.BeginUpdate();
            listViewUserItems.Items.Clear();
            if (sel)
            {
                User user = (User)listViewUsers.SelectedItems[0].Tag;
                textBoxUser.Text = user.name;
                textBoxOrg.Text = user.organisation;
                textBoxDep.Text = user.departament;
                textBoxPost.Text = user.post;
                Data.data.items.FindAll(o => o.user == user.name).ForEach(o =>
                {
                    listViewUserItems.Items.Add(o.GetListItemForUser());
                });
            }
            else
            {
                textBoxUser.Text = "";
                textBoxOrg.Text = "";
                textBoxDep.Text = "";
                textBoxPost.Text = "";
            }
            listViewUserItems.EndUpdate();

            //Установка доступности кнопок
            textBoxUser.Enabled = sel;
            textBoxOrg.Enabled = sel;
            textBoxPost.Enabled = sel;
            textBoxDep.Enabled = sel;
            listViewUserItems.Enabled = sel;
            toolStripButtonPrint.Enabled = sel;
            toolStripButtonDelUser.Enabled = sel;
            cmenuDelUser.Enabled = sel;
            menuPrintCard.Enabled = sel;
            cmenuPrintCard.Enabled = sel;
            toolStripButtonToInventory.Enabled = sel;
            cmenuToInventory.Enabled = sel;
        }

    }
}
