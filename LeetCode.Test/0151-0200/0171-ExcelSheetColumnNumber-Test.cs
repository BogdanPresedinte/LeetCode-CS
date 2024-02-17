namespace LeetCode.Test
{
    public class _0171_ExcelSheetColumnNumber_Test
    {
        [Test]
        public void TitleToNumber_1() {
            var solution = new _0171_ExcelSheetColumnNumber();
            var result = solution.TitleToNumber("A");
            Assert.AreEqual(1, result);
        }

        [Test]
        public void TitleToNumber_2() {
            var solution = new _0171_ExcelSheetColumnNumber();
            var result = solution.TitleToNumber("AB");
            Assert.AreEqual(28, result);
        }

        [Test]
        public void TitleToNumber_3() {
            var solution = new _0171_ExcelSheetColumnNumber();
            var result = solution.TitleToNumber("ZY");
            Assert.AreEqual(701, result);
        }
    }
}
