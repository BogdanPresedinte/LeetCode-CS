namespace LeetCode.Test
{
    public class _0788_RotatedDigits_Test
    {
        [Test]
        public void RotatedDigits_1() {
            var solution = new _0788_RotatedDigits();
            var result = solution.RotatedDigits(10);
            Assert.AreEqual(4, result);
        }
    }
}
