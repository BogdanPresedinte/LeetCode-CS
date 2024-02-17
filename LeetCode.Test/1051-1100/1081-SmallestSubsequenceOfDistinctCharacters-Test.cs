namespace LeetCode.Test
{
    public class _1081_SmallestSubsequenceOfDistinctCharacters_Test
    {
        [Test]
        public void SmallestSubsequence_1() {
            var solution = new _1081_SmallestSubsequenceOfDistinctCharacters();
            var result = solution.SmallestSubsequence("cdadabcc");
            Assert.AreEqual("adbc", result);
        }

        [Test]
        public void SmallestSubsequence_2() {
            var solution = new _1081_SmallestSubsequenceOfDistinctCharacters();
            var result = solution.SmallestSubsequence("abcd");
            Assert.AreEqual("abcd", result);
        }

        [Test]
        public void SmallestSubsequence_3() {
            var solution = new _1081_SmallestSubsequenceOfDistinctCharacters();
            var result = solution.SmallestSubsequence("ecbacba");
            Assert.AreEqual("eacb", result);
        }

        [Test]
        public void SmallestSubsequence_4() {
            var solution = new _1081_SmallestSubsequenceOfDistinctCharacters();
            var result = solution.SmallestSubsequence("leetcode");
            Assert.AreEqual("letcod", result);
        }
    }
}
