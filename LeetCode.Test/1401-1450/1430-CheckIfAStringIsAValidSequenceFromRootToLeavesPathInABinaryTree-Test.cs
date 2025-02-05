namespace LeetCode.Test
{
    public class _1430_CheckIfAStringIsAValidSequenceFromRootToLeavesPathInABinaryTree_Test
    {
        [Test]
        public void IsValidSequence_1() {
            var root = TestHelper.GenerateTree(new int?[] { 0, 1, 0, 0, 1, 0, null, null, 1, 0, 0 });

            var solution = new _1430_CheckIfAStringIsAValidSequenceFromRootToLeavesPathInABinaryTree();
            var result = solution.IsValidSequence(root, new int[] { 0, 1, 0, 1 });
            Assert.IsTrue(result);
        }

        [Test]
        public void IsValidSequence_2() {
            var root = TestHelper.GenerateTree(new int?[] { 0, 1, 0, 0, 1, 0, null, null, 1, 0, 0 });

            var solution = new _1430_CheckIfAStringIsAValidSequenceFromRootToLeavesPathInABinaryTree();
            var result = solution.IsValidSequence(root, new int[] { 0, 0, 1 });
            Assert.IsFalse(result);
        }

        [Test]
        public void IsValidSequence_3() {
            var root = TestHelper.GenerateTree(new int?[] { 0, 1, 0, 0, 1, 0, null, null, 1, 0, 0 });

            var solution = new _1430_CheckIfAStringIsAValidSequenceFromRootToLeavesPathInABinaryTree();
            var result = solution.IsValidSequence(root, new int[] { 0, 1, 1 });
            Assert.IsFalse(result);
        }

        [Test]
        public void IsValidSequence_4() {
            var root = TestHelper.GenerateTree(new int?[] { 0, 9, 0, 5, 6, 6, 9, 2, 8, 1, 6, 9, 5, 6, 3, 1, 4, 1, 9, 9, 1, 0, 1, 9, 7, 0, 4, 6, 5, 2, 7, 3, 3, 6, 9, 8, 2, 9, 1, 8, 5, 9, 2, null, 5, 3, 4, 7, 6, 5, 3, 2, 7, 6, 4, 0, 2, 0, 5, 8, 4, 1, 2, 9, 0, null, 2, 7, 8, 7, 4, 9, null, 9, 3, 9, 7, 0, 7, 3, 7, null, 7, 3, 5, 4, 1, 1, 8, null, 7, 7, 9, 4, 2, 6, 0, null, 5, 5, 4, 1, 0, 7, 4, 9, 8, 2, 8, 5, 2, null, null, 1, 9, 0, 5, 7, 3, null, null, 9, 4, 3, 6, 2, 9, 1, 1, 8, 5, 0, null, 8, null, 6, 8, 4, 5, 2, 3, null, null, null, null, 0, null, 2, 9, 1, null, null, null, 8, null, 7, null, 1, 1, null, 5, 8, 9, 5, 6, null, 4, 5, 9, null, 4, 6, null, null, 1, 8, null, 6, 3, 4, 5, 7, 3, 3, 9, 8, null, 0, 1, 3, 9, 9, 0, 4, 3, 1, 3, 9, 2, 1, 9, 5, null, 1, 8, 3, 6, null, null, 5, 3, null, 2, 2, 4, 6, 9, 8, 2, null, 5, 2, null, null, 4, 1, 6, null, 9, 5, 8, 3, null, null, 8, 3, null, 7, 6, null, 6, 4, null, null, null, null, null, 7, 0, 9, 4, 6, 5, 2, 3, null, 0, 2, 1, null, null, 8, 3, null, null, null, null, null, null, 1, 0, null, null, null, 4, null, 9, null, 7, null, null, 5, 7, null, 2, null, 0, null, 5, null, null, null, null, null, 0, 4, null, 2, 3, 2, null, 5, null, 1, 5, 3, null, null, 6, 2, 4, 1, 9, 9, 3, null, null, 3, 9, 0, null, 7, 7, 2, 8, 9, 8, 8, 2, 6, 9, 4, 6, 3, 0, 5, 0, 8, null, null, 5, 5, 6, 3, 0, 6, 9, 0, 0, 1, 0, 1, 0, 7, 2, null, null, null, null, null, null, null, null, 0, 6, 8, 4, null, 5, 3, 0, 9, null, null, null, null, 5, 7, 9, 0, 8, 4, 6, 3, 5, 9, null, null, null, null, null, null, null, null, null, 9, 9, 0, null, null, 9, 1, 9, 6, 6, null, 1, 2, null, 2, 4, 4, 7, 5, 4, 0, 1, 4, 9, null, 8, 3, null, null, null, 0, null, 4, null, null, 6, null, null, null, null, null, null, null, null, 4, null, null, null, null, null, null, null, null, null, 0, null, null, null, null, null, null, null, 2, 8, null, null, 8, 6, 1, 6, null, 4, 1, 2, 0, null, null, 0, 2, null, 2, 7, 7, 0, 6, 4, 1, 4, 1, 9, 9, 7, 0, 8, 7, 7, 3, 5, 7, 1, 8, null, 2, 8, 9, null, 5, 4, 0, 5, 4, null, 3, 6, 5, 7, 0, 4, null, 5, 7, 8, 8, 2, null, null, null, null, 3, 4, null, 1, 8, 6, 4, 7, 7, 7, 6, null, 8, 8, null, 1, 0, 9, null, null, 5, 8, 4, 7, null, 7, null, 3, 2, null, null, null, null, 4, 0, 3, 3, 5, 8, 2, null, 7, 4, 9, null, null, null, 0, 4, 8, 3, 0, 7, 0, 4, null, 3, null, null, null, 6, 8, 6, null, 1, 2, 2, 6, null, null, null, null, 3, 7, null, 0, 7, 1, 5, 3, null, null, 9, 6, null, null, null, 7, 7, 2, 6, 3, null, null, 9, 7, 0, 9, 0, null, 4, 5, 1, 3, 2, null, null, null, 7, null, null, null, null, null, null, null, null, 9, null, null, 5, 9, null, 9, null, null, 9, 6, null, 2, null, null, null, null, null, null, 6, null, 7, 9, 2, 6, 4, 3, null, 0, null, null, 1, 3, 1, 4, 3, 4, 7, null, null, null, null, null, 0, null, 7, 6, 3, 4, null, 3, 3, 9, null, null, 8, 8, 6, 4, 0, null, 4, 0, null, 4, null, 6, 3, 6, 7, null, null, null, 0, 2, 6, 0, 8, 2, null, 9, 4, 1, 5, 9, 9, 1, 0, 0, 4, 6, 1, 1, 3, null, 6, 0, 3, 7, 1, 3, 7, 4, 9, 0, null, 4, 9, null, null, 9, 4, 0, 2, 6, 4, null, null, null, 0, null, 3, 3, 4, 6, null, null, 4, null, null, null, 5, null, null, 3, 0, 3, null, null, 9, 1, 0, null, 6, 8, 2, null, null, null, null, 5, null, null, 5, null, 8, null, null, null, 6, null, 4, null, 5, null, 0, null, null, 7, 3, null, null, null, 9, null, null, 1, 9, 4, null, 4, 2, null, null, null, 3, 7, null, null, null, 5, 7, null, null, null, 8, null, null, null, null, null, null, null, 5, null, null, null, null, 2, 3, 6, null, null, 1, null, 3, 3, null, null, null, null, null, 2, 4, 0, null, 7, null, 2, 4, 1, 2, 6, null, 0, null, 8, null, 8, 8, 0, null, 8, 0, null, 0, null, null, 9, null, null, null, null, 4, 2, 4, 8, null, null, null, null, null, 7, null, null, null, null, null, 5, 1, null, null, null, 8, null, 9, 4, null, null, 1, null, 7, 5, 8, 9, 0, null, null, null, null, null, 1, 2, 7, null, null, 1, 2, 7, 4, 8, 6, 6, 4, 0, 9, 3, null, null, 2, null, null, null, null, null, null, null, null, null, 8, null, 0, null, 5, 3, 4, null, 4, 7, 5, null, null, null, null, 9, 6, 0, 7, 4, 7, 4, 7, 0, null, 0, 9, 1, 3, null, 9, null, null, null, 6, 1, null, null, 2, 9, 9, 5, 2, 9, null, null, 5, 8, 5, 4, 8, 1, 9, 6, 9, 9, 7, 8, 5, null, 0, 4, 9, 2, 1, 7, 3, 8, 7, 9, null, 0, 3, 9, 7, 9, 8, null, 3, 5, null, null, 0, 6, null, null, 2, 6, null, 9, null, null, 0, null, null, null, null, null, null, null, 2, null, null, null, null, 1, null, 4, null, null, 2, 6, 0, 2, 0, 2, null, null, null, null, null, 0, 2, 9, 5, 4, null, null, null, null, 1, 8, null, 4, null, null, null, 7, null, 4, null, null, null, 5, null, 9, null, null, 6, null, 9, 6, null, 3, null, null, null, null, 3, null, null, null, 9, 1, null, null, 7, null, null, 6, 8, null, null, null, null, null, null, null, 4, null, null, null, 9, null, null, null, null, null, 9, 8, null, 0, 7, 1, 2, 0, null, null, null, null, null, null, 7, null, null, null, null, null, null, null, null, null, null, null, 2, 1, null, null, 5, null, null, null, 5, null, null, 6, null, null, null, null, null, 1, null, null, 9, null, 3, 6, null, null, 1, 9, 3, 1, 2, 7, 8, null, null, null, 1, null, null, null, null, null, 8, 9, 0, null, 9, null, 1, null, null, null, 5, 1, 7, null, 3, 0, null, null, null, 0, null, null, null, null, 3, 4, null, null, 2, null, 0, null, 6, null, null, null, null, null, 9, null, 2, 3, 4, 4, 0, 9, 7, 4, 6, null, null, null, 5, 0, null, 6, null, null, null, 5, 2, 7, null, 5, null, 8, null, 6, 0, 4, null, null, 6, 1, 0, 6, 6, null, 2, null, null, 7, 5, 2, 7, null, 0, 2, 7, null, 3, 3, 3, null, 6, 3, 2, 4, null, 1, 9, null, 2, null, 1, 8, null, 7, 4, 0, 0, 2, 3, 3, null, null, null, null, null, null, 5, 2, 7, 4, 4, 7, 7, null, 8, 7, null, null, null, null, null, null, 7, 8, null, null, null, null, null, 7, 1, 0, null, 1, null, 8, null, null, null, null, null, null, null, 2, 1, 5, null, null, null, null, 2, 6, null, null, 8, 5, 4, 4, 0, 1, null, 7, 8, null, null, null, null, 0, null, 4, 5, 0, 2, null, 3, 9, null, null, null, 4, 9, null, 9, null, null, null, 7, 7, null, 0, null, null, null, 5, null, 6, 0, 0, null, null, null, null, null, null, null, null, null, 9, null, null, 0, null, 3, 7, null, 6, null, null, null, null, null, null, null, 1, 9, 6, null, 7, 1, 2, 7, 3, 7, 4, null, null, null, null, null, null, 3, 1, 1, 9, 2, 6, null, null, null, 3, 9, 0, 3, 1, null, null, null, null, 4, null, null, 0, null, null, null, 1, 9, 0, null, 0, 2, 8, 6, null, null, null, null, null, 1, null, 6, 4, null, null, null, null, null, null, null, null, 6, null, null, 1, null, null, null, null, 6, 4, 6, 7, null, null, 4, 5, null, null, null, 4, null, 4, null, 3, null, 1, 8, 5, null, 4, null, null, null, 6, 4, 1, 1, 0, 0, 0, 6, 4, null, 3, 4, 6, 9, null, 2, null, null, 4, null, null, 8, null, null, null, null, null, null, null, null, null, 0, 8, null, 6, null, null, 2, 0, 8, null, 9, 7, null, null, 3, 7, null, null, 8, null, null, 0, 2, null, 1, null, 6, 4, 5, 0, 0, 9, 7, 4, null, 9, 5, 7, 3, 4, null, null, null, 4, 7, 3, null, 5, 4, null, 9, null, null, 6, 7, null, null, null, null, null, null, null, 5, 2, null, null, null, null, 7, null, null, null, 3, 8, 7, null, null, null, null, null, 0, 3, null, null, 7, 5, null, null, 2, 8, null, null, null, 0, null, null, null, null, null, null, null, null, null, 4, null, null, 6, 3, null, null, null, null, null, null, null, null, 9, 0, 8, null, 6, 1, null, null, null, 9, null, null, null, 4, 3, null, null, null, 5, null, 8, 3, 2, 9, 5, 7, null, 3, 6, null, 1, null, 3, 3, null, null, 8, null, null, null, null, null, null, null, 2, 1, 3, 6, null, null, 7, null, 2, null, null, null, null, null, null, 4, 9, null, 3, null, 5, null, null, 5, null, null, null, null, null, null, null, null, null, 4, null, null, 1, null, 2, null, null, null, null, null, null, null, null, null, null, 2, 0, 0, null, null, null, null, 4, 3, 4, 1, 8, 7, 6, 1, 3, null, null, 8, null, null, null, null, null, null, null, null, null, 7, null, null, 5, 9, null, null, null, 0, 9, 5, 4, 1, 9, null, 0, 3, 8, 5, null, 9, 6, 0, null, 2, 9, 8, 1, null, null, null, 2, null, 0, 2, null, 8, null, null, null, 6, 7, 0, 0, 6, 4, null, 2, 0, null, null, null, 9, null, 2, 5, 3, null, null, null, null, null, 9, 5, null, 6, 1, null, 0, 3, 6, 8, 1, 6, 1, null, 6, 9, 2, 0, 8, 8, 5, 1, 8, 2, 8, 0, null, null, null, null, 7, null, null, null, null, null, null, null, null, null, 4, null, 4, null, 8, 7, null, null, null, null, null, 8, 6, null, 5, 2, null, null, null, null, null, 8, null, null, 6, null, 8, null, null, null, null, null, null, 5, null, null, null, 9, 7, 0, 0, null, null, null, null, null, 8, null, 1, null, null, null, null, null, null, null, null, 2, null, 7, 7, null, 7, 4, null, null, null, null, null, null, null, 8, null, null, null, 1, null, 0, 2, null, null, null, null, null, 3, null, 3, 6, 9, 5, null, 0, null, 1, null, null, 6, null, 4, null, null, null, null, null, 5, null, null, 6, null, 7, 0, 6, 8, 3, null, 5, null, 7, 7, null, null, 2, null, 5, null, null, 9, null, 6, null, null, null, 1, null, null, null, null, null, null, null, null, null, null, 5, null, null, null, null, 2, 6, 6, null, 9, null, 4, null, 2, 9, 3, null, null, 3, 7, 2, 1, 5, 6, null, null, null, null, 0, null, 6, 7, 2, 0, 5, null, null, null, null, 6, null, 6, 7, null, null, null, 4, null, null, 4, null, 5, null, null, null, null, null, null, null, null, 8, 5, null, null, null, 0, 7, 8, null, 0, 1, 6, 9, 7, 5, 0, null, 9, 7, 1, null, null, null, null, null, null, null, null, 8, 2, null, 6, null, 3, 1, 3, 1, 4, 6, 3, 5, 5, 4, 5, null, null, null, null, 7, 3, null, null, null, 3, null, 6, null, null, 5, null, 4, 9, 4, null, 3, null, null, null, null, null, null, null, null, null, null, null, 9, null, null, null, null, null, null, 6, null, null, null, null, 3, 6, null, null, null, null, null, null, 3, null, null, null, null, null, 4, null, null, null, null, null, null, 6, null, null, 1, null, null, null, null, null, null, null, null, null, null, null, null, 8, null, 9, 5, null, 9, 6, 0, 7, 3, 9, null, null, 3, 9, null, null, 4, null, null, null, null, null, null, null, null, 1, 8, null, null, null, null, 7, null, 6, 7, 5, null, null, 6, 5, null, null, null, null, null, null, null, null, null, 0, 1, null, null, null, 8, 0, 0, 3, null, null, null, null, null, 0, 0, null, null, null, 6, 3, null, 4, 5, 3, null, null, null, 9, null, null, null, null, null, 7, 5, 4, 8, 6, 5, 1, null, 4, 5, 3, null, 8, 1, 2, 7, 6, 8, 9, 6, null, null, null, null, null, 6, null, 3, 7, null, null, 6, 0, null, null, null, null, 6, 4, 9, 2, 9, 3, 1, null, 5, 7, null, null, null, null, 1, 1, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 0, null, null, null, 2, null, null, 6, null, null, null, null, null, null, 7, null, null, null, null, 0, 8, null, null, 3, null, null, null, null, null, null, null, null, null, 3, null, null, null, null, null, null, null, null, 5, null, null, null, null, 9, null, 5, null, 4, null, null, null, null, null, null, null, 2, null, null, null, 7, null, null, 1, 5, 7, 8, null, null, 8, null, null, 1, null, 3, null, null, 4, 6, null, null, 9, null, null, null, 1, 2, 4, null, 1, 1, null, null, 3, null, 4, 3, null, null, null, 5, 6, 0, 6, 4, 3, 8, null, 9, null, null, null, 9, null, null, null, 0, 7, null, null, 3, null, 9, 8, 1, 2, 7, 7, null, null, 4, null, 6, 8, 3, 9, null, null, 2, null, null, 8, null, null, null, 8, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 5, null, null, 7, null, null, null, null, null, null, null, null, null, 5, null, null, null, null, 0, null, null, null, null, null, null, null, null, null, null, null, 4, null, 3, null, 8, 2, 0, null, null, null, null, 0, null, null, 6, null, null, null, 7, null, null, 8, 3, 0, null, null, null, null, null, null, 4, 4, null, null, null, null, 1, null, null, 3, null, null, 2, null, 5, 8, null, null, null, null, null, null, null, null, null, 7, null, null, null, null, null, null, null, null, null, null, null, null, null, 2, null, null, null, null, null, null, null, null, null, null, 3, 8, 3, 5, null, null, null, 4, null, null, 8, null, 0, 0, null, 2, null, 1, null, 7, null, 5, 9, 2, null, null, null, 9, 3, 0, 3, null, null, null, null, 6, 0, 6, null, 5, 8, null, 7, 7, null, null, null, null, null, 2, 4, 9, null, null, null, null, null, 5, null, 6, null, null, null, null, null, null, 5, null, null, null, null, null, null, 8, null, 9 });

            var solution = new _1430_CheckIfAStringIsAValidSequenceFromRootToLeavesPathInABinaryTree();
            var result = solution.IsValidSequence(root, new int[] { 0, 0, 6, 9, 9, 7, 4, 6, 2, 8, 9, 4, 5, 7, 3, 8 });
            Assert.IsTrue(result);
        }
    }
}
