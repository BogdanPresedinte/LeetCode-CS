namespace LeetCode.Test
{
    public class _040_CombinationSum2_Test
    {
        [Test]
        public void CombinationSum2Test_WhenCandidiatesOrdered() {
            var solution = new _040_CombinationSum2();
            var result = solution.CombinationSum2(new int[] { 1, 1, 2, 5, 6, 7, 10 }, 8);

            AssertHelper.AssertList(new List<IList<int>>()
            {
                new List<int>() { 1, 1, 6 },
                new List<int>() { 1, 2, 5 },
                new List<int>() { 1, 7 },
                new List<int>() { 2, 6 }
            }, result);
        }

        [Test]
        public void CombinationSum2Test_WhenCandidiatesWithoutOrdered() {
            var solution = new _040_CombinationSum2();
            var result = solution.CombinationSum2(new int[] { 10, 1, 2, 7, 6, 1, 5 }, 8);

            AssertHelper.AssertList(new List<IList<int>>()
            {
                new List<int>() { 1, 1, 6 },
                new List<int>() { 1, 2, 5 },
                new List<int>() { 1, 7 },
                new List<int>() { 2, 6 }
            }, result);
        }

        [Test]
        public void CombinationSum2Test_NoMatch() {
            var solution = new _040_CombinationSum2();
            var result = solution.CombinationSum2(new int[] { 2, 3, 6, 7 }, 1);

            AssertHelper.AssertList(new List<IList<int>>() { }, result);
        }
    }
}
