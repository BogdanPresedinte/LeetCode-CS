namespace LeetCode.Test
{
    public class _0393_UTF8Validation_Test
    {
        [Test]
        public void ValidUtf8_1() {
            var solution = new _0393_UTF8Validation();
            var result = solution.ValidUtf8(new int[] { 197, 130, 1 });
            Assert.IsTrue(result);
        }

        [Test]
        public void ValidUtf8_2() {
            var solution = new _0393_UTF8Validation();
            var result = solution.ValidUtf8(new int[] { 235, 140, 4 });
            Assert.IsFalse(result);
        }
    }
}
