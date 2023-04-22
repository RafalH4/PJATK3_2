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
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-LQFAVEE;Initial Catalog=API_L4;Integrated Security=True");
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "Select * from uzytkownik";

            //2. Otwarcie połączenia
            con.Open();

            //3. Wykonanie zapytania
            SqlDataReader dr = com.ExecuteReader();

            //4. Odczyt rezultatu
            while (dr.Read())
            {
                string login = dr["Login"].ToString();
                int iUzytkownika = (int)dr["IdUzytkownik"];
                MessageBox.Show(login);
            }

            //5. Zamknięcie połączenia
            con.Dispose();

            var sql = $"select * from osoba where login ='{loginTextBox.Text}' and haslo = '{hasloTextBox.Text}'";
        }
    }
}
