namespace LeetCode.Test
{
    public class _1360_NumberOfDaysBetweenTwoDates_Test
    {
        [Test]
        public void DaysBetweenDates_1() {
            var solution = new _1360_NumberOfDaysBetweenTwoDates();
            var result = solution.DaysBetweenDates("2019-06-29", "2019-06-30");
            Assert.AreEqual(1, result);
        }

        [Test]
        public void DaysBetweenDates_2() {
            var solution = new _1360_NumberOfDaysBetweenTwoDates();
            var result = solution.DaysBetweenDates("2020-01-15", "2019-12-31");
            Assert.AreEqual(15, result);
        }
    }
}
