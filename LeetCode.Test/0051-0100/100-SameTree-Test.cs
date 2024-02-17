namespace LeetCode.Test
{
    public class _100_SameTree_Test
    {
        [Test]
        public void IsSameTreeTest_Same() {
            var solution = new _100_SameTree();
            Assert.IsTrue(solution.IsSameTree(
                                TestHelper.GenerateTree(new int?[] { 1, 2, 3 }),
                                TestHelper.GenerateTree(new int?[] { 1, 2, 3 })));
        }

        [Test]
        public void IsSameTreeTest_StructureDifferent() {
            var solution = new _100_SameTree();
            Assert.IsFalse(solution.IsSameTree(
                                TestHelper.GenerateTree(new int?[] { 1, 2 }),
                                TestHelper.GenerateTree(new int?[] { 1, null, 2 })));
            Assert.IsFalse(solution.IsSameTree(
                                TestHelper.GenerateTree(new int?[] { 1, null, 2 }),
                                TestHelper.GenerateTree(new int?[] { 1, 2 })));
        }

        [Test]
        public void IsSameTreeTest_ValueDifferent() {
            var solution = new _100_SameTree();
            Assert.IsFalse(solution.IsSameTree(
                                TestHelper.GenerateTree(new int?[] { 1, 2, 1 }),
                                TestHelper.GenerateTree(new int?[] { 1, 2, 2 })));
            Assert.IsFalse(solution.IsSameTree(
                                TestHelper.GenerateTree(new int?[] { 1, 2, 1 }),
                                TestHelper.GenerateTree(new int?[] { 1, 1, 2 })));
        }

        [Test]
        public void IsSameTreeTest_BothNull() {
            var solution = new _100_SameTree();
            Assert.IsTrue(solution.IsSameTree(null, null));
        }

        [Test]
        public void IsSameTreeTest_OneNull() {
            var solution = new _100_SameTree();
            Assert.IsFalse(solution.IsSameTree(TestHelper.GenerateTree(new int?[] { 1, 2, 1 }), null));
            Assert.IsFalse(solution.IsSameTree(null, TestHelper.GenerateTree(new int?[] { 1, 2, 1 })));
        }
    }
}
