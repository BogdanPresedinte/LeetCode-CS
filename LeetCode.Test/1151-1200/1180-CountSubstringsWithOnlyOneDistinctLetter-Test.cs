namespace LeetCode.Test
{
    public class _1180_CountSubstringsWithOnlyOneDistinctLetter_Test
    {
        [Test]
        public void CountLetters_1() {
            var solution = new _1180_CountSubstringsWithOnlyOneDistinctLetter();
            var result = solution.CountLetters("aaaba");
            Assert.AreEqual(8, result);
        }

        [Test]
        public void CountLetters_2() {
            var solution = new _1180_CountSubstringsWithOnlyOneDistinctLetter();
            var result = solution.CountLetters("aaaaaaaaaa");
            Assert.AreEqual(55, result);
        }
    }
}
