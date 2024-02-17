namespace LeetCode.Test
{
    public class _1217_PlayWithChips_Test
    {
        [Test]
        public void MinCostToMoveChips_1() {
            var solution = new _1217_PlayWithChips();
            var result = solution.MinCostToMoveChips(new int[] { 1, 2, 3 });
            Assert.AreEqual(1, result);
        }

        [Test]
        public void MinCostToMoveChips_2() {
            var solution = new _1217_PlayWithChips();
            var result = solution.MinCostToMoveChips(new int[] { 2, 2, 2, 3, 3 });
            Assert.AreEqual(2, result);
        }
    }
}
