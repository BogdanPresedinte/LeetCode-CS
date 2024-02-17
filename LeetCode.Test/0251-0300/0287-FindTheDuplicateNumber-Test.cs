namespace LeetCode.Test
{
    public class _0287_FindTheDuplicateNumber_Test
    {
        [Test]
        public void FindDuplicateTest_1() {
            var solution = new _0287_FindTheDuplicateNumber();
            var result = solution.FindDuplicate(new int[] { 1, 3, 4, 2, 2 });
            Assert.AreEqual(2, result);
        }

        [Test]
        public void FindDuplicateTest_2() {
            var solution = new _0287_FindTheDuplicateNumber();
            var result = solution.FindDuplicate(new int[] { 3, 1, 3, 4, 2 });
            Assert.AreEqual(3, result);
        }
    }
}
