namespace LeetCode.Test
{
    public class _029_DivideTwoIntegers_Test
    {
        [Test]
        public void DivideTest() {
            var solution = new _029_DivideTwoIntegers();
            var result = solution.Divide(5, 2);
            Assert.AreEqual(2, result);

            result = solution.Divide(-5, 2);
            Assert.AreEqual(-2, result);

            result = solution.Divide(5, -2);
            Assert.AreEqual(-2, result);

            result = solution.Divide(-5, -2);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void DivideTest_DivisorEqualZero() {
            var solution = new _029_DivideTwoIntegers();
            Assert.That(() => solution.Divide(5, 0),
                Throws.TypeOf<DivideByZeroException>());
        }

        [Test]
        public void DivideTest_MaxValueDivideMaxValue() {
            var solution = new _029_DivideTwoIntegers();
            var result = solution.Divide(int.MaxValue, int.MaxValue);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void DivideTest_MinValueDivideMinValue() {
            var solution = new _029_DivideTwoIntegers();
            var result = solution.Divide(int.MinValue, int.MinValue);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void DivideTest_DivisorLargerThanDividend() {
            var solution = new _029_DivideTwoIntegers();
            var result = solution.Divide(5, 10);

            Assert.AreEqual(0, result);
        }

        [Test]
        [Timeout(100)]
        public void DivideTest_MinValueDivideMinusOne() {
            var solution = new _029_DivideTwoIntegers();
            var result = solution.Divide(int.MinValue, -1);

            Assert.AreEqual(int.MaxValue, result);
        }

        [Test]
        [Timeout(100)]
        public void DivideTest_MinValueDivideOne() {
            var solution = new _029_DivideTwoIntegers();
            var result = solution.Divide(int.MinValue, 1);

            Assert.AreEqual(int.MinValue, result);
        }

        [Test]
        [Timeout(100)]
        public void DivideTest_MaxValueDivideMinusOne() {
            var solution = new _029_DivideTwoIntegers();
            var result = solution.Divide(int.MaxValue, -1);

            Assert.AreEqual(int.MinValue + 1, result);
        }

        [Test]
        [Timeout(100)]
        public void DivideTest_MaxValueDivideOne() {
            var solution = new _029_DivideTwoIntegers();
            var result = solution.Divide(int.MaxValue, 1);

            Assert.AreEqual(int.MaxValue, result);
        }
    }
}
