namespace LeetCode.Test
{
    public class _1227_AirplaneSeatAssignmentProbability_Test
    {
        [Test]
        public void NthPersonGetsNthSeat_1() {
            var solution = new _1227_AirplaneSeatAssignmentProbability();
            var result = solution.NthPersonGetsNthSeat(1);
            Assert.AreEqual(1.0, result);
        }

        [Test]
        public void NthPersonGetsNthSeat_2() {
            var solution = new _1227_AirplaneSeatAssignmentProbability();
            var result = solution.NthPersonGetsNthSeat(2);
            Assert.AreEqual(0.5, result);
        }
    }
}
