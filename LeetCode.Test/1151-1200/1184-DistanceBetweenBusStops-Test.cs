namespace LeetCode.Test
{
    public class _1184_DistanceBetweenBusStops_Test
    {
        [Test]
        public void DistanceBetweenBusStops_1() {
            var solution = new _1184_DistanceBetweenBusStops();
            var result = solution.DistanceBetweenBusStops(new int[] { 1, 2, 3, 4 }, 0, 1);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void DistanceBetweenBusStops_2() {
            var solution = new _1184_DistanceBetweenBusStops();
            var result = solution.DistanceBetweenBusStops(new int[] { 1, 2, 3, 4 }, 0, 2);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void DistanceBetweenBusStops_3() {
            var solution = new _1184_DistanceBetweenBusStops();
            var result = solution.DistanceBetweenBusStops(new int[] { 1, 2, 3, 4 }, 0, 3);
            Assert.AreEqual(4, result);
        }
    }
}
