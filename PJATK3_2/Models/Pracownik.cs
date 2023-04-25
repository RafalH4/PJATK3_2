using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJATK3_2.Models
{
    internal class Pracownik
    {
        private int _pracownikId;
        public int PracownikId
        {
            get { return _pracownikId; }
            set { _pracownikId = value; }
        }

        private string _imie;
        public string Imie
        {
            get { return _imie; }
            set { _imie = value; }
        }

        private string _nazwisko;
        public string Nazwisko
        {
            get { return _nazwisko; }
            set { _nazwisko = value; }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }




    }
}
