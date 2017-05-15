using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramKolokwium
{
    class Program
    {

        int PierwszaW, DrugaW;

        public void UstawPunkt ()
        {
            PierwszaW = 1;
            DrugaW = 1;
                        
        }

        public int ObliczBokProstokata ()
        {
            return 0;
        }


        static void Main(string[] args)
        {

            String WybranaFigura;

            

            Console.WriteLine("Podaj pierwsza wspolrzedna punktu zaczepienia");
            PierwszaW = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga wspolrzedna punktu zaczepienia");
            DrugaW = Int32.Parse(Console.ReadLine());


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
