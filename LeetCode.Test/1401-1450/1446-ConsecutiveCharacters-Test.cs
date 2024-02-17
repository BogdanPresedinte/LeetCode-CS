namespace LeetCode.Test
{
    public class _1446_ConsecutiveCharacters_Test
    {
        [Test]
        public void MaxPower_1() {
            var solution = new _1446_ConsecutiveCharacters();
            var result = solution.MaxPower("leetcode");
            Assert.AreEqual(2, result);
        }

        [Test]
        public void MaxPower_2() {
            var solution = new _1446_ConsecutiveCharacters();
            var result = solution.MaxPower("abbcccddddeeeeedcba");
            Assert.AreEqual(5, result);
        }

        [Test]
        public void MaxPower_3() {
            var solution = new _1446_ConsecutiveCharacters();
            var result = solution.MaxPower("triplepillooooow");
            Assert.AreEqual(5, result);
        }

        [Test]
        public void MaxPower_4() {
            var solution = new _1446_ConsecutiveCharacters();
            var result = solution.MaxPower("hooraaaaaaaaaaay");
            Assert.AreEqual(11, result);
        }

        [Test]
        public void MaxPower_5() {
            var solution = new _1446_ConsecutiveCharacters();
            var result = solution.MaxPower("tourist");
            Assert.AreEqual(1, result);
        }
    }
}
