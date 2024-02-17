namespace LeetCode.Test
{
    public class _0415_AddStrings_Test
    {
        [Test]
        public void AddStrings_1() {
            var solution = new _0415_AddStrings();
            var result = solution.AddStrings("123", "987");
            Assert.AreEqual("1110", result);
        }

        [Test]
        public void AddStrings_2() {
            var solution = new _0415_AddStrings();
            var result = solution.AddStrings("111", "1");
            Assert.AreEqual("112", result);
        }
    }
}
