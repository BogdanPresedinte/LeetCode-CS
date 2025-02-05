namespace LeetCode.Test
{
    public class _1051_HeightChecker_Test
    {
        [Test]
        public void HeightChecker_1() {
            var solution = new _1051_HeightChecker();
            var result = solution.HeightChecker(new int[] { 1, 1, 4, 2, 1, 3 });
            Assert.AreEqual(3, result);
        }

        [Test]
        public void HeightChecker_2() {
            var solution = new _1051_HeightChecker();
            var result = solution.HeightChecker(new int[] { 5, 1, 2, 3, 4 });
            Assert.AreEqual(5, result);
        }

        [Test]
        public void HeightChecker_3() {
            var solution = new _1051_HeightChecker();
            var result = solution.HeightChecker(new int[] { 1, 2, 3, 4, 5 });
            Assert.AreEqual(0, result);
        }
    }
}
