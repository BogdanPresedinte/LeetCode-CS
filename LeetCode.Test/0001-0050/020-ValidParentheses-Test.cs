namespace LeetCode.Test
{
    public class _020_ValidParentheses_Test
    {
        [Test]
        public void IsValidTest() {
            var solution = new _020_ValidParentheses();

            Assert.IsTrue(solution.IsValid("()"));
            Assert.IsTrue(solution.IsValid("[]"));
            Assert.IsTrue(solution.IsValid("{}"));
            Assert.IsTrue(solution.IsValid("()[]{}"));
        }

        [Test]
        public void IsValidTest_WithOtherCharacters() {
            var solution = new _020_ValidParentheses();

            Assert.IsTrue(solution.IsValid("abc(abc)abc"));
            Assert.IsTrue(solution.IsValid("abc[abc]abc"));
            Assert.IsTrue(solution.IsValid("abc{abc}abc"));
            Assert.IsTrue(solution.IsValid("abc(abc)abc[abc]abc{abc}abc"));
        }

        [Test]
        public void IsValidTest_NotValid() {
            var solution = new _020_ValidParentheses();

            Assert.IsFalse(solution.IsValid("("));
            Assert.IsFalse(solution.IsValid(")"));
            Assert.IsFalse(solution.IsValid("["));
            Assert.IsFalse(solution.IsValid("]"));
            Assert.IsFalse(solution.IsValid("{"));
            Assert.IsFalse(solution.IsValid("}"));
            Assert.IsFalse(solution.IsValid("(]"));
            Assert.IsFalse(solution.IsValid("(}"));
            Assert.IsFalse(solution.IsValid("[)"));
            Assert.IsFalse(solution.IsValid("[}"));
            Assert.IsFalse(solution.IsValid("{)"));
            Assert.IsFalse(solution.IsValid("{]"));
        }
    }
}
