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
        private string query, tableAuth, tablePub, itemId, itemId2;
        DatabaseConnection dc;
        public BookAddUpg()
        {
            InitializeComponent();
            dc = new DatabaseConnection();
            tableAuth = "Authors";
            tablePub = "Publishers";
        }


        private void BookAddUpg_Load(object sender, EventArgs e)
        {
            string authorsQuery = $"Select * from { tableAuth }";
            string publisherQuery = $"Select * from { tablePub }";
            dc.FillCombobox(authorsQuery, comboBox1, "Инициалы");
            dc.FillCombobox(publisherQuery, comboBox2, "Наименование");
            if (Saver.FormName == "Изменение")
            {
                textBox1.Text = Saver.Values[1];
                comboBox1.Text = Saver.Values[2];
                maskedTextBox1.Text = Saver.Values[3];
                comboBox2.Text = Saver.Values[4];
                textBox5.Text = Saver.Values[5];
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
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
        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                return;
            }
            else
            {
                if (int.Parse(textBox5.Text) <= 0)
                {
                    btnAddUpg.Enabled = false;
                    MessageBox.Show("Количество книг не может быть ниже 1");
                }
                else
                {
                    btnAddUpg.Enabled = true;
                }
            }
        }

        private void btnAddUpg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text))
            {
                return;
            }
            else
            {
                bool check1 = Saver.ComboboxChecker(comboBox1);
                bool check2 = Saver.ComboboxChecker(comboBox2);
                itemId = dc.GetItemId(comboBox1.Text, "Инициалы", tableAuth);
                itemId2 = dc.GetItemId(comboBox2.Text, "Наименование", tablePub);
                if (Saver.FormFunctionName == "Добавить" && check1 && check2)
                {
                    query = $"Insert into Books values(N'{ textBox1.Text }', { itemId }, { maskedTextBox1.Text}, { itemId2 }, { textBox5.Text })";
                    dc.AddorUpgr(query, "Добавлено");
                    Saver.FormEnabler();
                    Hide();
                }
                else if (Saver.FormFunctionName == "Изменить" && check1 && check2)
                {
                    query = $"Update Books Set Название_книги = N'{ textBox1.Text }', Автор = { itemId }, Год = { maskedTextBox1.Text}, Издательство = { itemId2 }, Количество = { textBox5.Text} Where Id = { Saver.Values[0]}";
                    dc.AddorUpgr(query, "Изменено");
                    Saver.FormEnabler();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Введите существующие значения");
                }
            }

        }
    }
}
