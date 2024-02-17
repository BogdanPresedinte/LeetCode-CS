namespace LeetCode.Test
{
    public class _0794_ValidTicTacToeState_Test
    {
        [Test]
        public void ValidTicTacToe_1() {
            var solution = new _0794_ValidTicTacToeState();
            var result = solution.ValidTicTacToe(new string[] { "O  ", "   ", "   " });
            Assert.IsFalse(result);
        }

        [Test]
        public void ValidTicTacToe_2() {
            var solution = new _0794_ValidTicTacToeState();
            var result = solution.ValidTicTacToe(new string[] { "XOX", " X ", "   " });
            Assert.IsFalse(result);
        }

        [Test]
        public void ValidTicTacToe_3() {
            var solution = new _0794_ValidTicTacToeState();
            var result = solution.ValidTicTacToe(new string[] { "XXX", "   ", "OOO" });
            Assert.IsFalse(result);
        }

        [Test]
        public void ValidTicTacToe_4() {
            var solution = new _0794_ValidTicTacToeState();
            var result = solution.ValidTicTacToe(new string[] { "XOX", "O O", "XOX" });
            Assert.IsTrue(result);
        }
    }
}
