using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            MessageBox.Show(Application.ProductName + "\nВерсия: " +
                Application.ProductVersion + "\nАвтор: Сергей Гордеев\n" +
                "Сайт: www.sg-software.ru",
                "О " + Application.ProductName, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        //Загрузка приложения
        private void FormMain_Load(object sender, EventArgs e)
        {
            Left = Properties.Settings.Default.WindowLeft;
            Top = Properties.Settings.Default.WindowTop;
            Width = Properties.Settings.Default.WindowsWidth;
            Height = Properties.Settings.Default.WindowsHeight;
            panelItem.Width = Properties.Settings.Default.Splitter1;
            listViewUsers.Width = Properties.Settings.Default.Splitter2;
            listViewInventory.Columns[0].Width = Properties.Settings.Default.Column00;
            listViewInventory.Columns[1].Width = Properties.Settings.Default.Column01;
            listViewInventory.Columns[2].Width = Properties.Settings.Default.Column02;
            listViewInventory.Columns[3].Width = Properties.Settings.Default.Column03;
            listViewInventory.Columns[4].Width = Properties.Settings.Default.Column04;
            listViewInventory.Columns[5].Width = Properties.Settings.Default.Column05;
            listViewUsers.Columns[0].Width = Properties.Settings.Default.Column10;
            listViewUsers.Columns[1].Width = Properties.Settings.Default.Column11;
            listViewUserItems.Columns[0].Width = Properties.Settings.Default.Column20;
            listViewUserItems.Columns[1].Width = Properties.Settings.Default.Column21;
            listViewUserItems.Columns[2].Width = Properties.Settings.Default.Column22;
            listViewUserItems.Columns[3].Width = Properties.Settings.Default.Column23;
            Data.Load();
            DrawBase();
        }

        //Выгрузка приложения
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.WindowLeft = Left;
            Properties.Settings.Default.WindowTop = Top;
            Properties.Settings.Default.WindowsWidth = Width;
            Properties.Settings.Default.WindowsHeight = Height;
            Properties.Settings.Default.Splitter1 = panelItem.Width;
            Properties.Settings.Default.Splitter2 = listViewUsers.Width;
            Properties.Settings.Default.Column00 = listViewInventory.Columns[0].Width;
            Properties.Settings.Default.Column01 = listViewInventory.Columns[1].Width;
            Properties.Settings.Default.Column02 = listViewInventory.Columns[2].Width;
            Properties.Settings.Default.Column03 = listViewInventory.Columns[3].Width;
            Properties.Settings.Default.Column04 = listViewInventory.Columns[4].Width;
            Properties.Settings.Default.Column05 = listViewInventory.Columns[5].Width;
            Properties.Settings.Default.Column10 = listViewUsers.Columns[0].Width;
            Properties.Settings.Default.Column11 = listViewUsers.Columns[1].Width;
            Properties.Settings.Default.Column20 = listViewUserItems.Columns[0].Width;
            Properties.Settings.Default.Column21 = listViewUserItems.Columns[1].Width;
            Properties.Settings.Default.Column22 = listViewUserItems.Columns[2].Width;
            Properties.Settings.Default.Column23 = listViewUserItems.Columns[3].Width;
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
        void DrawBase()
        {
            Data.Sort();
            //Рисование инвентаря
            listViewInventory.Items.Clear();
            foreach (Item item in Data.Items)
                listViewInventory.Items.Add(item.GetListItem());
            //Рисование сотрудников, выпадающие списки сотрудников, должностей,
            //организаций и подразделений! Очень круто!!!
            listViewUsers.Items.Clear();
            comboBoxUsers.Items.Clear();
            List<string> Posts = new List<string>();
            List<string> Orgs = new List<string>();
            List<string> Deps = new List<string>();
            foreach (User user in Data.Users)
            {
                listViewUsers.Items.Add(user.GetListVievItem());
                comboBoxUsers.Items.Add(user.Name);
                if (user.Post != "" && Posts.Find(o => o == user.Post) == null)
                    Posts.Add(user.Post);
                if (user.Organisation != "" && Orgs.Find(o => o == user.Organisation) == null)
                    Orgs.Add(user.Organisation);
                if (user.Departament != "" && Deps.Find(o => o == user.Departament) == null)
                    Deps.Add(user.Departament);
            }
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

        #region Вкладка "Инвентарь"
        /// <summary>
        /// Добавление нового предмета
        /// </summary>
        void NewItem()
        {
            tabControlMain.SelectedIndex = 0;
            //Ищем доступный номер
            int max = 1;
            foreach (Item itm in Data.Items)
            {
                int c = 0;
                try { c = Convert.ToInt32(itm.Number); } catch { }
                if (c > max) max = c;
            }
            max++;
            //Создаём предмет
            Item item = new Item(max.ToString(), "", "", "", "", "", "", "");
            Data.Items.Add(item);
            DrawBase();
            SelectOnliLastItem(listViewInventory);
            textBoxNum.Focus();
        }

        /// <summary>
        /// Удаление предметов
        /// </summary>
        void DelItem()
        {
            string ask = "Уверены, что хотите удалить выделенный предмет?";
            if (listViewInventory.SelectedIndices.Count > 1)
                ask = "Уверены, что хотите удалить выделенные предметы (" +
                    listViewInventory.SelectedIndices.Count + ")?";
            if (MessageBox.Show(ask, "Удаление инвентаря", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < listViewInventory.SelectedItems.Count; i++)
                    Data.Items.Remove((Item)listViewInventory.SelectedItems[i].Tag);
                DrawBase();
            }
        }

        private void listViewInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //В соответствии от того сколько строк выделено делаем активными нужные поля
            if (listViewInventory.SelectedIndices.Count == 0)
            {
                textBoxNum.Text = "";
                textBoxNum.Enabled = false;
                textBoxName.Text = "";
                textBoxName.Enabled = false;
                textBoxModel.Text = "";
                textBoxModel.Enabled = false;
                textBoxSerial.Text = "";
                textBoxSerial.Enabled = false;
                comboBoxUsers.Text = "";
                comboBoxUsers.Enabled = false;
                dateTimePickerDate.Text = "";
                dateTimePickerDate.Enabled = false;
                textBoxDiscription.Text = "";
                textBoxDiscription.Enabled = false;
            }
            if (listViewInventory.SelectedIndices.Count == 1)
            {
                Item item = (Item)listViewInventory.Items[listViewInventory.SelectedIndices[0]].Tag;
                textBoxNum.Text = item.Number;
                textBoxNum.Enabled = true;
                textBoxName.Text = item.Name;
                textBoxName.Enabled = true;
                textBoxModel.Text = item.Model;
                textBoxModel.Enabled = true;
                textBoxSerial.Text = item.Serial;
                textBoxSerial.Enabled = true;
                comboBoxUsers.Text = item.User;
                comboBoxUsers.Enabled = true;
                try { dateTimePickerDate.Text = item.Date; }
                catch { dateTimePickerDate.Text = "01.01.1970"; };
                dateTimePickerDate.Enabled = true;
                textBoxDiscription.Text = item.Discription;
                textBoxDiscription.Enabled = true;
            }
            if (listViewInventory.SelectedIndices.Count > 1)
            {
                textBoxNum.Text = "";
                textBoxNum.Enabled = false;
                textBoxName.Text = "";
                textBoxName.Enabled = false;
                textBoxModel.Text = "";
                textBoxModel.Enabled = false;
                textBoxSerial.Text = "";
                textBoxSerial.Enabled = false;
                comboBoxUsers.Text = "";
                comboBoxUsers.Enabled = true;
                dateTimePickerDate.Text = "";
                dateTimePickerDate.Enabled = true;
                textBoxDiscription.Text = "";
                textBoxDiscription.Enabled = true;
            }
            //Сбрасываем флаги изменений
            ChangeNum = false;
            ChangeUser = false;
            ChangeDate = false;
            ChangeDiscription = false;
            //Изменение доступностей кнопок
            buttonSave.Enabled = false;
            bool sel = listViewInventory.SelectedIndices.Count > 0;
            toolStripButtonDelItem.Enabled = sel;
            toolStripMenuItemDel.Enabled = sel;
            удалитьToolStripMenuItem.Enabled = sel;
        }

        private void textBoxNum_TextChanged(object sender, EventArgs e)
        {
            ChangeNum = true;
            buttonSave.Enabled = true;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e) { buttonSave.Enabled = true; }
        private void textBoxModel_TextChanged(object sender, EventArgs e) { buttonSave.Enabled = true; }
        private void textBoxSerial_TextChanged(object sender, EventArgs e) { buttonSave.Enabled = true; }

        private void comboBoxUsers_TextChanged(object sender, EventArgs e)
        {
            ChangeUser = true;
            buttonSave.Enabled = true;
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            ChangeDate = true;
            buttonSave.Enabled = true;
        }

        private void textBoxDiscription_TextChanged(object sender, EventArgs e)
        {
            ChangeDiscription = true;
            buttonSave.Enabled = true;
        }

        //Кнопка сохранения параметров предметов
        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool Many = listViewInventory.SelectedIndices.Count > 1;
            //Надо сделать проверку на то, нет ли такого номера уже в базе
            if (!Many && ChangeNum && Data.Items.Find(o => o.Number == textBoxNum.Text) != null)
            {
                MessageBox.Show("В базе уже есть предмет с таким номером");
                return;
            }
            foreach (ListViewItem lItem in listViewInventory.SelectedItems)
            {
                Item item = (Item)lItem.Tag;
                if (Many)
                {
                    if (ChangeUser) item.User = comboBoxUsers.Text;
                    if (ChangeDate) item.Date = dateTimePickerDate.Text;
                    if (ChangeDiscription) item.Discription = textBoxDiscription.Text;
                }
                else
                {
                    item.Number = textBoxNum.Text;
                    item.Name = textBoxName.Text;
                    item.Model = textBoxModel.Text;
                    item.Serial = textBoxSerial.Text;
                    item.User = comboBoxUsers.Text;
                    item.Date = dateTimePickerDate.Text;
                    item.Discription = textBoxDiscription.Text;
                }
            }
            DrawBase();
            Data.Save();
        }

        private void toolStripButtonNewItem_Click(object sender, EventArgs e) { NewItem(); }
        private void toolStripMenuItemNewItem_Click(object sender, EventArgs e) { NewItem(); }
        private void toolStripButtonDelItem_Click(object sender, EventArgs e) { DelItem(); }
        private void toolStripMenuItemDel_Click(object sender, EventArgs e) { DelItem(); }
        private void новыйПредметToolStripMenuItem_Click(object sender, EventArgs e) { NewItem(); }
        #endregion

        #region Вкладка "Сотрудники"
        /// <summary>
        /// Новый сотрудник
        /// </summary>
        void NewUser()
        {
            tabControlMain.SelectedIndex = 1;
            User user = new User("Сотрудник", "", "", "");
            Data.Users.Add(user);
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
            string name = user.Name;
            Data.Users.Remove(user);
            //А теперь пометим предметы, которые были прикреплены ничьими
            foreach (Item item in Data.Items)
                if (item.User == name) item.User = "";
            DrawBase();
        }

        //Изменение выделения списка сотрудников
        private void listViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool sel = listViewUsers.SelectedIndices.Count == 1;
            listViewUserItems.Items.Clear();
            if (sel)
            {
                //Заполнение списка прикреплённого инвентаря
                User user = (User)listViewUsers.SelectedItems[0].Tag;
                textBoxUUser.Text = user.Name;
                comboBoxPost.Text = user.Post;
                comboBoxOrg.Text = user.Organisation;
                comboBoxDepartament.Text = user.Departament;
                //comboBoxOrg.Text = user;
                Data.Items.FindAll(o => o.User == user.Name).ForEach(o =>
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
            удалитьToolStripMenuItem.Enabled = sel;
            ToolStripMenuItemPrint.Enabled = sel;
            buttonUSave.Enabled = false;
        }

        //Кнопка сохранения сотрудника
        private void buttonUSave_Click(object sender, EventArgs e)
        {
            //Надо сделать проверку на то, нет ли такого имени уже
            if (ChangeUserName && Data.Users.Find(o => o.Name == textBoxUUser.Text) != null)
            {
                MessageBox.Show("Сотрудник с такими Фамилией И. О. уже существует в базе.");
                return;
            }
            User user = (User)listViewUsers.SelectedItems[0].Tag;
            string oldName = user.Name;
            user.Name = textBoxUUser.Text;
            user.Post = comboBoxPost.Text;
            user.Organisation = comboBoxOrg.Text;
            user.Departament = comboBoxDepartament.Text;
            //Надо изменить записи в инвентаре при переименовании
            foreach (Item item in Data.Items)
                if (item.User == oldName) item.User = user.Name;
            DrawBase();
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

        private void новыйСотрудникToolStripMenuItem1_Click(object sender, EventArgs e) { NewUser(); }
        private void comboBoxPost_SelectedIndexChanged(object sender, EventArgs e) { buttonUSave.Enabled = true; }
        private void comboBoxPost_TextChanged(object sender, EventArgs e) { buttonUSave.Enabled = true; }
        private void comboBoxDepartament_SelectedIndexChanged(object sender, EventArgs e) { buttonUSave.Enabled = true; }
        private void comboBoxDepartament_TextChanged(object sender, EventArgs e) { buttonUSave.Enabled = true; }
        private void comboBoxOrg_SelectedIndexChanged(object sender, EventArgs e) { buttonUSave.Enabled = true; }
        private void comboBoxOrg_TextChanged(object sender, EventArgs e) { buttonUSave.Enabled = true; }
        private void toolStripButtonNewUser_Click(object sender, EventArgs e) { NewUser(); }
        private void ToolStripMenuItemNewUser_Click(object sender, EventArgs e) { NewUser(); }
        private void toolStripButtonDelUser_Click(object sender, EventArgs e) { DelUser(); }
        private void ToolStripMenuItemDelUser_Click(object sender, EventArgs e) { DelUser(); }
        private void печатьКарточкиУчётаToolStripMenuItem_Click(object sender, EventArgs e) { PrintRegistryCard(); }
        private void toolStripButtonPrint_Click(object sender, EventArgs e) { PrintRegistryCard(); }
        private void ToolStripMenuItemPrint_Click(object sender, EventArgs e) { PrintRegistryCard(); }
        #endregion

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedIndex == 0) DelItem();
            if (tabControlMain.SelectedIndex == 1) DelUser();
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedIndex == 0)
                удалитьToolStripMenuItem.Enabled = listViewInventory.SelectedItems.Count > 0;                
            if (tabControlMain.SelectedIndex == 1)
                удалитьToolStripMenuItem.Enabled = listViewUsers.SelectedItems.Count > 0;
        }

        private void параметрыПредприятияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompanyOptions form = new FormCompanyOptions();
            form.ShowDialog();
        }
    }
}
