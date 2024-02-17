namespace LeetCode.Test
{
    public class _0299_BullsAndCows_Test
    {
        [Test]
        public void GetHint_1() {
            var solution = new _0299_BullsAndCows();
            var result = solution.GetHint("1807", "7810");
            Assert.AreEqual("1A3B", result);
        }

        [Test]
        public void GetHint_2() {
            var solution = new _0299_BullsAndCows();
            var result = solution.GetHint("1123", "0111");
            Assert.AreEqual("1A1B", result);
        }

        [Test]
        public void GetHint_3() {
            var solution = new _0299_BullsAndCows();
            var result = solution.GetHint("0123", "1123");
            Assert.AreEqual("3A0B", result);
        }
    }
}
