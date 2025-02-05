namespace LeetCode.Test
{
    public class _0224_BasicCalculator_Test
    {
        [Test]
        public void Calculate_1() {
            var solution = new _0224_BasicCalculator();
            var result = solution.Calculate("1 + 1");
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Calculate_2() {
            var solution = new _0224_BasicCalculator();
            var result = solution.Calculate(" 2-1 + 2 ");
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Calculate_3() {
            var solution = new _0224_BasicCalculator();
            var result = solution.Calculate("(1+(4+5+2)-3)+(6+8)");
            Assert.AreEqual(23, result);
        }

        [Test]
        public void Calculate_4() {
            var solution = new _0224_BasicCalculator();
            var result = solution.Calculate("1-(2+3)");
            Assert.AreEqual(-4, result);
        }

        [Test]
        public void Calculate_5() {
            var solution = new _0224_BasicCalculator();
            var result = solution.Calculate("1+(1-(2+3))");
            Assert.AreEqual(-3, result);
        }
    }
}
