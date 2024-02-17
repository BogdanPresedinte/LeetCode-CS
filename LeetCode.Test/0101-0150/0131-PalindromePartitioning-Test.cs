namespace LeetCode.Test
{
    public class _0131_PalindromePartitioning_Test
    {
        [Test]
        public void PartitionTest() {
            var solution = new _0131_PalindromePartitioning();
            var result = solution.Partition("aab");
            AssertHelper.AssertList(new List<IList<string>>()
            {
                new List<string>() { "a", "a", "b" },
                new List<string>() { "aa", "b" },
            }, result);
        }
    }
}
