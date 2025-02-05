namespace LeetCode.Test
{
    public class _0849_MaximizeDistanceToClosestPerson_Test
    {
        [Test]
        public void MaxDistToClosest_1() {
            var solution = new _0849_MaximizeDistanceToClosestPerson();
            var result = solution.MaxDistToClosest(new int[] { 1, 0, 0, 0, 1, 0, 1 });
            Assert.AreEqual(2, result);
        }

        [Test]
        public void MaxDistToClosest_2() {
            var solution = new _0849_MaximizeDistanceToClosestPerson();
            var result = solution.MaxDistToClosest(new int[] { 1, 0, 0, 0 });
            Assert.AreEqual(3, result);
        }

        [Test]
        public void MaxDistToClosest_3() {
            var solution = new _0849_MaximizeDistanceToClosestPerson();
            var result = solution.MaxDistToClosest(new int[] { 0, 0, 0, 1 });
            Assert.AreEqual(3, result);
        }
    }
}
