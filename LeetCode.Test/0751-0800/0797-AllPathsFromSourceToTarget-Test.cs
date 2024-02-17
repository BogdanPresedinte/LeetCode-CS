namespace LeetCode.Test
{
    public class _0797_AllPathsFromSourceToTarget_Test
    {
        [Test]
        public void AllPathsSourceTarget_1() {
            var solution = new _0797_AllPathsFromSourceToTarget();
            var result = solution.AllPathsSourceTarget(new int[][] {
                new int[] { 1, 2 },
                new int[] { 3 },
                new int[] { 3 },
                new int[] { },
            });
            AssertHelper.AssertList(new List<IList<int>>() {
                new int[] { 0, 1, 3 },
                new int[] { 0, 2, 3 },
            }, result);
        }

        [Test]
        public void AllPathsSourceTarget_2() {
            var solution = new _0797_AllPathsFromSourceToTarget();
            var result = solution.AllPathsSourceTarget(new int[][] {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3 },
                new int[] { },
            });
            AssertHelper.AssertList(new List<IList<int>>() {
                new int[] { 0, 1, 2, 3 },
                new int[] { 0, 1, 3 },
                new int[] { 0, 2, 3 },
            }, result);
        }

        [Test]
        public void AllPathsSourceTarget_3() {
            var solution = new _0797_AllPathsFromSourceToTarget();
            var result = solution.AllPathsSourceTarget(new int[][] {
                new int[] { 4, 3, 1 },
                new int[] { 3, 2, 4 },
                new int[] { 3 },
                new int[] { 4 },
                new int[] { },
            });
            AssertHelper.AssertList(new List<IList<int>>() {
                new int[] { 0, 4 },
                new int[] { 0, 3, 4 },
                new int[] { 0, 1, 3, 4 },
                new int[] { 0, 1, 2, 3, 4 },
                new int[] { 0, 1, 4 },
            }, result);
        }
    }
}
