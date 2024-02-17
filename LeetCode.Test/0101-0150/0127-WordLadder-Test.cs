namespace LeetCode.Test
{
    public class _0127_WordLadder_Test
    {
        [Test]
        public void LadderLengthTest_1() {
            var solution = new _0127_WordLadder();
            var result = solution.LadderLength("hit", "cog", new string[] { "hot", "dot", "dog", "lot", "log", "cog" });
            Assert.AreEqual(5, result);
        }

        [Test]
        public void LadderLengthTest_2() {
            var solution = new _0127_WordLadder();
            var result = solution.LadderLength("hit", "cog", new string[] { "hot", "dot", "dog", "lot", "log" });
            Assert.AreEqual(0, result);
        }
    }
}
