using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace My_Inventory
{
    public partial class FormLogShrink : Form
    {
        public FormLogShrink()
        {
            InitializeComponent();
        }

        private void FormLogShrink_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.AddYears(-5);
        }

        private void buttonShrinkByDate_Click(object sender, EventArgs e)
        {
            Shrink(Data.Log.FindAll(o => Convert.ToDateTime(o.Date) < dateTimePicker1.Value.AddDays(-1)));
        }

        private void buttonShrinkByNum_Click(object sender, EventArgs e)
        {
            int i = (int)numericUpDown1.Value;
            if (i > Data.Log.Count) i = Data.Log.Count;
            Shrink(Data.Log.GetRange(i, Data.Log.Count - i));
        }

        void Shrink(List<LogRecord> removedrecs)
        {
            if (removedrecs.Count == 0)
            {
                MessageBox.Show("Журнал не изменился.");
                return;
            }
            if (MessageBox.Show("Удалить выбранные записи (" + removedrecs.Count.ToString() + " шт.)? "
                , Text, MessageBoxButtons.YesNo) == DialogResult.No) return;
            removedrecs.ForEach(o => Data.Log.Remove(o));
            Data.Save();
            Close();
        }
    }
}
