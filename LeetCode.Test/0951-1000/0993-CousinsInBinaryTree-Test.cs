namespace LeetCode.Test
{
    public class _0993_CousinsInBinaryTree_Test
    {
        [Test]
        public void IsCousins_1() {
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, 3, 4 });

            var solution = new _0993_CousinsInBinaryTree();
            var result = solution.IsCousins(root, 4, 3);
            Assert.IsFalse(result);
        }

        [Test]
        public void IsCousins_2() {
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, 3, null, 4, null, 5 });

            var solution = new _0993_CousinsInBinaryTree();
            var result = solution.IsCousins(root, 5, 4);
            Assert.IsTrue(result);
        }

        [Test]
        public void IsCousins_3() {
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, 3, null, 4 });

            var solution = new _0993_CousinsInBinaryTree();
            var result = solution.IsCousins(root, 2, 3);
            Assert.IsFalse(result);
        }
    }
}
