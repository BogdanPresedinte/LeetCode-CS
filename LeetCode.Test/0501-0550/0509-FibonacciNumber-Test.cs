namespace LeetCode.Test
{
    public class _0509_FibonacciNumber_Test
    {
        [Test]
        public void Fib_1() {
            var solution = new _0509_FibonacciNumber();
            var result = solution.Fib(2);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Fib_2() {
            var solution = new _0509_FibonacciNumber();
            var result = solution.Fib(3);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Fib_3() {
            var solution = new _0509_FibonacciNumber();
            var result = solution.Fib(4);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Fib_4() {
            var solution = new _0509_FibonacciNumber();
            var result = solution.Fib(5);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Fib_5() {
            var solution = new _0509_FibonacciNumber();
            var result = solution.Fib(6);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void Fib_6() {
            var solution = new _0509_FibonacciNumber();
            var result = solution.Fib(7);
            Assert.AreEqual(13, result);
        }
    }
}
