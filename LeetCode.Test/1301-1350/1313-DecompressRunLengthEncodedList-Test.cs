namespace LeetCode.Test
{
    public class _1313_DecompressRunLengthEncodedList_Test
    {
        [Test]
        public void DecompressRLElist_1() {
            var solution = new _1313_DecompressRunLengthEncodedList();
            var result = solution.DecompressRLElist(new int[] { 1, 2, 3, 4 });
            AssertHelper.AssertArray(new int[] { 2, 4, 4, 4 }, result);
        }

        [Test]
        public void DecompressRLElist_2() {
            var solution = new _1313_DecompressRunLengthEncodedList();
            var result = solution.DecompressRLElist(new int[] { 1, 1, 2, 3 });
            AssertHelper.AssertArray(new int[] { 1, 3, 3 }, result);
        }
    }
}
