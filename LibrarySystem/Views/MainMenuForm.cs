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
    public partial class MainMenuForm : Form
    {
        private Form activeForm;
        public MainMenuForm()
        {
            InitializeComponent();
        }
        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            btnToHomePage.Visible = false;
            ShowIcon = false;
            this.Text = string.Empty;
            if(Saver.Role == "Библиотекарь") { btnLib.Visible = false; }

        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            Button btn = btnSender as Button;
            TitleLabel.Text = btn.Text;
            Saver.Status = btn.Text;
            childForm.Show();
            pictureBox2.Visible = false;
            btnToHomePage.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.FormTableShower(), sender);
        }

        private void btnReaders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.FormTableShower(), sender);
        }

        private void btnGivenBooks_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.FormTableShower(), sender);
        }

        private void btnAuthors_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.FormTableShower(), sender);
        }

        private void btnPublishingHouses_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.FormTableShower(), sender);
        }

        private void btnLib_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.FormTableShower(), sender);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnToHomePage_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            btnToHomePage.Visible = false;
            TitleLabel.Text = "Домашняя страница";
            pictureBox2.Visible = true;
        }

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
