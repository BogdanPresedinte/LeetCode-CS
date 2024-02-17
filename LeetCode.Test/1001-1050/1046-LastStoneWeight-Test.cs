namespace LeetCode.Test
{
    public class _1046_LastStoneWeight_Test
    {
        [Test]
        public void LastStoneWeightTest_1() {
            var solution = new _1046_LastStoneWeight();
            var result = solution.LastStoneWeight(new int[] { 2, 7, 4, 1, 8, 1 });
            Assert.AreEqual(1, result);
        }

        [Test]
        public void LastStoneWeightTest_2() {
            var solution = new _1046_LastStoneWeight();
            var result = solution.LastStoneWeight(new int[] { 1, 1 });
            Assert.AreEqual(0, result);
        }
    }
}
