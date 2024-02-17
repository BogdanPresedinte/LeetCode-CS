namespace LeetCode.Test
{
    public class _097_InterleavingString_Test
    {
        [Test]
        public void IsInterleaveTest() {
            var solution = new _097_InterleavingString();
            Assert.IsTrue(solution.IsInterleave("aabcc", "dbbca", "aadbbcbcac"));
            Assert.IsFalse(solution.IsInterleave("aabcc", "dbbca", "aadbbbaccc"));
        }

        [Test]
        public void IsInterleaveTest_NotSameSize() {
            var solution = new _097_InterleavingString();
            Assert.IsFalse(solution.IsInterleave("aabcc", "dbbca", "aadbbcbcaca"));
            Assert.IsFalse(solution.IsInterleave("aabcc", "dbbca", "aadbbbaccca"));
        }
    }
}
