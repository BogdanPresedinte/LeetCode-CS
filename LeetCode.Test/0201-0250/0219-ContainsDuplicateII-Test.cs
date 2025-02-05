namespace LeetCode.Test
{
    public class _0219_ContainsDuplicateII_Test
    {
        [Test]
        public void ContainsNearbyDuplicate_1() {
            var solution = new _0219_ContainsDuplicateII();
            var result = solution.ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1 }, 3);
            Assert.IsTrue(result);
        }

        [Test]
        public void ContainsNearbyDuplicate_2() {
            var solution = new _0219_ContainsDuplicateII();
            var result = solution.ContainsNearbyDuplicate(new int[] { 1, 0, 1, 1 }, 1);
            Assert.IsTrue(result);
        }

        [Test]
        public void ContainsNearbyDuplicate_3() {
            var solution = new _0219_ContainsDuplicateII();
            var result = solution.ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1, 2, 3 }, 2);
            Assert.IsFalse(result);
        }
    }
}
