namespace LeetCode.Test
{
    public class _1351_CountNegativeNumbersInASortedMatrix_Test
    {
        [Test]
        public void CountNegatives_1() {
            var solution = new _1351_CountNegativeNumbersInASortedMatrix();
            var result = solution.CountNegatives(new int[][] {
                new int[] { 4, 3, 2, -1 },
                new int[] { 3, 2, 1, -1 },
                new int[] { 1, 1, -1, -2 },
                new int[] { -1, -1, -2, -3 },
            });
            Assert.AreEqual(8, result);
        }

        [Test]
        public void CountNegatives_2() {
            var solution = new _1351_CountNegativeNumbersInASortedMatrix();
            var result = solution.CountNegatives(new int[][] {
                new int[] { 3, 2 },
                new int[] { 1, 0 },
            });
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CountNegatives_3() {
            var solution = new _1351_CountNegativeNumbersInASortedMatrix();
            var result = solution.CountNegatives(new int[][] {
                new int[] { 1, -1 },
                new int[] { -1, -1 },
            });
            Assert.AreEqual(3, result);
        }

        [Test]
        public void CountNegatives_4() {
            var solution = new _1351_CountNegativeNumbersInASortedMatrix();
            var result = solution.CountNegatives(new int[][] {
                new int[] { -1 },
            });
            Assert.AreEqual(1, result);
        }
    }
}
