namespace LeetCode.Test
{
    public class _1299_ReplaceElementsWithGreatestElementOnRightSide_Test
    {
        [Test]
        public void ReplaceElements_1() {
            var solution = new _1299_ReplaceElementsWithGreatestElementOnRightSide();
            var result = solution.ReplaceElements(new int[] { 17, 18, 5, 4, 6, 1 });
            AssertHelper.AssertArray(new int[] { 18, 6, 6, 6, 1, -1 }, result);
        }
    }
}
