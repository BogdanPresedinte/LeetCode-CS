namespace LeetCode.Test
{
    public class _0345_ReverseVowelsOfAString_Test
    {
        [Test]
        public void ReverseVowels_1() {
            var solution = new _0345_ReverseVowelsOfAString();
            var result = solution.ReverseVowels("hello");
            Assert.AreEqual("holle", result);
        }

        [Test]
        public void ReverseVowels_2() {
            var solution = new _0345_ReverseVowelsOfAString();
            var result = solution.ReverseVowels("leetcode");
            Assert.AreEqual("leotcede", result);
        }

        [Test]
        public void ReverseVowels_3() {
            var solution = new _0345_ReverseVowelsOfAString();
            var result = solution.ReverseVowels("Aa");
            Assert.AreEqual("aA", result);
        }

        [Test]
        public void ReverseVowels_4() {
            var solution = new _0345_ReverseVowelsOfAString();
            var result = solution.ReverseVowels(".,");
            Assert.AreEqual(".,", result);
        }
    }
}
