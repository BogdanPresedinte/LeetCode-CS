namespace LeetCode.Test
{
    public class _0876_MiddleOfTheLinkedList_Test
    {
        [Test]
        public void MiddleNodeTest_1() {
            var solution = new _0876_MiddleOfTheLinkedList();
            var result = solution.MiddleNode(TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 }));
            AssertHelper.AssertLinkList(new int[] { 3, 4, 5 }, result);
        }

        [Test]
        public void MiddleNodeTest_2() {
            var solution = new _0876_MiddleOfTheLinkedList();
            var result = solution.MiddleNode(TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5, 6 }));
            AssertHelper.AssertLinkList(new int[] { 4, 5, 6 }, result);
        }
    }
}
