using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task6
{
    [TestFixture]
    class Test
    {
        [Test]
        public void createWizards()
        {
            var a = new Creature("Darias", 2, 2, 4, "Human");
            Assert.IsTrue(a.name == "Darias");
            Assert.IsTrue(a.mana == 2);
            Assert.IsTrue(a.powerlvl == 2);
            Assert.IsTrue(a.defenselvl == 4);
            Assert.IsTrue(a.typus == "Human");
        }
        [Test]
        public void Noname()
        {
            Assert.Catch(() =>
            {
                var a = new Creature(null, 2, 2, 4, "Human");
            });
        }
        [Test]
        public void Noname2()
        {
            Assert.Catch(() =>
            {
                var a = new Creature("", 2, 2, 4, "Human");
            });
        }
        [Test]
        public void Negativmana()
        {
            Assert.Catch(() =>
            {
                var a = new Creature("Darias", -2, 2, 4, "Human");
            });
        }

        [Test]
        public void Nodlvl()
        {
            Assert.Catch(() =>
            {
                var a = new Creature("Darias", 2, 2, 0, "Human");
            });
        }
        [Test]
        public void manaoverload()
        {
            Assert.Catch(() =>
            {
                var a = new Creature("Darias", 11, 2, 0, "Human");
            });
        }
        [Test]
        public void Notype()
        {
            Assert.Catch(() =>
            {
                var a = new Creature("Darias", 2, 2, 0, null);
            });
        }
        [Test]
        public void Notype2()
        {
            Assert.Catch(() =>
            {
                var a = new Creature("Darias", 2, 2, 0, "");
            });
        }
        [Test]
        public void negativattack()
        {
            Assert.Catch(() =>
            {
                var a = new Creature("Darias", 2, -2, 4, "Human");
            });
        }
    }
}
