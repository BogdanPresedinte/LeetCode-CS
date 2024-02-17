namespace LeetCode.Test
{
    public class _009_PalindromeNumber_Test
    {
        [Test]
        public void IsPalindromeTest_SingleDigit() {
            var solution = new _009_PalindromeNumber();
            var result = solution.IsPalindrome(0);
            Assert.IsTrue(result);

            result = solution.IsPalindrome(1);
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindromeTest_NegativeNumber() {
            var solution = new _009_PalindromeNumber();
            var result = solution.IsPalindrome(-1);
            Assert.IsFalse(result);
        }

        [Test]
        public void IsPalindromeTest_MultipleDigit() {
            var solution = new _009_PalindromeNumber();
            var result = solution.IsPalindrome(11);
            Assert.IsTrue(result);

            result = solution.IsPalindrome(121);
            Assert.IsTrue(result);

            result = solution.IsPalindrome(1231);
            Assert.IsFalse(result);
        }
    }
}
