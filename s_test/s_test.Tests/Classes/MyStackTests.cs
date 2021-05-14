using ExpectedObjects;
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
            var actual = new MyStack();
            actual.Push(1);
            actual.Push(3);
            actual.Push(2);
            actual.Push(4);
            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}
