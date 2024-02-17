namespace LeetCode.Test
{
    public class _1137_NThTribonacciNumber_Test
    {
        [Test]
        public void Tribonacci_1() {
            var solution = new _1137_NThTribonacciNumber();
            var result = solution.Tribonacci(4);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Tribonacci_2() {
            var solution = new _1137_NThTribonacciNumber();
            var result = solution.Tribonacci(25);
            Assert.AreEqual(1389537, result);
        }
    }
}
