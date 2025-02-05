﻿namespace LeetCode.Test
{
    public class _0349_IntersectionOfTwoArrays_Test
    {
        [Test]
        public void IntersectionTest_1() {
            var solution = new _0349_IntersectionOfTwoArrays();
            var result = solution.Intersection(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 });
            AssertHelper.AssertArray(new int[] { 2 }, result);
        }

        [Test]
        public void IntersectionTest_2() {
            var solution = new _0349_IntersectionOfTwoArrays();
            var result = solution.Intersection(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 });
            AssertHelper.AssertArray(new int[] { 4, 9 }, result);
        }
    }
}
