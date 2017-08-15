using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoftTesting
{
    using BashSoft.Contracts;

    [TestFixture]
    public class OrderedDataStructureTester
    {
        [TestFixtureSetUp]
        public void SetUp()
        {
            this.names = new SimpleSortedList<string>();
        }

        [TearDown]
        public void Clean()
        {
            this.names = new SimpleSortedList<string>();
        }

        private ISimpleOrderedBag<string> names;
        [Test]
        public void TestEmptyCtor()
        {
            this.names = new SimpleSortedList<string>();
            Assert.AreEqual(this.names.Capacity, 16);
            Assert.AreEqual(this.names.Size, 0);
        }

        [Test]
        public void TestCtorWithInitialCapacity()
        {
            this.names = new SimpleSortedList<string>(20);
            Assert.AreEqual(this.names.Capacity, 20);
            Assert.AreEqual(this.names.Size, 0);
        }

        [Test]
        public void TestCtorWithAllParams()
        {
            this.names = new SimpleSortedList<string>(30, StringComparer.OrdinalIgnoreCase);
            Assert.AreEqual(this.names.Capacity, 30);
            Assert.AreEqual(this.names.Size, 0);
        }


        [Test]
        public void TestCtorWithInitialComprer()
        {
            this.names = new SimpleSortedList<string>(StringComparer.OrdinalIgnoreCase);
            Assert.AreEqual(this.names.Capacity, 16);
            Assert.AreEqual(this.names.Size, 0);
        }

       

        [Test]
        public void TestAddIncreasesSize()
        {
            this.names.Add("Nasko");
            Assert.AreEqual(1, this.names.Size);
        }

        [Test]
        public void TestAddNullThrowsException()
        {
            Assert.Throws<ArgumentException>(() => this.names.Add(null));

        }

        [Test]
        public void TestAddUnsortedDataIsHeldSorted()
        {
            List<string> listOfNames = new List<string>()
            {
                "Rosen",
                "Georgi",
                "Balkan"
            };

            this.names.AddAll(listOfNames);

            listOfNames.Sort((x, y) => x.CompareTo(y));

            int i = 0;
            foreach (var name in names)
            {
                Assert.AreEqual(listOfNames[i], name);
                i++;

            }
        }

        [Test]
        public void TestAddingMoreThanInitialCapacity()
        {
            for (int i = 0; i < 17; i++)
            {
                this.names.Add(i.ToString());
            }

            Assert.AreEqual(17, this.names.Size);
            Assert.AreNotEqual(16, this.names.Capacity);

        }

        [Test]
        public void TestAddingAllFromCollectionIncreasesSize()
        {
            List<string> listOfNames = new List<string>()
            {
                "Rosen",
                "Georgi",
            };

            this.names.AddAll(listOfNames);

            Assert.AreEqual(2, this.names.Size);
        }

        [Test]
        public void TestAddingAllFromNullThrowsException()
        {
            Assert.Throws<ArgumentException>(() => this.names.AddAll(null));
        }

        [Test]
        public void TestAddAllKeepsSorted()
        {
            List<string> listOfNames = new List<string>()
            {
                "Rosen",
                "Georgi",
                "Balkan",
                "Asen",
                "Ivan",
                "Yordan",
                "Kiril",
                "Marin"
            };

            this.names.AddAll(listOfNames);

            listOfNames.Sort((x, y) => x.CompareTo(y));

            int i = 0;
            foreach (var name in names)
            {
                Assert.AreEqual(listOfNames[i], name);
                i++;

            }
        }

        [Test]
        public void TestRemoveValidElementDecreasesSize()
        {
            this.names.Add("Nasko");
            this.names.Remove("Nasko");
            Assert.AreEqual(0, this.names.Size);
        }

        [Test]
        public void TestRemoveValidElementRemovesSelectedOne()
        {
            this.names.Add("Nasko");

            this.names.Add("Ivan");

            this.names.Remove("Ivan");

            Assert.AreEqual(false, this.names.Contains("Ivan"));
        }

        [Test]
        public void TestRemovingNullThrowsException()
        {
            Assert.Throws<ArgumentException>(()=> this.names.Remove(null));
        }

        [Test]
        public void TestJoinWithNull()
        {
            Assert.Throws<ArgumentException>(() => this.names.JoinWith(null));
        }

        [Test]
        public void TestJoinWorksFine()
        {
            Assert.AreEqual(string.Join(" ", this.names), this.names.JoinWith(" ").ToString());
        }


    }
}
