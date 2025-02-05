namespace LeetCode.Test
{
    public class _1502_CanMakeArithmeticProgressionFromSequence_Test
    {
        [Test]
        public void CanMakeArithmeticProgression_1() {
            var solution = new _1502_CanMakeArithmeticProgressionFromSequence();
            var result = solution.CanMakeArithmeticProgression(new int[] { 3, 5, 1 });
            Assert.IsTrue(result);
        }

        [Test]
        public void CanMakeArithmeticProgression_2() {
            var solution = new _1502_CanMakeArithmeticProgressionFromSequence();
            var result = solution.CanMakeArithmeticProgression(new int[] { 1, 2, 4 });
            Assert.IsFalse(result);
        }
    }
}
