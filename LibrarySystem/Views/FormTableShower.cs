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
        private string query;

        public Form Form { get; set; }

        DatabaseConnection dc = new DatabaseConnection(); 
        public FormTableShower()
        {
            InitializeComponent();
        }
        private void FormTableShower_Load(object sender, EventArgs e)
        {
            Checker();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            BookAddUpg bookAddUpg = new BookAddUpg(btnAdd.Text, Adding);
            bookAddUpg.Show();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            BookAddUpg bookAddUpg = new BookAddUpg(btnUpd.Text, Updating);
            bookAddUpg.Show();
        }


        private void Checker()
        {
            switch (Saver.Status)
            {
                case "Книги":
                    query = "Select * from Books";
                    break;
                case "Читатели":
                    query = "Select * from Readers";
                    break;
                case "Выданные книги":
                    query = "Select * from GivenBooks";
                    break;
                case "Авторы":
                    query = "Select * from Authors";
                    break;
                case "Издательства":
                    query = "Select * from Publishers";
                    break;
                case "Библиотекари":
                    query = "Select * from Users";
                    break;
            }
            dc.ShowTable(query, dataGridView1);
        }
    }
}
