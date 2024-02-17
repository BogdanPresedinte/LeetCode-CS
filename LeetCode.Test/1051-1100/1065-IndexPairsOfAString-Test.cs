namespace LeetCode.Test
{
    public class _1065_IndexPairsOfAString_Test
    {
        [Test]
        public void IndexPairs_1() {
            var solution = new _1065_IndexPairsOfAString();
            var result = solution.IndexPairs("thestoryofleetcodeandme", new string[] { "story", "fleet", "leetcode" });
            AssertHelper.AssertArray(
                new int[][]
                {
                    new int[] { 3, 7 },
                    new int[] { 9, 13 },
                    new int[] { 10, 17 },
                }, result);
        }

        [Test]
        public void IndexPairs_2() {
            var solution = new _1065_IndexPairsOfAString();
            var result = solution.IndexPairs("ababa", new string[] { "aba", "ab" });
            AssertHelper.AssertArray(
                new int[][]
                {
                    new int[] { 0, 1 },
                    new int[] { 0, 2 },
                    new int[] { 2, 3 },
                    new int[] { 2, 4 },
                }, result);
        }
    }
}
