using NUnit.Framework;
using hashtable;
namespace hashtest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            hashTable = new HashTable(50, hashFunction1);
        }

        [Test]
        public void ManyElementsTestDelete()
        {
            hashTable.Append(2, "melon");
            hashTable.Append(14, "banana");
            hashTable.Append(10, "watermelon");
            hashTable.Append(12, "lemon");
            hashTable.Append(11, "tomato");
            hashTable.Append(3, "chicken");
            hashTable.Append(25, "milk");
            hashTable.Delete(10);
            hashTable.Delete(3);
            hashTable.Delete(14);
            hashTable.Delete(12);
            hashTable.Delete(25);
            hashTable.Delete(11);
            Assert.AreEqual(7, hashTable.Count);
        }
        [Test]
        public void AddElementsWithSameKeysTest()
        {
            hashTable.Append(3, "apple");
            hashTable.Append(3, "banana");
            hashTable.Delete(3);
            Assert.IsTrue(hashTable.Find(3));
        }

        [Test]
        public void ManyElementsAppendTest()
        {
            hashTable.Append(2, "melon");
            hashTable.Append(14, "banana");
            hashTable.Append(10, "watermelon");
            hashTable.Append(12, "lemon");
            hashTable.Append(11, "tomato");
            hashTable.Append(3, "chicken");
            hashTable.Append(25, "milk");
            Assert.AreEqual(7, hashTable.Count);
        }

        [Test]
        public void AppendTest()
        {
            hashTable.Append(3, "milk");
            Assert.IsTrue(hashTable.Find(3));
        }
        [Test]
        public void DeleteTest()
        {
            hashTable.Append(5, "lemon");
            hashTable.Delete(5);
            Assert.IsFalse(hashTable.Find(5));
        }

        [Test]
        public void AddValuesWithSameKeysTest()
        {
            hashTable.Append(3, "lemon");
            hashTable.Append(3, "banana");
            hashTable.Append(3, "apple");
            Assert.AreEqual(3, hashTable.Count);
        }

        private HashTable hashTable;
        private IHashFunction hashFunction1;
    }
}