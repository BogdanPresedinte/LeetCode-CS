namespace LeetCode.Test
{
    public class _0563_BinaryTreeTilt_Test
    {
        [Test]
        public void FindTilt_1() {
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, 3 });

            var solution = new _0563_BinaryTreeTilt();
            var result = solution.FindTilt(root);
            Assert.AreEqual(1, result);
        }
    }
}
