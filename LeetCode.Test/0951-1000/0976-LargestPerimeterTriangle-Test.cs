namespace LeetCode.Test
{
    public class _0976_LargestPerimeterTriangle_Test
    {
        [Test]
        public void LargestPerimeter_1() {
            var solution = new _0976_LargestPerimeterTriangle();
            var result = solution.LargestPerimeter(new int[] { 2, 1, 2 });
            Assert.AreEqual(5, result);
        }

        [Test]
        public void LargestPerimeter_2() {
            var solution = new _0976_LargestPerimeterTriangle();
            var result = solution.LargestPerimeter(new int[] { 1, 2, 1 });
            Assert.AreEqual(0, result);
        }

        [Test]
        public void LargestPerimeter_3() {
            var solution = new _0976_LargestPerimeterTriangle();
            var result = solution.LargestPerimeter(new int[] { 3, 2, 3, 4 });
            Assert.AreEqual(10, result);
        }

        [Test]
        public void LargestPerimeter_4() {
            var solution = new _0976_LargestPerimeterTriangle();
            var result = solution.LargestPerimeter(new int[] { 3, 6, 2, 3 });
            Assert.AreEqual(8, result);
        }
    }
}
