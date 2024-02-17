namespace LeetCode.Test
{
    public class _1021_RemoveOutermostParentheses_Test
    {
        [Test]
        public void RemoveOuterParentheses_1() {
            var solution = new _1021_RemoveOutermostParentheses();
            var result = solution.RemoveOuterParentheses("(()())(())");
            Assert.AreEqual("()()()", result);
        }

        [Test]
        public void RemoveOuterParentheses_2() {
            var solution = new _1021_RemoveOutermostParentheses();
            var result = solution.RemoveOuterParentheses("(()())(())(()(()))");
            Assert.AreEqual("()()()()(())", result);
        }

        [Test]
        public void RemoveOuterParentheses_3() {
            var solution = new _1021_RemoveOutermostParentheses();
            var result = solution.RemoveOuterParentheses("()()");
            Assert.AreEqual("", result);
        }
    }
}
