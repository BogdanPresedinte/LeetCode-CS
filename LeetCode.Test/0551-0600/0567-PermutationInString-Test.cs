namespace LeetCode.Test
{
    public class _0567_PermutationInString_Test
    {
        [Test]
        public void CheckInclusion_1() {
            var solution = new _0567_PermutationInString();
            var result = solution.CheckInclusion("ab", "eidbaooo");
            Assert.IsTrue(result);
        }

        [Test]
        public void CheckInclusion_2() {
            var solution = new _0567_PermutationInString();
            var result = solution.CheckInclusion("ab", "eidboaoo");
            Assert.IsFalse(result);
        }
    }
}
