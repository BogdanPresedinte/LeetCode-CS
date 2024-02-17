namespace LeetCode.Test
{
    public class _1415_TheKThLexicographicalStringOfAllHappyStringsOfLengthN_Test
    {
        [Test]
        public void GetHappyString_1() {
            var solution = new _1415_TheKThLexicographicalStringOfAllHappyStringsOfLengthN();
            var result = solution.GetHappyString(1, 3);
            Assert.AreEqual("c", result);
        }

        [Test]
        public void GetHappyString_2() {
            var solution = new _1415_TheKThLexicographicalStringOfAllHappyStringsOfLengthN();
            var result = solution.GetHappyString(1, 4);
            Assert.AreEqual("", result);
        }

        [Test]
        public void GetHappyString_3() {
            var solution = new _1415_TheKThLexicographicalStringOfAllHappyStringsOfLengthN();
            var result = solution.GetHappyString(3, 9);
            Assert.AreEqual("cab", result);
        }

        [Test]
        public void GetHappyString_4() {
            var solution = new _1415_TheKThLexicographicalStringOfAllHappyStringsOfLengthN();
            var result = solution.GetHappyString(2, 7);
            Assert.AreEqual("", result);
        }

        [Test]
        public void GetHappyString_5() {
            var solution = new _1415_TheKThLexicographicalStringOfAllHappyStringsOfLengthN();
            var result = solution.GetHappyString(10, 100);
            Assert.AreEqual("abacbabacb", result);
        }
    }
}
