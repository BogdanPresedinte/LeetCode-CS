namespace LeetCode.Test
{
    public class _1256_EncodeNumber_Test
    {
        [Test]
        public void Encode_1() {
            var solution = new _1256_EncodeNumber();
            var result = solution.Encode(23);
            Assert.AreEqual("1000", result);
        }

        [Test]
        public void Encode_2() {
            var solution = new _1256_EncodeNumber();
            var result = solution.Encode(107);
            Assert.AreEqual("101100", result);
        }
    }
}
