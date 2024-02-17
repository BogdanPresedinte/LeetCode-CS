namespace LeetCode.Test
{
    public class _0520_DetectCapital_Test
    {
        [Test]
        public void DetectCapitalUse_1() {
            var solution = new _0520_DetectCapital();
            var result = solution.DetectCapitalUse("USA");
            Assert.IsTrue(result);
        }

        [Test]
        public void DetectCapitalUse_2() {
            var solution = new _0520_DetectCapital();
            var result = solution.DetectCapitalUse("FlaG");
            Assert.IsFalse(result);
        }

        [Test]
        public void DetectCapitalUse_3() {
            var solution = new _0520_DetectCapital();
            var result = solution.DetectCapitalUse("leetcode");
            Assert.IsTrue(result);
        }

        [Test]
        public void DetectCapitalUse_4() {
            var solution = new _0520_DetectCapital();
            var result = solution.DetectCapitalUse("Google");
            Assert.IsTrue(result);
        }
    }
}
