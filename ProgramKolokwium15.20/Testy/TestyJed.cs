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

            int PierwszaWsp = Program.PierwszaW;
            int DrugaWsp = Program.DrugaW;

            Assert.AreEqual("1", PierwszaWsp);
            Assert.AreEqual("1", DrugaWsp);

        }

        [TestMethod]
        public int TestObliczBok (int bok)
        {

            return bok;
        }

        
            
            
    }
}
