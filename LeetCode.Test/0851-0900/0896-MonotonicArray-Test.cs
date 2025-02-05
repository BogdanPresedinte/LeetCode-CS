namespace LeetCode.Test
{
    public class _0896_MonotonicArray_Test
    {
        [Test]
        public void IsMonotonic_1() {
            var solution = new _0896_MonotonicArray();
            var result = solution.IsMonotonic(new int[] { 1, 2, 2, 3 });
            Assert.IsTrue(result);
        }

        [Test]
        public void IsMonotonic_2() {
            var solution = new _0896_MonotonicArray();
            var result = solution.IsMonotonic(new int[] { 6, 5, 4, 4 });
            Assert.IsTrue(result);
        }

        [Test]
        public void IsMonotonic_3() {
            var solution = new _0896_MonotonicArray();
            var result = solution.IsMonotonic(new int[] { 1, 3, 2 });
            Assert.IsFalse(result);
        }

        [Test]
        public void IsMonotonic_4() {
            var solution = new _0896_MonotonicArray();
            var result = solution.IsMonotonic(new int[] { 1, 2, 4, 5 });
            Assert.IsTrue(result);
        }

        [Test]
        public void IsMonotonic_5() {
            var solution = new _0896_MonotonicArray();
            var result = solution.IsMonotonic(new int[] { 1, 1, 1 });
            Assert.IsTrue(result);
        }
    }
}
