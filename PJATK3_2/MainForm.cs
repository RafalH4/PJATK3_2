using PJATK3_2.Models;
using System.Data;
using System.Data.SqlClient;

namespace PJATK3_2
{
    public partial class MainForm : Form
    {
        public MainForm(string login)
        {
            InitializeComponent();
            loginLabel.Text = login;
            PobierzPracownikow();

        }
        private void PobierzPracownikow()
        {
            using SqlConnection con = new SqlConnection(Constants.ConnectionString);
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
            while (dr.Read() == true)
            {
                pracownicy.Add(new Pracownik()
                {
                    Imie = dr["Imie"].ToString(),
                    Nazwisko = dr["Nazwisko"].ToString(),
                    Email = dr["Email"].ToString(),
                    PracownikId = (int)dr["IdPracownik"],
                    DataUrodzenia = DateTime.Parse(dr["DataUrodzenia"].ToString())
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

        private void usunButton_Click(object sender, EventArgs e)
        {
            //1. Pobrac dane pracownika z tabeli
            var selectedRows = dataGridView1.SelectedRows;
            if (selectedRows.Count !=1)
            {
                MessageBox.Show("Musisz zaznaczyć jeden wiersz");
            }
            else
            {
                var pracownik = selectedRows[0].DataBoundItem as Pracownik;

                //2 Wywolac procedurę
                using SqlConnection con = new SqlConnection(Constants.ConnectionString);
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "UsunPracownika";
                com.Parameters.AddWithValue("@IdPracownik", pracownik.PracownikId);
                con.Open();
                com.ExecuteNonQuery();
                PobierzPracownikow();
            }


        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            var okno = new AddEditPracownikDialog();
            okno.ShowDialog();
            PobierzPracownikow();
        }

        private void edytujButton_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridView1.SelectedRows;
            if (selectedRows.Count !=1)
            {
                MessageBox.Show("Musisz zaznaczyć jeden wiersz");
            }
            else
            {
                var pracownik = selectedRows[0].DataBoundItem as Pracownik;
                var okno = new AddEditPracownikDialog(pracownik);
                okno.ShowDialog();
                PobierzPracownikow();
            }

        }
    }
}
