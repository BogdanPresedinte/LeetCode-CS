namespace LeetCode.Test
{
    public class _0394_DecodeString_Test
    {
        [Test]
        public void DecodeStringTest_1() {
            var solution = new _0394_DecodeString();
            var result = solution.DecodeString("3[a]2[bc]");
            Assert.AreEqual("aaabcbc", result);
        }

        [Test]
        public void DecodeStringTest_2() {
            var solution = new _0394_DecodeString();
            var result = solution.DecodeString("3[a2[c]]");
            Assert.AreEqual("accaccacc", result);
        }

        [Test]
        public void DecodeStringTest_3() {
            var solution = new _0394_DecodeString();
            var result = solution.DecodeString("2[abc]3[cd]ef");
            Assert.AreEqual("abcabccdcdcdef", result);
        }
    }
}
