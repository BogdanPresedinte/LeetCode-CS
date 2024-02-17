namespace LeetCode.Test
{
    public class _0271_EncodeAndDecodeStrings_Test
    {
        [Test]
        public void EncodeDecodeTest() {
            var input = new string[] { "Hello", "", "World" };

            var solution = new _0271_EncodeAndDecodeStrings();
            var result = solution.decode(solution.encode(input));
            AssertHelper.AssertList(input, result);
        }
    }
}
