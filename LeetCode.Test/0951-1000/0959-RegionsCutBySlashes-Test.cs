namespace LeetCode.Test
{
    public class _0959_RegionsCutBySlashes_Test
    {
        [Test]
        public void RegionsBySlashesTest_1() {
            var input = new string[] { " /", "/ " };

            var solution = new _0959_RegionsCutBySlashes();
            var result = solution.RegionsBySlashes(input);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void RegionsBySlashesTest_2() {
            var input = new string[] { " /", "  " };

            var solution = new _0959_RegionsCutBySlashes();
            var result = solution.RegionsBySlashes(input);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void RegionsBySlashesTest_3() {
            var input = new string[] { "\\/", "/\\" };

            var solution = new _0959_RegionsCutBySlashes();
            var result = solution.RegionsBySlashes(input);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void RegionsBySlashesTest_4() {
            var input = new string[] { "/\\", "\\/" };

            var solution = new _0959_RegionsCutBySlashes();
            var result = solution.RegionsBySlashes(input);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void RegionsBySlashesTest_5() {
            var input = new string[] { "//", "/ " };

            var solution = new _0959_RegionsCutBySlashes();
            var result = solution.RegionsBySlashes(input);
            Assert.AreEqual(3, result);
        }
    }
}
