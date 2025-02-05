namespace LeetCode.Test
{
    public class _0392_IsSubsequence_Test
    {
        [Test]
        public void IsSubsequence_1() {
            var solution = new _0392_IsSubsequence();
            var result = solution.IsSubsequence("abc", "ahbgdc");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsSubsequence_2() {
            var solution = new _0392_IsSubsequence();
            var result = solution.IsSubsequence("axc", "ahbgdc");
            Assert.IsFalse(result);
        }
    }
}
