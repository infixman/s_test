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
            var expected = new MyStack(new int[] { 1, 3, 2, 4 });
            var actual = new MyStack();
            actual.Push(1);
            actual.Push(3);
            actual.Push(2);
            actual.Push(4);
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod]
        public void Veriry_Pop()
        {
            var expected = new MyStack(new int[] { 1, 3, 2 });
            var actual = new MyStack(new int[] { 1, 3, 2, 4, 6 });
            actual.Pop();
            actual.Pop();
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod]
        public void Veriry_Top()
        {
            var expected = 4;
            var actual = new MyStack(new int[] { 1, 4 }).Top();
            Assert.AreEqual(expected, actual);
        }
    }
}
