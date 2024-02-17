namespace LeetCode.Test
{
    public class _1056_ConfusingNumber_Test
    {
        [Test]
        public void ConfusingNumber_1() {
            var solution = new _1056_ConfusingNumber();
            var result = solution.ConfusingNumber(6);
            Assert.IsTrue(result);
        }

        [Test]
        public void ConfusingNumber_2() {
            var solution = new _1056_ConfusingNumber();
            var result = solution.ConfusingNumber(89);
            Assert.IsTrue(result);
        }

        [Test]
        public void ConfusingNumber_3() {
            var solution = new _1056_ConfusingNumber();
            var result = solution.ConfusingNumber(11);
            Assert.IsFalse(result);
        }

        [Test]
        public void ConfusingNumber_4() {
            var solution = new _1056_ConfusingNumber();
            var result = solution.ConfusingNumber(25);
            Assert.IsFalse(result);
        }

        [Test]
        public void ConfusingNumber_5() {
            var solution = new _1056_ConfusingNumber();
            var result = solution.ConfusingNumber(8000);
            Assert.IsTrue(result);
        }
    }
}
