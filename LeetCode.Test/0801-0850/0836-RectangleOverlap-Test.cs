namespace LeetCode.Test
{
    public class _0836_RectangleOverlap_Test
    {
        [Test]
        public void IsRectangleOverlap_1() {
            var solution = new _0836_RectangleOverlap();
            var result = solution.IsRectangleOverlap(new int[] { 0, 0, 2, 2 }, new int[] { 1, 1, 3, 3 });
            Assert.IsTrue(result);
        }

        [Test]
        public void IsRectangleOverlap_2() {
            var solution = new _0836_RectangleOverlap();
            var result = solution.IsRectangleOverlap(new int[] { 0, 0, 1, 1 }, new int[] { 1, 0, 2, 1 });
            Assert.IsFalse(result);
        }
    }
}
