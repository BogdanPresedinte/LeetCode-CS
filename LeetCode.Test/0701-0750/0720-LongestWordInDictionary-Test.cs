namespace LeetCode.Test
{
    public class _0720_LongestWordInDictionary_Test
    {
        [Test]
        public void LongestWord_1() {
            var solution = new _0720_LongestWordInDictionary();
            var result = solution.LongestWord(new string[] { "w", "wo", "wor", "worl", "world" });
            Assert.AreEqual("world", result);
        }

        [Test]
        public void LongestWord_2() {
            var solution = new _0720_LongestWordInDictionary();
            var result = solution.LongestWord(new string[] { "a", "banana", "app", "appl", "ap", "apply", "apple" });
            Assert.AreEqual("apple", result);
        }
    }
}
