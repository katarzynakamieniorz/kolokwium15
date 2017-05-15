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

            int wyjscie = Program.PierwszaW;

            Assert.AreEqual("1", wyjscie);

        }

        [TestMethod]
        public int TestMethod2 (int bok)
        {

            return bok;
        }
            
            
            
            
            
    }
}
