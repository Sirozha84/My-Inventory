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
            textBoxResponsiblePerson.Text = Data.data.ResponsiblePerson;
            textBoxPost.Text = Data.data.Post;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Data.data.ResponsiblePerson = textBoxResponsiblePerson.Text;
            Data.data.Post = textBoxPost.Text;
            Data.Save();
            Close();
        }
    }
}
