﻿namespace LeetCode.Test
{
    public class _0621_TaskScheduler_Test
    {
        [Test]
        public void LeastIntervalTest_1() {
            var solution = new _0621_TaskScheduler();
            var result = solution.LeastInterval(new char[] { 'A', 'A', 'A', 'B', 'B', 'B' }, 2);
            Assert.AreEqual(8, result);
        }
    }
}
