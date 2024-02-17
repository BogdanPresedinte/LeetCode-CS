namespace LeetCode.Test
{
    public class _0336_PalindromePairs_Test
    {
        [Test]
        public void PalindromePairsTest_1() {
            var solution = new _0336_PalindromePairs();
            var result = solution.PalindromePairs(new string[] { "abcd", "dcba", "lls", "s", "sssll" });
            AssertHelper.AssertList(
                new List<IList<int>>
                {
                    new List<int> { 1, 0 },
                    new List<int> { 0, 1 },
                    new List<int> { 3, 2 },
                    new List<int> { 2, 4 },
                }, result);
        }

        [Test]
        public void PalindromePairsTest_2() {
            var solution = new _0336_PalindromePairs();
            var result = solution.PalindromePairs(new string[] { "bat", "tab", "cat" });
            AssertHelper.AssertList(
                new List<IList<int>>
                {
                    new List<int> { 1, 0 },
                    new List<int> { 0, 1 },
                }, result);
        }

        [Test]
        public void PalindromePairsTest_3() {
            var solution = new _0336_PalindromePairs();
            var result = solution.PalindromePairs(new string[] { "a", "" });
            AssertHelper.AssertList(
                new List<IList<int>>
                {
                    new List<int> { 0, 1 },
                    new List<int> { 1, 0 },
                }, result);
        }
    }
}
