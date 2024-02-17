namespace LeetCode.Test
{
    public class _089_GrayCode_Test
    {
        [Test]
        public void GrayCodeTest() {
            var solution = new _089_GrayCode();
            AssertHelper.AssertList(new int[] { 0, 1 }, solution.GrayCode(1));
            AssertHelper.AssertList(new int[] { 0, 1, 3, 2 }, solution.GrayCode(2));
            AssertHelper.AssertList(new int[] { 0, 1, 3, 2, 6, 7, 5, 4 }, solution.GrayCode(3));
            AssertHelper.AssertList(new int[] { 0, 1, 3, 2, 6, 7, 5, 4, 12, 13, 15, 14, 10, 11, 9, 8 }, solution.GrayCode(4));
        }

        [Test]
        public void GrayCodeTest_Zero() {
            var solution = new _089_GrayCode();
            AssertHelper.AssertList(new int[] { 0 }, solution.GrayCode(0));
        }
    }
}
