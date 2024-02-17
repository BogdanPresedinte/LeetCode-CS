namespace LeetCode.Test
{
    public class _0190_ReverseBits_Test
    {
        [Test]
        public void reverseBits_1() {
            var solution = new _0190_ReverseBits();
            var result = solution.reverseBits((uint)43261596);
            Assert.AreEqual((uint)964176192, result);
        }

        [Test]
        public void reverseBits_2() {
            var solution = new _0190_ReverseBits();
            var result = solution.reverseBits((uint)4294967293);
            Assert.AreEqual((uint)3221225471, result);
        }
    }
}
