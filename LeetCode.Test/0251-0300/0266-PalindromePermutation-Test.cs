namespace LeetCode.Test
{
    public class _0266_PalindromePermutation_Test
    {
        [Test]
        public void CanPermutePalindrome_1() {
            var solution = new _0266_PalindromePermutation();
            var result = solution.CanPermutePalindrome("code");
            Assert.IsFalse(result);
        }

        [Test]
        public void CanPermutePalindrome_2() {
            var solution = new _0266_PalindromePermutation();
            var result = solution.CanPermutePalindrome("aab");
            Assert.IsTrue(result);
        }

        [Test]
        public void CanPermutePalindrome_3() {
            var solution = new _0266_PalindromePermutation();
            var result = solution.CanPermutePalindrome("carerac");
            Assert.IsTrue(result);
        }
    }
}
