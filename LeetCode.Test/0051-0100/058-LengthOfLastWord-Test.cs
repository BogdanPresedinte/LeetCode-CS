namespace LeetCode.Test
{
    public class _058_LengthOfLastWord_Test
    {
        [Test]
        public void LengthOfLastWordTestd() {
            var solution = new _058_LengthOfLastWord();
            var result = solution.LengthOfLastWord("Hello World");

            Assert.AreEqual(5, result);
        }

        [Test]
        public void LengthOfLastWordTest_OnlyOneWord() {
            var solution = new _058_LengthOfLastWord();
            var result = solution.LengthOfLastWord("Hello");

            Assert.AreEqual(5, result);
        }

        [Test]
        public void LengthOfLastWordTest_AllSpace() {
            var solution = new _058_LengthOfLastWord();
            var result = solution.LengthOfLastWord("    ");

            Assert.AreEqual(0, result);
        }

        [Test]
        public void LengthOfLastWordTest_SpacesAfterLastWord() {
            var solution = new _058_LengthOfLastWord();
            var result = solution.LengthOfLastWord("Hello World123    ");

            Assert.AreEqual(8, result);
        }

        [Test]
        public void LengthOfLastWordTest_EmptyInput() {
            var solution = new _058_LengthOfLastWord();
            var result = solution.LengthOfLastWord("");

            Assert.AreEqual(0, result);
        }
    }
}
