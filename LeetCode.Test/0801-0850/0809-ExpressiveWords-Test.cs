namespace LeetCode.Test
{
    public class _0809_ExpressiveWords_Test
    {
        [Test]
        public void ExpressiveWordsTest_1() {
            var solution = new _0809_ExpressiveWords();
            var restult = solution.ExpressiveWords("heeellooo", new string[] { "hello", "hi", "helo" });
            Assert.AreEqual(1, restult);
        }

        [Test]
        public void ExpressiveWordsTest_2() {
            var solution = new _0809_ExpressiveWords();
            var restult = solution.ExpressiveWords("heeellooo", new string[] { "heello" });
            Assert.AreEqual(1, restult);
        }

        [Test]
        public void ExpressiveWordsTest_3() {
            var solution = new _0809_ExpressiveWords();
            var restult = solution.ExpressiveWords("heeellooo", new string[] { "heeello" });
            Assert.AreEqual(1, restult);
        }
    }
}
