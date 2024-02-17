namespace LeetCode.Test
{
    public class _1379_FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree_Test
    {
        [Test]
        public void GetTargetCopy_1() {
            var root1 = TestHelper.GenerateTree(new int?[] { 7, 4, 3, null, null, 6, 19 });
            var root2 = TestHelper.GenerateTree(new int?[] { 7, 4, 3, null, null, 6, 19 });

            var solution = new _1379_FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree();
            var result = solution.GetTargetCopy(root1, root2, root1.right);
            Assert.AreEqual(root2.right, result);
        }

        [Test]
        public void GetTargetCopy_2() {
            var root1 = TestHelper.GenerateTree(new int?[] { 7 });
            var root2 = TestHelper.GenerateTree(new int?[] { 7 });

            var solution = new _1379_FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree();
            var result = solution.GetTargetCopy(root1, root2, root1);
            Assert.AreEqual(root2, result);
        }

        [Test]
        public void GetTargetCopy_3() {
            var root1 = TestHelper.GenerateTree(new int?[] { 8, null, 6, null, 5, null, 4, null, 3, null, 2, null, 1 });
            var root2 = TestHelper.GenerateTree(new int?[] { 8, null, 6, null, 5, null, 4, null, 3, null, 2, null, 1 });

            var solution = new _1379_FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree();
            var result = solution.GetTargetCopy(root1, root2, root1.right.right.right);
            Assert.AreEqual(root2.right.right.right, result);
        }

        [Test]
        public void GetTargetCopy_4() {
            var root1 = TestHelper.GenerateTree(new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            var root2 = TestHelper.GenerateTree(new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            var solution = new _1379_FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree();
            var result = solution.GetTargetCopy(root1, root2, root1.left.right);
            Assert.AreEqual(root2.left.right, result);
        }

        [Test]
        public void GetTargetCopy_5() {
            var root1 = TestHelper.GenerateTree(new int?[] { 1, 2, null, 3 });
            var root2 = TestHelper.GenerateTree(new int?[] { 1, 2, null, 3 });

            var solution = new _1379_FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree();
            var result = solution.GetTargetCopy(root1, root2, root1.left);
            Assert.AreEqual(root2.left, result);
        }
    }
}
