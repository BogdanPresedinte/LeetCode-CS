namespace LeetCode.Test
{
    public class _1047_RemoveAllAdjacentDuplicatesInString_Test
    {
        [Test]
        public void RemoveDuplicates_1() {
            var solution = new _1047_RemoveAllAdjacentDuplicatesInString();
            var result = solution.RemoveDuplicates("abbaca");
            Assert.AreEqual("ca", result);
        }
    }
}
