using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgettoPalestra;

namespace UnitTestProgettoPalestra
{
    [TestClass]
    public class UnitTestProgettoPalestra
    {
        [TestMethod]
        public void TestTariffaMigliore1_1()
        {
            int a = 2;
            double risultato_effetivo = 231.98;
            double risultato_calcolato = Gestiohne.tariffamigliore(a);
            Assert.AreEqual(risultato_effetivo, risultato_calcolato);
        }
        public void TestTariffaMigliore1_2()
        {
            int a = 2;
            string risultato_effetivo = "La scelta migliore è quella di un mese"; 
            string risultato_calcolato = Gestiohne.tariffamigliore1(a);
            Assert.AreEqual(risultato_effetivo, risultato_calcolato);
        }
        [TestMethod]
        public void TestTariffaMigliore2_1()
        {
            int a = 6;
            double risultato_effetivo = 599.99;
            double risultato_calcolato = Gestiohne.tariffamigliore(a);
            Assert.AreEqual(risultato_effetivo, risultato_calcolato);
        }
        [TestMethod]
        public void TestTariffaMigliore2_2()
        {
            int a = 6;
            string risultato_effetivo = "La scelta migliore è quella di tre mesi";
            string risultato_calcolato = Gestiohne.tariffamigliore1(a);
            Assert.AreEqual(risultato_effetivo, risultato_calcolato);
        }
        [TestMethod]
        public void TestTariffaMigliore3_1()
        {
            int a = 12;
            double risultato_effetivo = 959.88;
            double risultato_calcolato = Gestiohne.tariffamigliore(a);
            Assert.AreEqual(risultato_effetivo, risultato_calcolato);
        }
        [TestMethod]
        public void TestTariffaMigliore3_2()
        {
            int a = 12;
            string risultato_effetivo = "La scelta migliore è quella di dodici mesi";
            string risultato_calcolato = Gestiohne.tariffamigliore1(a);
            Assert.AreEqual(risultato_effetivo, risultato_calcolato);
        }
    }
}
