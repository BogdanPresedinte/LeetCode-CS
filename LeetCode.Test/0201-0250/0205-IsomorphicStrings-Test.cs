namespace LeetCode.Test
{
    public class _0205_IsomorphicStrings_Test
    {
        [Test]
        public void IsIsomorphicTest_1() {
            var solution = new _0205_IsomorphicStrings();
            Assert.IsTrue(solution.IsIsomorphic("egg", "add"));
        }

        [Test]
        public void IsIsomorphicTest_2() {
            var solution = new _0205_IsomorphicStrings();
            Assert.IsFalse(solution.IsIsomorphic("foo", "bar"));
        }

        [Test]
        public void IsIsomorphicTest_3() {
            var solution = new _0205_IsomorphicStrings();
            Assert.IsTrue(solution.IsIsomorphic("paper", "title"));
        }

        [Test]
        public void IsIsomorphicTest_4() {
            var solution = new _0205_IsomorphicStrings();
            Assert.IsFalse(solution.IsIsomorphic("ab", "aa"));
        }
    }
}
