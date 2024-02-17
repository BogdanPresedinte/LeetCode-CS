namespace LeetCode.Test
{
    public class _1346_CheckIfNAndItsDoubleExist_Test
    {
        [Test]
        public void CheckIfExist_1() {
            var solution = new _1346_CheckIfNAndItsDoubleExist();
            var result = solution.CheckIfExist(new int[] { 10, 2, 5, 3 });
            Assert.IsTrue(result);
        }

        [Test]
        public void CheckIfExist_2() {
            var solution = new _1346_CheckIfNAndItsDoubleExist();
            var result = solution.CheckIfExist(new int[] { 7, 1, 14, 11 });
            Assert.IsTrue(result);
        }

        [Test]
        public void CheckIfExist_3() {
            var solution = new _1346_CheckIfNAndItsDoubleExist();
            var result = solution.CheckIfExist(new int[] { 3, 1, 7, 11 });
            Assert.IsFalse(result);
        }
    }
}
