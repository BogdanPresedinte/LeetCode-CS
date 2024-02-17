namespace LeetCode.Test
{
    public class _1496_PathCrossing_Test
    {
        [Test]
        public void IsPathCrossing_1() {
            var solution = new _1496_PathCrossing();
            var result = solution.IsPathCrossing("NES");
            Assert.IsFalse(result);
        }

        [Test]
        public void IsPathCrossing_2() {
            var solution = new _1496_PathCrossing();
            var result = solution.IsPathCrossing("NESWW");
            Assert.IsTrue(result);
        }
    }
}
