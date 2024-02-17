namespace LeetCode.Test
{
    public class _0256_PaintHouse_Test
    {
        [Test]
        public void MinCost_1() {
            var solution = new _0256_PaintHouse();
            var result = solution.MinCost(new int[][] {
                new int[] { 17, 2, 17 },
                new int[] { 16, 16, 5 },
                new int[] { 14, 3, 19 },
            });
            Assert.AreEqual(10, result);
        }
    }
}
