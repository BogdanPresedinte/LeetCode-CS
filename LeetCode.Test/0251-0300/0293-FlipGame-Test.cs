namespace LeetCode.Test
{
    public class _0293_FlipGame_Test
    {
        [Test]
        public void GeneratePossibleNextMoves_1() {
            var solution = new _0293_FlipGame();
            var result = solution.GeneratePossibleNextMoves("++++");
            AssertHelper.AssertList(new string[] { "--++", "+--+", "++--" }, result);
        }

        [Test]
        public void GeneratePossibleNextMoves_2() {
            var solution = new _0293_FlipGame();
            var result = solution.GeneratePossibleNextMoves("+-+-");
            Assert.AreEqual(0, result.Count);
        }

        [Test]
        public void GeneratePossibleNextMoves_3() {
            var solution = new _0293_FlipGame();
            var result = solution.GeneratePossibleNextMoves("--");
            Assert.AreEqual(0, result.Count);
        }

        [Test]
        public void GeneratePossibleNextMoves_4() {
            var solution = new _0293_FlipGame();
            var result = solution.GeneratePossibleNextMoves("++");
            AssertHelper.AssertList(new string[] { "--" }, result);
        }
    }
}
