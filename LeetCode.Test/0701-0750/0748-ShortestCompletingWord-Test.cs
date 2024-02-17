namespace LeetCode.Test
{
    public class _0748_ShortestCompletingWord_Test
    {
        [Test]
        public void ShortestCompletingWord_1() {
            var solution = new _0748_ShortestCompletingWord();
            var result = solution.ShortestCompletingWord("1s3 PSt", new string[] { "step", "steps", "stripe", "stepple" });
            Assert.AreEqual("steps", result);
        }

        [Test]
        public void ShortestCompletingWord_2() {
            var solution = new _0748_ShortestCompletingWord();
            var result = solution.ShortestCompletingWord("1s3 456", new string[] { "looks", "pest", "stew", "show" });
            Assert.AreEqual("pest", result);
        }
    }
}
