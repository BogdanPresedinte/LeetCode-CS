namespace LeetCode.Test
{
    public class _0168_ExcelSheetColumnTitle_Test
    {
        [Test]
        public void ConvertToTitle_1() {
            var solution = new _0168_ExcelSheetColumnTitle();
            var result = solution.ConvertToTitle(1);
            Assert.AreEqual("A", result);
        }

        [Test]
        public void ConvertToTitle_2() {
            var solution = new _0168_ExcelSheetColumnTitle();
            var result = solution.ConvertToTitle(28);
            Assert.AreEqual("AB", result);
        }

        [Test]
        public void ConvertToTitle_3() {
            var solution = new _0168_ExcelSheetColumnTitle();
            var result = solution.ConvertToTitle(701);
            Assert.AreEqual("ZY", result);
        }
    }
}
