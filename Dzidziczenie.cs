using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Pojazd
    {
        private string nazwa;
        private string vin;
        public void jedz()
        {
            Console.WriteLine("Jadę!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        }
        public void tankuj()
        {
            Console.WriteLine("TANKUJE!!!!!!!!!!!");
        }
    }
    public class Samochód : Pojazd
    {
        private string oc;
        public void zaparkuj()
        {
            Console.WriteLine("PARKUJE!!!");
        }
    }
    public class Motur : Pojazd
    {
        public void zalozKask()
        {
            Console.WriteLine("ZAKŁADAM!!!");
        }
    }
    public class Koparka : Pojazd
    {
        private string udt;
        public void kop()
        {
            Console.WriteLine("KOPIE!!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Samochód s1 = new Samochód();
            Motur m1 = new Motur();
            Koparka k1 = new Koparka();
            s1.jedz();
            s1.tankuj();
            m1.tankuj();
            m1.zalozKask();
            k1.tankuj();
            k1.kop();
        }
    }
}
