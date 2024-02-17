namespace LeetCode.Test
{
    public class _1243_ArrayTransformation_Test
    {
        [Test]
        public void TransformArray_1() {
            var solution = new _1243_ArrayTransformation();
            var result = solution.TransformArray(new int[] { 6, 2, 3, 4 });
            AssertHelper.AssertList(new int[] { 6, 3, 3, 4 }, result);
        }

        [Test]
        public void TransformArray_2() {
            var solution = new _1243_ArrayTransformation();
            var result = solution.TransformArray(new int[] { 1, 6, 3, 4, 3, 5 });
            AssertHelper.AssertList(new int[] { 1, 4, 4, 4, 4, 5 }, result);
        }
    }
}
