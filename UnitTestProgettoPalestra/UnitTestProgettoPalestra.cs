using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgettoPalestra;

namespace UnitTestProgettoPalestra
{
    [TestClass]
    public class UnitTestProgettoPalestra
    {
        [TestMethod]
        public void TestTariffaMigliore1()
        {
            int a = 2;
            double risultato_effetivo = 231.98;
            double risultato_calcolato = Gestiohne.tariffamigliore(a);
            Assert.AreEqual(risultato_effetivo, risultato_calcolato);
        }
        [TestMethod]
        public void TestTariffaMigliore2()
        {
            int a = 6;
            double risultato_effetivo = 599.99;
            double risultato_calcolato = Gestiohne.tariffamigliore(a);
            Assert.AreEqual(risultato_effetivo, risultato_calcolato);
        }
        [TestMethod]
        public void TestTariffaMigliore3()
        {
            int a = 12;
            double risultato_effetivo = 959.88;
            double risultato_calcolato = Gestiohne.tariffamigliore(a);
            Assert.AreEqual(risultato_effetivo, risultato_calcolato);
        }
    }
}
