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
    public partial class AddEditPracownikDialog : Form
    {
        private Pracownik pracownikDoEdycji;
        public AddEditPracownikDialog()
        {
            InitializeComponent();
        }
        public AddEditPracownikDialog(Pracownik pracownik)
        {
            InitializeComponent();
            titleLabel.Text = "Edytuj Studenta";
            imieTextBox.Text = pracownik.Imie;
            nazwiskoTextBox.Text = pracownik.Nazwisko;
            emailTextBox.Text = pracownik.Email;
            dataUrodzeniaPicker.Value = pracownik.DataUrodzenia;
            pracownikDoEdycji = pracownik;
        }

        private void anulujButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if(emailTextBox.Text == "")
            {
                MessageBox.Show("Email jest wymagany");
                return;
            }
            //walidacja
            var dataUrodzenia = dataUrodzeniaPicker.Value;
            var con = new SqlConnection(Constants.ConnectionString);
            var com = new SqlCommand();
            com.Connection = con;
            if(pracownikDoEdycji == null)
            {
                com.CommandText = "insert into Pracownik(Imie, Nazwisko, Email, DataUrodzenia) values (@imie, @nazwisko, @email, @dataURodzenia)";
            }
            else
            {
                com.CommandText = "Update Pracownik " +
                    "Set imie = @imie" +
                    ",nazwisko = @nazwisko" +
                    ",email = @email," +
                    "dataUrodzenia = @dataUrodzenia where IdPracownik = @idPracownik";
                com.Parameters.AddWithValue("@idPracownik", pracownikDoEdycji.PracownikId);

            }

            com.Parameters.AddWithValue("@imie", imieTextBox.Text);
            com.Parameters.AddWithValue("@nazwisko", nazwiskoTextBox.Text);
            com.Parameters.AddWithValue("@email", emailTextBox.Text);
            com.Parameters.AddWithValue("@dataUrodzenia", dataUrodzenia);
            

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            Close();

        }
    }
}
