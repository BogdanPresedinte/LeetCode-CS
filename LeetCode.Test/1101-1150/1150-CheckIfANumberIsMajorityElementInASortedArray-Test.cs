namespace LeetCode.Test
{
    public class _1150_CheckIfANumberIsMajorityElementInASortedArray_Test
    {
        [Test]
        public void IsMajorityElement_1() {
            var solution = new _1150_CheckIfANumberIsMajorityElementInASortedArray();
            var result = solution.IsMajorityElement(new int[] { 2, 4, 5, 5, 5, 5, 5, 6, 6 }, 5);
            Assert.IsTrue(result);
        }

        [Test]
        public void IsMajorityElement_2() {
            var solution = new _1150_CheckIfANumberIsMajorityElementInASortedArray();
            var result = solution.IsMajorityElement(new int[] { 10, 100, 101, 101 }, 101);
            Assert.IsFalse(result);
        }
    }
}
