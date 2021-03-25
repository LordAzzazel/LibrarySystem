using LibrarySystem.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RoleBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            RolesAdding(RoleBox);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginBox_MouseClick(object sender, MouseEventArgs e)
        {
            LoginLabel.Visible = false;
        }

        private void PasswordBox_MouseClick(object sender, MouseEventArgs e)
        {
            PasLabel.Visible = false;
        }

        private void RoleBox_MouseClick(object sender, MouseEventArgs e)
        {
            RoleLabel.Visible = false;

        }

        public void RolesAdding(ComboBox listb)
        {
            listb.Items.Add("Библиотекарь");
            listb.Items.Add("Администратор");
        }

        private void RoleBox_DropDownClosed(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { RoleBox.Select(0, 0); }));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            Hide();
        }
    }
}
