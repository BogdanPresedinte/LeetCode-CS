﻿namespace LeetCode.Test
{
    public class _096_UniqueBinarySearchTree_Test
    {
        [Test]
        public void MyTestMethod() {
            var solution = new _096_UniqueBinarySearchTree();
            var result = solution.NumTrees(0);
            Assert.AreEqual(1, result);
            result = solution.NumTrees(1);
            Assert.AreEqual(1, result);
            result = solution.NumTrees(2);
            Assert.AreEqual(2, result);
            result = solution.NumTrees(3);
            Assert.AreEqual(5, result);
        }
    }
}
