using LibrarySystem.Service;
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
    public partial class BookAddUpg : Form
    {
        public BookAddUpg()
        {
            InitializeComponent();
        }

        private void BookAddUpg_Load(object sender, EventArgs e)
        {
            
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Saver.FormEnabler();
            Hide();
        }

        private void BookAddUpg_Activated(object sender, EventArgs e)
        {
            FormNameLabel.Text = Saver.FormName + " книги";
            btnAddUpg.Text = Saver.FormFunctionName;
        }
    }
}
