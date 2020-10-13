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
    public partial class FormUser : Form
    {
        User user;
        bool cancel;
        public FormUser(User user)
        {
            InitializeComponent();
            this.user = user;

            if (user.name != null) Text = user.name;

            List<string> Posts = new List<string>();
            List<string> Orgs = new List<string>();
            List<string> Deps = new List<string>();
            foreach (User u in Data.data.users)
            {
                if (u.post != "" && Posts.Find(o => o == u.post) == null)
                    Posts.Add(u.post);
                if (u.organisation != "" && Orgs.Find(o => o == u.organisation) == null)
                    Orgs.Add(u.organisation);
                if (u.departament != "" && Deps.Find(o => o == u.departament) == null)
                    Deps.Add(u.departament);
            }
            Posts.Sort();
            Orgs.Sort();
            Deps.Sort();
            comboBoxPost.DataSource = Posts;
            comboBoxOrg.DataSource = Orgs;
            comboBoxDep.DataSource = Deps;


            textBoxUser.Text = user.name;
            comboBoxOrg.Text = user.organisation;
            comboBoxDep.Text = user.departament;
            comboBoxPost.Text = user.post;
        }

        private void OK(object sender, EventArgs e)
        {
            string newName = textBoxUser.Text;
            if (user.name != newName && Data.data.users.Find(o => o.name == newName) != null)
            {
                MessageBox.Show("В базе уже есть пользователь с таким именем. Измените имя пользователя.");
                cancel = true;
            }
            else
            {
                user.name = newName;
                user.organisation = comboBoxOrg.Text;
                user.departament = comboBoxDep.Text;
                user.post = comboBoxPost.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) { cancel = false; }

        private void FormUser_FormClosing(object sender, FormClosingEventArgs e) { e.Cancel = cancel; }
    }
}
