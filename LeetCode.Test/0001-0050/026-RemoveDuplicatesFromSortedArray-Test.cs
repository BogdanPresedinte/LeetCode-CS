namespace LeetCode.Test
{
    public class _026_RemoveDuplicatesFromSortedArray_Test
    {
        [Test]
        public void RemoveDuplicatesTest() {
            var input = new int[] { 1, 1, 2 };

            var solution = new _026_RemoveDuplicatesFromSortedArray();
            var result = solution.RemoveDuplicates(input);

            Assert.AreEqual(2, result);
            AssertHelper.AssertArray(new int[] { 1, 2 }, input, true);
        }

        [Test]
        public void RemoveDuplicatesTest_EmptyInput() {
            var solution = new _026_RemoveDuplicatesFromSortedArray();
            var result = solution.RemoveDuplicates(new int[] { });

            Assert.AreEqual(0, result);
        }

        [Test]
        public void RemoveDuplicatesTest_OneItem() {
            var input = new int[] { 1 };

            var solution = new _026_RemoveDuplicatesFromSortedArray();
            var result = solution.RemoveDuplicates(input);

            Assert.AreEqual(1, result);
            AssertHelper.AssertArray(new int[] { 1 }, input);
        }
    }
}
