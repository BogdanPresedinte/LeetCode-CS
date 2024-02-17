namespace LeetCode.Test
{
    public class _0765_CouplesHoldingHands_Test
    {
        [Test]
        public void MinSwapsCouplesTest_1() {
            var solution = new _0765_CouplesHoldingHands();
            var result = solution.MinSwapsCouples(new int[] { 0, 2, 1, 3 });
            Assert.AreEqual(1, result);
        }

        [Test]
        public void MinSwapsCouplesTest_2() {
            var solution = new _0765_CouplesHoldingHands();
            var result = solution.MinSwapsCouples(new int[] { 3, 2, 0, 1 });
            Assert.AreEqual(0, result);
        }
    }
}
