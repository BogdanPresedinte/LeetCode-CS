namespace LeetCode.Test
{
    public class _1207_UniqueNumberOfOccurrences_Test
    {
        [Test]
        public void UniqueOccurrences_1() {
            var solution = new _1207_UniqueNumberOfOccurrences();
            var result = solution.UniqueOccurrences(new int[] { 1, 2, 2, 1, 1, 3 });
            Assert.IsTrue(result);
        }

        [Test]
        public void UniqueOccurrences_2() {
            var solution = new _1207_UniqueNumberOfOccurrences();
            var result = solution.UniqueOccurrences(new int[] { 1, 2 });
            Assert.IsFalse(result);
        }

        [Test]
        public void UniqueOccurrences_3() {
            var solution = new _1207_UniqueNumberOfOccurrences();
            var result = solution.UniqueOccurrences(new int[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 });
            Assert.IsTrue(result);
        }
    }
}
