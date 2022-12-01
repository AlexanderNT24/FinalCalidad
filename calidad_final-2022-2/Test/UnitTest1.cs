using Calidad20222.web.Models;
using Calidad20222.web.Services;
using NUnit.Framework;
using System.Collections.Generic;

namespace Test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var carta1 = new Carta { Numero = 1, Palo = "ESPADA" };
            var carta2 = new Carta { Numero = 13, Palo = "ESPADA" };
            var carta3 = new Carta { Numero = 12, Palo = "ESPADA" };
            var carta4 = new Carta { Numero = 11, Palo = "ESPADA" };
            var carta5 = new Carta { Numero = 10, Palo = "ESPADA" };
            List<Carta> cartas = new List<Carta>();
            cartas.Add(carta1);
            cartas.Add(carta2);
            cartas.Add(carta3);
            cartas.Add(carta4);
            cartas.Add(carta5);
            var service = new PokerService();
            Assert.AreEqual("COLOR", service.GetJugada(cartas));
            //Assert.AreEqual("ESCALERA", service.GetJugada(cartas));
        }
        [Test]
        public void Test2()
        {
            var carta1 = new Carta { Numero = 10, Palo = "CORAZON" };
            var carta2 = new Carta { Numero = 9, Palo = "CORAZON" };
            var carta3 = new Carta { Numero = 8, Palo = "CORAZON" };
            var carta4 = new Carta { Numero = 7, Palo = "CORAZON" };
            var carta5 = new Carta { Numero = 6, Palo = "CORAZON" };
            List<Carta> cartas = new List<Carta>();
            cartas.Add(carta1);
            cartas.Add(carta2);
            cartas.Add(carta3);
            cartas.Add(carta4);
            cartas.Add(carta5);
            var service = new PokerService();
            Assert.AreEqual("COLOR", service.GetJugada(cartas));
        }
        [Test]
        public void Test3()
        {
            var carta1 = new Carta { Numero = 12, Palo = "CORAZON" };
            var carta2 = new Carta { Numero = 12, Palo = "TREBOL" };
            var carta3 = new Carta { Numero = 12, Palo = "ESPADA" };
            var carta4 = new Carta { Numero = 12, Palo = "COCO" };
            var carta5 = new Carta { Numero = 10, Palo = "COCO" };
            List<Carta> cartas = new List<Carta>();
            cartas.Add(carta1);
            cartas.Add(carta2);
            cartas.Add(carta3);
            cartas.Add(carta4);
            cartas.Add(carta5);
            var service = new PokerService();
            Assert.AreEqual("POKER", service.GetJugada(cartas));
            //Assert.AreEqual("COLOR", service.GetJugada(cartas));
        }
        [Test]
        public void Test4()
        {
            var carta1 = new Carta { Numero = 1, Palo = "COCO" };
            var carta2 = new Carta { Numero = 1, Palo = "ESPADA" };
            var carta3 = new Carta { Numero = 1, Palo = "CORAZON" };
            var carta4 = new Carta { Numero = 7, Palo = "TREBOL" };
            var carta5 = new Carta { Numero = 7, Palo = "COCO" };
            List<Carta> cartas = new List<Carta>();
            cartas.Add(carta1);
            cartas.Add(carta2);
            cartas.Add(carta3);
            cartas.Add(carta4);
            cartas.Add(carta5);
            var service = new PokerService();
            Assert.AreEqual("FULL", service.GetJugada(cartas));
        }
        [Test]
        public void Test5()
        {
            var carta1 = new Carta { Numero = 1, Palo = "COCO" };
            var carta2 = new Carta { Numero = 11, Palo = "COCO" };
            var carta3 = new Carta { Numero = 8, Palo = "COCO" };
            var carta4 = new Carta { Numero = 5, Palo = "COCO" };
            var carta5 = new Carta { Numero = 7, Palo = "COCO" };
            List<Carta> cartas = new List<Carta>();
            cartas.Add(carta1);
            cartas.Add(carta2);
            cartas.Add(carta3);
            cartas.Add(carta4);
            cartas.Add(carta5);
            var service = new PokerService();
            Assert.AreEqual("COLOR", service.GetJugada(cartas));
        }
        [Test]
        public void Test6()
        {
            var carta1 = new Carta { Numero = 10, Palo = "CORAZON" };
            var carta2 = new Carta { Numero = 9, Palo = "ESPADA" };
            var carta3 = new Carta { Numero = 8, Palo = "COCO" };
            var carta4 = new Carta { Numero = 7, Palo = "TREBOL" };
            var carta5 = new Carta { Numero = 6, Palo = "ESPADA" };
            List<Carta> cartas = new List<Carta>();
            cartas.Add(carta1);
            cartas.Add(carta2);
            cartas.Add(carta3);
            cartas.Add(carta4);
            cartas.Add(carta5);
            var service = new PokerService();
            Assert.AreEqual("ESCALERA", service.GetJugada(cartas));
        }
        [Test]
        public void Test7()
        {
            var carta1 = new Carta { Numero = 12, Palo = "CORAZON" };
            var carta2 = new Carta { Numero = 12, Palo = "ESPADA" };
            var carta3 = new Carta { Numero = 12, Palo = "COCO" };
            var carta4 = new Carta { Numero = 7, Palo = "TREBOL" };
            var carta5 = new Carta { Numero = 6, Palo = "ESPADA" };
            List<Carta> cartas = new List<Carta>();
            cartas.Add(carta1);
            cartas.Add(carta2);
            cartas.Add(carta3);
            cartas.Add(carta4);
            cartas.Add(carta5);
            var service = new PokerService();
            Assert.AreEqual("TRIO", service.GetJugada(cartas));
        }
        [Test]
        public void Test8()
        {

            var carta1 = new Carta { Numero = 11, Palo = "CORAZON" };
            var carta2 = new Carta { Numero = 11, Palo = "TREBOL" };
            var carta3 = new Carta { Numero = 9, Palo = "COCO" };
            var carta4 = new Carta { Numero = 9, Palo = "TREBOL" };
            var carta5 = new Carta { Numero = 2, Palo = "COCO" };
            List<Carta> cartas = new List<Carta>();
            cartas.Add(carta1);
            cartas.Add(carta2);
            cartas.Add(carta3);
            cartas.Add(carta4);
            cartas.Add(carta5);
            var service = new PokerService();
            Assert.AreEqual("DOBLE PAREJA", service.GetJugada(cartas));
        }
        [Test]
        public void Test9()
        {

            var carta1 = new Carta { Numero = 12, Palo = "ESPADA" };
            var carta2 = new Carta { Numero = 12, Palo = "CORAZON" };
            var carta3 = new Carta { Numero = 6, Palo = "CORAZON" };
            var carta4 = new Carta { Numero = 9, Palo = "TREBOL" };
            var carta5 = new Carta { Numero = 2, Palo = "COCO" };
            List<Carta> cartas = new List<Carta>();
            cartas.Add(carta1);
            cartas.Add(carta2);
            cartas.Add(carta3);
            cartas.Add(carta4);
            cartas.Add(carta5);
            var service = new PokerService();
            Assert.AreEqual("DOBLE", service.GetJugada(cartas));
            //Assert.AreEqual("PAREJA", service.GetJugada(cartas));
        }
        [Test]
        public void Test10()
        {

            var carta1 = new Carta { Numero = 1, Palo = "CORAZON" };
            var carta2 = new Carta { Numero = 12, Palo = "ESPADA" };
            var carta3 = new Carta { Numero = 6, Palo = "ESPADA" };
            var carta4 = new Carta { Numero = 5, Palo = "COCO" };
            var carta5 = new Carta { Numero = 10, Palo = "TREBOL" };
            List<Carta> cartas = new List<Carta>();
            cartas.Add(carta1);
            cartas.Add(carta2);
            cartas.Add(carta3);
            cartas.Add(carta4);
            cartas.Add(carta5);
            var service = new PokerService();
            Assert.AreEqual("CARTA MAYOR", service.GetJugada(cartas));
            //Assert.AreEqual("COLOR", service.GetJugada(cartas));
        }
        [Test]
        public void Test11()
        {
            var carta1 = new Carta { Numero = 13, Palo = "ESPADA" };
            var carta2 = new Carta { Numero = 1, Palo = "ESPADA" };
            var carta3 = new Carta { Numero = 11, Palo = "ESPADA" };
            var carta4 = new Carta { Numero = 12, Palo = "ESPADA" };
            var carta5 = new Carta { Numero = 10, Palo = "ESPADA" };
            List<Carta> cartas = new List<Carta>();
            cartas.Add(carta1);
            cartas.Add(carta2);
            cartas.Add(carta3);
            cartas.Add(carta4);
            cartas.Add(carta5);
            var service = new PokerService();
            Assert.AreEqual("COLOR", service.GetJugada(cartas));
            //Assert.AreEqual("ESCALERA", service.GetJugada(cartas));
        }
        [Test]
        public void Test12()
        {
            var carta1 = new Carta { Numero = 6, Palo = "CORAZON" };
            var carta2 = new Carta { Numero = 7, Palo = "CORAZON" };
            var carta3 = new Carta {  Numero = 9, Palo = "CORAZON" };
            var carta4 = new Carta { Numero = 8, Palo = "CORAZON" };
            var carta5 = new Carta {  Numero = 10, Palo = "CORAZON" };
            List<Carta> cartas = new List<Carta>();
            cartas.Add(carta1);
            cartas.Add(carta2);
            cartas.Add(carta3);
            cartas.Add(carta4);
            cartas.Add(carta5);
            var service = new PokerService();
            Assert.AreEqual("COLOR", service.GetJugada(cartas));
        }
        [Test]
        public void Test13()
        {
            var carta1 = new Carta { Numero = 12, Palo = "TREBOL" };
            var carta2 = new Carta { Numero = 12, Palo = "CORAZON"};
            var carta3 = new Carta { Numero = 12, Palo = "COCO" };
            var carta4 = new Carta { Numero = 10, Palo = "COCO" };
            var carta5 = new Carta { Numero = 12, Palo = "ESPADA" };
            List<Carta> cartas = new List<Carta>();
            cartas.Add(carta1);
            cartas.Add(carta2);
            cartas.Add(carta3);
            cartas.Add(carta4);
            cartas.Add(carta5);
            var service = new PokerService();
            Assert.AreEqual("POKER", service.GetJugada(cartas));
            //Assert.AreEqual("COLOR", service.GetJugada(cartas));
        }
        [Test]
        public void Test14()
        {
            var carta1 = new Carta { Numero = 1, Palo = "ESPADA" };
            var carta2 = new Carta { Numero = 1, Palo = "COCO"  };
            var carta3 = new Carta { Numero = 7, Palo = "TREBOL" };
            var carta4 = new Carta { Numero = 7, Palo = "COCO" };
            var carta5 = new Carta { Numero = 1, Palo = "CORAZON" };
            List<Carta> cartas = new List<Carta>();
            cartas.Add(carta1);
            cartas.Add(carta2);
            cartas.Add(carta3);
            cartas.Add(carta4);
            cartas.Add(carta5);
            var service = new PokerService();
            Assert.AreEqual("FULL", service.GetJugada(cartas));
        }
        [Test]
        public void Test15()
        {
            var carta1 = new Carta { Numero = 11, Palo = "COCO"};
            var carta2 = new Carta { Numero = 1, Palo = "COCO" };
            var carta3 = new Carta { Numero = 5, Palo = "COCO" };
            var carta4 = new Carta { Numero = 7, Palo = "COCO" };
            var carta5 = new Carta { Numero = 8, Palo = "COCO" };
            List<Carta> cartas = new List<Carta>();
            cartas.Add(carta1);
            cartas.Add(carta2);
            cartas.Add(carta3);
            cartas.Add(carta4);
            cartas.Add(carta5);
            var service = new PokerService();
            Assert.AreEqual("COLOR", service.GetJugada(cartas));
        }
        [Test]
        public void Test16()
        {
            var carta1 = new Carta { Numero = 9, Palo = "ESPADA" };
            var carta2 = new Carta { Numero = 10, Palo = "CORAZON" };
            var carta3 = new Carta { Numero = 7, Palo = "TREBOL" };
            var carta4 = new Carta { Numero = 6, Palo = "ESPADA" };
            var carta5 = new Carta { Numero = 8, Palo = "COCO" };
            List<Carta> cartas = new List<Carta>();
            cartas.Add(carta1);
            cartas.Add(carta2);
            cartas.Add(carta3);
            cartas.Add(carta4);
            cartas.Add(carta5);
            var service = new PokerService();
            Assert.AreEqual("ESCALERA", service.GetJugada(cartas));
        }
        [Test]
        public void Test17()
        {
            var carta1 = new Carta { Numero = 12, Palo = "ESPADA" };
            var carta2 = new Carta { Numero = 12, Palo = "CORAZON"};
            var carta3 = new Carta { Numero = 7, Palo = "TREBOL"};
            var carta4 = new Carta { Numero = 6, Palo = "ESPADA"};
            var carta5 = new Carta { Numero = 12, Palo = "COCO" };
            List<Carta> cartas = new List<Carta>();
            cartas.Add(carta1);
            cartas.Add(carta2);
            cartas.Add(carta3);
            cartas.Add(carta4);
            cartas.Add(carta5);
            var service = new PokerService();
            Assert.AreEqual("TRIO", service.GetJugada(cartas));
        }
        [Test]
        public void Test18()
        {

            var carta1 = new Carta { Numero = 11, Palo = "TREBOL" };
            var carta2 = new Carta { Numero = 11, Palo = "CORAZON"  };
            var carta3 = new Carta { Numero = 9, Palo = "COCO" };
            var carta4 = new Carta { Numero = 2, Palo = "COCO" };
            var carta5 = new Carta { Numero = 9, Palo = "TREBOL"  };
            List<Carta> cartas = new List<Carta>();
            cartas.Add(carta1);
            cartas.Add(carta2);
            cartas.Add(carta3);
            cartas.Add(carta4);
            cartas.Add(carta5);
            var service = new PokerService();
            Assert.AreEqual("DOBLE PAREJA", service.GetJugada(cartas));
        }
        [Test]
        public void Test19()
        {

            var carta1 = new Carta { Numero = 12, Palo = "CORAZON" };
            var carta2 = new Carta { Numero = 12, Palo = "ESPADA" };
            var carta3 = new Carta { Numero = 2, Palo = "COCO" };
            var carta4 = new Carta { Numero = 6, Palo = "CORAZON" };
            var carta5 = new Carta { Numero = 9, Palo = "TREBOL" };
            List<Carta> cartas = new List<Carta>();
            cartas.Add(carta1);
            cartas.Add(carta2);
            cartas.Add(carta3);
            cartas.Add(carta4);
            cartas.Add(carta5);
            var service = new PokerService();
            Assert.AreEqual("DOBLE", service.GetJugada(cartas));
            //Assert.AreEqual("PAREJA", service.GetJugada(cartas));
        }
        [Test]
        public void Test20()
        {

            var carta1 = new Carta { Numero = 12, Palo = "ESPADA" };
            var carta2 = new Carta { Numero = 1, Palo = "CORAZON" };
            var carta3 = new Carta { Numero = 5, Palo = "COCO" };
            var carta4 = new Carta { Numero = 6, Palo = "ESPADA" };
            var carta5 = new Carta { Numero = 10, Palo = "TREBOL" };
            List<Carta> cartas = new List<Carta>();
            cartas.Add(carta1);
            cartas.Add(carta2);
            cartas.Add(carta3);
            cartas.Add(carta4);
            cartas.Add(carta5);
            var service = new PokerService();
            Assert.AreEqual("CARTA MAYOR", service.GetJugada(cartas));
            //Assert.AreEqual("COLOR", service.GetJugada(cartas));
        }
    }
}