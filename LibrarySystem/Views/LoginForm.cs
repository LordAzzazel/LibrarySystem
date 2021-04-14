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
        private string loginAccess;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PasswordBox.PasswordChar = '*';
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

        public void DisableLabels()
        {
            LoginLabel.Visible = false;
            PasLabel.Visible = false;
        }


        private void button2_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(LoginBox.Text) || String.IsNullOrEmpty(PasswordBox.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            else
            {
                string query = $"SELECT * FROM Users WHERE Login = '{ LoginBox.Text }' and Password = '{ PasswordBox.Text }'";
                DatabaseConnection dc = new DatabaseConnection();
                loginAccess = dc.SqlCheck(query);
                if (loginAccess != null)
                {
                    Saver.Role = loginAccess;
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
}
