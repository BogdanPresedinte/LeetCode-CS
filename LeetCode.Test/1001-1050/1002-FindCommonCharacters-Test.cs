namespace LeetCode.Test
{
    public class _1002_FindCommonCharacters_Test
    {
        [Test]
        public void CommonChars_1() {
            var solution = new _1002_FindCommonCharacters();
            var result = solution.CommonChars(new string[] { "bella", "label", "roller" });
            AssertHelper.AssertList(new string[] { "e", "l", "l" }, result);
        }

        [Test]
        public void CommonChars_2() {
            var solution = new _1002_FindCommonCharacters();
            var result = solution.CommonChars(new string[] { "cool", "lock", "cook" });
            AssertHelper.AssertList(new string[] { "c", "o" }, result);
        }
    }
}
