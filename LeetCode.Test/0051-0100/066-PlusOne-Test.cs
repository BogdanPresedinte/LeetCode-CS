namespace LeetCode.Test
{
    public class _066_PlusOne_Test
    {
        [Test]
        public void PlusOneTest() {
            var input = new int[] { 1, 2, 3 };

            var solution = new _066_PlusOne();
            var result = solution.PlusOne(input);

            AssertHelper.AssertArray(new int[] { 1, 2, 4 }, result);
        }

        [Test]
        public void PlusOneTest_Zero() {
            var input = new int[] { 0 };

            var solution = new _066_PlusOne();
            var result = solution.PlusOne(input);

            AssertHelper.AssertArray(new int[] { 1 }, result);
        }

        [Test]
        public void PlusOneTest_WithCarry() {
            var input = new int[] { 9, 9, 9 };

            var solution = new _066_PlusOne();
            var result = solution.PlusOne(input);

            AssertHelper.AssertArray(new int[] { 1, 0, 0, 0 }, result);
        }
    }
}
