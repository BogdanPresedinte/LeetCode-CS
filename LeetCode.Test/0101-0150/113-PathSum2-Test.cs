﻿namespace LeetCode.Test
{
    public class _113_PathSum2_Test
    {
        [Test]
        public void PathSumTest() {
            var solution = new _113_PathSum2();
            var results = solution.PathSum(TestHelper.GenerateTree(new int?[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, 5, 1 }), 22);
            AssertHelper.AssertList(new List<IList<int>>()
            {
                new List<int>() { 5, 4, 11, 2 },
                new List<int>() { 5, 8, 4, 5 },
            }, results);
        }

        [Test]
        public void PathSumTest_MoreOnSamePath() {
            var solution = new _113_PathSum2();
            var results = solution.PathSum(TestHelper.GenerateTree(new int?[] { 2, 3, 4, 5, null, null, null, -5 }), 5);
            AssertHelper.AssertList(new List<IList<int>>()
            {
                new List<int>() { 2, 3, 5, -5 }
            }, results);
        }

        [Test]
        public void PathSumTest_NoResults() {
            var solution = new _113_PathSum2();
            var results = solution.PathSum(TestHelper.GenerateTree(new int?[] { 2, 3, 4, 5, null, null, null, -5 }), 7);
            Assert.AreEqual(0, results.Count);
        }

        [Test]
        public void PathSumTest_Null() {
            var solution = new _113_PathSum2();
            var results = solution.PathSum(null, 7);
            Assert.AreEqual(0, results.Count);
        }
    }
}
