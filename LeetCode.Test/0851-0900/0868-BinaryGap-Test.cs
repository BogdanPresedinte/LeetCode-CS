namespace LeetCode.Test
{
    public class _0868_BinaryGap_Test
    {
        [Test]
        public void BinaryGap_1() {
            var solution = new _0868_BinaryGap();
            var result = solution.BinaryGap(22);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void BinaryGap_2() {
            var solution = new _0868_BinaryGap();
            var result = solution.BinaryGap(5);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void BinaryGap_3() {
            var solution = new _0868_BinaryGap();
            var result = solution.BinaryGap(6);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void BinaryGap_4() {
            var solution = new _0868_BinaryGap();
            var result = solution.BinaryGap(8);
            Assert.AreEqual(0, result);
        }
    }
}
