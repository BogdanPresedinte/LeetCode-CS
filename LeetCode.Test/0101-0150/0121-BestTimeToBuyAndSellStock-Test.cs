namespace LeetCode.Test
{
    public class _0121_BestTimeToBuyAndSellStock_Test
    {
        [Test]
        public void MaxProfitTest_1() {
            var solution = new _0121_BestTimeToBuyAndSellStock();
            var result = solution.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
            Assert.AreEqual(5, result);
        }

        [Test]
        public void MaxProfitTest_2() {
            var solution = new _0121_BestTimeToBuyAndSellStock();
            var result = solution.MaxProfit(new int[] { 7, 6, 4, 3, 1 });
            Assert.AreEqual(0, result);
        }
    }
}
