﻿namespace LeetCode.Test
{
    class _0268_MissingNumber_Test
    {
        [Test]
        public void MissingNumberTest_1() {
            var solution = new _0268_MissingNumber();
            var result = solution.MissingNumber(new int[] { 3, 0, 1 });
            Assert.AreEqual(2, result);
        }

        [Test]
        public void MissingNumberTest_2() {
            var solution = new _0268_MissingNumber();
            var result = solution.MissingNumber(new int[] { 0 });
            Assert.AreEqual(1, result);
        }

        [Test]
        public void MissingNumberTest_3() {
            var solution = new _0268_MissingNumber();
            var result = solution.MissingNumber(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 });
            Assert.AreEqual(8, result);
        }
    }
}
