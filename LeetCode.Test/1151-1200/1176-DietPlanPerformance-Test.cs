namespace LeetCode.Test
{
    public class _1176_DietPlanPerformance_Test
    {
        [Test]
        public void DietPlanPerformance_1() {
            var solution = new _1176_DietPlanPerformance();
            var result = solution.DietPlanPerformance(new int[] { 1, 2, 3, 4, 5 }, 1, 3, 3);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void DietPlanPerformance_2() {
            var solution = new _1176_DietPlanPerformance();
            var result = solution.DietPlanPerformance(new int[] { 3, 2 }, 2, 0, 0);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void DietPlanPerformance_3() {
            var solution = new _1176_DietPlanPerformance();
            var result = solution.DietPlanPerformance(new int[] { 6, 5, 0, 0 }, 2, 1, 5);
            Assert.AreEqual(0, result);
        }
    }
}
