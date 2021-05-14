using Microsoft.VisualStudio.TestTools.UnitTesting;
using s_test.Calsses;

namespace s_test.Tests.Classes
{
    [TestClass]
    public class MyStackTests
    {
        [TestMethod]
        public void Veriry_Push()
        {
            var array = new int[] { 1, 3, 2, 4 };
            var expected = new MyStack(array);
            var result = new MyStack();
            result.Push(1);
            result.Push(3);
            result.Push(2);
            result.Push(4);
            Assert.AreEqual(expected, result);
        }
    }
}
