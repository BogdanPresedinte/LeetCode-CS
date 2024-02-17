namespace LeetCode.Test
{
    public class _1100_FindKLengthSubstringsWithNoRepeatedCharacters_Test
    {
        [Test]
        public void NumKLenSubstrNoRepeats_1() {
            var solution = new _1100_FindKLengthSubstringsWithNoRepeatedCharacters();
            var result = solution.NumKLenSubstrNoRepeats("havefunonleetcode", 5);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void NumKLenSubstrNoRepeats_2() {
            var solution = new _1100_FindKLengthSubstringsWithNoRepeatedCharacters();
            var result = solution.NumKLenSubstrNoRepeats("home", 5);
            Assert.AreEqual(0, result);
        }
    }
}
