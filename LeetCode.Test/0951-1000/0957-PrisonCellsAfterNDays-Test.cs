namespace LeetCode.Test
{
    public class _0957_PrisonCellsAfterNDays_Test
    {
        [Test]
        public void PrisonAfterNDays_1() {
            var solution = new _0957_PrisonCellsAfterNDays();
            var result = solution.PrisonAfterNDays(new int[] { 0, 1, 0, 1, 1, 0, 0, 1 }, 7);
            AssertHelper.AssertArray(new int[] { 0, 0, 1, 1, 0, 0, 0, 0 }, result);
        }

        [Test]
        [Timeout(500)]
        public void PrisonAfterNDays_2() {
            var solution = new _0957_PrisonCellsAfterNDays();
            var result = solution.PrisonAfterNDays(new int[] { 1, 0, 0, 1, 0, 0, 1, 0 }, 1000000000);
            AssertHelper.AssertArray(new int[] { 0, 0, 1, 1, 1, 1, 1, 0 }, result);
        }
    }
}
