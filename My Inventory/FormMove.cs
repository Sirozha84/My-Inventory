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
    public partial class FormMove : Form
    {
        Move move;
        public FormMove(Move move)
        {
            this.move = move;
            InitializeComponent();
            date.Value = move.date;
            
            //Заполнение выпадающего списка пользователей
            foreach (User user in Data.data.users) comboBoxUser.Items.Add(user.name);
            
            //Заполнение выпадающего списка мест
            List<string> places = new List<string>();
            foreach (Item item in Data.data.items)
                if (item.place != "" && places.Find(o => o == item.place) == null)
                    places.Add(item.place);
            places.Sort();
            comboBoxPlace.DataSource = places;

            comboBoxUser.Text = move.user;
            comboBoxPlace.Text = move.place;
            textBoxComment.Text = move.comment;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            move.date = date.Value;
            move.user = comboBoxUser.Text;
            move.place = comboBoxPlace.Text;
            move.comment = textBoxComment.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
