namespace LeetCode.Test
{
    public class _0389_FindTheDifference_Test
    {
        [Test]
        public void FindTheDifference_1() {
            var solution = new _0389_FindTheDifference();
            var result = solution.FindTheDifference("abcd", "abcde");
            Assert.AreEqual('e', result);
        }

        [Test]
        public void FindTheDifference_2() {
            var solution = new _0389_FindTheDifference();
            var result = solution.FindTheDifference("abcd", "bedac");
            Assert.AreEqual('e', result);
        }
    }
}
