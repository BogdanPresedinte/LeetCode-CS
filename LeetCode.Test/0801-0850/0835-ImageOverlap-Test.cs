namespace LeetCode.Test
{
    public class _0835_ImageOverlap_Test
    {
        [Test]
        public void LargestOverlap_1() {
            var solution = new _0835_ImageOverlap();
            var result = solution.LargestOverlap(new int[][] {
                new int[] { 1, 1, 0 },
                new int[] { 0, 1, 0 },
                new int[] { 0, 1, 0 },
            }, new int[][] {
                new int[] { 0, 0, 0 },
                new int[] { 0, 1, 1 },
                new int[] { 0, 0, 1 },
            });
            Assert.AreEqual(3, result);
        }

        [Test]
        public void LargestOverlap_2() {
            var solution = new _0835_ImageOverlap();
            var result = solution.LargestOverlap(new int[][] {
                new int[] { 1 },
            }, new int[][] {
                new int[] { 1 },
            });
            Assert.AreEqual(1, result);
        }

        [Test]
        public void LargestOverlap_3() {
            var solution = new _0835_ImageOverlap();
            var result = solution.LargestOverlap(new int[][] {
                new int[] { 0 },
            }, new int[][] {
                new int[] { 0 },
            });
            Assert.AreEqual(0, result);
        }

        [Test]
        public void LargestOverlap_4() {
            var solution = new _0835_ImageOverlap();
            var result = solution.LargestOverlap(new int[][] {
                new int[] { 0, 0, 0, 0, 1 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
            }, new int[][] {
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 1, 0, 0, 0, 0 },
            });
            Assert.AreEqual(1, result);
        }
    }
}
