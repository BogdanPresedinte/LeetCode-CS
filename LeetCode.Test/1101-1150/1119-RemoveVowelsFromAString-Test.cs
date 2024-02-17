namespace LeetCode.Test
{
    public class _1119_RemoveVowelsFromAString_Test
    {
        [Test]
        public void RemoveVowelsTest_Empty() {
            var solution = new _1119_RemoveVowelsFromAString();
            var result = solution.RemoveVowels("");
            Assert.AreEqual("", result);
        }

        [Test]
        public void RemoveVowelsTest_Whitespace() {
            var solution = new _1119_RemoveVowelsFromAString();
            var result = solution.RemoveVowels("    ");
            Assert.AreEqual("    ", result);
        }

        [Test]
        public void RemoveVowelsTest_1() {
            var solution = new _1119_RemoveVowelsFromAString();
            var result = solution.RemoveVowels("leetcodeisacommunityforcoders");
            Assert.AreEqual("ltcdscmmntyfrcdrs", result);
        }

        [Test]
        public void RemoveVowelsTest_2() {
            var solution = new _1119_RemoveVowelsFromAString();
            var result = solution.RemoveVowels("aeiou");
            Assert.AreEqual("", result);
        }
    }
}
