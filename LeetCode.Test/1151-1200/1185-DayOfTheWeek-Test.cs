namespace LeetCode.Test
{
    public class _1185_DayOfTheWeek_Test
    {
        [Test]
        public void DayOfTheWeek_1() {
            var solution = new _1185_DayOfTheWeek();
            var result = solution.DayOfTheWeek(31, 8, 2019);
            Assert.AreEqual("Saturday", result);
        }

        [Test]
        public void DayOfTheWeek_2() {
            var solution = new _1185_DayOfTheWeek();
            var result = solution.DayOfTheWeek(18, 7, 1999);
            Assert.AreEqual("Sunday", result);
        }

        [Test]
        public void DayOfTheWeek_3() {
            var solution = new _1185_DayOfTheWeek();
            var result = solution.DayOfTheWeek(15, 8, 1993);
            Assert.AreEqual("Sunday", result);
        }
    }
}
