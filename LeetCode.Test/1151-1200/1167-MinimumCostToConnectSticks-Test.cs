namespace LeetCode.Test
{
    public class _1167_MinimumCostToConnectSticks_Test
    {
        [Test]
        public void ConnectSticks_1() {
            var solution = new _1167_MinimumCostToConnectSticks();
            var result = solution.ConnectSticks(new int[] { 2, 4, 3 });
            Assert.AreEqual(14, result);
        }

        [Test]
        public void ConnectSticks_2() {
            var solution = new _1167_MinimumCostToConnectSticks();
            var result = solution.ConnectSticks(new int[] { 1, 8, 3, 5 });
            Assert.AreEqual(30, result);
        }

        [Test]
        public void ConnectSticks_3() {
            var solution = new _1167_MinimumCostToConnectSticks();
            var result = solution.ConnectSticks(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
            Assert.AreEqual(88, result);
        }
    }
}
