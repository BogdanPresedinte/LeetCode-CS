namespace LeetCode.Test
{
    public class _0894_AllPossibleFullBinaryTrees_Test
    {
        [Test]
        public void AllPossibleFBT_1() {
            var solution = new _0894_AllPossibleFullBinaryTrees();
            var result = solution.AllPossibleFBT(2);
            Assert.AreEqual(0, result.Count);
        }

        [Test]
        public void AllPossibleFBT_2() {
            var solution = new _0894_AllPossibleFullBinaryTrees();
            var result = solution.AllPossibleFBT(1);
            AssertHelper.AssertTrees(new List<int?[]> {
                new int?[] { 0 },
            }, result);
        }

        [Test]
        public void AllPossibleFBT_3() {
            var solution = new _0894_AllPossibleFullBinaryTrees();
            var result = solution.AllPossibleFBT(3);
            AssertHelper.AssertTrees(new List<int?[]> {
                new int?[] { 0, 0, 0 },
            }, result);
        }

        [Test]
        public void AllPossibleFBT_4() {
            var solution = new _0894_AllPossibleFullBinaryTrees();
            var result = solution.AllPossibleFBT(7);
            AssertHelper.AssertTrees(new List<int?[]> {
                new int?[] { 0, 0, 0, null, null, 0, 0, null, null, 0, 0 },
                new int?[] { 0, 0, 0, null, null, 0, 0, 0, 0 },
                new int?[] { 0, 0, 0, 0, 0, 0, 0 },
                new int?[] { 0, 0, 0, 0, 0, null, null, null, null, 0, 0 },
                new int?[] { 0, 0, 0, 0, 0, null, null, 0, 0 },
            }, result);
        }
    }
}
