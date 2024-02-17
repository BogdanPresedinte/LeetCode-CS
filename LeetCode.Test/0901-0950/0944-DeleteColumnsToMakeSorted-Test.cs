namespace LeetCode.Test
{
    public class _0944_DeleteColumnsToMakeSorted_Test
    {
        [Test]
        public void MinDeletionSize_1() {
            var solution = new _0944_DeleteColumnsToMakeSorted();
            var result = solution.MinDeletionSize(new string[] { "cba", "daf", "ghi" });
            Assert.AreEqual(1, result);
        }

        [Test]
        public void MinDeletionSize_2() {
            var solution = new _0944_DeleteColumnsToMakeSorted();
            var result = solution.MinDeletionSize(new string[] { "a", "b" });
            Assert.AreEqual(0, result);
        }

        [Test]
        public void MinDeletionSize_3() {
            var solution = new _0944_DeleteColumnsToMakeSorted();
            var result = solution.MinDeletionSize(new string[] { "zyx", "wvu", "tsr" });
            Assert.AreEqual(3, result);
        }
    }
}
