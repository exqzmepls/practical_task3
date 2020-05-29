using System;
using System.IO;
using practical_task3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestBelongs1()
        {
            double x = 1.01;
            double y = 0.65;

            bool result = false;

            Assert.AreEqual(result, Program.Belongs(x, y));
        }

        [TestMethod]
        public void TestBelongs2()
        {
            double x = -3.995;
            double y = -0.3;

            bool result = false;

            Assert.AreEqual(result, Program.Belongs(x, y));
        }

        [TestMethod]
        public void TestBelongs3()
        {
            double x = -1.5;
            double y = 30.87;

            bool result = false;

            Assert.AreEqual(result, Program.Belongs(x, y));
        }

        [TestMethod]
        public void TestBelongs4()
        {
            double x = 4;
            double y = -1.25;

            bool result = false;

            Assert.AreEqual(result, Program.Belongs(x, y));
        }

        [TestMethod]
        public void TestBelongs5()
        {
            double x = 0;
            double y = -4;

            bool result = false;

            Assert.AreEqual(result, Program.Belongs(x, y));
        }

        [TestMethod]
        public void TestBelongs6()
        {
            double x = -1.07;
            double y = -1.01;

            bool result = false;

            Assert.AreEqual(result, Program.Belongs(x, y));
        }

        [TestMethod]
        public void TestBelongs7()
        {
            double x = 0.5;
            double y = -0.038;

            bool result = true;

            Assert.AreEqual(result, Program.Belongs(x, y));
        }

        [TestMethod]
        public void TestBelongs8()
        {
            double x = 1;
            double y = -1;

            bool result = true;

            Assert.AreEqual(result, Program.Belongs(x, y));
        }

        [TestMethod]
        public void TestBelongs9()
        {
            double x = -1;
            double y = -1;

            bool result = true;

            Assert.AreEqual(result, Program.Belongs(x, y));
        }

        [TestMethod]
        public void TestBelongs10()
        {
            double x = 0;
            double y = 2;

            bool result = true;

            Assert.AreEqual(result, Program.Belongs(x, y));
        }

        [TestMethod]
        public void TestDoubleInput()
        {
            Console.SetIn(new StreamReader("input.txt"));
            double result = -2.09;

            double input = Program.DoubleInput("some info");

            Assert.AreEqual(result, input);
        }
    }
}
