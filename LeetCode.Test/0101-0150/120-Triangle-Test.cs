﻿namespace LeetCode.Test
{
    public class _120_Triangle_Test
    {
        [Test]
        public void MinimumTotalTest() {
            var solution = new _120_Triangle();
            var result = solution.MinimumTotal(new List<IList<int>>()
            {
                new List<int> { 2 },
                new List<int> { 3, 4 },
                new List<int> { 6, 5, 7 },
                new List<int> { 4, 1, 8, 3 },
            });
            Assert.AreEqual(11, result);
        }

        [Test]
        public void MinimumTotalTest_NotMiniumInProcess() {
            var solution = new _120_Triangle();
            var result = solution.MinimumTotal(new List<IList<int>>()
            {
                new List<int> { 2 },
                new List<int> { 3, 4 },
                new List<int> { 6, 5, 1 },
                new List<int> { 4, 1, 8, 1 },
            });
            Assert.AreEqual(8, result);
        }

        [Test]
        public void MinimumTotalTest_Empty() {
            var solution = new _120_Triangle();
            var result = solution.MinimumTotal(new List<IList<int>>());
            Assert.AreEqual(0, result);
        }

        [Test]
        public void MinimumTotalTest_OneLayer() {
            var solution = new _120_Triangle();
            var result = solution.MinimumTotal(new List<IList<int>>()
            {
                new List<int> { 2 },
            });
            Assert.AreEqual(2, result);
        }

        [Test]
        public void MinimumTotalTest_SameResult() {
            var solution = new _120_Triangle();
            var result = solution.MinimumTotal(new List<IList<int>>()
            {
                new List<int> { 2 },
                new List<int> { 3, 3 },
            });
            Assert.AreEqual(5, result);
        }
    }
}
