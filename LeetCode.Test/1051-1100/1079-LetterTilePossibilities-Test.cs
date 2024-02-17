namespace LeetCode.Test
{
    public class _1079_LetterTilePossibilities_Test
    {
        [Test]
        public void NumTilePossibilities_1() {
            var solution = new _1079_LetterTilePossibilities();
            var result = solution.NumTilePossibilities("AAB");
            Assert.AreEqual(8, result);
        }

        [Test]
        public void NumTilePossibilities_2() {
            var solution = new _1079_LetterTilePossibilities();
            var result = solution.NumTilePossibilities("AAABBC");
            Assert.AreEqual(188, result);
        }
    }
}
