namespace LeetCode.Test
{
    public class _0582_KillProcess_Test
    {
        [Test]
        public void KillProcess_1() {
            var solution = new _0582_KillProcess();
            var result = solution.KillProcess(new int[] { 1, 3, 10, 5 }, new int[] { 3, 0, 5, 3 }, 5);
            AssertHelper.AssertList(new int[] { 5, 10 }, result);
        }

        [Test]
        public void KillProcess_2() {
            var solution = new _0582_KillProcess();
            var result = solution.KillProcess(new int[] { 1, 3, 10, 5 }, new int[] { 3, 0, 5, 3 }, 3);
            AssertHelper.AssertList(new int[] { 3, 1, 5, 10 }, result);
        }
    }
}
