namespace LeetCode.Test
{
    public class _0476_NumberComplement_Test
    {
        [Test]
        public void FindComplement_1() {
            var solution = new _0476_NumberComplement();
            var result = solution.FindComplement(5);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void FindComplement_2() {
            var solution = new _0476_NumberComplement();
            var result = solution.FindComplement(1);
            Assert.AreEqual(0, result);
        }
    }
}
