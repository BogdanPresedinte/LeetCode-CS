namespace LeetCode.Test
{
    public class _1033_MovingStonesUntilConsecutive_Test
    {
        [Test]
        public void NumMovesStones_1() {
            var solution = new _1033_MovingStonesUntilConsecutive();
            var result = solution.NumMovesStones(1, 3, 5);
            AssertHelper.AssertArray(new int[] { 1, 2 }, result);
        }

        [Test]
        public void NumMovesStones_2() {
            var solution = new _1033_MovingStonesUntilConsecutive();
            var result = solution.NumMovesStones(4, 3, 2);
            AssertHelper.AssertArray(new int[] { 0, 0 }, result);
        }

        [Test]
        public void NumMovesStones_3() {
            var solution = new _1033_MovingStonesUntilConsecutive();
            var result = solution.NumMovesStones(3, 5, 1);
            AssertHelper.AssertArray(new int[] { 1, 2 }, result);
        }

        [Test]
        public void NumMovesStones_4() {
            var solution = new _1033_MovingStonesUntilConsecutive();
            var result = solution.NumMovesStones(1, 2, 5);
            AssertHelper.AssertArray(new int[] { 1, 2 }, result);
        }
    }
}
