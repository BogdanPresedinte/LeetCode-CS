using static LeetCode._1237_FindPositiveIntegerSolutionForAGivenEquation;

namespace LeetCode.Test
{
    public class _1237_FindPositiveIntegerSolutionForAGivenEquation_Test
    {
        [Test]
        public void FindSolution_1() {
            var solution = new _1237_FindPositiveIntegerSolutionForAGivenEquation();
            var result = solution.FindSolution(new CustomFunction((x, y) => x + y), 5);
            AssertHelper.AssertList(new List<IList<int>> {
                new int[] { 1, 4 },
                new int[] { 2, 3 },
                new int[] { 3, 2 },
                new int[] { 4, 1 },
            }, result);
        }

        [Test]
        public void FindSolution_2() {
            var solution = new _1237_FindPositiveIntegerSolutionForAGivenEquation();
            var result = solution.FindSolution(new CustomFunction((x, y) => x * y), 5);
            AssertHelper.AssertList(new List<IList<int>> {
                new int[] { 1, 5 },
                new int[] { 5, 1 },
            }, result);
        }
    }
}
