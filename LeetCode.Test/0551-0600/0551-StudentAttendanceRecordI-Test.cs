namespace LeetCode.Test
{
    public class _0551_StudentAttendanceRecordI_Test
    {
        [Test]
        public void CheckRecord_1() {
            var solution = new _0551_StudentAttendanceRecordI();
            var result = solution.CheckRecord("PPALLP");
            Assert.IsTrue(result);
        }

        [Test]
        public void CheckRecord_2() {
            var solution = new _0551_StudentAttendanceRecordI();
            var result = solution.CheckRecord("PPALLL");
            Assert.IsFalse(result);
        }
    }
}
