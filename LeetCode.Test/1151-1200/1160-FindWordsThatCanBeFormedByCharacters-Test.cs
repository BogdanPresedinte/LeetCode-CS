namespace LeetCode.Test
{
    public class _1160_FindWordsThatCanBeFormedByCharacters_Test
    {
        [Test]
        public void CountCharacters_1() {
            var solution = new _1160_FindWordsThatCanBeFormedByCharacters();
            var result = solution.CountCharacters(new string[] { "cat", "bt", "hat", "tree" }, "atach");
            Assert.AreEqual(6, result);
        }

        [Test]
        public void CountCharacters_2() {
            var solution = new _1160_FindWordsThatCanBeFormedByCharacters();
            var result = solution.CountCharacters(new string[] { "hello", "world", "leetcode" }, "welldonehoneyr");
            Assert.AreEqual(10, result);
        }
    }
}
