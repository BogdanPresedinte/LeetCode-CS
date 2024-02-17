namespace LeetCode.Test
{
    public class _0561_ArrayPartitionI_Test
    {
        [Test]
        public void ArrayPairSum_1() {
            var solution = new _0561_ArrayPartitionI();
            var result = solution.ArrayPairSum(new int[] { 1, 4, 3, 2 });
            Assert.AreEqual(4, result);
        }
    }
}
