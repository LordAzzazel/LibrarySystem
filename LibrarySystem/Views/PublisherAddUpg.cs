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
    public partial class PublisherAddUpg : Form
    {
        private string query;
        DatabaseConnection dc;
        private DateTime today;
        public PublisherAddUpg()
        {
            InitializeComponent();
            dc = new DatabaseConnection();
        }

        private void PublisherAddUpg_Load(object sender, EventArgs e)
        {
            if (Saver.FormName == "Изменение")
            {
                textBox1.Text = Saver.Values[1];
                textBox2.Text = Saver.Values[2];
                maskedTextBox1.Text = Saver.Values[3];
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Saver.FormEnabler();
            Hide();
        }

        private void PublisherAddUpg_Activated(object sender, EventArgs e)
        {
            FormNameLabel.Text = Saver.FormName + "\nиздательства";
            btnAddUpg.Text = Saver.FormFunctionName;
        }

        private void btnAddUpg_Click(object sender, EventArgs e)
        {
            if(maskedTextBox1.MaskCompleted == false)
            {
                MessageBox.Show("Заполните поле год до конца");

            }
            today = DateTime.Today;
            if (maskedTextBox1.MaskCompleted)
            {
                if(int.Parse(maskedTextBox1.Text) < 1700)
                {
                    MessageBox.Show("Слишком ранняя дата");
                    return;
                }
                else if(today.Year < int.Parse(maskedTextBox1.Text))
                {
                    MessageBox.Show("Данный год ещё даже не произошёл");
                    return;
                }
                else
                {
                    if (Saver.FormFunctionName == "Добавить")
                    {
                        query = $"Insert into Publishers values(N'{ textBox1.Text }', N'{ textBox2.Text }', N'{ maskedTextBox1.Text}')";
                        dc.AddorUpgr(query, "Добавлено");
                        Saver.FormEnabler();
                        Hide();
                    }
                    else if (Saver.FormFunctionName == "Изменить")
                    {
                        query = $"Update Publishers Set Наименование = N'{ textBox1.Text }', Описание = N'{ textBox2.Text }', Год_создания = N'{ maskedTextBox1.Text}' Where Id = { Saver.Values[0]}";
                        dc.AddorUpgr(query, "Изменено");
                        Saver.FormEnabler();
                        Hide();
                    }
                }
            }

        }
    }
}
