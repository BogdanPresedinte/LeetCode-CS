namespace LeetCode.Test
{
    public class _0128_LongestConsecutiveSequence_Test
    {
        [Test]
        public void LongestConsecutiveTest_1() {
            var solution = new _0128_LongestConsecutiveSequence();
            var result = solution.LongestConsecutive(new int[] { 100, 4, 200, 1, 3, 2 });
            Assert.AreEqual(4, result);
        }

        [Test]
        public void LongestConsecutiveTest_2() {
            var solution = new _0128_LongestConsecutiveSequence();
            var result = solution.LongestConsecutive(new int[] { 100, 4, 200, 1, 3, 2, 4 });
            Assert.AreEqual(4, result);
        }

        [Test]
        public void LongestConsecutiveTest_3() {
            var solution = new _0128_LongestConsecutiveSequence();
            var result = solution.LongestConsecutive(new int[] { 100, 4, 100, 1, 3, 2, 4 });
            Assert.AreEqual(4, result);
        }
    }
}
