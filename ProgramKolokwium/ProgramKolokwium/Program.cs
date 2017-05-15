using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramKolokwium
{
    class Program
    {

        public void UstawPunkt (int PierwszaWspolrzedna, int DrugaWspolrzedna)
        {
            
        }

        public int ObliczBokProstokata ()
        {
            return 0;
        }


        static void Main(string[] args)
        {

            String WybranaFigura;
            int PierwszaW, DrugaW;



            Console.WriteLine("T - trapez prostokatny\nO - okrag\nP - prostokat");
            WybranaFigura = Console.ReadLine();

            if(WybranaFigura=="t")
            {
                Console.WriteLine("Podaj pierwsza wspolrzedna punktu zaczepienia");
                Console.ReadLine();
                Console.WriteLine("Podaj druga wspolrzedna punktu zaczepienia");
                Console.ReadLine();

            }
        }
    }
}
