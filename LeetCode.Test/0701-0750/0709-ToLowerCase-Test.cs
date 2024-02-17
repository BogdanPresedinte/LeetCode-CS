namespace LeetCode.Test
{
    public class _0709_ToLowerCase_Test
    {
        [Test]
        public void ToLowerCase_1() {
            var solution = new _0709_ToLowerCase();
            var result = solution.ToLowerCase("Hello");
            Assert.AreEqual("hello", result);
        }

        [Test]
        public void ToLowerCase_2() {
            var solution = new _0709_ToLowerCase();
            var result = solution.ToLowerCase("here");
            Assert.AreEqual("here", result);
        }

        [Test]
        public void ToLowerCase_3() {
            var solution = new _0709_ToLowerCase();
            var result = solution.ToLowerCase("LOVELY");
            Assert.AreEqual("lovely", result);
        }
    }
}
