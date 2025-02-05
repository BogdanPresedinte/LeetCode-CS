namespace LeetCode.Test
{
    public class _1306_JumpGameIII_Test
    {
        [Test]
        public void CanReach_1() {
            var solution = new _1306_JumpGameIII();
            var result = solution.CanReach(new int[] { 4, 2, 3, 0, 3, 1, 2 }, 5);
            Assert.IsTrue(result);
        }

        [Test]
        public void CanReach_2() {
            var solution = new _1306_JumpGameIII();
            var result = solution.CanReach(new int[] { 4, 2, 3, 0, 3, 1, 2 }, 0);
            Assert.IsTrue(result);
        }

        [Test]
        public void CanReach_3() {
            var solution = new _1306_JumpGameIII();
            var result = solution.CanReach(new int[] { 3, 0, 2, 1, 2 }, 2);
            Assert.IsFalse(result);
        }
    }
}
