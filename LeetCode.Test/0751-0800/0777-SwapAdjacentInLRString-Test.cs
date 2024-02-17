namespace LeetCode.Test
{
    public class _0777_SwapAdjacentInLRString_Test
    {
        [Test]
        public void CanTransformTest() {
            var solution = new _0777_SwapAdjacentInLRString();
            var result = solution.CanTransform("RXXLRXRXL", "XRLXXRRLX");
            Assert.IsTrue(result);
        }

        [Test]
        public void CanTransformTest_2() {
            var solution = new _0777_SwapAdjacentInLRString();
            var result = solution.CanTransform("X", "L");
            Assert.IsFalse(result);
        }
    }
}
