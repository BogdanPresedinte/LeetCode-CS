namespace LeetCode.Test
{
    public class _1048_LongestStringChain_Test
    {
        [Test]
        public void LongestStrChain_1() {
            var solution = new _1048_LongestStringChain();
            var result = solution.LongestStrChain(new string[] { "a", "b", "ba", "bca", "bda", "bdca" });
            Assert.AreEqual(4, result);
        }
    }
}
