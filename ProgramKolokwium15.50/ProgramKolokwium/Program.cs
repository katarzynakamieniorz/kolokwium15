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
        int DlugoscBokuA, DlugoscBokuB;
        int WspolrzednaProstokat1a, WspolrzednaProstokat1b, WspolrzednaProstokat2a, WspolrzednaProstokat2b, WspolrzednaProstokat3a, WspolrzednaProstokat3b, WspolrzednaProstokat4a, WspolrzednaProstokat4b;

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

        public void ObliczBokProstokata1 (int dlugosc1, int dlugosc2)
        {
            dlugosc1 = DlugoscBokuA;
            dlugosc2 = DlugoscBokuB;

            WspolrzednaProstokat1a = PierwszaW;
            WspolrzednaProstokat1b = DrugaW;

        }

        public void ObliczBokProstokata2 (int dlugosc1, int dlugosc2)
        {
            dlugosc1 = DlugoscBokuA;
            dlugosc2 = DlugoscBokuB;

            WspolrzednaProstokat2a = PierwszaW + dlugosc1;
            WspolrzednaProstokat2b = DrugaW;

        }

        public void ObliczBokProstokata3(int dlugosc1, int dlugosc2)
        {
            dlugosc1 = DlugoscBokuA;
            dlugosc2 = DlugoscBokuB;

            WspolrzednaProstokat3a = PierwszaW + dlugosc2;
            WspolrzednaProstokat3b = DrugaW + dlugosc1;
        }

        static void Main(string[] args)
        {

            String WybranaFigura;
            int PierwszaW, DrugaW;
            int BokPierwszy, BokDrugi;
            int DlugoscBokuA, DlugoscBokuB;

            


            Console.WriteLine("T - trapez prostokatny\nO - okrag\nP - prostokat");
            WybranaFigura = Console.ReadLine();

            if(WybranaFigura=="t")
            {
                

            }else if(WybranaFigura=="o")
            {

            }else if(WybranaFigura=="p")
            {
                Console.WriteLine("Podaj pierwsza wspolrzedna punktu zaczepienia");
                PierwszaW = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Podaj druga wspolrzedna punktu zaczepienia");
                DrugaW = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Podaj dlugosc dluzszego boku");
                DlugoscBokuA = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Podaj dlugosc krotszego boku");
                DlugoscBokuB = Int32.Parse(Console.ReadLine());

            }

        }
    }
}
