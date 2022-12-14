 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2e1
{
        internal class Rower
        {
            private Producent producent;
            private string kolor;
            private Material material;
            public void jedz()
            {
                Console.WriteLine("Jedź");
            }
            public void setColor(string akolor)
            {
                this.kolor = akolor;
            }
            public string getColor()
            {
                return this.kolor;
            }
            public void setMaterial(Material amaterial)
            {
            this.material = amaterial;
            }
            public Rower(Producent aproducent)
            {
                this.producent = aproducent;
            }
        }
        internal class Producent
        {
            private string nazwa;
            private string nip;
            public string getNazwa()
            {
                return this.nazwa;
            }
            public string getNip()
            {
                return this.nip;
            }
            public void setNazwa(string anazwa)
            {
                this.nazwa = anazwa;
            }
        }
        internal class Material
        {
            private string typ;
            private int id;
            private double cena;
            public void setTyp(string atyp)
            {
                this.typ = atyp;
            }
            public string getTyp()
            {
                return this.typ;
            }
            public double getCena()
            {
                return this.cena;
            }
            public void setId(int aid)
            {
                this.id = aid;
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                
                Material m = new Material();
                Producent p = new Producent();
                Rower r = new Rower(p);
                p.setNazwa("Wigry");
                r.setColor("czerwony");
                m.setTyp("fajny");
                m.setId(123);
                Console.WriteLine($"Rowe jest {p.getNazwa()} o kolorze {r.getColor()} ma typ {m.getTyp()}");
            }
        }
}
