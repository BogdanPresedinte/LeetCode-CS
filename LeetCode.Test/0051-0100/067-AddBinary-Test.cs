namespace LeetCode.Test
{
    public class _067_AddBinary_Test
    {
        [Test]
        public void AddBinaryTest_ALonger() {
            var solution = new _067_AddBinary();
            var result = solution.AddBinary("10", "1");

            Assert.AreEqual("11", result);
        }

        [Test]
        public void AddBinaryTest_BLonger() {
            var solution = new _067_AddBinary();
            var result = solution.AddBinary("1", "10");

            Assert.AreEqual("11", result);
        }

        [Test]
        public void AddBinaryTest_WithCarry() {
            var solution = new _067_AddBinary();
            var result = solution.AddBinary("1", "1");

            Assert.AreEqual("10", result);
        }

        [Test]
        public void AddBinaryTest_WithMultipleCarry() {
            var solution = new _067_AddBinary();
            var result = solution.AddBinary("11", "1");

            Assert.AreEqual("100", result);
        }

        [Test]
        public void AddBinaryTest_WithMultipleCarry_2() {
            var solution = new _067_AddBinary();
            var result = solution.AddBinary("11", "11");

            Assert.AreEqual("110", result);
        }
    }
}
