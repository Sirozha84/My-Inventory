using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace My_Inventory
{
    public partial class FormItem : Form
    {
        Item item;
        List<Move> history = new List<Move>();
        bool cancel;

        public FormItem(Item item)
        {
            InitializeComponent();
            this.item = item;

            if (item.name != null) Text = item.name + " " + item.model;

            textBoxNumber.Text = item.number;
            textBoxName.Text = item.name;
            textBoxModel.Text = item.model;
            textBoxDisc.Text = item.discription;
            
            history.Clear();
            foreach (Move m in item.history)
                history.Add(m);
            DrawHistory();
        }

        void DrawHistory()
        {
            listViewHistory.BeginUpdate();
            listViewHistory.Items.Clear();
            history.Sort((o1, o2) => o1.date.CompareTo(o2.date));
            foreach (Move m in history) listViewHistory.Items.Add(m.listItem());
            listViewHistory.EndUpdate();
            bool notVoid = history.Count > 0;
            int last = history.Count - 1;
            item.date = notVoid ? history[last].date.ToString("dd.MM.yyyy") : "";
            item.user = notVoid ? history[last].user : "";
            item.place = notVoid ? history[last].place : "";
            textBoxDate.Text = item.date;
            textBoxUser.Text = item.user;
            textBoxPlace.Text = item.place;
        }

        private void addMove(object sender, EventArgs e)
        {
            Move move = new Move();
            FormMove form = new FormMove(move);
            if (form.ShowDialog() == DialogResult.OK)
            {
                history.Add(move);
                DrawHistory();
            }
        }
        private void ChangeMove(object sender, EventArgs e)
        {
            if (listViewHistory.SelectedIndices.Count == 1)
            {
                Move move = (Move)listViewHistory.SelectedItems[0].Tag;
                FormMove form = new FormMove(move);
                if (form.ShowDialog() == DialogResult.OK) DrawHistory();
            }
        }

        private void DelMove(object sender, EventArgs e)
        {
            if (listViewHistory.SelectedIndices.Count == 1)
            {
                Move move = (Move)listViewHistory.SelectedItems[0].Tag;
                history.Remove(move);
                DrawHistory();
            }
        }

        private void HistorySelectedChanged(object sender, EventArgs e)
        {
            bool sel = listViewHistory.SelectedIndices.Count > 0;
            buttonChangeMove.Enabled = sel;
            buttonDelMove.Enabled = sel;
        }

        private void OK(object sender, EventArgs e)
        {
            if (item.number != textBoxNumber.Text && Data.data.items.Find(o => o.number == textBoxNumber.Text) != null)
            {
                MessageBox.Show("В базе уже есть объект с таким номером. Измените инвентарный номер.");
                cancel = true;
            }
            else
            {
                item.number = textBoxNumber.Text;
                item.name = textBoxName.Text;
                item.model = textBoxModel.Text;
                item.discription = textBoxDisc.Text;
                item.history.Clear();
                foreach (Move m in history) item.history.Add(m);
                DialogResult = DialogResult.OK;
                cancel = false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) { cancel = false; }

        private void FormItem_FormClosing(object sender, FormClosingEventArgs e) { e.Cancel = cancel; }

    }
}
