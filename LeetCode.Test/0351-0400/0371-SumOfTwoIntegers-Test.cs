namespace LeetCode.Test
{
    public class _0371_SumOfTwoIntegers_Test
    {
        [Test]
        public void GetSumTest_1() {
            var solution = new _0371_SumOfTwoIntegers();
            Assert.AreEqual(3, solution.GetSum(1, 2));
        }

        [Test]
        public void GetSumTest_2() {
            var solution = new _0371_SumOfTwoIntegers();
            Assert.AreEqual(1, solution.GetSum(-2, 3));
        }

        [Test]
        public void GetSumTest_3() {
            var solution = new _0371_SumOfTwoIntegers();
            Assert.AreEqual(-1, solution.GetSum(1, -2));
        }
    }
}
