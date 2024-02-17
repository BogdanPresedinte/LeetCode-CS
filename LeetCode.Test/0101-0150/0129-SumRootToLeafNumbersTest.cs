namespace LeetCode.Test
{
    public class _0129_SumRootToLeafNumbersTest
    {
        [Test]
        public void SumNumbersTest_1() {
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, 3 });
            var solution = new _0129_SumRootToLeafNumbers();
            Assert.AreEqual(25, solution.SumNumbers(root));
        }

        [Test]
        public void SumNumbersTest_2() {
            var root = TestHelper.GenerateTree(new int?[] { 4, 9, 0, 5, 1 });
            var solution = new _0129_SumRootToLeafNumbers();
            Assert.AreEqual(1026, solution.SumNumbers(root));
        }
    }
}
