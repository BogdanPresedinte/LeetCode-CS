﻿namespace LeetCode.Test
{
    public class _0239_SlidingWindowMaximum_Test
    {
        [Test]
        public void MyTestMethod() {
            var solution = new _0239_SlidingWindowMaximum();
            var result = solution.MaxSlidingWindow(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3);
            AssertHelper.AssertArray(new int[] { 3, 3, 5, 5, 6, 7 }, result);
        }
    }
}
