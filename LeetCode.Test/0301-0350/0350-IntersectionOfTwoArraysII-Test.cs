namespace LeetCode.Test
{
    public class _0350_IntersectionOfTwoArraysII_Test
    {
        [Test]
        public void Intersect_1() {
            var solution = new _0350_IntersectionOfTwoArraysII();
            var result = solution.Intersect(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 });
            AssertHelper.AssertArray(new int[] { 2, 2 }, result);
        }

        [Test]
        public void Intersect_2() {
            var solution = new _0350_IntersectionOfTwoArraysII();
            var result = solution.Intersect(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 });
            AssertHelper.AssertArray(new int[] { 9, 4 }, result);
        }
    }
}
