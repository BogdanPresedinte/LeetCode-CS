namespace LeetCode.Test
{
    public class _0767_ReorganizeString_Test
    {
        [Test]
        public void ReorganizeString_1() {
            var solution = new _0767_ReorganizeString();
            var result = solution.ReorganizeString("aab");
            Assert.AreEqual("aba", result);
        }

        [Test]
        public void ReorganizeString_2() {
            var solution = new _0767_ReorganizeString();
            var result = solution.ReorganizeString("aaab");
            Assert.AreEqual("", result);
        }

        [Test]
        public void ReorganizeString_3() {
            var solution = new _0767_ReorganizeString();
            var result = solution.ReorganizeString("vvvlo");
            Assert.AreEqual("vovlv", result);
        }
    }
}
