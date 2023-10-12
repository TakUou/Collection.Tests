using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

using TestMethods;

namespace Collection.Tests
{
    [TestClass]
    public class CollectionTests
    {

        static List<string> list;
        static List<string> list2;
        static List<string> list3;
        static List<string> list4;

        TestMethodsTests TMT = new TestMethodsTests();

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            list = new List<string>
            {
                "3","2"
            };
            list2 = new List<string>
            {
               "2"
            };
            list3 = new List<string>
            {
               "корней нет"
            };
            list4 = new List<string>
            {
                "15f", "0.5"
            };
        }

        [TestMethod]
        public void TestMethod_FindTwoRoots_returnTwoRoots()
        {
            CollectionAssert.AreEquivalent(list, TMT.TestMethod(1,-5,6));
        }

        [TestMethod]
        public void TestMethod_FindRoot_returnRoot()
        {
            CollectionAssert.AreEqual(list2, TMT.TestMethod(1,-4, 4));
        }

        [TestMethod]
        public void TestMethod_FindNoRoots_returnNoRoots()
        {
            CollectionAssert.AreEqual(list3, TMT.TestMethod(2, 3, 7));
        }

        [TestMethod]
        public void CalculatePercentage_FindPercentageFromNumber_PersentageFromNumber()
        {
            double number = 50.0f, percentage = 10.0f;
            double[] actual = new double[] { 5.0f };
            var res = TMT.CalculatePercentage(number, percentage);
            double[] expected = new double[] { res };
            CollectionAssert.AreEqual(expected, actual, $"expected - {expected[0]}, actual - {actual[0]}");
        }
    }
}
