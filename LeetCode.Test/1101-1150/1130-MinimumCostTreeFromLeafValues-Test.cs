namespace LeetCode.Test
{
    public class _1130_MinimumCostTreeFromLeafValues_Test
    {
        [Test]
        public void MctFromLeafValues_1() {
            var solution = new _1130_MinimumCostTreeFromLeafValues();
            var result = solution.MctFromLeafValues(new int[] { 6, 2, 4 });
            Assert.AreEqual(32, result);
        }

        [Test]
        public void MctFromLeafValues_2() {
            var solution = new _1130_MinimumCostTreeFromLeafValues();
            var result = solution.MctFromLeafValues(new int[] { 15, 13, 5, 3, 15 });
            Assert.AreEqual(500, result);
        }
    }
}
