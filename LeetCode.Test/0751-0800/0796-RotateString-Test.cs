namespace LeetCode.Test
{
    public class _0796_RotateString_Test
    {
        [Test]
        public void RotateString_1() {
            var solution = new _0796_RotateString();
            var result = solution.RotateString("abcde", "cdeab");
            Assert.IsTrue(result);
        }

        [Test]
        public void RotateString_2() {
            var solution = new _0796_RotateString();
            var result = solution.RotateString("abcde", "abced");
            Assert.IsFalse(result);
        }
    }
}
