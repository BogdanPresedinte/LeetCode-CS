namespace LeetCode.Test
{
    public class _0438_FindAllAnagramsInAString_Test
    {
        [Test]
        public void FindAnagrams_1() {
            var solution = new _0438_FindAllAnagramsInAString();
            var result = solution.FindAnagrams("cbaebabacd", "abc");
            AssertHelper.AssertList(new int[] { 0, 6 }, result);
        }

        [Test]
        public void FindAnagrams_2() {
            var solution = new _0438_FindAllAnagramsInAString();
            var result = solution.FindAnagrams("abab", "ab");
            AssertHelper.AssertList(new int[] { 0, 1, 2 }, result);
        }
    }
}
