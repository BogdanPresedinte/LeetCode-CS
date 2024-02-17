namespace LeetCode.Test
{
    public class _0374_GuessNumberHigherOrLower_Test
    {
        [Test]
        public void GuessNumber_1() {
            var solution = new _0374_GuessNumberHigherOrLower(6);
            var result = solution.GuessNumber(10);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void GuessNumber_2() {
            var solution = new _0374_GuessNumberHigherOrLower(4);
            var result = solution.GuessNumber(6);
            Assert.AreEqual(4, result);
        }
    }
}
