namespace LeetCode.Test
{
    public class _0207_CourseSchedule_Test
    {
        [Test]
        public void CanFinishTest_1() {
            var solution = new _0207_CourseSchedule();
            var result = solution.CanFinish(2, new int[][] { new int[] { 1, 0 } });
            Assert.IsTrue(result);
        }

        [Test]
        public void CanFinishTest_2() {
            var solution = new _0207_CourseSchedule();
            var result = solution.CanFinish(2, new int[][] { new int[] { 1, 0 }, new int[] { 0, 1 } });
            Assert.IsFalse(result);
        }
    }
}
