namespace LeetCode.Test
{
    public class _0470_ImplementRand10UsingRand7_Test
    {
        [Test]
        public void Rand10_1() {
            var solution = new _0470_ImplementRand10UsingRand7();

            for (int i = 0; i < 1000; i++) {
                var result = solution.Rand10();
                Assert.IsTrue(result > 0);
                Assert.IsTrue(result <= 10);
            }
        }
    }
}
