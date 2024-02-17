namespace LeetCode.Test
{
    public class _1071_GreatestCommonDivisorOfStrings_Test
    {
        [Test]
        public void GcdOfStrings_1() {
            var solution = new _1071_GreatestCommonDivisorOfStrings();
            var result = solution.GcdOfStrings("ABCABC", "ABC");
            Assert.AreEqual("ABC", result);
        }

        [Test]
        public void GcdOfStrings_2() {
            var solution = new _1071_GreatestCommonDivisorOfStrings();
            var result = solution.GcdOfStrings("ABABAB", "ABAB");
            Assert.AreEqual("AB", result);
        }

        [Test]
        public void GcdOfStrings_3() {
            var solution = new _1071_GreatestCommonDivisorOfStrings();
            var result = solution.GcdOfStrings("LEET", "CODE");
            Assert.AreEqual("", result);
        }

        [Test]
        public void GcdOfStrings_4() {
            var solution = new _1071_GreatestCommonDivisorOfStrings();
            var result = solution.GcdOfStrings("NLZGMNLZGMNLZGMNLZGMNLZGMNLZGMNLZGMNLZGM", "NLZGMNLZGMNLZGMNLZGMNLZGMNLZGMNLZGMNLZGMNLZGM");
            Assert.AreEqual("NLZGM", result);
        }
    }
}
