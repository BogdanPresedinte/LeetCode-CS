namespace LeetCode.Test
{
    public class _0151_ReverseWordsInAString_Test
    {
        [Test]
        public void ReverseWords_1() {
            var solution = new _0151_ReverseWordsInAString();
            var result = solution.ReverseWords("the sky is blue");
            Assert.AreEqual("blue is sky the", result);
        }

        [Test]
        public void ReverseWords_2() {
            var solution = new _0151_ReverseWordsInAString();
            var result = solution.ReverseWords("  hello world!  ");
            Assert.AreEqual("world! hello", result);
        }

        [Test]
        public void ReverseWords_3() {
            var solution = new _0151_ReverseWordsInAString();
            var result = solution.ReverseWords("a good   example");
            Assert.AreEqual("example good a", result);
        }
    }
}
