namespace LeetCode.Test
{
    public class _0459_RepeatedSubstringPattern_Test
    {
        [Test]
        public void RepeatedSubstringPattern_1() {
            var solution = new _0459_RepeatedSubstringPattern();
            var result = solution.RepeatedSubstringPattern("abab");
            Assert.IsTrue(result);
        }

        [Test]
        public void RepeatedSubstringPattern_2() {
            var solution = new _0459_RepeatedSubstringPattern();
            var result = solution.RepeatedSubstringPattern("aba");
            Assert.IsFalse(result);
        }

        [Test]
        public void RepeatedSubstringPattern_3() {
            var solution = new _0459_RepeatedSubstringPattern();
            var result = solution.RepeatedSubstringPattern("abcabcabcabc");
            Assert.IsTrue(result);
        }
    }
}
