namespace LeetCode.Test
{
    public class _0213_HouseRobberII_Test
    {
        [Test]
        public void Rob_1() {
            var solution = new _0213_HouseRobberII();
            var result = solution.Rob(new int[] { 2, 3, 2 });
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Rob_2() {
            var solution = new _0213_HouseRobberII();
            var result = solution.Rob(new int[] { 1, 2, 3, 1 });
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Rob_3() {
            var solution = new _0213_HouseRobberII();
            var result = solution.Rob(new int[] { 0 });
            Assert.AreEqual(0, result);
        }
    }
}
