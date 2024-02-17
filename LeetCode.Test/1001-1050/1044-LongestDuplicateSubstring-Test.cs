namespace LeetCode.Test
{
    public class _1044_LongestDuplicateSubstring_Test
    {
        [Test]
        public void LongestDupSubstring_1() {
            var solution = new _1044_LongestDuplicateSubstring();
            var result = solution.LongestDupSubstring("banana");
            Assert.AreEqual("ana", result);
        }

        [Test]
        public void LongestDupSubstring_2() {
            var solution = new _1044_LongestDuplicateSubstring();
            var result = solution.LongestDupSubstring("abcd");
            Assert.AreEqual("", result);
        }
    }
}
