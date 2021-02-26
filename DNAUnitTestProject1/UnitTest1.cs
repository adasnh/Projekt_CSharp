using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfProjekt;
using System;

namespace DNAUnitTestProject1
{
    [TestClass]
    public class CreatingObjectsTestClass
    {
        [TestMethod]
        public void Create_Worker()
        {
            Workers newWorker = new Workers();

            newWorker.Id = 1;
            newWorker.imie = "Jan";
            newWorker.nazwisko = "Kowalski";

            Assert.AreEqual(newWorker.Id, 1);
            Assert.AreEqual(newWorker.imie, "Jan");
            Assert.AreEqual(newWorker.nazwisko, "Kowalski");

        }
        [TestMethod]
        public void Create_Item()
        {
            Items newItem = new Items();

            newItem.id_artykulu = 1;
            newItem.nazwa = "Młotek";
            newItem.koszt_zakupu = 52;
            newItem.ilosc_sztuk = 1;

            Assert.AreEqual(newItem.id_artykulu, 1);
            Assert.AreEqual(newItem.nazwa, "Młotek");
            Assert.AreEqual(newItem.koszt_zakupu, 52);
            Assert.AreEqual(newItem.ilosc_sztuk, 1);

        }
        [TestMethod]
        public void Create_User()
        {
            Users newUser = new Users();

            newUser.Id = 1;
            newUser.nazwa = "admin";
            newUser.haslo = "admin";
            newUser.rola = "admin";
            newUser.status = true;

            Assert.AreEqual(newUser.Id, 1);
            Assert.AreEqual(newUser.nazwa, "admin");
            Assert.AreEqual(newUser.haslo, "admin");
            Assert.AreEqual(newUser.rola, "admin");
            Assert.AreEqual(newUser.status, true);

        }
        [TestMethod]
        public void Give_Away()
        {
            GiveAway newga = new GiveAway();
            DateTime dt1 = new DateTime(2010, 10, 10);
            newga.id_zamowienia = 1;
            newga.id_pracownika = 2;
            newga.id_artykulu = 3;
            newga.ilosc_sztuk = 7;
            newga.data_wydania = dt1;

            Assert.AreEqual(newga.id_zamowienia, 1);
            Assert.AreEqual(newga.id_pracownika, 2);
            Assert.AreEqual(newga.id_artykulu, 3);
            Assert.AreEqual(newga.ilosc_sztuk, 7);
            Assert.AreEqual(newga.data_wydania, dt1);

        }
    }
}
