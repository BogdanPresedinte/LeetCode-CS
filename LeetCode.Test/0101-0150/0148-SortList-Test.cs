namespace LeetCode.Test
{
    public class _0148_SortList_Test
    {
        [Test]
        public void SortList_1() {
            var head = TestHelper.GenerateList(new int[] { 4, 2, 1, 3 });

            var solution = new _0148_SortList();
            var result = solution.SortList(head);
            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4 }, result);
        }

        [Test]
        public void SortList_2() {
            var head = TestHelper.GenerateList(new int[] { -1, 5, 3, 4, 0 });

            var solution = new _0148_SortList();
            var result = solution.SortList(head);
            AssertHelper.AssertLinkList(new int[] { -1, 0, 3, 4, 5 }, result);
        }
    }
}
