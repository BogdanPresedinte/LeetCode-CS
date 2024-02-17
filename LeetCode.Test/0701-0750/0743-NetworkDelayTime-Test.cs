namespace LeetCode.Test
{
    public class _0743_NetworkDelayTime_Test
    {
        [Test]
        public void NetworkDelayTimeTest() {
            var solution = new _0743_NetworkDelayTime();
            var result = solution.NetworkDelayTime(new int[][]
            {
                new int[] { 2, 1, 1 },
                new int[] { 2, 3, 1 },
                new int[] { 3, 4, 1 }
            }, 4, 2);
        }
    }
}
