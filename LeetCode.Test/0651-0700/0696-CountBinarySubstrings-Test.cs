namespace LeetCode.Test
{
    public class _0696_CountBinarySubstrings_Test
    {
        [Test]
        public void CountBinarySubstrings_1() {
            var solution = new _0696_CountBinarySubstrings();
            var result = solution.CountBinarySubstrings("00110011");
            Assert.AreEqual(6, result);
        }

        [Test]
        public void CountBinarySubstrings_2() {
            var solution = new _0696_CountBinarySubstrings();
            var result = solution.CountBinarySubstrings("10101");
            Assert.AreEqual(4, result);
        }
    }
}
