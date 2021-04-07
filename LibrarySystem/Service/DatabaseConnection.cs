using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.Service
{
    class DatabaseConnection
    {

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Library.mdf;Integrated Security=True");
/*        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lebed\source\repos\LibrarySystem\LibrarySystem\Library.mdf;Integrated Security=True");
*/

        public string SqlCheck(string query)
        {
            using (sqlConnection)
            {
                SqlCommand command = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        return reader.GetString(4);
                    }
                }
                else
                {
                    sqlConnection.Close();
                    return null;
                }
                reader.Close();
                return null;
            }

        }
        public void ShowTable(string query, DataGridView dg)
        {
            sqlConnection.Open();
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dg.DataSource = dt;
            sqlConnection.Close();
        }

        public void AddorUpgr(string query, string add)
        {
            sqlConnection.Open();
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            SDA.SelectCommand.ExecuteNonQuery();
            MessageBox.Show(add);
            sqlConnection.Close();
        }
        public void Delete(string query)
        {
            const string message = "Вы уверены?";
            const string caption = "Удаление";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                sqlConnection.Open();
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
                SDA.SelectCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }

        }
        public void FillCombobox(string query, ComboBox comboBox, int column)
        {
            sqlConnection.Open();
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            DataSet ds = new DataSet();
            SDA.Fill(ds);
            comboBox.DataSource = ds.Tables[column];
            sqlConnection.Close();
        }

        
    }
}
