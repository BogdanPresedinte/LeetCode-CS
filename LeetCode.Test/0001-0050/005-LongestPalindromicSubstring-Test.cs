namespace LeetCode.Test
{
    public class _005_LongestPalindromicSubstring_Test
    {
        [Test]
        public void LongestPalindromeTest_Odd() {
            var input = "abcdefgfedcba";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("abcdefgfedcba", result);
        }

        [Test]
        public void LongestPalindromeTest_Even() {
            var input = "abcdefggfedcba";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("abcdefggfedcba", result);
        }

        [Test]
        public void LongestPalindromeTest_AllTheSame_Odd() {
            var input = "ccc";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("ccc", result);
        }

        [Test]
        public void LongestPalindromeTest_AllTheSame_Even() {
            var input = "aaaaaaaaaa";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("aaaaaaaaaa", result);
        }

        [Test]
        public void LongestPalindromeTest_EmptyString() {
            var input = "";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("", result);
        }

        [Test]
        public void LongestPalindromeTest_OneCharacterString() {
            var input = "a";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("a", result);
        }

        [Test]
        public void LongestPalindromeTest_MultiplePalindrome_LongestAtStart() {
            var input = "aabccdccbaaeeggee";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("aabccdccbaa", result);
        }

        [Test]
        public void LongestPalindromeTest_MultiplePalindrome_LongestAtEnd() {
            var input = "eegffgeeaabcdcbaa";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("aabcdcbaa", result);
        }

        [Test]
        public void LongestPalindromeTest_MultipleMixPalindrome() {
            var input = "abcdcbbcd";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("dcbbcd", result);
        }

        [Test]
        public void LongestPalindromeTest_MultipleMixPalindrome_2() {
            var input = "abcddcbebcd";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("dcbebcd", result);
        }
    }
}
