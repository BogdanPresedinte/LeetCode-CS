﻿namespace LeetCode.Test
{
    public class _0375_GuessNumberHigherOrLowerII_Test
    {
        [Test]
        public void GetMoneyAmountTest_1() {
            var solution = new _0375_GuessNumberHigherOrLowerII();
            var result = solution.GetMoneyAmount(10);
            Assert.AreEqual(16, result);
        }

        [Test]
        public void GetMoneyAmountTest_2() {
            var solution = new _0375_GuessNumberHigherOrLowerII();
            var result = solution.GetMoneyAmount(5);
            Assert.AreEqual(6, result);
        }
    }
}
