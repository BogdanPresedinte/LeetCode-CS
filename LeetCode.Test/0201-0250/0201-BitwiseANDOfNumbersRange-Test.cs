namespace LeetCode.Test
{
    public class _0201_BitwiseANDOfNumbersRange_Test
    {
        [Test]
        public void RangeBitwiseAnd_1() {
            var solution = new _0201_BitwiseANDOfNumbersRange();
            var result = solution.RangeBitwiseAnd(5, 7);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void RangeBitwiseAnd_2() {
            var solution = new _0201_BitwiseANDOfNumbersRange();
            var result = solution.RangeBitwiseAnd(0, 1);
            Assert.AreEqual(0, result);
        }
    }
}
