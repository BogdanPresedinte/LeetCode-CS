namespace LeetCode.Test
{
    public class _115_DistinctSubsequences_Test
    {
        [Test]
        public void NumDistinctTest() {
            var solution = new _115_DistinctSubsequences();
            var result = solution.NumDistinct("rabbbit", "rabbit");
            Assert.AreEqual(3, result);
        }

        [Test]
        public void NumDistinctTest_2() {
            var solution = new _115_DistinctSubsequences();
            var result = solution.NumDistinct("babgbag", "bag");
            Assert.AreEqual(5, result);
        }

        [Test]
        public void NumDistinctTest_BothEmptyString() {
            var solution = new _115_DistinctSubsequences();
            var result = solution.NumDistinct("", "");
            Assert.AreEqual(1, result);
        }

        [Test]
        public void NumDistinctTest_TEmptyString() {
            var solution = new _115_DistinctSubsequences();
            var result = solution.NumDistinct("", "");
            Assert.AreEqual(1, result);
        }

        [Test]
        public void NumDistinctTest_SEmptyString() {
            var solution = new _115_DistinctSubsequences();
            var result = solution.NumDistinct("", "abc");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void NumDistinctTest_NoMatch() {
            var solution = new _115_DistinctSubsequences();
            var result = solution.NumDistinct("abc", "d");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void NumDistinctTest_NoMatch_2() {
            var solution = new _115_DistinctSubsequences();
            var result = solution.NumDistinct("abcd", "de");
            Assert.AreEqual(0, result);
        }
    }
}
