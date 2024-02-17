namespace LeetCode.Test
{
    public class _1518_WaterBottles_Test
    {
        [Test]
        public void NumWaterBottles_1() {
            var solution = new _1518_WaterBottles();
            var result = solution.NumWaterBottles(9, 3);
            Assert.AreEqual(13, result);
        }

        [Test]
        public void NumWaterBottles_2() {
            var solution = new _1518_WaterBottles();
            var result = solution.NumWaterBottles(15, 4);
            Assert.AreEqual(19, result);
        }

        [Test]
        public void NumWaterBottles_3() {
            var solution = new _1518_WaterBottles();
            var result = solution.NumWaterBottles(5, 5);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void NumWaterBottles_4() {
            var solution = new _1518_WaterBottles();
            var result = solution.NumWaterBottles(2, 3);
            Assert.AreEqual(2, result);
        }
    }
}
