using System;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var calculator = new Calculator();
            var add = calculator.Add(1, 2);
            Assert.AreEqual();
        }
    }
}