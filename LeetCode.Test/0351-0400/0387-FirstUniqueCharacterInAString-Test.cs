namespace LeetCode.Test
{
    public class _0387_FirstUniqueCharacterInAString_Test
    {
        [Test]
        public void FirstUniqChar_1() {
            var solution = new _0387_FirstUniqueCharacterInAString();
            var result = solution.FirstUniqChar("leetcode");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void FirstUniqChar_2() {
            var solution = new _0387_FirstUniqueCharacterInAString();
            var result = solution.FirstUniqChar("loveleetcode");
            Assert.AreEqual(2, result);
        }
    }
}
