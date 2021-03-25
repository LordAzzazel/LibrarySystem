using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.Views
{
    public partial class FormTableShower : Form
    {
        private string Adding = "Добавление", Updating = "Изменение";
        public FormTableShower()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BookAddUpg bookAddUpg = new BookAddUpg(btnAdd.Text, Adding);
            bookAddUpg.Show();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            BookAddUpg bookAddUpg = new BookAddUpg(btnUpd.Text, Updating);
            bookAddUpg.Show();
        }
    }
}
