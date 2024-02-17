namespace LeetCode.Test
{
    public class _0884_UncommonWordsFromTwoSentences_Test
    {
        [Test]
        public void UncommonFromSentences_1() {
            var solution = new _0884_UncommonWordsFromTwoSentences();
            var result = solution.UncommonFromSentences("this apple is sweet", "this apple is sour");
            AssertHelper.AssertArray(new string[] { "sweet", "sour" }, result);
        }

        [Test]
        public void UncommonFromSentences_2() {
            var solution = new _0884_UncommonWordsFromTwoSentences();
            var result = solution.UncommonFromSentences("apple apple", "banana");
            AssertHelper.AssertArray(new string[] { "banana" }, result);
        }
    }
}
