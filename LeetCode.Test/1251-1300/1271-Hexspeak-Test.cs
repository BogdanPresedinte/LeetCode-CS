namespace LeetCode.Test
{
    public class _1271_Hexspeak_Test
    {
        [Test]
        public void ToHexspeak_1() {
            var solution = new _1271_Hexspeak();
            var result = solution.ToHexspeak("257");
            Assert.AreEqual("IOI", result);
        }

        [Test]
        public void ToHexspeak_2() {
            var solution = new _1271_Hexspeak();
            var result = solution.ToHexspeak("3");
            Assert.AreEqual("ERROR", result);
        }
    }
}
