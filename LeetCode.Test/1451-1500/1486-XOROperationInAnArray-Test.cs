namespace LeetCode.Test
{
    public class _1486_XOROperationInAnArray_Test
    {
        [Test]
        public void XorOperation_1() {
            var solution = new _1486_XOROperationInAnArray();
            var result = solution.XorOperation(5, 0);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void XorOperation_2() {
            var solution = new _1486_XOROperationInAnArray();
            var result = solution.XorOperation(4, 3);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void XorOperation_3() {
            var solution = new _1486_XOROperationInAnArray();
            var result = solution.XorOperation(1, 7);
            Assert.AreEqual(7, result);
        }

        [Test]
        public void XorOperation_4() {
            var solution = new _1486_XOROperationInAnArray();
            var result = solution.XorOperation(10, 5);
            Assert.AreEqual(2, result);
        }
    }
}
