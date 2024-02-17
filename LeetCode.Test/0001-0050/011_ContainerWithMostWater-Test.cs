namespace LeetCode.Test
{
    public class _011_ContainerWithMostWater_Test
    {
        [Test]
        public void MaxAreaTest_General_1() {
            int[] input = { 1, 1 };

            var solution = new _011_ContainerWithMostWater();
            var result = solution.MaxArea(input);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void MaxAreaTest_General_2() {
            int[] input = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var solution = new _011_ContainerWithMostWater();
            var result = solution.MaxArea(input);

            Assert.AreEqual(20, result);
        }

        [Test]
        public void MaxAreaTest_General_3() {
            int[] input = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            var solution = new _011_ContainerWithMostWater();
            var result = solution.MaxArea(input);

            Assert.AreEqual(20, result);
        }
    }
}
