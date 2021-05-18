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
    public partial class FormTableShower : Form
    {
        private string Adding = "Добавление", Updating = "Изменение";
        private string query, tableName, idName, searchValues, delCheckQuery; 
        private Form form;
        private List<string> sells;
        private DateTime today;
        public Form Form { get; set; }

        DatabaseConnection dc = new DatabaseConnection(); 
        public FormTableShower()
        {
            InitializeComponent();
            sells = new List<string>();
        }
        private void FormTableShower_Load(object sender, EventArgs e)
        {
            btnNeedToReturn.Visible = false;
            dataGridView1.ReadOnly = true;
            Saver.TableShower = this;
            CheckerTableShower();
        }
        private void FormTableShower_EnabledChanged(object sender, EventArgs e)
        {
            CheckerTableShower();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Saver.FormDisabler();
            Saver.FormName = Adding;
            Saver.FormFunctionName = "Добавить";
            if (form is GivenBookAddUpg)
            {
                Saver.FormName = "Выдача";
                Saver.FormFunctionName = "Выдать";
            }
            sells.Add("0");
            Saver.Values = sells;
            form.Show();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            FillCells(sells);
            Saver.FormDisabler();
            Saver.FormName = Updating;
            Saver.FormFunctionName = "Изменить";
            if (form is GivenBookAddUpg)
            {
                Saver.FormName = "Продление";
                Saver.FormFunctionName = "Продлить";
            }
            form.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            idName = "Id";
            DelQueryChecker();
            bool isExist = dc.isExist(delCheckQuery);
            if (form is GivenBookAddUpg || form is LibrarianAddUpg)
            {
                isExist = false;
            }
            else if (isExist)
            {
                MessageBox.Show("Данное значение связано и не может быть удалено");
                return;
            }
            else if (form is ReaderAddUpg)
            {
                idName = "Номер_билета";
            }
            query = $"Delete from {tableName} where {idName} = {dataGridView1.CurrentRow.Cells[0].Value}";
            dc.Delete(query);
            if (Saver.Status == "Выданные книги" && Saver.StateStop == false)
            {
                string bookId = dc.GetItemId(dataGridView1.CurrentRow.Cells[1].Value.ToString(), "Название_книги", "Books");
                int bookNumber = dc.GetBookQuontity(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                dc.BookNumberChanger(bookNumber, int.Parse(bookId), Adding);

            }
            CheckerTableShower();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                SearchValuesChecker();
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format(searchValues);
            }
            catch (Exception)
            {
                
            }
        }

        private void btnNeedToReturn_Click(object sender, EventArgs e)
        {
            today = DateTime.Today;
            if(btnNeedToReturn.Text == "Просроченные")
            {
                string date = today.ToString("MM/dd/yyyy");
                query = $"Select GivenBooks.Id, Books.Название_книги as [Название книги], GivenBooks.Дата_сдачи as [Дата сдачи], GivenBooks.Номер_Билета_Читателя as [Номер билета читателя], Readers.Фамилия, Readers.Имя, Readers.Отчество, Readers.Телефон from GivenBooks inner join Books on GivenBooks.Название_Книги = Books.Id inner join Readers on GivenBooks.Номер_Билета_Читателя = Readers.Номер_билета Where GivenBooks.Дата_сдачи < '{date}'";
                bool isExist = dc.isExist(query);
                if (isExist == false)
                {
                    MessageBox.Show("Нет просроченных книг");
                    return;
                }
                dc.ShowTable(query, dataGridView1);
                btnNeedToReturn.Text = "Отменить";
            }
            else if(btnNeedToReturn.Text == "Отменить")
            {
                CheckerTableShower();
                btnNeedToReturn.Text = "Просроченные";
            }
        }

        private void FormTableShower_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Close();
        }


        private void CheckerTableShower()
        {
            switch (Saver.Status)
            {
                case "Книги":
                    query = "Select Books.Id, Books.Название_книги as [Название книги], Authors.Инициалы as Автор, Books.Год, Publishers.Наименование, Books.Количество from Books inner join Authors on Books.Автор = Authors.Id inner join Publishers on Books.Издательство = Publishers.Id";
                    tableName = "Books";
                    BookAddUpg bookAdd = new BookAddUpg();
                    form = bookAdd;
                    break;
                case "Читатели":
                    query = "Select * from Readers";
                    tableName = "Readers";
                    ReaderAddUpg reader = new ReaderAddUpg();
                    form = reader;
                    break;
                case "Выданные книги":
                    query = "Select GivenBooks.Id, Books.Название_книги as [Название книги], GivenBooks.Дата_сдачи as [Дата сдачи], GivenBooks.Номер_Билета_Читателя as [Номер билета читателя], Readers.Фамилия, Readers.Имя, Readers.Отчество, Readers.Телефон from GivenBooks inner join Books on GivenBooks.Название_Книги = Books.Id inner join Readers on GivenBooks.Номер_Билета_Читателя = Readers.Номер_билета";
                    tableName = "GivenBooks";
                    btnNeedToReturn.Visible = true;
                    GivenBookAddUpg givenBook = new GivenBookAddUpg();
                    btnAdd.Text = "Выдать";
                    btnUpd.Text = "Продлить";
                    btnDel.Text = "Вернуть";
                    form = givenBook;
                    break;
                case "Авторы":
                    query = "Select * from Authors";
                    tableName = "Authors";
                    AuthorAddUpg author = new AuthorAddUpg();
                    form = author;
                    break;
                case "Издательства":
                    query = "Select * from Publishers";
                    tableName = "Publishers";
                    PublisherAddUpg publisher = new PublisherAddUpg();
                    form = publisher;
                    break;
                case "Библиотекари":
                    query = "Select * from Users";
                    tableName = "Users";
                    LibrarianAddUpg librarian = new LibrarianAddUpg();
                    form = librarian;
                    break;
            }
            dc.ShowTable(query, dataGridView1);
            dataGridView1.Columns[0].Visible = false;
            if(form is ReaderAddUpg) { dataGridView1.Columns[0].Visible = true; }
        }


        private void FillCells(List<string> sell)
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                sell.Add(dataGridView1.CurrentRow.Cells[i].Value.ToString());
            }
            Saver.Values = sell;
        }

        private void SearchValuesChecker()
        {
            switch (Saver.Status)
            {
                case "Книги":
                    searchValues = $"[{dataGridView1.Columns[1].HeaderText}] LIKE '%{textBox1.Text}%' OR [{dataGridView1.Columns[2].HeaderText}] LIKE '%{textBox1.Text}%' OR Convert([{dataGridView1.Columns[3].HeaderText}], 'System.String') LIKE '%{textBox1.Text}%' OR [{dataGridView1.Columns[4].HeaderText}] LIKE '%{textBox1.Text}%' OR Convert([{dataGridView1.Columns[5].HeaderText}], 'System.String') LIKE '%{textBox1.Text}%'";
                    break;
                case "Читатели":
                    searchValues = $"Convert([{dataGridView1.Columns[0].HeaderText}], 'System.String') LIKE '%{textBox1.Text}%' OR [{dataGridView1.Columns[1].HeaderText}] LIKE '%{textBox1.Text}%' OR [{dataGridView1.Columns[2].HeaderText}] LIKE '%{textBox1.Text}%' OR [{dataGridView1.Columns[3].HeaderText}] LIKE '%{textBox1.Text}%' OR [{dataGridView1.Columns[4].HeaderText}] LIKE '%{textBox1.Text}%' OR Convert([{dataGridView1.Columns[5].HeaderText}], 'System.String') LIKE '%{textBox1.Text}%' OR Convert([{dataGridView1.Columns[6].HeaderText}], 'System.String') LIKE '%{textBox1.Text}%' Or Convert([{dataGridView1.Columns[7].HeaderText}], 'System.String') LIKE '%{textBox1.Text}%'";
                    break;
                case "Выданные книги":
                    searchValues = $"[{dataGridView1.Columns[1].HeaderText}] LIKE '%{textBox1.Text}%' OR Convert([{dataGridView1.Columns[2].HeaderText}], 'System.String') LIKE '%{textBox1.Text}%' OR Convert([{dataGridView1.Columns[3].HeaderText}], 'System.String') LIKE '%{textBox1.Text}%' OR [{dataGridView1.Columns[4].HeaderText}] LIKE '%{textBox1.Text}%' OR [{dataGridView1.Columns[5].HeaderText}] LIKE '%{textBox1.Text}%' OR [{dataGridView1.Columns[6].HeaderText}] LIKE '%{textBox1.Text}%' OR [{dataGridView1.Columns[7].HeaderText}] LIKE '%{textBox1.Text}%'";
                    break;
                case "Авторы":
                    searchValues = $"[{dataGridView1.Columns[1].HeaderText}] LIKE '%{textBox1.Text}%' OR [{dataGridView1.Columns[2].HeaderText}] LIKE '%{textBox1.Text}%' OR [{dataGridView1.Columns[3].HeaderText}] LIKE '%{textBox1.Text}%' OR [{dataGridView1.Columns[4].HeaderText}] LIKE '%{textBox1.Text}%' OR Convert([{dataGridView1.Columns[5].HeaderText}], 'System.String') LIKE '%{textBox1.Text}%'";
                    break;
                case "Издательства":
                    searchValues = $"[{dataGridView1.Columns[1].HeaderText}] LIKE '%{textBox1.Text}%' OR [{dataGridView1.Columns[2].HeaderText}] LIKE '%{textBox1.Text}%' OR Convert([{dataGridView1.Columns[3].HeaderText}], 'System.String') LIKE '%{textBox1.Text}%'";
                    break;
                case "Библиотекари":
                    searchValues = $"[{dataGridView1.Columns[1].HeaderText}] LIKE '%{textBox1.Text}%' OR [{dataGridView1.Columns[2].HeaderText}] LIKE '%{textBox1.Text}%' OR [{dataGridView1.Columns[3].HeaderText}] LIKE '%{textBox1.Text}%' OR [{dataGridView1.Columns[4].HeaderText}] LIKE '%{textBox1.Text}%'";
                    break;
            }
        }
        private void DelQueryChecker()
        {
            switch (Saver.Status)
            {
                case "Книги":
                    delCheckQuery = $"Select * from GivenBooks Where Название_Книги = { dataGridView1.CurrentRow.Cells[0].Value}";
                    break;
                case "Читатели":
                    delCheckQuery = $"Select * from GivenBooks Where Номер_Билета_Читателя = { dataGridView1.CurrentRow.Cells[0].Value }";
                    break;
                case "Выданные книги":
                    delCheckQuery = $"Select * from GivenBooks";
                    break;
                case "Авторы":
                    delCheckQuery = $"Select * from Books Where Автор = {dataGridView1.CurrentRow.Cells[0].Value}";
                    break;
                case "Издательства":
                    delCheckQuery = $"Select * from Books Where Издательство = {dataGridView1.CurrentRow.Cells[0].Value}";
                    break;
                case "Библиотекари":
                    delCheckQuery = $"Select * from Users";
                    break;
            }
        }


    }
}
