using NUnit.Framework;
using MoveToFront;
using System.Collections.Generic;

namespace MovetoFrontTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            moveTo = new MoveToFront();
        }

        [Test]
        public void BananaTest()
        {
            var list = moveTo.StringCoding("banana");
            var expectedList = new List<int>() { 1, 1, 13, 1, 1, 1 };
            CollectionAssert.AreEqual(expectedList, list);
        }

        [Test]
        public void TomatoTest()
        {
            var list = moveTo.StringCoding("tomato");
            var expectedList = new List<int>() { 19, 15, 14, 3, 3, 3 };
            CollectionAssert.AreEqual(expectedList, list);
        }

        [Test]
        public void MelonTest()
        {
            var list = moveTo.StringCoding("melon");
            var expectedList = new List<int>() { 12, 5, 12, 14, 14 };
            CollectionAssert.AreEqual(expectedList, list);
        }

        private MoveToFront moveTo;
    }
}