﻿namespace LeetCode.Test
{
    public class _001_TwoSum_Test
    {
        private readonly int[] largeArray;

        public _001_TwoSum_Test()
        {
            largeArray = new int[20000];
            for (int i = 0; i < 20000; i++) {
                largeArray[i] = i * 2;
            }
        }

        [Test]
        public void TwoSumTest_Ordered()
        {
            int[] nums = [2, 7, 11, 15];
            int target = 9;

            var solution = new _001_TwoSum();
            int[] result = solution.TwoSum(nums, target);

            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
        }

        [Test]
        public void TwoSumTest_Unordered()
        {
            int[] nums = [5, 75, 25];
            var target = 100;

            var solution = new _001_TwoSum();
            int[] result = solution.TwoSum(nums, target);

            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
        }

        [Test]
        public void TwoSumTest_Duplicate()
        {
            int[] nums = [5, 5, 15, 30];
            var target = 20;

            var solution = new _001_TwoSum();
            int[] result = solution.TwoSum(nums, target);

            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
        }

        [Test]
        public void TwoSumTest_AllSame()
        {
            int[] nums = [5, 5, 5, 5, 5];
            var target = 10;

            var solution = new _001_TwoSum();
            int[] result = solution.TwoSum(nums, target);

            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
        }

        [Test]
        public void TwoSumTest_NoTarget()
        {
            int[] nums = [2, 7, 11, 15];
            var target = 5;

            var solution = new _001_TwoSum();
            int[] result = solution.TwoSum(nums, target);

            Assert.AreEqual(0, result.Length);
        }

        [Test]
        [Timeout(50)]
        public void TwoSumTest_LargeArray()
        {
            var target = 19082;

            var solution = new _001_TwoSum();
            int[] result = solution.TwoSum(largeArray, target);

            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(4770, result[0]);
            Assert.AreEqual(4771, result[1]);
        }

        [Test]
        [Timeout(50)]
        public void TwoSumTest_LargeArray_NoTarget()
        {
            var target = 19081;

            var solution = new _001_TwoSum();
            int[] result = solution.TwoSum(largeArray, target);

            Assert.AreEqual(0, result.Length);
        }
    }
}
