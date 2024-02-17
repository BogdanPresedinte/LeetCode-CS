namespace LeetCode.Test
{
    public class _0504_Base7_Test
    {
        [Test]
        public void ConvertToBase7_1() {
            var solution = new _0504_Base7();
            var result = solution.ConvertToBase7(100);
            Assert.AreEqual("202", result);
        }

        [Test]
        public void ConvertToBase7_2() {
            var solution = new _0504_Base7();
            var result = solution.ConvertToBase7(-7);
            Assert.AreEqual("-10", result);
        }

        [Test]
        public void ConvertToBase7_3() {
            var solution = new _0504_Base7();
            var result = solution.ConvertToBase7(0);
            Assert.AreEqual("0", result);
        }
    }
}
