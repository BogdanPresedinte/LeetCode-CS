﻿namespace LeetCode.Test
{
    public class _0167_TwoSumII_Test
    {
        [Test]
        public void TwoSumTest_1() {
            var solution = new _0167_TwoSumII();
            var result = solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            AssertHelper.AssertArray(new int[] { 1, 2 }, result);
        }

        [Test]
        public void TwoSumTest_2() {
            var solution = new _0167_TwoSumII();
            var result = solution.TwoSum(new int[] { 2, 7, 11, 15 }, 10);
            AssertHelper.AssertArray(new int[] { }, result);
        }
    }
}
