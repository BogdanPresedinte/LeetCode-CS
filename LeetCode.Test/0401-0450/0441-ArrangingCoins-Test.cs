namespace LeetCode.Test
{
    public class _0441_ArrangingCoins_Test
    {
        [Test]
        public void ArrangeCoins_1() {
            var solution = new _0441_ArrangingCoins();
            var result = solution.ArrangeCoins(5);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void ArrangeCoins_2() {
            var solution = new _0441_ArrangingCoins();
            var result = solution.ArrangeCoins(8);
            Assert.AreEqual(3, result);
        }
    }
}
