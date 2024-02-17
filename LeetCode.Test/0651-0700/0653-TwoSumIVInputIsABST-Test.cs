namespace LeetCode.Test
{
    public class _0653_TwoSumIVInputIsABST_Test
    {
        [Test]
        public void FindTarget_1() {
            var root = TestHelper.GenerateTree(new int?[] { 5, 3, 6, 2, 4, null, 7 });

            var solution = new _0653_TwoSumIVInputIsABST();
            var result = solution.FindTarget(root, 9);
            Assert.IsTrue(result);
        }

        [Test]
        public void FindTarget_2() {
            var root = TestHelper.GenerateTree(new int?[] { 5, 3, 6, 2, 4, null, 7 });

            var solution = new _0653_TwoSumIVInputIsABST();
            var result = solution.FindTarget(root, 28);
            Assert.IsFalse(result);
        }
    }
}
