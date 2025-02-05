namespace LeetCode.Test
{
    public class _1295_FindNumbersWithEvenNumberOfDigits_Test
    {
        [Test]
        public void FindNumbers_1() {
            var solution = new _1295_FindNumbersWithEvenNumberOfDigits();
            var result = solution.FindNumbers(new int[] { 12, 345, 2, 6, 7896 });
            Assert.AreEqual(2, result);
        }

        [Test]
        public void FindNumbers_2() {
            var solution = new _1295_FindNumbersWithEvenNumberOfDigits();
            var result = solution.FindNumbers(new int[] { 555, 901, 482, 1771 });
            Assert.AreEqual(1, result);
        }
    }
}
