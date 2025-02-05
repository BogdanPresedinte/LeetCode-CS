namespace LeetCode.Test
{
    public class _1309_DecryptStringFromAlphabetToIntegerMapping_Test
    {
        [Test]
        public void FreqAlphabets_1() {
            var solution = new _1309_DecryptStringFromAlphabetToIntegerMapping();
            var result = solution.FreqAlphabets("10#11#12");
            Assert.AreEqual("jkab", result);
        }

        [Test]
        public void FreqAlphabets_2() {
            var solution = new _1309_DecryptStringFromAlphabetToIntegerMapping();
            var result = solution.FreqAlphabets("1326#");
            Assert.AreEqual("acz", result);
        }

        [Test]
        public void FreqAlphabets_3() {
            var solution = new _1309_DecryptStringFromAlphabetToIntegerMapping();
            var result = solution.FreqAlphabets("25#");
            Assert.AreEqual("y", result);
        }

        [Test]
        public void FreqAlphabets_4() {
            var solution = new _1309_DecryptStringFromAlphabetToIntegerMapping();
            var result = solution.FreqAlphabets("12345678910#11#12#13#14#15#16#17#18#19#20#21#22#23#24#25#26#");
            Assert.AreEqual("abcdefghijklmnopqrstuvwxyz", result);
        }
    }
}
