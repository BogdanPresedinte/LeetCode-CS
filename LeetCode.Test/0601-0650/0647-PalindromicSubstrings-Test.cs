namespace LeetCode.Test
{
    public class _0647_PalindromicSubstrings_Test
    {
        [Test]
        public void CountSubstrings_1() {
            var solution = new _0647_PalindromicSubstrings();
            var result = solution.CountSubstrings("abc");
            Assert.AreEqual(3, result);
        }

        [Test]
        public void CountSubstrings_2() {
            var solution = new _0647_PalindromicSubstrings();
            var result = solution.CountSubstrings("aaa");
            Assert.AreEqual(6, result);
        }
    }
}
