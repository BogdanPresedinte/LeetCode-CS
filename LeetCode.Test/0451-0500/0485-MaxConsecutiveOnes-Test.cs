namespace LeetCode.Test
{
    public class _0485_MaxConsecutiveOnes_Test
    {
        [Test]
        public void FindMaxConsecutiveOnes_1() {
            var solution = new _0485_MaxConsecutiveOnes();
            var result = solution.FindMaxConsecutiveOnes(new int[] { 1, 1, 0, 1, 1, 1 });
            Assert.AreEqual(3, result);
        }
    }
}
