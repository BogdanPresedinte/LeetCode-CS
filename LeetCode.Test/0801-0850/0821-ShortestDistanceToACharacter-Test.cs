namespace LeetCode.Test
{
    public class _0821_ShortestDistanceToACharacter_Test
    {
        [Test]
        public void ShortestToChar_1() {
            var solution = new _0821_ShortestDistanceToACharacter();
            var result = solution.ShortestToChar("loveleetcode", 'e');
            AssertHelper.AssertArray(new int[] { 3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0 }, result);
        }
    }
}
