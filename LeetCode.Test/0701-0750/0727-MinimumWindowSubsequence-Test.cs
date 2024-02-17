namespace LeetCode.Test
{
    public class _0727_MinimumWindowSubsequence_Test
    {
        [Test]
        public void MinWindowTest_1() {
            var solution = new _0727_MinimumWindowSubsequence();
            var result = solution.MinWindow("abcdebdde", "bde");
            Assert.AreEqual("bcde", result);
        }

        [Test]
        public void MinWindowTest_2() {
            var solution = new _0727_MinimumWindowSubsequence();
            var result = solution.MinWindow("jmeqksfrsdcmsiwvaovztaqenprpvnbstl", "l");
            Assert.AreEqual("l", result);
        }
    }
}
