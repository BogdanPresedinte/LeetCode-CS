﻿namespace LeetCode.Test
{
    public class _0162_FindPeakElement_Test
    {
        [Test]
        public void FindPeakElementTest_1() {
            var solution = new _0162_FindPeakElement();
            var result = solution.FindPeakElement(new int[] { 1, 2, 3, 1 });
            Assert.AreEqual(2, result);
        }

        [Test]
        public void FindPeakElementTest_2() {
            var solution = new _0162_FindPeakElement();
            var result = solution.FindPeakElement(new int[] { 1, 2, 1, 3, 5, 6, 4 });
            Assert.AreEqual(5, result);
        }
    }
}
