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
    public partial class AuthorAddUpg : Form
    {
        private string query, initial;
        DatabaseConnection dc;
        public AuthorAddUpg()
        {
            InitializeComponent();
            dc = new DatabaseConnection();
        }

        private void AuthorAddUpg_Load(object sender, EventArgs e)
        {
            if (Saver.FormName == "Изменение")
            {
                textBox1.Text = Saver.Values[1];
                textBox2.Text = Saver.Values[2];
                textBox3.Text = Saver.Values[3];
                textBox4.Text = Saver.Values[4];
                maskedTextBox1.Text = Saver.Values[5];
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Saver.FormEnabler();
            Hide();
        }

        private void AuthorAddUpg_Activated(object sender, EventArgs e)
        {
            FormNameLabel.Text = Saver.FormName + "\nавтора";
            btnAddUpg.Text = Saver.FormFunctionName;
        }

        private void btnAddUpg_Click(object sender, EventArgs e)
        {
            if (Saver.FormFunctionName == "Добавить")
            {
                query = $"Insert into Authors values(N'{ textBox1.Text }', N'{ textBox2.Text }', N'{ textBox3.Text}', N'{ textBox4.Text }', { maskedTextBox1.Text })";
                dc.AddorUpgr(query, "Добавлено");
                Saver.FormEnabler();
                Hide();
            }
            else if (Saver.FormFunctionName == "Изменить")
            {
                query = $"Update Authors Set Фамилия = N'{ textBox1.Text }', Имя = N'{ textBox2.Text }', Отчество = N'{ textBox3.Text }', Инициалы = N'{ textBox4.Text }', Год_рождения = { maskedTextBox1.Text } Where Id = { Saver.Values[0]}";
                dc.AddorUpgr(query, "Изменено");
                Saver.FormEnabler();
                Hide();
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            InitialsMaking();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            InitialsMaking();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            InitialsMaking();
        }

        private void InitialsMaking()
        {
            if(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                return;
            }
            else
            {
                initial = $"{textBox2.Text[0]}. {textBox3.Text[0]}. {textBox1.Text}";
                textBox4.Text = initial;
            }
        }
    }
}
