namespace LeetCode.Test
{
    public class _0557_ReverseWordsInAStringIII_Test
    {
        [Test]
        public void ReverseWords_1() {
            var solution = new _0557_ReverseWordsInAStringIII();
            var result = solution.ReverseWords("Let's take LeetCode contest");
            Assert.AreEqual("s'teL ekat edoCteeL tsetnoc", result);
        }
    }
}
