namespace LeetCode.Test
{
    public class _0780_ReachingPoints_Test
    {
        [Test]
        public void ReachingPoints_1() {
            var solution = new _0780_ReachingPoints();
            var result = solution.ReachingPoints(1, 1, 3, 5);
            Assert.IsTrue(result);
        }

        [Test]
        public void ReachingPoints_2() {
            var solution = new _0780_ReachingPoints();
            var result = solution.ReachingPoints(1, 1, 2, 2);
            Assert.IsFalse(result);
        }

        [Test]
        public void ReachingPoints_3() {
            var solution = new _0780_ReachingPoints();
            var result = solution.ReachingPoints(1, 1, 1, 1);
            Assert.IsTrue(result);
        }
    }
}
