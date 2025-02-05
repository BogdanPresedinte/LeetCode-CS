namespace LeetCode.Test
{
    public class _0806_NumberOfLinesToWriteString_Test
    {
        [Test]
        public void NumberOfLines_1() {
            var solution = new _0806_NumberOfLinesToWriteString();
            var result = solution.NumberOfLines(new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }, "abcdefghijklmnopqrstuvwxyz");
            AssertHelper.AssertArray(new int[] { 3, 60 }, result);
        }

        [Test]
        public void NumberOfLines_2() {
            var solution = new _0806_NumberOfLinesToWriteString();
            var result = solution.NumberOfLines(new int[] { 4, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }, "bbbcccdddaaa");
            AssertHelper.AssertArray(new int[] { 2, 4 }, result);
        }
    }
}
