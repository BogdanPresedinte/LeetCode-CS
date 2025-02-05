namespace LeetCode.Test
{
    public class _0728_SelfDividingNumbers_Test
    {
        [Test]
        public void SelfDividingNumbers_1() {
            var solution = new _0728_SelfDividingNumbers();
            var result = solution.SelfDividingNumbers(128, 128);
            AssertHelper.AssertList(new int[] { 128 }, result);
        }

        [Test]
        public void SelfDividingNumbers_2() {
            var solution = new _0728_SelfDividingNumbers();
            var result = solution.SelfDividingNumbers(1, 22);
            AssertHelper.AssertList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22 }, result);
        }
    }
}
