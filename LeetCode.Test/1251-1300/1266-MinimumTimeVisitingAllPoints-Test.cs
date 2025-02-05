namespace LeetCode.Test
{
    public class _1266_MinimumTimeVisitingAllPoints_Test
    {
        [Test]
        public void MinTimeToVisitAllPoints_1() {
            var solution = new _1266_MinimumTimeVisitingAllPoints();
            var result = solution.MinTimeToVisitAllPoints(new int[][]
            {
                new int[] { 1, 1 },
                new int[] { 3, 4 },
                new int[] { -1, 0 },
            });
            Assert.AreEqual(7, result);
        }

        [Test]
        public void MinTimeToVisitAllPoints_2() {
            var solution = new _1266_MinimumTimeVisitingAllPoints();
            var result = solution.MinTimeToVisitAllPoints(new int[][]
            {
                new int[] { 3, 2 },
                new int[] { -2, 2 },
            });
            Assert.AreEqual(5, result);
        }
    }
}
