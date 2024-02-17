namespace LeetCode.Test
{
    public class _0492_ConstructTheRectangle_Test
    {
        [Test]
        public void ConstructRectangle_1() {
            var solution = new _0492_ConstructTheRectangle();
            var result = solution.ConstructRectangle(4);
            AssertHelper.AssertArray(new int[] { 2, 2 }, result);
        }
    }
}
