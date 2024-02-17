namespace LeetCode.Test
{
    public class _0461_HammingDistance_Test
    {
        [Test]
        public void HammingDistanceTest() {
            var solution = new _0461_HammingDistance();
            var result = solution.HammingDistance(1, 4);
            Assert.AreEqual(2, result);
        }
    }
}
