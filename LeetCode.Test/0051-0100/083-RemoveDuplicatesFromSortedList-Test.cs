namespace LeetCode.Test
{
    public class _083_RemoveDuplicatesFromSortedList_Test
    {
        [Test]
        public void DeleteDuplicatesTest_WithoutDuplicate() {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _083_RemoveDuplicatesFromSortedList();
            var result = solution.DeleteDuplicates(input);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5 }, result);
        }

        [Test]
        public void DeleteDuplicatesTest_WithDuplicate() {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 3, 4, 5 });

            var solution = new _083_RemoveDuplicatesFromSortedList();
            var result = solution.DeleteDuplicates(input);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5 }, result);
        }

        [Test]
        public void DeleteDuplicatesTest_WithMultipleDuplicate() {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 3, 4, 4, 5 });

            var solution = new _083_RemoveDuplicatesFromSortedList();
            var result = solution.DeleteDuplicates(input);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5 }, result);
        }

        [Test]
        public void DeleteDuplicatesTest_StartWithDuplicate() {
            var input = TestHelper.GenerateList(new int[] { 1, 1, 1, 2, 3, 4, 5 });

            var solution = new _083_RemoveDuplicatesFromSortedList();
            var result = solution.DeleteDuplicates(input);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5 }, result);
        }

        [Test]
        public void DeleteDuplicatesTest_EndWithDuplicate() {
            var input = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5, 5, 5 });

            var solution = new _083_RemoveDuplicatesFromSortedList();
            var result = solution.DeleteDuplicates(input);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5 }, result);
        }

        [Test]
        public void DeleteDuplicatesTest_AllTheSame() {
            var input = TestHelper.GenerateList(new int[] { 1, 1, 1, 1, 1 });

            var solution = new _083_RemoveDuplicatesFromSortedList();
            var result = solution.DeleteDuplicates(input);

            AssertHelper.AssertLinkList(new int[] { 1 }, result);
        }
    }
}
