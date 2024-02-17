namespace LeetCode.Test
{
    public class _0521_LongestUncommonSubsequenceI_Test
    {
        [Test]
        public void FindLUSlength_1() {
            var solution = new _0521_LongestUncommonSubsequenceI();
            var result = solution.FindLUSlength("aba", "cdc");
            Assert.AreEqual(3, result);
        }

        [Test]
        public void FindLUSlength_2() {
            var solution = new _0521_LongestUncommonSubsequenceI();
            var result = solution.FindLUSlength("aaa", "bbb");
            Assert.AreEqual(3, result);
        }

        [Test]
        public void FindLUSlength_3() {
            var solution = new _0521_LongestUncommonSubsequenceI();
            var result = solution.FindLUSlength("aaa", "aaa");
            Assert.AreEqual(-1, result);
        }
    }
}
