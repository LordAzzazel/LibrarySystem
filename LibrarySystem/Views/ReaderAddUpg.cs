﻿using LibrarySystem.Service;
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
        private string query;
        DatabaseConnection dc;
        public ReaderAddUpg()
        {
            InitializeComponent();
            dc = new DatabaseConnection();
        }

        private void ReaderAddUpg_Load(object sender, EventArgs e)
        {
            if (Saver.FormName == "Изменение")
            {
                textBox1.Text = Saver.Values[1];
                textBox2.Text = Saver.Values[2];
                textBox3.Text = Saver.Values[3];
                textBox4.Text = Saver.Values[4];
                dateTimePicker1.Text = Saver.Values[5];
                textBox6.Text = Saver.Values[6];
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
            if (Saver.FormFunctionName == "Добавить")
            {
                query = $"Insert into Readers values(N'{ textBox1.Text }', N'{ textBox2.Text }', N'{ textBox3.Text}', { textBox4.Text }, '{ dateTimePicker1.Value }', N'{ textBox6.Text }')";
                dc.AddorUpgr(query, "Добавлено");
                Saver.FormEnabler();
                Hide();
            }
            else if (Saver.FormFunctionName == "Изменить")
            {
                query = $"Update Readers Set Фамилия = N'{ textBox1.Text }', Имя = N'{ textBox2.Text }', Отчество = N'{ textBox3.Text }', Телефон = { textBox4.Text }, Дата_Рождения = '{ dateTimePicker1.Value }', Адрес = N'{ textBox6.Text }' Where Номер_билета = { Saver.Values[0]}";
                dc.AddorUpgr(query, "Изменено");
                Saver.FormEnabler();
                Hide();
            }
        }
    }
}