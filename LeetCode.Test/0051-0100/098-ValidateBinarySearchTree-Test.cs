namespace LeetCode.Test
{
    public class _098_ValidateBinarySearchTree_Test
    {
        [Test]
        public void IsValidBSTTest() {
            var solution = new _098_ValidateBinarySearchTree();
            Assert.IsTrue(solution.IsValidBST(TestHelper.GenerateTree(new int?[] { 2, 1, 3 })));
        }

        [Test]
        public void IsValidBSTTest_Invalid() {
            var solution = new _098_ValidateBinarySearchTree();
            Assert.IsFalse(solution.IsValidBST(TestHelper.GenerateTree(new int?[] { 5, 1, 4, null, null, 3, 6 })));
        }

        [Test]
        public void IsValidBSTTest_Invalid_2Layer() {
            var solution = new _098_ValidateBinarySearchTree();
            Assert.IsFalse(solution.IsValidBST(TestHelper.GenerateTree(new int?[] { 5, 1, 6, null, null, 3, 8 })));
        }

        [Test]
        public void IsValidBSTTest_Empty() {
            var solution = new _098_ValidateBinarySearchTree();
            Assert.IsTrue(solution.IsValidBST(null));
        }

        [Test]
        public void IsValidBSTTest_MaxInt() {
            var solution = new _098_ValidateBinarySearchTree();
            Assert.IsTrue(solution.IsValidBST(TestHelper.GenerateTree(new int?[] { int.MaxValue })));
            Assert.IsFalse(solution.IsValidBST(TestHelper.GenerateTree(new int?[] { int.MaxValue, null, int.MaxValue })));
        }

        [Test]
        public void IsValidBSTTest_MinInt() {
            var solution = new _098_ValidateBinarySearchTree();
            Assert.IsTrue(solution.IsValidBST(TestHelper.GenerateTree(new int?[] { int.MinValue })));
            Assert.IsFalse(solution.IsValidBST(TestHelper.GenerateTree(new int?[] { int.MinValue, int.MinValue })));
        }
    }
}
