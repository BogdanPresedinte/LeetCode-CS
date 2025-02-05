namespace LeetCode.Test
{
    public class _0191_NumberOf1Bits_Test
    {
        [Test]
        public void HammingWeight_1() {
            var solution = new _0191_NumberOf1Bits();
            var result = solution.HammingWeight(Convert.ToUInt32("00000000000000000000000000001011", 2));
            Assert.AreEqual(3, result);
        }

        [Test]
        public void HammingWeight_2() {
            var solution = new _0191_NumberOf1Bits();
            var result = solution.HammingWeight(Convert.ToUInt32("00000000000000000000000010000000", 2));
            Assert.AreEqual(1, result);
        }

        [Test]
        public void HammingWeight_3() {
            var solution = new _0191_NumberOf1Bits();
            var result = solution.HammingWeight(Convert.ToUInt32("11111111111111111111111111111101", 2));
            Assert.AreEqual(31, result);
        }
    }
}
