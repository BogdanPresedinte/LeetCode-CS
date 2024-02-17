namespace LeetCode.Test
{
    public class _0541_ReverseStringII_Test
    {
        [Test]
        public void ReverseStr_1() {
            var solution = new _0541_ReverseStringII();
            var result = solution.ReverseStr("abcdefg", 2);
            Assert.AreEqual("bacdfeg", result);
        }

        [Test]
        public void ReverseStr_2() {
            var solution = new _0541_ReverseStringII();
            var result = solution.ReverseStr("a", 2);
            Assert.AreEqual("a", result);
        }
    }
}
