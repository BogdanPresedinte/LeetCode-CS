namespace LeetCode.Test
{
    public class _0800_SimilarRGBColor_Test
    {
        [Test]
        public void SimilarRGB_1() {
            var solution = new _0800_SimilarRGBColor();
            var result = solution.SimilarRGB("#09f166");
            Assert.AreEqual("#11ee66", result);
        }

        [Test]
        public void SimilarRGB_2() {
            var solution = new _0800_SimilarRGBColor();
            var result = solution.SimilarRGB("#1c9e03");
            Assert.AreEqual("#229900", result);
        }
    }
}
