namespace LeetCode.Test
{
    public class _0874_WalkingRobotSimulation_Test
    {
        [Test]
        public void RobotSim_1() {
            var solution = new _0874_WalkingRobotSimulation();
            var result = solution.RobotSim(new int[] { 4, -1, 3 }, new int[][] { });
            Assert.AreEqual(25, result);
        }

        [Test]
        public void RobotSim_2() {
            var solution = new _0874_WalkingRobotSimulation();
            var result = solution.RobotSim(new int[] { 4, -1, 4, -2, 4 }, new int[][] { new int[] { 2, 4 } });
            Assert.AreEqual(65, result);
        }
    }
}
