using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Sortowanie
    {
        private List<int> lista;
        public List<int> sortuj(List<int> L)
        {
            return lista;
        }
    }
    public class Babelek: Sortowanie
    {
        public List <int> sortuj(List<int> L)
        {
            for (int i = 0; i < L.Count()-1; i++)
            {
                for (int j = 0; j < L.Count()-1; j++)
                {
                    if (L[j] > L[j+1])
                    {
                        int tmp = L[j + 1];
                        L[j + 1] = L[j];
                        L[j] = tmp;
                    }
                }
            }
            return L;
        }
    }
    public class Debilne : Sortowanie
    {
        public List<int> sortuj(List<int> L)
        {
            L.Sort();
            return L;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>() { 7, 3, 2, 5, 1 };
            Babelek B = new Babelek();
            List<int> WYN = new List<int>();
            B.wyswietl(K);
            WYN = B.sortuj(K);
            B.wyswietl(WYN);


            Console.WriteLine();
            Debilne d = new Debilne();
            d.wyswietl(K);
            WYN = d.sortuj(K);
            d.wyswietl(WYN);

        }
    }
}
