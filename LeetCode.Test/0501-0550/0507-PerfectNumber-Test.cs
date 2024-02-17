namespace LeetCode.Test
{
    public class _0507_PerfectNumber_Test
    {
        [Test]
        public void CheckPerfectNumber_1() {
            var solution = new _0507_PerfectNumber();
            var result = solution.CheckPerfectNumber(28);
            Assert.IsTrue(result);
        }
    }
}
