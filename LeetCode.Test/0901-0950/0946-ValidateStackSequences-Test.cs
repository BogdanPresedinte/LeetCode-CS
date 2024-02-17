namespace LeetCode.Test
{
    public class _0946_ValidateStackSequences_Test
    {
        [Test]
        public void ValidateStackSequences_1() {
            var solution = new _0946_ValidateStackSequences();
            var result = solution.ValidateStackSequences(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 3, 2, 1 });
            Assert.IsTrue(result);
        }

        [Test]
        public void ValidateStackSequences_2() {
            var solution = new _0946_ValidateStackSequences();
            var result = solution.ValidateStackSequences(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 3, 5, 1, 2 });
            Assert.IsFalse(result);
        }
    }
}
