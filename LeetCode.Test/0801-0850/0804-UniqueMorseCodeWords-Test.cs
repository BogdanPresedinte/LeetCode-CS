namespace LeetCode.Test
{
    public class _0804_UniqueMorseCodeWords_Test
    {
        [Test]
        public void UniqueMorseRepresentations_1() {
            var solution = new _0804_UniqueMorseCodeWords();
            var result = solution.UniqueMorseRepresentations(new string[] { "gin", "zen", "gig", "msg" });
            Assert.AreEqual(2, result);
        }

        [Test]
        public void UniqueMorseRepresentations_2() {
            var solution = new _0804_UniqueMorseCodeWords();
            var result = solution.UniqueMorseRepresentations(new string[] { "cba" });
            Assert.AreEqual(1, result);
        }
    }
}
