using PJATK3_2.Models;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PobierzPracownikow();

        }
        private void PobierzPracownikow()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-LQFAVEE;Initial Catalog=API_L4;Integrated Security=True");
            SqlCommand com = new SqlCommand();
            var sql = "select * from Pracownik";
            com.Connection = con;
            com.CommandText = sql;

            //2. Otwarcie połączenia
            con.Open();

            //3. Wykonanie zapytania
            SqlDataReader dr = com.ExecuteReader();
            var pracownicy = new List<Pracownik>();
            //4. Odczyt rezultatu
            while(dr.Read() == true)
            {
                pracownicy.Add(new Pracownik()
                {
                    Imie = dr["Imie"].ToString(),
                    Nazwisko = dr["Nazwisko"].ToString(),
                    Email = dr["Email"].ToString()
                });
            }
            dataGridView1.DataSource = pracownicy;
            //5. Zamknięcie połączenia
            con.Dispose();
        }
        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
