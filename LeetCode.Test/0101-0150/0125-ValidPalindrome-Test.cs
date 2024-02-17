namespace LeetCode.Test
{
    public class _0125_ValidPalindrome_Test
    {
        [Test]
        public void IsPalindromeTest_1() {
            var solution = new _0125_ValidPalindrome();
            Assert.IsTrue(solution.IsPalindrome("A man, a plan, a canal: Panama"));
        }

        [Test]
        public void IsPalindromeTest_2() {
            var solution = new _0125_ValidPalindrome();
            Assert.IsFalse(solution.IsPalindrome("race a car"));
        }

        [Test]
        public void IsPalindromeTest_3() {
            var solution = new _0125_ValidPalindrome();
            Assert.IsTrue(solution.IsPalindrome(string.Empty));
        }

        [Test]
        public void IsPalindromeTest_4() {
            var solution = new _0125_ValidPalindrome();
            Assert.IsTrue(solution.IsPalindrome("."));
        }

        [Test]
        public void IsPalindromeTest_5() {
            var solution = new _0125_ValidPalindrome();
            Assert.IsFalse(solution.IsPalindrome("0P"));
        }
    }
}
