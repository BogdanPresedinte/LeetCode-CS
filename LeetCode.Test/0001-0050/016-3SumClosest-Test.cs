namespace LeetCode.Test
{
    public class _016_3SumClosest_Test
    {
        [Test]
        public void ThreeSumClosestTest_NotMatch() {
            int[] input = { -1, 2, 1, -4 };

            var solution = new _016_3SumClosest();

            var result = solution.ThreeSumClosest(input, 1);
            Assert.AreEqual(2, result);

            result = solution.ThreeSumClosest(input, -2);
            Assert.AreEqual(-3, result);
        }

        [Test]
        public void ThreeSumClosestTest_NotMatch_Duplicate() {
            var solution = new _016_3SumClosest();

            int[] input1 = { 0, 0, 0 };
            var result = solution.ThreeSumClosest(input1, 1);
            Assert.AreEqual(0, result);

            int[] input2 = { 1, 1, 1, 1 };
            result = solution.ThreeSumClosest(input2, 0);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void ThreeSumClosestTest_HaveMatch() {
            int[] input = { -1, 2, 1, -4 };

            var solution = new _016_3SumClosest();
            var result = solution.ThreeSumClosest(input, 2);
            Assert.AreEqual(2, result);

            result = solution.ThreeSumClosest(input, -1);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void ThreeSumClosestTest_HaveMatch_2() {
            int[] input = { 1, 1, -1, -1, 3 };

            var solution = new _016_3SumClosest();
            var result = solution.ThreeSumClosest(input, 1);
            Assert.AreEqual(1, result);

            result = solution.ThreeSumClosest(input, -1);
            Assert.AreEqual(-1, result);
        }
    }
}
