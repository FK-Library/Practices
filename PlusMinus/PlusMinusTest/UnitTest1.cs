using PlusMinus;
using System.Drawing;

namespace PlusMinusTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("6", "-4 3 -9 0 4 1")]
        public void TestMethod1(string size, string input)
        {

            List<int> arr = input.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(arr);
        }
    }
}