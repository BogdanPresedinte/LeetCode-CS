namespace LeetCode.Test
{
    public class _0724_FindPivotIndex_Test
    {
        [Test]
        public void PivotIndex_1() {
            var solution = new _0724_FindPivotIndex();
            var result = solution.PivotIndex(new int[] { 1, 7, 3, 6, 5, 6 });
            Assert.AreEqual(3, result);
        }

        [Test]
        public void PivotIndex_2() {
            var solution = new _0724_FindPivotIndex();
            var result = solution.PivotIndex(new int[] { 1, 2, 3 });
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void PivotIndex_3() {
            var solution = new _0724_FindPivotIndex();
            var result = solution.PivotIndex(new int[] { 1, 7, 3, 0, -1, 1, 5, 6 });
            Assert.AreEqual(3, result);
        }
    }
}
