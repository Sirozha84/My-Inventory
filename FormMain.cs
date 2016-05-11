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
            MessageBox.Show(Application.ProductName + "\nВерсия:" +
                Application.ProductVersion + "\nАвтор: Сергей Гордеев\n" +
                "Сайт автора: www.sg-software.ru",
                "О " + Application.ProductName, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        void DrawItems()
        {
            listViewInventory.Items.Clear();
            foreach (Item item in Data.Items)
            {
                string[] str = { item.Number, item.Name };
                listViewInventory.Items.Add(new ListViewItem(str));
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            DrawItems();
        }

        private void toolStripButtonNewItem_Click(object sender, EventArgs e)
        {
            Data.Items.Add(new Item("", ""));
            string[] str = { "", "" };
            listViewInventory.Items.Add(new ListViewItem(str));
            listViewInventory.Items[listViewInventory.Items.Count - 1].Selected = true;
        }

        private void listViewInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewInventory.SelectedIndices.Count == 0)
            {
                textBoxNum.Text = "";
                textBoxNum.Enabled = false;
                textBoxName.Text = "";
                textBoxName.Enabled = false;
                comboBoxUsers.Text = "";
                comboBoxUsers.Enabled = false;
                dateTimePickerDate.Text = "";
                dateTimePickerDate.Enabled = false;
                textBoxDiscription.Text = "";
                textBoxDiscription.Enabled = false;
            }
            if (listViewInventory.SelectedIndices.Count == 1)
            {
                textBoxNum.Text = "";
                textBoxNum.Enabled = true;
                textBoxName.Text = "";
                textBoxName.Enabled = true;
                comboBoxUsers.Text = "";
                comboBoxUsers.Enabled = true;
                dateTimePickerDate.Text = "";
                dateTimePickerDate.Enabled = true;
                textBoxDiscription.Text = "";
                textBoxDiscription.Enabled = true;
            }
            if (listViewInventory.SelectedIndices.Count > 1)
            {
                textBoxNum.Text = "Несколько позиций";
                textBoxNum.Enabled = false;
                textBoxName.Text = "Несколько позиций";
                textBoxName.Enabled = false;
                comboBoxUsers.Text = "Несколько";
                comboBoxUsers.Enabled = true;
                dateTimePickerDate.Text = "";
                dateTimePickerDate.Enabled = true;
                textBoxDiscription.Text = "";
                textBoxDiscription.Enabled = true;
            }
        }
    }
}
