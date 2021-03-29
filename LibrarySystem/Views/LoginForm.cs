using LibrarySystem.Service;
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
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RoleBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            RolesAdding(RoleBox);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginBox_MouseClick(object sender, MouseEventArgs e)
        {
            DisableLabels();
        }

        private void PasswordBox_MouseClick(object sender, MouseEventArgs e)
        {
            DisableLabels();
        }

        private void RoleBox_MouseClick(object sender, MouseEventArgs e)
        {
            DisableLabels();
        }

        public void RolesAdding(ComboBox listb)
        {
            listb.Items.Add("Библиотекарь");
            listb.Items.Add("Администратор");
        }
        public void DisableLabels()
        {
            LoginLabel.Visible = false;
            PasLabel.Visible = false;
            RoleLabel.Visible = false;
        }

        private void RoleBox_DropDownClosed(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { RoleBox.Select(0, 0); }));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM Users WHERE Login = '{ LoginBox.Text }' and Password = '{ PasswordBox.Text }' and Role = N'{ RoleBox.Text }'";
            DatabaseConnection dc = new DatabaseConnection();
            if (dc.SqlCheck(query) == true)
            {
                Saver.Role = RoleBox.Text;
                MainMenuForm mainMenuForm = new MainMenuForm();
                mainMenuForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Введите корректные данные");
            }
        }
    }
}
