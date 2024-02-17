namespace LeetCode.Test
{
    public class _003_LongestSubstringWithoutRepeatingCharacters_Test
    {
        [Test]
        public void LengthOfLongestSubstringTest() {
            var input = "abcabcbb";

            var solution = new _003_LongestSubstringWithoutRepeatingCharacters();
            var result = solution.LengthOfLongestSubstring(input);

            Assert.AreEqual(3, result);
        }

        [Test]
        public void LengthOfLongestSubstringTest_RepeatChars() {
            var input = "bbbbb";

            var solution = new _003_LongestSubstringWithoutRepeatingCharacters();
            var result = solution.LengthOfLongestSubstring(input);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void LengthOfLongestSubstringTest_EmptyInput() {
            var solution = new _003_LongestSubstringWithoutRepeatingCharacters();
            var result = solution.LengthOfLongestSubstring("");

            Assert.AreEqual(0, result);
        }

        [Test]
        public void LengthOfLongestSubstringTest_LongString() {
            var input = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";

            var solution = new _003_LongestSubstringWithoutRepeatingCharacters();
            var result = solution.LengthOfLongestSubstring(input);

            Assert.AreEqual(26, result);
        }

        [Test]
        public void LengthOfLongestSubstringTest_LongString_HaveShortRepeat() {
            var input = "abcdefghijklmnopqrstuvwxyzabcdefghijk  lmnopqrstuvwxyz";

            var solution = new _003_LongestSubstringWithoutRepeatingCharacters();
            var result = solution.LengthOfLongestSubstring(input);

            Assert.AreEqual(27, result);
        }
    }
}
