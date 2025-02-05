﻿namespace LeetCode.Test
{
    public class _1426_CountingElements_Test
    {
        [Test]
        public void CountElementsTest_1() {
            var solution = new _1426_CountingElements();
            var result = solution.CountElements(new int[] { 1, 2, 3 });
            Assert.AreEqual(2, result);
        }

        [Test]
        public void CountElementsTest_2() {
            var solution = new _1426_CountingElements();
            var result = solution.CountElements(new int[] { 1, 1, 3, 3, 5, 5, 7, 7 });
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CountElementsTest_3() {
            var solution = new _1426_CountingElements();
            var result = solution.CountElements(new int[] { 1, 3, 2, 3, 5, 0 });
            Assert.AreEqual(3, result);
        }

        [Test]
        public void CountElementsTest_4() {
            var solution = new _1426_CountingElements();
            var result = solution.CountElements(new int[] { 1, 1, 2, 2 });
            Assert.AreEqual(2, result);
        }
    }
}
