namespace LeetCode.Test
{
    public class _0322_CoinChange_Test
    {
        [Test]
        public void CoinChange_1() {
            var solution = new _0322_CoinChange();
            var result = solution.CoinChange(new int[] { 1, 2, 5 }, 11);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void CoinChange_2() {
            var solution = new _0322_CoinChange();
            var result = solution.CoinChange(new int[] { 2 }, 3);
            Assert.AreEqual(-1, result);
        }
    }
}
