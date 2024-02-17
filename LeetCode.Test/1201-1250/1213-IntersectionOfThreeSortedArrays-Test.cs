namespace LeetCode.Test
{
    public class _1213_IntersectionOfThreeSortedArrays_Test
    {
        [Test]
        public void ArraysIntersection_1() {
            var solution = new _1213_IntersectionOfThreeSortedArrays();
            var result = solution.ArraysIntersection(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 5, 7, 9 }, new int[] { 1, 3, 4, 5, 8 });
            AssertHelper.AssertList(new int[] { 1, 5 }, result);
        }
    }
}
