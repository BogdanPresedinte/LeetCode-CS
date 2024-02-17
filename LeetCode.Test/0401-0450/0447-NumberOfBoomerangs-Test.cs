namespace LeetCode.Test
{
    public class _0447_NumberOfBoomerangs_Test
    {
        [Test]
        public void NumberOfBoomerangs_1() {
            var solution = new _0447_NumberOfBoomerangs();
            var result = solution.NumberOfBoomerangs(new int[][] {
                new int[] { 0, 0 },
                new int[] { 1, 0 },
                new int[] { 2, 0 },
            });
            Assert.AreEqual(2, result);
        }
    }
}
