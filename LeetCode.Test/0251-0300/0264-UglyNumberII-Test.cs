namespace LeetCode.Test
{
    public class _0264_UglyNumberII_Test
    {
        [Test]
        public void NthUglyNumber_1() {
            var solution = new _0264_UglyNumberII();
            var result = solution.NthUglyNumber(10);
            Assert.AreEqual(12, result);
        }

        [Test]
        public void NthUglyNumber_2() {
            var solution = new _0264_UglyNumberII();
            var result = solution.NthUglyNumber(9);
            Assert.AreEqual(10, result);
        }

        [Test]
        public void NthUglyNumber_3() {
            var solution = new _0264_UglyNumberII();
            var result = solution.NthUglyNumber(8);
            Assert.AreEqual(9, result);
        }

        [Test]
        public void NthUglyNumber_4() {
            var solution = new _0264_UglyNumberII();
            var result = solution.NthUglyNumber(7);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void NthUglyNumber_5() {
            var solution = new _0264_UglyNumberII();
            var result = solution.NthUglyNumber(6);
            Assert.AreEqual(6, result);
        }
    }
}
