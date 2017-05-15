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
        int BokPierwszy, BokDrugi;

        public void UstawPunkt()
        {
            Console.WriteLine("Podaj pierwsza wspolrzedna punktu zaczepienia");
            PierwszaW = Int32.Parse(Console.ReadLine());
        }

        public void UstawPunkty()
        {
            Console.WriteLine("Podaj pierwsza wspolrzedna punktu zaczepienia");
            PierwszaW = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga wspolrzedna punktu zaczepienia");
            DrugaW = Int32.Parse(Console.ReadLine());
        }

        public int ObliczBokProstokata()
        {
            return 0;
        }



        static void Main(string[] args)
        {

            String WybranaFigura;
            int PierwszaW, DrugaW;
            int BokPierwszy, BokDrugi;




            Console.WriteLine("T - trapez prostokatny\nO - okrag\nP - prostokat");
            WybranaFigura = Console.ReadLine();

            if(WybranaFigura=="t")
            {
                ProgramKolokwium.Program.UstawPunkty();

            }
        }
    }
}
