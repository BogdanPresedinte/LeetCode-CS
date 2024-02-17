using static LeetCode._1428_LeftmostColumnWithAtLeastAOne;

namespace LeetCode.Test
{
    public class _1428_LeftmostColumnWithAtLeastAOne_Test
    {
        [Test]
        public void LeftMostColumnWithOne_1() {
            var solution = new _1428_LeftmostColumnWithAtLeastAOne();
            var result = solution.LeftMostColumnWithOne(new BinaryMatrix(new int[][] {
                new int[] { 0, 0 },
                new int[] { 1, 1 },
            }));
            Assert.AreEqual(0, result);
        }

        [Test]
        public void LeftMostColumnWithOne_2() {
            var solution = new _1428_LeftmostColumnWithAtLeastAOne();
            var result = solution.LeftMostColumnWithOne(new BinaryMatrix(new int[][] {
                new int[] { 0, 0 },
                new int[] { 0, 1 },
            }));
            Assert.AreEqual(1, result);
        }

        [Test]
        public void LeftMostColumnWithOne_3() {
            var solution = new _1428_LeftmostColumnWithAtLeastAOne();
            var result = solution.LeftMostColumnWithOne(new BinaryMatrix(new int[][] {
                new int[] { 0, 0 },
                new int[] { 0, 0 },
            }));
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void LeftMostColumnWithOne_4() {
            var solution = new _1428_LeftmostColumnWithAtLeastAOne();
            var result = solution.LeftMostColumnWithOne(new BinaryMatrix(new int[][] {
                new int[] { 0, 0, 0, 1 },
                new int[] { 0, 0, 1, 1 },
                new int[] { 0, 1, 1, 1 },
            }));
            Assert.AreEqual(1, result);
        }
    }
}
