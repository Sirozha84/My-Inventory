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
    public partial class FormCompanyOptions : Form
    {
        public FormCompanyOptions()
        {
            InitializeComponent();
            textBoxResponsiblePerson.Text = Data.ResponsiblePerson;
            textBoxPost.Text = Data.Post;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Data.ResponsiblePerson = textBoxResponsiblePerson.Text;
            Data.Post = textBoxPost.Text;
            Data.Save();
            Close();
        }
    }
}
