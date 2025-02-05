namespace LeetCode.Test
{
    public class _1291_SequentialDigits_Test
    {
        [Test]
        public void SequentialDigits_1() {
            var solution = new _1291_SequentialDigits();
            var result = solution.SequentialDigits(100, 300);
            AssertHelper.AssertList(new int[] { 123, 234 }, result);
        }

        [Test]
        public void SequentialDigits_2() {
            var solution = new _1291_SequentialDigits();
            var result = solution.SequentialDigits(1000, 13000);
            AssertHelper.AssertList(new int[] { 1234, 2345, 3456, 4567, 5678, 6789, 12345 }, result);
        }
    }
}
