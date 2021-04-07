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
        private string query, tableName;
        private Form form;
        private List<string> sells;

        public Form Form { get; set; }

        DatabaseConnection dc = new DatabaseConnection(); 
        public FormTableShower()
        {
            InitializeComponent();
            sells = new List<string>();
        }
        private void FormTableShower_Load(object sender, EventArgs e)
        {
            Saver.TableShower = this;
            Checker();
        }
        private void FormTableShower_EnabledChanged(object sender, EventArgs e)
        {
            Checker();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Saver.FormDisabler();
            Saver.FormName = Adding;
            Saver.FormFunctionName = "Добавить";
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
            form.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            query = $"Delete from {tableName} where Id = {dataGridView1.CurrentRow.Cells[0].Value}";
            dc.Delete(query);
            Checker();
        }
        private void FormTableShower_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Close();
        }


        private void Checker()
        {
            switch (Saver.Status)
            {
                case "Книги":
                    query = "Select Books.Id, Books.Название_книги, Authors.Инициалы as Автор, Books.Год, Publishers.Наименование, Books.Количество from Books inner join Authors on Books.Автор = Authors.Id inner join Publishers on Books.Издательство = Publishers.Id";
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
                    query = "Select GivenBooks.Id, GivenBooks.Номер_Билета_Читателя, Books.Название_книги from GivenBooks inner join Books on GivenBooks.Название_Книги = Books.Id";
                    tableName = "Books";
                    BookAddUpg bookk = new BookAddUpg();
                    form = bookk;
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
        }


        private void FillCells(List<string> sell)
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                sell.Add(dataGridView1.CurrentRow.Cells[i].Value.ToString());
            }
            Saver.Values = sell;
        }

    }
}
