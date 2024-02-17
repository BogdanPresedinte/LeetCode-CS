namespace LeetCode.Test
{
    public class _0753_CrackingtheSafe_Test
    {
        [Test]
        public void CrackSafeTest_1() {
            var solution = new _0753_CrackingtheSafe();
            var result = solution.CrackSafe(1, 2);
            Assert.AreEqual("10", result);
        }

        [Test]
        public void CrackSafeTest_2() {
            var solution = new _0753_CrackingtheSafe();
            var result = solution.CrackSafe(2, 2);
            Assert.AreEqual("01100", result);
        }

        [Test]
        public void CrackSafeTest_3() {
            var solution = new _0753_CrackingtheSafe();
            var result = solution.CrackSafe(2, 1);
            Assert.AreEqual("00", result);
        }
    }
}
