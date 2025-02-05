﻿namespace LeetCode.Test
{
    public class _0973_KClosestPointsToOrigin_Test
    {
        [Test]
        public void KClosest_1() {
            var solution = new _0973_KClosestPointsToOrigin();
            var result = solution.KClosest(
                new int[][]
                {
                    new int[] { 1, 3 },
                    new int[] { -2, 2 }
                }, 1);
            AssertHelper.AssertArray(
                new int[][]
                {
                    new int[] { -2, 2 }
                }, result);
        }

        [Test]
        public void KClosest_2() {
            var solution = new _0973_KClosestPointsToOrigin();
            var result = solution.KClosest(
                new int[][]
                {
                    new int[] { 3, 3 },
                    new int[] { 5, -1 },
                    new int[] { -2, 4 },
                }, 2);
            AssertHelper.AssertArray(
                new int[][]
                {
                    new int[] { 3, 3 },
                    new int[] { -2, 4 }
                }, result);
        }
    }
}
