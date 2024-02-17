namespace LeetCode.Test
{
    public class _0204_CountPrimes_Test
    {
        [Test]
        public void CountPrimes_1() {
            var solution = new _0204_CountPrimes();
            var result = solution.CountPrimes(10);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void CountPrimes_2() {
            var solution = new _0204_CountPrimes();
            var result = solution.CountPrimes(20);
            Assert.AreEqual(8, result);
        }
    }
}
