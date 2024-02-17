namespace LeetCode.Test
{
    public class _0925_LongPressedName_Test
    {
        [Test]
        public void IsLongPressedName_1() {
            var solution = new _0925_LongPressedName();
            var result = solution.IsLongPressedName("alex", "aaleex");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsLongPressedName_2() {
            var solution = new _0925_LongPressedName();
            var result = solution.IsLongPressedName("saeed", "ssaaedd");
            Assert.IsFalse(result);
        }

        [Test]
        public void IsLongPressedName_3() {
            var solution = new _0925_LongPressedName();
            var result = solution.IsLongPressedName("leelee", "lleeelee");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsLongPressedName_4() {
            var solution = new _0925_LongPressedName();
            var result = solution.IsLongPressedName("laiden", "laiden");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsLongPressedName_5() {
            var solution = new _0925_LongPressedName();
            var result = solution.IsLongPressedName("alex", "aaleexr");
            Assert.IsFalse(result);
        }

        [Test]
        public void IsLongPressedName_6() {
            var solution = new _0925_LongPressedName();
            var result = solution.IsLongPressedName("vtkgn", "vttkgnn");
            Assert.IsTrue(result);
        }
    }
}
