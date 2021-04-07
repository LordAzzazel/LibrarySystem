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
    public partial class LibrarianAddUpg : Form
    {
        private string query;
        DatabaseConnection dc;
        public LibrarianAddUpg()
        {
            InitializeComponent();
            dc = new DatabaseConnection();
        }

        private void LibrarianAddUpg_Load(object sender, EventArgs e)
        {
            if(Saver.FormName == "Изменение")
            {
                UserNameTxt.Text = Saver.Values[1];
                LoginTxt.Text = Saver.Values[2];
                PasBox.Text = Saver.Values[3];
            }
        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            Saver.FormEnabler();
            Hide();
        }

        private void LibrarianAddUpg_Activated(object sender, EventArgs e)
        {
            FormNameLabel.Text = Saver.FormName + "\nбиблиотекаря";
            btnAddUpg.Text = Saver.FormFunctionName;
        }

        private void btnAddUpg_Click(object sender, EventArgs e)
        {
            if(Saver.FormFunctionName == "Добавить")
            {
                query = $"Insert into Users values(N'{ UserNameTxt.Text }', N'{ LoginTxt.Text }', N'{ PasLabel.Text}', N'Библиотекарь')";
                dc.AddorUpgr(query, "Добавлено");
                Saver.FormEnabler();
                Hide();
            }
            else if (Saver.FormFunctionName == "Изменить")
            {
                query = $"Update Users Set Name = N'{ UserNameTxt.Text }', Login = N'{ LoginTxt.Text }', Password = N'{ PasBox.Text}', Role = N'Библиотекарь' Where Id = { Saver.Values[0]}";
                dc.AddorUpgr(query, "Изменено");
                Saver.FormEnabler();
                Hide();
            }
        }
    }
}
