namespace LeetCode.Test
{
    public class _1118_NumberOfDaysInAMonth_Test
    {
        [Test]
        public void NumberOfDays_1() {
            var solution = new _1118_NumberOfDaysInAMonth();
            var result = solution.NumberOfDays(1992, 7);
            Assert.AreEqual(31, result);
        }

        [Test]
        public void NumberOfDays_2() {
            var solution = new _1118_NumberOfDaysInAMonth();
            var result = solution.NumberOfDays(2000, 2);
            Assert.AreEqual(29, result);
        }

        [Test]
        public void NumberOfDays_3() {
            var solution = new _1118_NumberOfDaysInAMonth();
            var result = solution.NumberOfDays(1900, 2);
            Assert.AreEqual(28, result);
        }
    }
}
