namespace LeetCode.Test
{
    public class _0829_ConsecutiveNumbersSum_Test
    {
        [Test]
        public void ConsecutiveNumbersSum_1() {
            var solution = new _0829_ConsecutiveNumbersSum();
            var result = solution.ConsecutiveNumbersSum(5);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void ConsecutiveNumbersSum_2() {
            var solution = new _0829_ConsecutiveNumbersSum();
            var result = solution.ConsecutiveNumbersSum(9);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void ConsecutiveNumbersSum_3() {
            var solution = new _0829_ConsecutiveNumbersSum();
            var result = solution.ConsecutiveNumbersSum(15);
            Assert.AreEqual(4, result);
        }
    }
}
