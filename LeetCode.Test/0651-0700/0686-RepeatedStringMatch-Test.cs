namespace LeetCode.Test
{
    public class _0686_RepeatedStringMatch_Test
    {
        [Test]
        public void RepeatedStringMatchTest() {
            var solution = new _0686_RepeatedStringMatch();
            var result = solution.RepeatedStringMatch("abcd", "cdabcdab");
            Assert.AreEqual(3, result);
        }
    }
}
