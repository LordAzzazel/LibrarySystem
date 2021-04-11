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
    public partial class GivenBookAddUpg : Form
    {
        private string query, tableReader, tableBook, readerId, bookId;
        private int bookNumber;
        DatabaseConnection dc;

        public GivenBookAddUpg()
        {
            InitializeComponent();
            dc = new DatabaseConnection();
            tableReader = "Readers";
            tableBook = "Books";
        }
        private void GivenBookAddUpg_Load(object sender, EventArgs e)
        {
            string readerssQuery = $"Select * from { tableReader }";
            string booksQuery = $"Select * from { tableBook }";
            dc.FillCombobox(readerssQuery, comboBox1, "Инициалы");
            dc.FillCombobox(booksQuery, comboBox2, "Название_книги");
            if (Saver.FormName == "Продление")
            {
                ReaderNumberLabel.Text = "Номер билета:";
                comboBox1.Text = Saver.Values[3];
                comboBox2.Text = Saver.Values[1];
                dateTimePicker1.Text = Saver.Values[2];
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Saver.FormEnabler();
            Hide();
        }
        private void GivenBookAddUpg_Activated(object sender, EventArgs e)
        {
            FormNameLabel.Text = Saver.FormName + " книги";
            btnAddUpg.Text = Saver.FormFunctionName;
        }
        private void btnAddUpg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                bool check1 = Saver.ComboboxChecker(comboBox1);
                bool check2 = Saver.ComboboxChecker(comboBox2);
                bookId = dc.GetItemId(comboBox2.Text, "Название_книги", tableBook);
                readerId = dc.GetItemId(comboBox1.Text, "Инициалы", tableReader);
                if (Saver.FormFunctionName == "Выдать" && check1 && check2)
                {
                    bookNumber = dc.GetBookQuontity(comboBox2.Text);
                    if (bookNumber <= 0)
                    {
                        MessageBox.Show("Данной книги нет в наличии");
                    }
                    else if (dc.isBookGiven(bookId, readerId))
                    {
                        MessageBox.Show("Данная книга уже выдана этому читателю");
                    }
                    else
                    {
                        query = $"Insert into GivenBooks values(N'{ readerId }', N'{ bookId }', '{ dateTimePicker1.Value }')";
                        dc.BookNumberChanger(bookNumber, int.Parse(bookId));
                        dc.AddorUpgr(query, "Выдано");
                        Saver.FormEnabler();
                        Hide();
                    }

                }
                else if (Saver.FormFunctionName == "Продлить")
                {
                    query = $"Update GivenBooks Set Номер_Билета_Читателя = { comboBox1.Text }, Название_Книги = { bookId }, Дата_сдачи = '{ dateTimePicker1.Value }' Where Id = { Saver.Values[0]}";
                    dc.AddorUpgr(query, "Продлено");
                    Saver.FormEnabler();
                    comboBox1.Enabled = true;
                    comboBox2.Enabled = true;
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
