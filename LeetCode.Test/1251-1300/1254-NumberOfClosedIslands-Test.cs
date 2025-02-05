namespace LeetCode.Test
{
    public class _1254_NumberOfClosedIslands_Test
    {
        [Test]
        public void ClosedIsland_1() {
            var solution = new _1254_NumberOfClosedIslands();
            var result = solution.ClosedIsland(new int[][] {
                new int[] { 1, 1, 1, 1, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 0, 1, 1, 0 },
                new int[] { 1, 0, 1, 0, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 0, 1, 0, 1 },
                new int[] { 1, 1, 1, 1, 1, 1, 1, 0 },
            });
            Assert.AreEqual(2, result);
        }

        [Test]
        public void ClosedIsland_2() {
            var solution = new _1254_NumberOfClosedIslands();
            var result = solution.ClosedIsland(new int[][] {
                new int[] { 0, 0, 1, 0, 0 },
                new int[] { 0, 1, 0, 1, 0 },
                new int[] { 0, 1, 1, 1, 0 },
            });
            Assert.AreEqual(1, result);
        }

        [Test]
        public void ClosedIsland_3() {
            var solution = new _1254_NumberOfClosedIslands();
            var result = solution.ClosedIsland(new int[][] {
                new int[] { 1, 1, 1, 1, 1, 1, 1 },
                new int[] { 1, 0, 0, 0, 0, 0, 1 },
                new int[] { 1, 0, 1, 1, 1, 0, 1 },
                new int[] { 1, 0, 1, 0, 1, 0, 1 },
                new int[] { 1, 0, 1, 1, 1, 0, 1 },
                new int[] { 1, 0, 0, 0, 0, 0, 1 },
                new int[] { 1, 1, 1, 1, 1, 1, 1 },
            });
            Assert.AreEqual(2, result);
        }
    }
}
