namespace LeetCode.Test
{
    public class _0312_BurstBalloons_Test
    {
        [Test]
        public void MaxCoinsTest() {
            var solution = new _0312_BurstBalloons();
            var result = solution.MaxCoins(new int[] { 3, 1, 5, 8 });
            Assert.AreEqual(167, result);
        }
    }
}
