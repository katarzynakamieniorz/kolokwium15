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

        public int UstawPunkt ()
        {
            return 0;
                        
        }

        public int ObliczBokProstokata ()
        {
            return 0;
        }


        static void Main(string[] args)
        {

            String WybranaFigura;
            
            



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
