﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace My_Inventory
{
    public partial class FormMain : Form
    {
        //Флаги изменений
        bool ChangeNum;
        bool ChangeUser;
        bool ChangeDate;
        bool ChangeDiscription;
        bool ChangeUserName;
        bool ChangePlace;

        #region Общее
        public FormMain()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }

        //Загрузка приложения
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

        //Выгрузка приложения
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

        /// <summary>
        /// Выделение только последнего элемента в списке ListView
        /// </summary>
        /// <param name="listView"></param>
        void SelectOnliLastItem(ListView listView)
        {
            foreach (ListViewItem item in listView.SelectedItems)
                item.Selected = false;
            listView.Items[listView.Items.Count - 1].Selected = true;
        }

        /// <summary>
        /// Рисование данных на форме
        /// </summary>
        void RefreshData()
        {
            Data.Sort();
            //Вкладка инвентаря
            //Рисование списка
            DrawItems("");
            
            //Выпадающие списки
            List<string> Places = new List<string>();
            foreach (Item item in Data.data.items)
            {
                if (item.place != "" && Places.Find(o => o == item.place) == null)
                    Places.Add(item.place);
            }
            Places.Sort();
            //comboBoxPlace.DataSource = Places;

            //Вкладка сотрудников
            //Рисование списка
            listViewUsers.BeginUpdate();
            listViewUsers.Items.Clear();
            //comboBoxUsers.Items.Clear();

            //Выпадающие списки по данным пользователей
            List<string> Posts = new List<string>();
            List<string> Orgs = new List<string>();
            List<string> Deps = new List<string>();
            foreach (User user in Data.data.users)
            {
                listViewUsers.Items.Add(user.GetListVievItem());
                //comboBoxUsers.Items.Add(user.Name);
                if (user.post != "" && Posts.Find(o => o == user.post) == null)
                    Posts.Add(user.post);
                if (user.organisation != "" && Orgs.Find(o => o == user.organisation) == null)
                    Orgs.Add(user.organisation);
                if (user.departament != "" && Deps.Find(o => o == user.departament) == null)
                    Deps.Add(user.departament);
            }
            listViewUsers.EndUpdate();
            Posts.Sort();
            Orgs.Sort();
            Deps.Sort();
            comboBoxPost.DataSource = Posts;
            comboBoxOrg.DataSource = Orgs;
            comboBoxDepartament.DataSource = Deps;
            //Проверка выделений
            listViewInventory_SelectedIndexChanged(null, null);
            listViewUsers_SelectedIndexChanged(null, null);
            buttonUSave.Enabled = false;
        }

        /// <summary>
        /// Вывод списка предметов
        /// </summary>
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

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedIndex == 0)
                удалитьToolStripMenuItem.Enabled = listViewInventory.SelectedItems.Count > 0;                
            if (tabControlMain.SelectedIndex == 1)
                удалитьToolStripMenuItem.Enabled = listViewUsers.SelectedItems.Count > 0;
        }

        #endregion
        private void сайтРазработчикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.sg-software.ru");
        }

        private void страницаПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.sg-software.ru/windows/programs/my_inventory");
        }

        #region Вкладка "Инвентарь"
        /// <summary>
        /// Добавление нового предмета
        /// </summary>
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
            //SelectOnliLastItem(listViewInventory);
            //textBoxNum.Focus();
        }

        /// <summary>
        /// Удаление предметов
        /// </summary>
        void DelItem(bool Crib)
        {
            string del = Crib ? "списать" : "удалить";
            string cap = Crib ? "Списание инвентаря" : "Удаление инвентаря";
            string ask = "Уверены, что хотите удалить выделенный предмет?";
            if (listViewInventory.SelectedIndices.Count > 1)
                ask = "Уверены, что хотите удалить выделенные предметы (" +
                    listViewInventory.SelectedIndices.Count + ")?";
            if (MessageBox.Show(ask, cap, MessageBoxButtons.YesNo) == DialogResult.Yes)
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

        private void listViewInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //В соответствии от того сколько строк выделено делаем активными нужные поля
            if (listViewInventory.SelectedIndices.Count == 0)
            {
                toolStripStatusLabel1.Text = "";
            }
            if (listViewInventory.SelectedIndices.Count == 1)
            {
                Item item = (Item)listViewInventory.Items[listViewInventory.SelectedIndices[0]].Tag;
                toolStripStatusLabel1.Text = "Выбран один элемент";
            }
            if (listViewInventory.SelectedIndices.Count > 1)
            {
                toolStripStatusLabel1.Text = "Выбрано элементов: " + listViewInventory.SelectedIndices.Count;
            }
            //Сбрасываем флаги изменений
            ChangeNum = false;
            ChangeUser = false;
            ChangeDate = false;
            ChangePlace = false;
            ChangeDiscription = false;

            //Изменение доступностей кнопок
            bool sel = listViewInventory.SelectedIndices.Count > 0;
            toolStripButtonDelItem.Enabled = sel;
            toolStripButtonCrib.Enabled = sel;
            toolStripMenuItemDel.Enabled = sel;
            удалитьToolStripMenuItem.Enabled = sel;
            списатьToolStripMenuItem.Enabled = sel;
        }


        /*/Сохранение изменений в инвентаре
        void SaveItem(bool Log)
        {
            bool Many = listViewInventory.SelectedIndices.Count > 1;
            //Надо сделать проверку на то, нет ли такого номера уже в базе
            if (!Many && ChangeNum && Data.data.Items.Find(o => o.number == textBoxNum.Text) != null)
            {
                MessageBox.Show("В базе уже есть предмет с таким номером");
                return;
            }
            foreach (ListViewItem lItem in listViewInventory.SelectedItems)
            {
                Item item = (Item)lItem.Tag;
                string move = item.user + " " + item.place + "   ->   ";
                if (Many)
                {
                    if (ChangeUser) item.user = comboBoxUsers.Text;
                    if (ChangePlace) item.place = comboBoxPlace.Text; 
                    if (ChangeDate) item.date = dateTimePickerDate.Text;
                    if (ChangeDiscription) item.discription = textBoxDiscription.Text;
                }
                else
                {
                    item.number = textBoxNum.Text;
                    item.name = textBoxName.Text;
                    item.model = textBoxModel.Text;
                    item.serial = textBoxSerial.Text;
                    item.user = comboBoxUsers.Text;
                    item.place = comboBoxPlace.Text;
                    item.date = dateTimePickerDate.Text;
                    item.discription = textBoxDiscription.Text;
                }
                move += item.user + " " + item.place;
                if (Log)
                {
                    item.date = DateTime.Now.ToLongDateString();
                }
            }
            RefreshData();
            Data.Save();
        }*/

        private void данныеПредприятияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompanyOptions form = new FormCompanyOptions();
            form.ShowDialog();

        }

        private void toolStripButtonResetFilter_Click(object sender, EventArgs e)
        {
            toolStripTextBoxFilter.Text = "";
            toolStripButtonResetFilter.Enabled = false;
        }
        private void toolStripTextBoxFilter_TextChanged(object sender, EventArgs e)
        {
            toolStripButtonResetFilter.Enabled = toolStripTextBoxFilter.Text != "";
            DrawItems(toolStripTextBoxFilter.Text.ToLower());
        }

        //Кнопка сохранения параметров предметов
        private void toolStripButtonCrib_Click(object sender, EventArgs e) { DelItem(true); }
        private void списатьToolStripMenuItem_Click(object sender, EventArgs e) { DelItem(true); }
        private void toolStripMenuItemDel_Click(object sender, EventArgs e) { DelItem(false); }
        private void toolStripButtonDelItem_Click(object sender, EventArgs e) { DelItem(false); }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e) { DelItem(false); }        
        #endregion

        #region Вкладка "Сотрудники"
        /// <summary>
        /// Новый сотрудник
        /// </summary>
        void NewUser()
        {
            tabControlMain.SelectedIndex = 1;
            User user = new User("Сотрудник", "", "", "");
            Data.data.users.Add(user);
            listViewUsers.Items.Add(user.GetListVievItem());
            SelectOnliLastItem(listViewUsers);
            textBoxUUser.Focus();
        }

        /// <summary>
        /// Удаление сотрудника
        /// </summary>
        void DelUser()
        {
            if (MessageBox.Show("Уверены, что хотите удалить выбранного сотрудника?",
                "Удаление сотрудника", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            User user = (User)listViewUsers.SelectedItems[0].Tag;
            string name = user.name;
            Data.data.users.Remove(user);
            //А теперь пометим предметы, которые были прикреплены ничьими
            foreach (Item item in Data.data.items)
                if (item.user == name) item.user = "";
            RefreshData();
            Data.Save();
        }

        //Изменение выделения списка сотрудников
        private void listViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool sel = listViewUsers.SelectedIndices.Count == 1;
            listViewUserItems.BeginUpdate();
            listViewUserItems.Items.Clear();
            if (sel)
            {
                //Заполнение списка прикреплённого инвентаря
                User user = (User)listViewUsers.SelectedItems[0].Tag;
                textBoxUUser.Text = user.name;
                comboBoxPost.Text = user.post;
                comboBoxOrg.Text = user.organisation;
                comboBoxDepartament.Text = user.departament;
                //comboBoxOrg.Text = user;
                Data.data.items.FindAll(o => o.user == user.name).ForEach(o =>
                {
                    listViewUserItems.Items.Add(o.GetListItemForUser());
                });
            }
            else
            {
                textBoxUUser.Text = "";
                comboBoxPost.Text = "";
                comboBoxDepartament.Text = "";
                comboBoxOrg.Text = "";
            }
            listViewUserItems.EndUpdate();
            //Сброс флагов
            ChangeUserName = false;
            //Установка доступности кнопок
            textBoxUUser.Enabled = sel;
            comboBoxPost.Enabled = sel;
            comboBoxDepartament.Enabled = sel;
            comboBoxOrg.Enabled = sel;
            listViewUserItems.Enabled = sel;
            toolStripButtonPrint.Enabled = sel;
            toolStripButtonDelUser.Enabled = sel;
            ToolStripMenuItemDelUser.Enabled = sel;
            печатьКарточкиУчётаToolStripMenuItem.Enabled = sel;
            удалитьToolStripMenuItem1.Enabled = sel;
            ToolStripMenuItemPrint.Enabled = sel;
            buttonUSave.Enabled = false;
            toolStripButtonToInventory.Enabled = sel;
            перейтиВИнвентарьToolStripMenuItem.Enabled = sel;
        }

        //Кнопка сохранения сотрудника
        private void buttonUSave_Click(object sender, EventArgs e)
        {
            //Надо сделать проверку на то, нет ли такого имени уже
            if (ChangeUserName && Data.data.users.Find(o => o.name == textBoxUUser.Text) != null)
            {
                MessageBox.Show("Сотрудник с такими Фамилией И. О. уже существует в базе.");
                return;
            }
            User user = (User)listViewUsers.SelectedItems[0].Tag;
            string oldName = user.name;
            user.name = textBoxUUser.Text;
            user.post = comboBoxPost.Text;
            user.organisation = comboBoxOrg.Text;
            user.departament = comboBoxDepartament.Text;
            //Надо изменить записи в инвентаре при переименовании
            foreach (Item item in Data.data.items)
                if (item.user == oldName) item.user = user.name;
            RefreshData();
            Data.Save();
        }

        private void textBoxUUser_TextChanged(object sender, EventArgs e)
        {
            ChangeUserName = true;
            buttonUSave.Enabled = true;
        }

        //Печать карточки учёта
        void PrintRegistryCard()
        {
            if (listViewUsers.SelectedIndices.Count == 1)
                Print.RegistryCard((User)listViewUsers.SelectedItems[0].Tag);
        }

        private void listViewUserItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listViewInventory.SelectedIndices.Count == 0)
        }

        void ToInventory()
        {
            tabControlMain.SelectedIndex = 0;
            User user = (User)listViewUsers.SelectedItems[0].Tag;
            foreach (ListViewItem item in listViewInventory.Items)
            {
                Item i = (Item)(item.Tag);
                item.Selected = i.user == user.name;
            }
        }


        private void toolStripButtonNewUser_Click(object sender, EventArgs e) { NewUser(); }
        private void ToolStripMenuItemNewUser_Click(object sender, EventArgs e) { NewUser(); }
        private void новыйСотрудникToolStripMenuItem_Click(object sender, EventArgs e) { NewUser(); }
        private void toolStripButtonDelUser_Click(object sender, EventArgs e) { DelUser(); }
        private void ToolStripMenuItemDelUser_Click(object sender, EventArgs e) { DelUser(); }
        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e) { DelUser(); }
        private void comboBoxPost_SelectedIndexChanged(object sender, EventArgs e) { buttonUSave.Enabled = true; }
        private void comboBoxPost_TextChanged(object sender, EventArgs e) { buttonUSave.Enabled = true; }
        private void comboBoxDepartament_SelectedIndexChanged(object sender, EventArgs e) { buttonUSave.Enabled = true; }
        private void comboBoxDepartament_TextChanged(object sender, EventArgs e) { buttonUSave.Enabled = true; }
        private void comboBoxOrg_SelectedIndexChanged(object sender, EventArgs e) { buttonUSave.Enabled = true; }
        private void comboBoxOrg_TextChanged(object sender, EventArgs e) { buttonUSave.Enabled = true; }
        private void печатьКарточкиУчётаToolStripMenuItem_Click(object sender, EventArgs e) { PrintRegistryCard(); }
        private void toolStripButtonPrint_Click(object sender, EventArgs e) { PrintRegistryCard(); }
        private void ToolStripMenuItemPrint_Click(object sender, EventArgs e) { PrintRegistryCard(); }
        private void перейтиВИнвентарьToolStripMenuItem_Click(object sender, EventArgs e) { ToInventory(); }
        private void toolStripButtonToInventory_Click(object sender, EventArgs e) { ToInventory(); }
        #endregion

        private void listViewInventory_DoubleClick(object sender, EventArgs e)
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
    }
}
