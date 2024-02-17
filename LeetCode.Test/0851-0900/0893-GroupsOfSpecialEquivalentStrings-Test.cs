namespace LeetCode.Test
{
    public class _0893_GroupsOfSpecialEquivalentStrings_Test
    {
        [Test]
        public void NumSpecialEquivGroups_1() {
            var solution = new _0893_GroupsOfSpecialEquivalentStrings();
            var result = solution.NumSpecialEquivGroups(new string[] { "abcd", "cdab", "cbad", "xyzz", "zzxy", "zzyx" });
            Assert.AreEqual(3, result);
        }

        [Test]
        public void NumSpecialEquivGroups_2() {
            var solution = new _0893_GroupsOfSpecialEquivalentStrings();
            var result = solution.NumSpecialEquivGroups(new string[] { "abc", "acb", "bac", "bca", "cab", "cba" });
            Assert.AreEqual(3, result);
        }
    }
}
