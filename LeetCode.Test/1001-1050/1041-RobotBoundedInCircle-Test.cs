namespace LeetCode.Test
{
    public class _1041_RobotBoundedInCircle_Test
    {
        [Test]
        public void IsRobotBounded_1() {
            var solution = new _1041_RobotBoundedInCircle();
            var result = solution.IsRobotBounded("GGLLGG");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsRobotBounded_2() {
            var solution = new _1041_RobotBoundedInCircle();
            var result = solution.IsRobotBounded("GG");
            Assert.IsFalse(result);
        }

        [Test]
        public void IsRobotBounded_3() {
            var solution = new _1041_RobotBoundedInCircle();
            var result = solution.IsRobotBounded("GL");
            Assert.IsTrue(result);
        }
    }
}
