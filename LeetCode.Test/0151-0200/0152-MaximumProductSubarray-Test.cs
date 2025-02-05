﻿namespace LeetCode.Test
{
    public class _0152_MaximumProductSubarray_Test
    {
        [Test]
        public void MaxProductTest_1() {
            var solution = new _0152_MaximumProductSubarray();
            var result = solution.MaxProduct(new int[] { 2, 3, -2, 4 });
            Assert.AreEqual(6, result);
        }

        [Test]
        public void MaxProductTest_2() {
            var solution = new _0152_MaximumProductSubarray();
            var result = solution.MaxProduct(new int[] { -2, 0, -1 });
            Assert.AreEqual(0, result);
        }

        [Test]
        public void MaxProductTest_3() {
            var solution = new _0152_MaximumProductSubarray();
            var result = solution.MaxProduct(new int[] { 1 });
            Assert.AreEqual(1, result);
        }

        [Test]
        public void MaxProductTest_4() {
            var solution = new _0152_MaximumProductSubarray();
            var result = solution.MaxProduct(new int[] { });
            Assert.AreEqual(0, result);
        }
    }
}
