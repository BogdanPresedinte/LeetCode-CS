namespace LeetCode.Test
{
    public class _1400_ConstructKPalindromeStrings_Test
    {
        [Test]
        public void CanConstruct_1() {
            var solution = new _1400_ConstructKPalindromeStrings();
            var result = solution.CanConstruct("annabelle", 2);
            Assert.IsTrue(result);
        }

        [Test]
        public void CanConstruct_2() {
            var solution = new _1400_ConstructKPalindromeStrings();
            var result = solution.CanConstruct("leetcode", 3);
            Assert.IsFalse(result);
        }

        [Test]
        public void CanConstruct_3() {
            var solution = new _1400_ConstructKPalindromeStrings();
            var result = solution.CanConstruct("true", 4);
            Assert.IsTrue(result);
        }

        [Test]
        public void CanConstruct_4() {
            var solution = new _1400_ConstructKPalindromeStrings();
            var result = solution.CanConstruct("yzyzyzyzyzyzyzy", 2);
            Assert.IsTrue(result);
        }

        [Test]
        public void CanConstruct_5() {
            var solution = new _1400_ConstructKPalindromeStrings();
            var result = solution.CanConstruct("cr", 7);
            Assert.IsFalse(result);
        }
    }
}
