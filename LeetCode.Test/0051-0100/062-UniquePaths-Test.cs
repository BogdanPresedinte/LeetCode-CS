namespace LeetCode.Test
{
    public class _062_UniquePaths_Test
    {
        [Test]
        public void UniquePathsTest() {
            var solution = new _062_UniquePaths();
            var result = solution.UniquePaths(3, 7);

            Assert.AreEqual(28, result);
        }

        [Test]
        public void UniquePathsTest_OneRow() {
            var solution = new _062_UniquePaths();
            var result = solution.UniquePaths(1, 7);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void UniquePathsTest_OneColumn() {
            var solution = new _062_UniquePaths();
            var result = solution.UniquePaths(7, 1);

            Assert.AreEqual(1, result);
        }
    }
}
