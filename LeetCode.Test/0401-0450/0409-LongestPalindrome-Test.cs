namespace LeetCode.Test
{
    public class _0409_LongestPalindrome_Test
    {
        [Test]
        public void LongestPalindrome_1() {
            var solution = new _0409_LongestPalindrome();
            var result = solution.LongestPalindrome("abccccdd");
            Assert.AreEqual(7, result);
        }

        [Test]
        public void LongestPalindrome_2() {
            var solution = new _0409_LongestPalindrome();
            var result = solution.LongestPalindrome("ccccdd");
            Assert.AreEqual(6, result);
        }

        [Test]
        public void LongestPalindrome_3() {
            var solution = new _0409_LongestPalindrome();
            var result = solution.LongestPalindrome("abc");
            Assert.AreEqual(1, result);
        }
    }
}
