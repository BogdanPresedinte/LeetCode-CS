namespace LeetCode.Test
{
    public class _1111_MaximumNestingDepthOfTwoValidParenthesesStrings_Test
    {
        [Test]
        public void MaxDepthAfterSplit_1() {
            var solution = new _1111_MaximumNestingDepthOfTwoValidParenthesesStrings();
            var result = solution.MaxDepthAfterSplit("(()())");
            AssertHelper.AssertArray(new int[] { 0, 1, 1, 1, 1, 0 }, result);
        }

        [Test]
        public void MaxDepthAfterSplit_2() {
            var solution = new _1111_MaximumNestingDepthOfTwoValidParenthesesStrings();
            var result = solution.MaxDepthAfterSplit("()(())()");
            AssertHelper.AssertArray(new int[] { 0, 0, 0, 1, 1, 0, 0, 0 }, result);
        }
    }
}
