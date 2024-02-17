namespace LeetCode.Test
{
    public class _1247_MinimumSwapsToMakeStringsEqual_Test
    {
        [Test]
        public void MinimumSwap_1() {
            var solution = new _1247_MinimumSwapsToMakeStringsEqual();
            var result = solution.MinimumSwap("xx", "yy");
            Assert.AreEqual(1, result);
        }

        [Test]
        public void MinimumSwap_2() {
            var solution = new _1247_MinimumSwapsToMakeStringsEqual();
            var result = solution.MinimumSwap("xy", "yx");
            Assert.AreEqual(2, result);
        }

        [Test]
        public void MinimumSwap_3() {
            var solution = new _1247_MinimumSwapsToMakeStringsEqual();
            var result = solution.MinimumSwap("xx", "xy");
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void MinimumSwap_4() {
            var solution = new _1247_MinimumSwapsToMakeStringsEqual();
            var result = solution.MinimumSwap("xxyyxyxyxx", "xyyxyxxxyx");
            Assert.AreEqual(4, result);
        }
    }
}
