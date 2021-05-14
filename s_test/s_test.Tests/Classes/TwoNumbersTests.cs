using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using s_test.Calsses;

namespace s_test.Tests.Classes
{
    [TestClass]
    public class TwoNumbersTests
    {

        [TestMethod]
        public void Verify_GetTwoNumbers()
        {
            var expected = new int[] { 4, 9 };
            var actual = new TwoNumbers(new int[] { 1, 4, 7, 23, 9 }, 13).GetTwoNumbers();
            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}
