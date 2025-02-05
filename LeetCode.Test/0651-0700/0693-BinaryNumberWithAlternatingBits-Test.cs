namespace LeetCode.Test
{
    public class _0693_BinaryNumberWithAlternatingBits_Test
    {
        [Test]
        public void HasAlternatingBits_1() {
            var solution = new _0693_BinaryNumberWithAlternatingBits();
            var result = solution.HasAlternatingBits(5);
            Assert.IsTrue(result);
        }

        [Test]
        public void HasAlternatingBits_2() {
            var solution = new _0693_BinaryNumberWithAlternatingBits();
            var result = solution.HasAlternatingBits(7);
            Assert.IsFalse(result);
        }

        [Test]
        public void HasAlternatingBits_3() {
            var solution = new _0693_BinaryNumberWithAlternatingBits();
            var result = solution.HasAlternatingBits(11);
            Assert.IsFalse(result);
        }

        [Test]
        public void HasAlternatingBits_4() {
            var solution = new _0693_BinaryNumberWithAlternatingBits();
            var result = solution.HasAlternatingBits(10);
            Assert.IsTrue(result);
        }
    }
}
