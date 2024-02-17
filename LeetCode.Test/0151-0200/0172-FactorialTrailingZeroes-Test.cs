namespace LeetCode.Test
{
    public class _0172_FactorialTrailingZeroes_Test
    {
        [Test]
        public void TrailingZeroes_1() {
            var solution = new _0172_FactorialTrailingZeroes();
            var result = solution.TrailingZeroes(3);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void TrailingZeroes_2() {
            var solution = new _0172_FactorialTrailingZeroes();
            var result = solution.TrailingZeroes(5);
            Assert.AreEqual(1, result);
        }
    }
}
