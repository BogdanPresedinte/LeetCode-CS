namespace LeetCode.Test
{
    public class _0408_ValidWordAbbreviation_Test
    {
        [Test]
        public void ValidWordAbbreviation_1() {
            var solution = new _0408_ValidWordAbbreviation();
            var result = solution.ValidWordAbbreviation("internationalization", "i12iz4n");
            Assert.IsTrue(result);
        }

        [Test]
        public void ValidWordAbbreviation_2() {
            var solution = new _0408_ValidWordAbbreviation();
            var result = solution.ValidWordAbbreviation("apple", "a2e");
            Assert.IsFalse(result);
        }

        [Test]
        public void ValidWordAbbreviation_3() {
            var solution = new _0408_ValidWordAbbreviation();
            var result = solution.ValidWordAbbreviation("internationalization", "i5a11o1");
            Assert.IsTrue(result);
        }

        [Test]
        public void ValidWordAbbreviation_4() {
            var solution = new _0408_ValidWordAbbreviation();
            var result = solution.ValidWordAbbreviation("a", "01");
            Assert.IsFalse(result);
        }
    }
}
