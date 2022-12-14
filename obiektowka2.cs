using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace _2e1
{
    internal class Produkt
    {
        private string nazwa;
        private double cena;
        private string opis;
        public string getNazwa()
        {
            return this.nazwa;
        }
        public double getCena()
        {
            return this.cena;
        }
        public string getOpis()
        {
            return this.opis;
        }
        public Produkt(string anazwa, double acena, string aopis)
        {
            this.nazwa = anazwa;
            this.cena = acena;
            this.opis = aopis;
        }
    }
    internal class Profil
    {
        private string imie;
        private string drugieimie;
        private string nazwisko;
        public string getImie()
        {
            return this.imie;
        }
        public string getNazwisko()
        {
            return this.nazwisko;
        }
    }
    internal class Uzytkownik
    {
        private string login;
        private string haslo;
        private Profil profil;
        public void loguj()
        {
            Console.WriteLine("Logowanie");
        }
        public Uzytkownik(Profil aprofil)
        {
            this.profil = aprofil;
        }
    }
    internal class Koszyk
    {
        private int id;
        private Produkt produkt;
        private Uzytkownik uzytkownik;
        public int getId()
        {
            return this.id;
        }
        public void operation()
        {
            Console.WriteLine("Operacja");
        }
        public Koszyk(Produkt aprodukt)
        {
            this.produkt = aprodukt;
        }
        public void setUzytkownik(Uzytkownik auzytkownik)
        {
            this.uzytkownik = auzytkownik;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Produkt p = new Produkt("produkt", 420, "opis");
            Profil prof = new Profil();
            Uzytkownik u = new Uzytkownik(prof);
            Koszyk k = new Koszyk(p);
        }
    }
}
