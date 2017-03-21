using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task2and3
{
    [TestFixture]
    class Test
    {
        [Test]
        public void createWizards()
        {
            var w = new Beginners("Pawel", "Noobiness", 1, false);
            Assert.IsTrue(w.Name == "Pawel");
            Assert.IsTrue(w.Spell == "None");
            Assert.IsTrue(w.Powerlvl == 1);
            Assert.IsTrue(w.Castingpermission == false);
        }
        [Test]
        public void Noname()
        {
            Assert.Catch(() =>
            {
                var w = new Beginners(null, "Noobiness", 1, false);
            });
        }
        [Test]
        public void Noname2()
        {
            Assert.Catch(() =>
            {
                var w = new Beginners("", "Noobiness", 1, false);
            });
        }
        [Test]
        public void Nospell()
        {
            Assert.Catch(() =>
            {
                var w = new Beginners("Pawel", null, 1, false);
            });
        }
        [Test]
        public void Nospell2()
        {
            Assert.Catch(() =>
            {
                var w = new Beginners("Pawel", "", 1, false);
            });
        }
        [Test]
        public void Noplvl()
        {
            Assert.Catch(() =>
            {
                var w = new Beginners("Pawel", "Noobiness", 0, false);
            });
        }
        [Test]
        public void plvlplus()
        {
            Assert.Catch(() =>
            {
                var w = new Beginners("Pawel", "Noobiness", 101, false);
            });
        }
        [Test]
        public void bollT()
        {
            Assert.Catch(() =>
            {
                var w = new Beginners("Pawel", "Noobiness", 1, true);
            });
        }
    }
}
