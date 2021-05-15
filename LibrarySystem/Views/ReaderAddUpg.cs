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
    public partial class ReaderAddUpg : Form
    {
        private string query, initial, checkQuery;
        DatabaseConnection dc;
        DateTime today;

        public ReaderAddUpg()
        {
            InitializeComponent();
            dc = new DatabaseConnection();
        }

        private void ReaderAddUpg_Load(object sender, EventArgs e)
        {
            today = DateTime.Today;
            if (Saver.FormName == "Изменение")
            {
                textBox1.Text = Saver.Values[1];
                textBox2.Text = Saver.Values[2];
                textBox3.Text = Saver.Values[3];
                textBox4.Text = Saver.Values[4];
                maskedTextBox1.Text = Saver.Values[5];
                dateTimePicker1.Text = Saver.Values[6];
                textBox6.Text = Saver.Values[7];
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Saver.FormEnabler();
            Hide();
        }


        private void ReaderAddUpg_Activated(object sender, EventArgs e)
        {
            FormNameLabel.Text = Saver.FormName + "\nчитателя";
            btnAddUpg.Text = Saver.FormFunctionName;
        }
        private void btnAddUpg_Click(object sender, EventArgs e)
        {
            checkQuery = $"Select Телефон from Readers Where Телефон = '{ maskedTextBox1.Text }'";
            bool isExist = dc.isExist(checkQuery);
            if (dateTimePicker1.Value.Year >= today.Year - 14)
            {
                MessageBox.Show("Данный человек слишком молод, чтобы быть читателем");
                return;
            }
            else if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Заполните все поля");
            }
            else if (Saver.FormFunctionName == "Изменить")
            {
                query = $"Update Readers Set Фамилия = N'{ textBox1.Text }', Имя = N'{ textBox2.Text }', Отчество = N'{ textBox3.Text }', Инициалы = N'{textBox4.Text}',Телефон = '{ maskedTextBox1.Text }', Дата_Рождения = '{ dateTimePicker1.Value }', Адрес = N'{ textBox6.Text }' Where Номер_билета = { Saver.Values[0]}";
                dc.AddorUpgr(query, "Изменено");
                Saver.FormEnabler();
                Hide();
            }
            else if (isExist)
            {
                MessageBox.Show("Наличие одинакового номера телефона у 2 человек невозможно");
                return;
            }
            else if (Saver.FormFunctionName == "Добавить")
            {
                query = $"Insert into Readers values(N'{ textBox1.Text }', N'{ textBox2.Text }', N'{ textBox3.Text}', N'{textBox4.Text}','{ maskedTextBox1.Text }', '{ dateTimePicker1.Value }', N'{ textBox6.Text }')";
                dc.AddorUpgr(query, "Добавлено");
                Saver.FormEnabler();
                Hide();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            InitialsMaking();
        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            InitialsMaking();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            InitialsMaking();
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            InitialsMaking();
        }

        private void InitialsMaking()
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                return;
            }
            else
            {
                initial = $"{textBox1.Text}.{textBox2.Text[0]}.{textBox3.Text[0]}";
                textBox4.Text = initial;
            }
        }
    }
}
