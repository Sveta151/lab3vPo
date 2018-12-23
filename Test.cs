using NUnit.Framework;
using System;
using System.Collections.Generic;
namespace lab3OneMoreTime
{
    [TestFixture]
    public class Test
    {
        ClassSet S = new ClassSet();
        [Test]
        public void firsttest1()
        {
            List<int> b1 = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            List<int> b2 = new List<int> { 7, 8, 9 };
            List<int> b3 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Assert.AreEqual(S.Summ(b1, b2), b3);

        }
        [Test]
        public void firsttest2()
        {
            List<int> b1 = new List<int> { 1, 2, 3, 4 };
            List<int> b2 = new List<int> { 4, 5, 6, 7, 8, 9 };
            List<int> b3 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Assert.AreEqual(S.Summ(b1, b2), b3);

        }

        [Test]
        public void secondtest()
        {
            List<int> b1 = new List<int> { 4, 5 };
            List<int> b2 = new List<int> { 4, 5 };
            List<int> b3 = new List<int> { 4, 5 };

            Assert.AreEqual(S.Peresech(b1, b2), b3);

        }
        [Test]
        public void secondtest2()
        {
            List<int> b1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> b2 = new List<int> { 4, 5, 6, 7 };
            List<int> b3 = new List<int> { 4, 5 };

            Assert.AreEqual(S.Peresech(b1, b2), b3);

        }
        [Test]
        public void secondtest3()
        {
            List<int> b1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> b2 = new List<int> { 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            List<int> b3 = new List<int> { 4, 5 };

            Assert.AreEqual(S.Peresech(b1, b2), b3);

        }

        [Test]
        public void thirdtest()
        {
            List<int> b1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> b2 = new List<int> { 4, 5, 6, 7 };
            List<int> b3 = new List<int> { 1, 2, 3 };

            Assert.AreEqual(S.Substraction(b1, b2), b3);

        }
        [Test]
        public void thirdtest2()
        {
            List<int> b1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> b2 = new List<int> { 6, 7 };
            List<int> b3 = new List<int> { 1, 2, 3, 4, 5 };

            Assert.AreEqual(S.Substraction(b1, b2), b3);

        }
        [Test]
        public void fourthtest()
        {
            List<int> b1 = new List<int> { 1, 2, 3, 4, 5 };
            int b2 = 3;
            bool b3 = true;

            Assert.AreEqual(S.Isin(b1, b2), b3);

        }
        [Test]
        public void fourthtest2()
        {
            List<int> b1 = new List<int> { 1, 2, 3, 4, 5 };
            int b2 = 6;
            bool b3 = false;

            Assert.AreEqual(S.Isin(b1, b2), b3);

        }
    }
}
