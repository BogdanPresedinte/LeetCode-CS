namespace LeetCode.Test
{
    public class _0416_PartitionEqualSubsetSum_Test
    {
        [Test]
        public void CanPartition_1() {
            var solution = new _0416_PartitionEqualSubsetSum();
            var result = solution.CanPartition(new int[] { 1, 5, 11, 5 });
            Assert.IsTrue(result);
        }

        [Test]
        public void CanPartition_2() {
            var solution = new _0416_PartitionEqualSubsetSum();
            var result = solution.CanPartition(new int[] { 1, 2, 3, 5 });
            Assert.IsFalse(result);
        }

        [Test]
        [Timeout(100)]
        public void CanPartition_3() {
            var input = new int[100];
            for (int i = 0; i < 98; i++)
                input[i] = 1;
            input[98] = 97;
            input[99] = 95;
            var solution = new _0416_PartitionEqualSubsetSum();
            var result = solution.CanPartition(input);
            Assert.IsTrue(result);
        }
    }
}
