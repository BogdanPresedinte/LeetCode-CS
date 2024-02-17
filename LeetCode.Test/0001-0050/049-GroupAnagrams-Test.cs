namespace LeetCode.Test
{
    public class _049_GroupAnagrams_Test
    {
        [Test]
        public void GroupAnagramsTest() {
            var input = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };

            var solution = new _049_GroupAnagrams();
            var result = solution.GroupAnagrams(input);

            AssertHelper.AssertList(
                new List<IList<string>>()
                {
                    new List<string> () { "ate", "eat", "tea" },
                    new List<string> () { "nat","tan" },
                    new List<string> () { "bat" }
                }, result);
        }

        [Test]
        public void GroupAnagramsTest_Empty() {
            var input = new string[] { };

            var solution = new _049_GroupAnagrams();
            var result = solution.GroupAnagrams(input);

            Assert.AreEqual(0, result.Count);
        }
    }
}
