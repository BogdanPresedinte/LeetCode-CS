namespace LeetCode.Test
{
    public class _0453_MinimumMovesToEqualArrayElements_Test
    {
        [Test]
        public void MinMoves_1() {
            var solution = new _0453_MinimumMovesToEqualArrayElements();
            var result = solution.MinMoves(new int[] { 1, 2, 3 });
            Assert.AreEqual(3, result);
        }

        [Test]
        public void MinMoves_2() {
            var solution = new _0453_MinimumMovesToEqualArrayElements();
            var result = solution.MinMoves(new int[] { 1, 2, 3, 4 });
            Assert.AreEqual(6, result);
        }
    }
}
