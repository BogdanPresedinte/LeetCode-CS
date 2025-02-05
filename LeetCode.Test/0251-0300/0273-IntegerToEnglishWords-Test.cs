﻿namespace LeetCode.Test
{
    public class _0273_IntegerToEnglishWords_Test
    {
        [Test]
        public void NumberToWordsTest_1() {
            var solution = new _0273_IntegerToEnglishWords();
            var result = solution.NumberToWords(123);
            Assert.AreEqual("One Hundred Twenty Three", result);
        }

        [Test]
        public void NumberToWordsTest_2() {
            var solution = new _0273_IntegerToEnglishWords();
            var result = solution.NumberToWords(12345);
            Assert.AreEqual("Twelve Thousand Three Hundred Forty Five", result);
        }

        [Test]
        public void NumberToWordsTest_3() {
            var solution = new _0273_IntegerToEnglishWords();
            var result = solution.NumberToWords(1234567);
            Assert.AreEqual("One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven", result);
        }

        [Test]
        public void NumberToWordsTest_4() {
            var solution = new _0273_IntegerToEnglishWords();
            var result = solution.NumberToWords(1234567891);
            Assert.AreEqual("One Billion Two Hundred Thirty Four Million Five Hundred Sixty Seven Thousand Eight Hundred Ninety One", result);
        }

        [Test]
        public void NumberToWordsTest_5() {
            var solution = new _0273_IntegerToEnglishWords();
            var result = solution.NumberToWords(0);
            Assert.AreEqual("Zero", result);
        }
    }
}
