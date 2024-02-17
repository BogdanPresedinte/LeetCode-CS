namespace LeetCode.Test
{
    public class _0278_FirstBadVersion_Test
    {
        [Test]
        public void FirstBadVersion_1() {
            var solution = new _0278_FirstBadVersion();
            var result = solution.FirstBadVersion(5);
            Assert.AreEqual(4, result);
        }
    }
}
