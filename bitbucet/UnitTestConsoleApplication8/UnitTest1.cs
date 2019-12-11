using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication8;

namespace UnitTestConsoleApplication8
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBubbleSort()
        {
            double[] array = {1.3, 1.2, 1.5};
            double[] array1 = { 1.2, 1.3, 1.5};
            
            array = Program.BubbleSort(array);
            CollectionAssert.AreEqual(array1,array);
        }
    }
}
