﻿namespace LeetCode.Test
{
    public class _0237_DeleteNodeInALinkedList_Test
    {
        [Test]
        public void DeleteNodeTest_1() {
            var list = TestHelper.GenerateList(new int[] { 4, 5, 1, 9 });

            var solution = new _0237_DeleteNodeInALinkedList();
            solution.DeleteNode(list.next);
            AssertHelper.AssertLinkList(new int[] { 4, 1, 9 }, list);
        }

        [Test]
        public void DeleteNodeTest_2() {
            var list = TestHelper.GenerateList(new int[] { 4, 5, 1, 9 });

            var solution = new _0237_DeleteNodeInALinkedList();
            solution.DeleteNode(list.next.next);
            AssertHelper.AssertLinkList(new int[] { 4, 5, 9 }, list);
        }
    }
}
