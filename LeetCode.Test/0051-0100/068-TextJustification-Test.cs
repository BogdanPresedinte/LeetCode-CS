namespace LeetCode.Test
{
    public class _068_TextJustification_Test
    {
        [Test]
        public void FullJustifyTest() {
            var input = new string[] { "This", "is", "an", "example", "of", "text", "justification." };

            var solution = new _068_TextJustification();
            var result = solution.FullJustify(input, 16);

            AssertHelper.AssertList(new string[] {
                "This    is    an",
                "example  of text",
                "justification.  "
            }, result);
        }

        [Test]
        public void FullJustifyTest_OneLine() {
            var input = new string[] { "justification." };

            var solution = new _068_TextJustification();
            var result = solution.FullJustify(input, 16);

            AssertHelper.AssertList(new string[] {
                "justification.  "
            }, result);
        }

        [Test]
        public void FullJustifyTest_JustEnough() {
            var input = new string[] { "This", "is", "an", "example", "of", "text" };

            var solution = new _068_TextJustification();
            var result = solution.FullJustify(input, 7);

            AssertHelper.AssertList(new string[] {
                "This is",
                "an     ",
                "example",
                "of text"
            }, result);
        }

        [Test]
        public void FullJustifyTest_AlittleLess() {
            var input = new string[] { "This", "is", "an", "of", "text" };

            var solution = new _068_TextJustification();
            var result = solution.FullJustify(input, 6);

            AssertHelper.AssertList(new string[] {
                "This  ",
                "is  an",
                "of    ",
                "text  "
            }, result);
        }
    }
}
