﻿namespace LeetCode.Test
{
    public class _039_CombinationSum_Test
    {
        [Test]
        public void CombinationSumTest_WhenCandidiatesOrdered() {
            var solution = new _039_CombinationSum();
            var result = solution.CombinationSum(new int[] { 2, 3, 6, 7 }, 7);

            AssertHelper.AssertList(new List<IList<int>>()
            {
                new List<int>() { 2, 2, 3 },
                new List<int>() { 7 }
            }, result);
        }

        [Test]
        public void CombinationSumTest_WhenCandidiatesWithoutOrdered() {
            var solution = new _039_CombinationSum();
            var result = solution.CombinationSum(new int[] { 3, 6, 2, 7 }, 7);

            AssertHelper.AssertList(new List<IList<int>>()
            {
                new List<int>() { 2, 2, 3 },
                new List<int>() { 7 }
            }, result);
        }

        [Test]
        public void CombinationSumTest_NoMatch() {
            var solution = new _039_CombinationSum();
            var result = solution.CombinationSum(new int[] { 2, 3, 6, 7 }, 1);

            AssertHelper.AssertList(new List<IList<int>>() { }, result);
        }
    }
}
