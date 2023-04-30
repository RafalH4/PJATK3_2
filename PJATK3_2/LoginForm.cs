using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJATK3_2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(loginTextBox.Text == "" || hasloTextBox.Text == "")
            {
                MessageBox.Show("Wprowadź login i hasło");
                return;
            }
            //1. Konfiguracja połączenia i zapytania
            SqlConnection con = new SqlConnection(Constants.ConnectionString);
            SqlCommand com = new SqlCommand();
            var sql = "select * from uzytkownik where login =@login and haslo = @haslo";
            com.Connection = con;
            com.CommandText = sql;
            com.Parameters.AddWithValue("@login", loginTextBox.Text);
            com.Parameters.AddWithValue("@haslo", hasloTextBox.Text);

            //2. Otwarcie połączenia
            con.Open();

            //3. Wykonanie zapytania
            SqlDataReader dr = com.ExecuteReader();

            //4. Odczyt rezultatu
            if (dr.Read())
            {
                string login = dr["Login"].ToString();
                //int iUzytkownika = (int)dr["IdUzytkownik"];
                MessageBox.Show("Zalogowano poprawnie");
                var glowneOkno = new MainForm(login);
                //Hide();
                glowneOkno.Show();
            }
            else
            {
                MessageBox.Show("Niepoprawny login/hasło");
            }

            //5. Zamknięcie połączenia
            con.Dispose();

        }
    }
}
