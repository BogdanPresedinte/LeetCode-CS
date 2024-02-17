namespace LeetCode.Test
{
    public class _1347_MinimumNumberOfStepsToMakeTwoStringsAnagram_Test
    {
        [Test]
        public void MinSteps_1() {
            var solution = new _1347_MinimumNumberOfStepsToMakeTwoStringsAnagram();
            var result = solution.MinSteps("bab", "aba");
            Assert.AreEqual(1, result);
        }

        [Test]
        public void MinSteps_2() {
            var solution = new _1347_MinimumNumberOfStepsToMakeTwoStringsAnagram();
            var result = solution.MinSteps("leetcode", "practice");
            Assert.AreEqual(5, result);
        }

        [Test]
        public void MinSteps_3() {
            var solution = new _1347_MinimumNumberOfStepsToMakeTwoStringsAnagram();
            var result = solution.MinSteps("anagram", "mangaar");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void MinSteps_4() {
            var solution = new _1347_MinimumNumberOfStepsToMakeTwoStringsAnagram();
            var result = solution.MinSteps("xxyyzz", "xxyyzz");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void MinSteps_5() {
            var solution = new _1347_MinimumNumberOfStepsToMakeTwoStringsAnagram();
            var result = solution.MinSteps("friend", "family");
            Assert.AreEqual(4, result);
        }
    }
}
