namespace LeetCode.Test
{
    public class _063_UniquePaths2_Test
    {
        [Test]
        public void UniquePathsWithObstaclesTest() {
            var input = new int[3, 3]
            {
                { 0, 0, 0 },
                { 0, 1, 0 },
                { 0, 0, 0 }
            };

            var solution = new _063_UniquePaths2();
            var result = solution.UniquePathsWithObstacles(input);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void UniquePathsWithObstaclesTest_ObstacleOnFirstRow() {
            var input = new int[3, 3]
            {
                { 0, 1, 0 },
                { 0, 0, 0 },
                { 0, 0, 0 }
            };

            var solution = new _063_UniquePaths2();
            var result = solution.UniquePathsWithObstacles(input);

            Assert.AreEqual(3, result);
        }

        [Test]
        public void UniquePathsWithObstaclesTest_ObstacleOnFirstColumn() {
            var input = new int[3, 3]
            {
                { 0, 0, 0 },
                { 1, 0, 0 },
                { 0, 0, 0 }
            };

            var solution = new _063_UniquePaths2();
            var result = solution.UniquePathsWithObstacles(input);

            Assert.AreEqual(3, result);
        }

        [Test]
        public void UniquePathsWithObstaclesTest_ObstacleAtStart() {
            var input = new int[3, 3]
            {
                { 1, 0, 0 },
                { 0, 0, 0 },
                { 0, 0, 0 }
            };

            var solution = new _063_UniquePaths2();
            var result = solution.UniquePathsWithObstacles(input);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void UniquePathsWithObstaclesTest_ObstacleAtEnd() {
            var input = new int[3, 3]
            {
                { 0, 0, 0 },
                { 0, 0, 0 },
                { 0, 0, 1 }
            };

            var solution = new _063_UniquePaths2();
            var result = solution.UniquePathsWithObstacles(input);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void UniquePathsWithObstaclesTest_OneItem() {
            var input = new int[1, 1]
            {
                { 0 }
            };

            var solution = new _063_UniquePaths2();
            var result = solution.UniquePathsWithObstacles(input);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void UniquePathsWithObstaclesTest_OneItem_Obstacles() {
            var input = new int[1, 1]
            {
                { 1 }
            };

            var solution = new _063_UniquePaths2();
            var result = solution.UniquePathsWithObstacles(input);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void UniquePathsWithObstaclesTest_RowLarger() {
            var input = new int[4, 3]
            {
                { 0, 0, 0 },
                { 0, 1, 0 },
                { 0, 0, 0 },
                { 0, 0, 0 },
            };

            var solution = new _063_UniquePaths2();
            var result = solution.UniquePathsWithObstacles(input);

            Assert.AreEqual(4, result);
        }

        [Test]
        public void UniquePathsWithObstaclesTest_ColumnLarger() {
            var input = new int[3, 4]
            {
                { 0, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 0, 0 }
            };

            var solution = new _063_UniquePaths2();
            var result = solution.UniquePathsWithObstacles(input);

            Assert.AreEqual(4, result);
        }
    }
}
