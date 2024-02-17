namespace LeetCode.Test
{
    public class _0665_NonDecreasingArray_Test
    {
        [Test]
        public void CheckPossibility_1() {
            var solution = new _0665_NonDecreasingArray();
            var result = solution.CheckPossibility(new int[] { 4, 2, 3 });
            Assert.IsTrue(result);
        }

        [Test]
        public void CheckPossibility_2() {
            var solution = new _0665_NonDecreasingArray();
            var result = solution.CheckPossibility(new int[] { 4, 2, 1 });
            Assert.IsFalse(result);
        }
    }
}
