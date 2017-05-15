using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testy
{
    [TestClass]
    public class TestyJed
    {
        [TestMethod]
        public void TestUstawWspolrzedna()
        {
            int liczbatestowa = 1;

            int PierwszaWsp = ProgramKolokwium.Program.PierwszaW;

            Assert.AreEqual(liczbatestowa, PierwszaWsp);


        }

        [TestMethod]
        public void TestUstawWspolrzedne()
        {
            int liczbatestowa = 1;

            int PierwszaWsp = ProgramKolokwium.Program.PierwszaW;
            int DrugaWsp = ProgramKolokwium.Program.DrugaW;

            Assert.AreEqual(liczbatestowa, PierwszaWsp);
            Assert.AreEqual(liczbatestowa, DrugaWsp);

        }

        [TestMethod]
        public void TestObliczBok (int bok)
        {
            bok = 0;

            int BokTestowany = ProgramKolokwium.Program.BokPierwszy;

            Assert.AreEqual(bok, BokTestowany);

        }

      
            
            
            
    }
}
