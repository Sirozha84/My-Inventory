using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Inventory
{
    public partial class FormItem : Form
    {
        Item item;
        List<Move> history = new List<Move>();

        public FormItem(Item item)
        {
            InitializeComponent();
            this.item = item;

            textBoxNumber.Text = item.number;
            textBoxName.Text = item.name;
            textBoxModel.Text = item.model;
            textBoxDisc.Text = item.discription;
            textBoxDate.Text = item.date;
            textBoxUser.Text = item.user;
            textBoxPlace.Text = item.place;
            
            history.Clear();
            foreach (Move m in item.history)
                history.Add(m);
            DrawHistory();
        }

        void DrawHistory()
        {
            listViewHistory.BeginUpdate();
            listViewHistory.Items.Clear();
            foreach (Move m in history)
                listViewHistory.Items.Add(m.listItem());
            listViewHistory.EndUpdate();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            item.number = textBoxNumber.Text;
            item.name = textBoxName.Text;
            item.model = textBoxModel.Text;
            item.discription = textBoxDisc.Text;
            DialogResult = DialogResult.OK;
            //Close();
        }

        private void buttonAddVersion_Click(object sender, EventArgs e)
        {
            Move move = new Move();
            FormMove form = new FormMove(move);
            if (form.ShowDialog() == DialogResult.OK)
            {
                history.Add(move);
                DrawHistory();
            }
        }
    }
}
