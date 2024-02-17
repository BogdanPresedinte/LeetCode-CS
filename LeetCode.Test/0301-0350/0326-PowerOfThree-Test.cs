namespace LeetCode.Test
{
    public class _0326_PowerOfThree_Test
    {
        [Test]
        public void IsPowerOfThree_1() {
            var solution = new _0326_PowerOfThree();
            var result = solution.IsPowerOfThree(27);
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPowerOfThree_2() {
            var solution = new _0326_PowerOfThree();
            var result = solution.IsPowerOfThree(0);
            Assert.IsFalse(result);
        }

        [Test]
        public void IsPowerOfThree_3() {
            var solution = new _0326_PowerOfThree();
            var result = solution.IsPowerOfThree(9);
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPowerOfThree_4() {
            var solution = new _0326_PowerOfThree();
            var result = solution.IsPowerOfThree(45);
            Assert.IsFalse(result);
        }
    }
}
