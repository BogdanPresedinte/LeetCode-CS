namespace LeetCode.Test
{
    public class _1281_SubtractTheProductAndSumOfDigitsOfAnInteger_Test
    {
        [Test]
        public void SubtractProductAndSum_1() {
            var solution = new _1281_SubtractTheProductAndSumOfDigitsOfAnInteger();
            var result = solution.SubtractProductAndSum(234);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void SubtractProductAndSum_2() {
            var solution = new _1281_SubtractTheProductAndSumOfDigitsOfAnInteger();
            var result = solution.SubtractProductAndSum(4421);
            Assert.AreEqual(21, result);
        }
    }
}
