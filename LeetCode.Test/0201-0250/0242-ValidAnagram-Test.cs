namespace LeetCode.Test
{
    public class _0242_ValidAnagram_Test
    {
        [Test]
        public void IsAnagram_1() {
            var solution = new _0242_ValidAnagram();
            var result = solution.IsAnagram("anagram", "nagaram");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsAnagram_2() {
            var solution = new _0242_ValidAnagram();
            var result = solution.IsAnagram("rat", "car");
            Assert.IsFalse(result);
        }
    }
}
