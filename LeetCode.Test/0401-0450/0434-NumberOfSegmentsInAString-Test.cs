namespace LeetCode.Test
{
    public class _0434_NumberOfSegmentsInAString_Test
    {
        [Test]
        public void CountSegments_1() {
            var solution = new _0434_NumberOfSegmentsInAString();
            var result = solution.CountSegments("Hello, my name is John");
            Assert.AreEqual(5, result);
        }
    }
}
