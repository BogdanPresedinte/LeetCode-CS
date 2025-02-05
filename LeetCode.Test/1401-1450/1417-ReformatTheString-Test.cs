namespace LeetCode.Test
{
    public class _1417_ReformatTheString_Test
    {
        [Test]
        public void Reformat_1() {
            var solution = new _1417_ReformatTheString();
            var result = solution.Reformat("a0b1c2");
            Assert.AreEqual("0a1b2c", result);
        }

        [Test]
        public void Reformat_2() {
            var solution = new _1417_ReformatTheString();
            var result = solution.Reformat("leetcode");
            Assert.AreEqual("", result);
        }

        [Test]
        public void Reformat_3() {
            var solution = new _1417_ReformatTheString();
            var result = solution.Reformat("1229857369");
            Assert.AreEqual("", result);
        }

        [Test]
        public void Reformat_4() {
            var solution = new _1417_ReformatTheString();
            var result = solution.Reformat("covid2019");
            Assert.AreEqual("c2o0v1i9d", result);
        }

        [Test]
        public void Reformat_5() {
            var solution = new _1417_ReformatTheString();
            var result = solution.Reformat("ab123");
            Assert.AreEqual("1a2b3", result);
        }
    }
}
