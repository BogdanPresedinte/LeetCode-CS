namespace LeetCode.Test
{
    public class _087_ScrambleString_Test
    {
        [Test]
        public void IsScrambleTest_Odd() {
            var solution = new _087_ScrambleString();
            Assert.IsTrue(solution.IsScramble("great", "rgeat"));
            Assert.IsTrue(solution.IsScramble("rgeat", "great"));
            Assert.IsTrue(solution.IsScramble("great", "rgtae"));
            Assert.IsTrue(solution.IsScramble("rgeat", "rgtae"));
        }

        [Test]
        public void IsScrambleTest_Even() {
            var solution = new _087_ScrambleString();
            Assert.IsTrue(solution.IsScramble("abab", "baba"));
            Assert.IsTrue(solution.IsScramble("abcd", "bcad"));
        }

        [Test]
        public void IsScrambleTest_Same() {
            var solution = new _087_ScrambleString();
            Assert.IsTrue(solution.IsScramble("ab", "ab"));
        }

        [Test]
        public void IsScrambleTest_Not() {
            var solution = new _087_ScrambleString();
            Assert.IsFalse(solution.IsScramble("abcde", "caebd"));
        }
    }
}
