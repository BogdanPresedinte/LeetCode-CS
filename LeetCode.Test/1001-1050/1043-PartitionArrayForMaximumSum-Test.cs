namespace LeetCode.Test
{
    public class _1043_PartitionArrayForMaximumSum_Test
    {
        [Test]
        public void MaxSumAfterPartitioning_1() {
            var solution = new _1043_PartitionArrayForMaximumSum();
            var result = solution.MaxSumAfterPartitioning(new int[] { 1, 15, 7, 9, 2, 5, 10 }, 3);
            Assert.AreEqual(84, result);
        }
    }
}
