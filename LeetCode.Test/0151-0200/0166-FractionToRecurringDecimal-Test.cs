namespace LeetCode.Test
{
    public class _0166_FractionToRecurringDecimal_Test
    {
        [Test]
        public void FractionToDecimal_1() {
            var solution = new _0166_FractionToRecurringDecimal();
            var result = solution.FractionToDecimal(1, 2);
            Assert.AreEqual("0.5", result);
        }

        [Test]
        public void FractionToDecimal_2() {
            var solution = new _0166_FractionToRecurringDecimal();
            var result = solution.FractionToDecimal(2, 1);
            Assert.AreEqual("2", result);
        }

        [Test]
        public void FractionToDecimal_3() {
            var solution = new _0166_FractionToRecurringDecimal();
            var result = solution.FractionToDecimal(2, 3);
            Assert.AreEqual("0.(6)", result);
        }
    }
}
