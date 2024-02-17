namespace LeetCode.Test
{
    public class _1325_DeleteLeavesWithAGivenValue_Test
    {
        [Test]
        public void RemoveLeafNodes_1() {
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, 3, 2, null, 2, 4 });

            var solution = new _1325_DeleteLeavesWithAGivenValue();
            var result = solution.RemoveLeafNodes(root, 2);
            AssertHelper.AssertTree(new int?[] { 1, null, 3, null, 4 }, result);
        }

        [Test]
        public void RemoveLeafNodes_2() {
            var root = TestHelper.GenerateTree(new int?[] { 1, 3, 3, 3, 2 });

            var solution = new _1325_DeleteLeavesWithAGivenValue();
            var result = solution.RemoveLeafNodes(root, 3);
            AssertHelper.AssertTree(new int?[] { 1, 3, null, null, 2 }, result);
        }

        [Test]
        public void RemoveLeafNodes_3() {
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, null, 2, null, 2 });

            var solution = new _1325_DeleteLeavesWithAGivenValue();
            var result = solution.RemoveLeafNodes(root, 2);
            AssertHelper.AssertTree(new int?[] { 1 }, result);
        }

        [Test]
        public void RemoveLeafNodes_4() {
            var root = TestHelper.GenerateTree(new int?[] { 1, 1, 1 });

            var solution = new _1325_DeleteLeavesWithAGivenValue();
            var result = solution.RemoveLeafNodes(root, 1);
            Assert.IsNull(result);
        }

        [Test]
        public void RemoveLeafNodes_5() {
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, 3 });

            var solution = new _1325_DeleteLeavesWithAGivenValue();
            var result = solution.RemoveLeafNodes(root, 1);
            AssertHelper.AssertTree(new int?[] { 1, 2, 3 }, result);
        }
    }
}
