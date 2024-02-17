namespace LeetCode.Test
{
    public class _0843_GuesstheWord_Test
    {
        [Test]
        public void FindSecretWordTest() {
            var wordlist = new string[] { "acckzz", "ccbazz", "eiowzz", "abcczz" };
            var master = new Master("acckzz", wordlist);

            var solution = new _0843_GuesstheWord();
            solution.FindSecretWord(wordlist, master);

            Assert.IsTrue(master.GuessCount <= 10);
        }
    }
}
