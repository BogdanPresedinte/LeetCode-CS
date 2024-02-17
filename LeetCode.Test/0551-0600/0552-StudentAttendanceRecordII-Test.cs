namespace LeetCode.Test
{
    public class _0552_StudentAttendanceRecordII_Test
    {
        [Test]
        public void CheckRecordTest_0() {
            var solution = new _0552_StudentAttendanceRecordII();
            var result = solution.CheckRecord(0);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void CheckRecordTest_1() {
            var solution = new _0552_StudentAttendanceRecordII();
            var result = solution.CheckRecord(1);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void CheckRecordTest_2() {
            var solution = new _0552_StudentAttendanceRecordII();
            var result = solution.CheckRecord(2);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void CheckRecordTest_3() {
            var solution = new _0552_StudentAttendanceRecordII();
            var result = solution.CheckRecord(3);
            Assert.AreEqual(19, result);
        }

        [Test]
        public void CheckRecordTest_4() {
            var solution = new _0552_StudentAttendanceRecordII();
            var result = solution.CheckRecord(4);
            Assert.AreEqual(43, result);
        }

        [Test]
        public void CheckRecordTest_5() {
            var solution = new _0552_StudentAttendanceRecordII();
            var result = solution.CheckRecord(5);
            Assert.AreEqual(94, result);
        }

        [Test]
        public void CheckRecordTest_6() {
            var solution = new _0552_StudentAttendanceRecordII();
            var result = solution.CheckRecord(6);
            Assert.AreEqual(200, result);
        }
    }
}
