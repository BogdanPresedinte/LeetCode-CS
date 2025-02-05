namespace LeetCode.Test
{
    public class _0455_AssignCookies_Test
    {
        [Test]
        public void FindContentChildren_1() {
            var solution = new _0455_AssignCookies();
            var result = solution.FindContentChildren(new int[] { 1, 2, 3 }, new int[] { 1, 1 });
            Assert.AreEqual(1, result);
        }

        [Test]
        public void FindContentChildren_2() {
            var solution = new _0455_AssignCookies();
            var result = solution.FindContentChildren(new int[] { 1, 2 }, new int[] { 1, 2, 3 });
            Assert.AreEqual(2, result);
        }
    }
}
