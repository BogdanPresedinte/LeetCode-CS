namespace LeetCode.Test
{
    public class _1165_SingleRowKeyboard_Test
    {
        [Test]
        public void CalculateTime_1() {
            var solution = new _1165_SingleRowKeyboard();
            var result = solution.CalculateTime("abcdefghijklmnopqrstuvwxyz", "cba");
            Assert.AreEqual(4, result);
        }

        [Test]
        public void CalculateTime_2() {
            var solution = new _1165_SingleRowKeyboard();
            var result = solution.CalculateTime("pqrstuvwxyzabcdefghijklmno", "leetcode");
            Assert.AreEqual(73, result);
        }
    }
}
