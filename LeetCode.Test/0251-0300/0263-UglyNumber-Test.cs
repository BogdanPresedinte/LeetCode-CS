namespace LeetCode.Test
{
    public class _0263_UglyNumber_Test
    {
        [Test]
        public void IsUgly_1() {
            var solution = new _0263_UglyNumber();
            var result = solution.IsUgly(6);
            Assert.IsTrue(result);
        }

        [Test]
        public void IsUgly_2() {
            var solution = new _0263_UglyNumber();
            var result = solution.IsUgly(8);
            Assert.IsTrue(result);
        }

        [Test]
        public void IsUgly_3() {
            var solution = new _0263_UglyNumber();
            var result = solution.IsUgly(1);
            Assert.IsTrue(result);
        }

        [Test]
        public void IsUgly_4() {
            var solution = new _0263_UglyNumber();
            var result = solution.IsUgly(-1);
            Assert.IsFalse(result);
        }

        [Test]
        public void IsUgly_5() {
            var solution = new _0263_UglyNumber();
            var result = solution.IsUgly(14);
            Assert.IsFalse(result);
        }
    }
}
