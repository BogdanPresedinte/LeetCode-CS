namespace LeetCode.Test
{
    public class _1342_NumberOfStepsToReduceANumberToZero_Test
    {
        [Test]
        public void NumberOfSteps_1() {
            var solution = new _1342_NumberOfStepsToReduceANumberToZero();
            var result = solution.NumberOfSteps(14);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void NumberOfSteps_2() {
            var solution = new _1342_NumberOfStepsToReduceANumberToZero();
            var result = solution.NumberOfSteps(8);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void NumberOfSteps_3() {
            var solution = new _1342_NumberOfStepsToReduceANumberToZero();
            var result = solution.NumberOfSteps(123);
            Assert.AreEqual(12, result);
        }

        [Test]
        public void NumberOfSteps_4() {
            var solution = new _1342_NumberOfStepsToReduceANumberToZero();
            var result = solution.NumberOfSteps(0);
            Assert.AreEqual(0, result);
        }
    }
}
