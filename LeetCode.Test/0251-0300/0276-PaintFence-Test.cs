namespace LeetCode.Test
{
    public class _0276_PaintFence_Test
    {
        [Test]
        public void NumWays_1() {
            var solution = new _0276_PaintFence();
            var result = solution.NumWays(3, 2);
            Assert.AreEqual(6, result);
        }
    }
}
