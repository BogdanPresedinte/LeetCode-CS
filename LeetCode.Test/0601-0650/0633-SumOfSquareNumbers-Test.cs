namespace LeetCode.Test
{
    public class _0633_SumOfSquareNumbers_Test
    {
        [Test]
        public void JudgeSquareSum_1() {
            var solution = new _0633_SumOfSquareNumbers();
            var result = solution.JudgeSquareSum(5);
            Assert.IsTrue(result);
        }

        [Test]
        public void JudgeSquareSum_2() {
            var solution = new _0633_SumOfSquareNumbers();
            var result = solution.JudgeSquareSum(3);
            Assert.IsFalse(result);
        }

        [Test]
        [Timeout(20)]
        public void JudgeSquareSum_3() {
            var solution = new _0633_SumOfSquareNumbers();
            var result = solution.JudgeSquareSum(2147483646);
            Assert.IsFalse(result);
        }
    }
}
