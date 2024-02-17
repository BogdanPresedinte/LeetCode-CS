namespace LeetCode.Test
{
    public class _0917_ReverseOnlyLetters_Test
    {
        [Test]
        public void ReverseOnlyLetters_1() {
            var solution = new _0917_ReverseOnlyLetters();
            var result = solution.ReverseOnlyLetters("ab-cd");
            Assert.AreEqual("dc-ba", result);
        }

        [Test]
        public void ReverseOnlyLetters_2() {
            var solution = new _0917_ReverseOnlyLetters();
            var result = solution.ReverseOnlyLetters("a-bC-dEf-ghIj");
            Assert.AreEqual("j-Ih-gfE-dCba", result);
        }

        [Test]
        public void ReverseOnlyLetters_3() {
            var solution = new _0917_ReverseOnlyLetters();
            var result = solution.ReverseOnlyLetters("Test1ng-Leet=code-Q!");
            Assert.AreEqual("Qedo1ct-eeLg=ntse-T!", result);
        }
    }
}
