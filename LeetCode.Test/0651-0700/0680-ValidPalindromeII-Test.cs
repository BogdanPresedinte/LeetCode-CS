namespace LeetCode.Test
{
    public class _0680_ValidPalindromeII_Test
    {
        [Test]
        public void ValidPalindrome_1() {
            var solution = new _0680_ValidPalindromeII();
            var result = solution.ValidPalindrome("aba");
            Assert.IsTrue(result);
        }

        [Test]
        public void ValidPalindrome_2() {
            var solution = new _0680_ValidPalindromeII();
            var result = solution.ValidPalindrome("abca");
            Assert.IsTrue(result);
        }

        [Test]
        public void ValidPalindrome_3() {
            var solution = new _0680_ValidPalindromeII();
            var result = solution.ValidPalindrome("abc");
            Assert.IsFalse(result);
        }
    }
}
