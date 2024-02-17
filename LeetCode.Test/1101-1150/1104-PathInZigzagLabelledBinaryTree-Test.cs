namespace LeetCode.Test
{
    public class _1104_PathInZigzagLabelledBinaryTree_Test
    {
        [Test]
        public void PathInZigZagTree_1() {
            var solution = new _1104_PathInZigzagLabelledBinaryTree();
            var result = solution.PathInZigZagTree(14);
            AssertHelper.AssertList(new int[] { 1, 3, 4, 14 }, result);
        }

        [Test]
        public void PathInZigZagTree_2() {
            var solution = new _1104_PathInZigzagLabelledBinaryTree();
            var result = solution.PathInZigZagTree(26);
            AssertHelper.AssertList(new int[] { 1, 2, 6, 10, 26 }, result);
        }

        [Test]
        public void PathInZigZagTree_3() {
            var solution = new _1104_PathInZigzagLabelledBinaryTree();
            var result = solution.PathInZigZagTree(16);
            AssertHelper.AssertList(new int[] { 1, 3, 4, 15, 16 }, result);
        }
    }
}
