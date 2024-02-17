namespace LeetCode.Test
{
    public class _0301_RemoveInvalidParentheses_Test
    {
        [Test]
        public void RemoveInvalidParenthesesTest_1() {
            var solution = new _0301_RemoveInvalidParentheses();
            var result = solution.RemoveInvalidParentheses("()())()");
            AssertHelper.AssertList(new string[] { "(())()", "()()()" }, result);
        }

        [Test]
        public void RemoveInvalidParenthesesTest_2() {
            var solution = new _0301_RemoveInvalidParentheses();
            var result = solution.RemoveInvalidParentheses("(a)())()");
            AssertHelper.AssertList(new string[] { "(a())()", "(a)()()" }, result);
        }

        [Test]
        public void RemoveInvalidParenthesesTest_3() {
            var solution = new _0301_RemoveInvalidParentheses();
            var result = solution.RemoveInvalidParentheses(")(");
            AssertHelper.AssertList(new string[] { "" }, result);
        }
    }
}
