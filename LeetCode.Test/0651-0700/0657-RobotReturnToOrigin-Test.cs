namespace LeetCode.Test
{
    public class _0657_RobotReturnToOrigin_Test
    {
        [Test]
        public void JudgeCircle_1() {
            var solution = new _0657_RobotReturnToOrigin();
            var result = solution.JudgeCircle("UD");
            Assert.IsTrue(result);
        }

        [Test]
        public void JudgeCircle_2() {
            var solution = new _0657_RobotReturnToOrigin();
            var result = solution.JudgeCircle("LL");
            Assert.IsFalse(result);
        }
    }
}
