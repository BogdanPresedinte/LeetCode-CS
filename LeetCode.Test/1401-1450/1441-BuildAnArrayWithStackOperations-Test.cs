namespace LeetCode.Test
{
    public class _1441_BuildAnArrayWithStackOperations_Test
    {
        [Test]
        public void BuildArray_1() {
            var solution = new _1441_BuildAnArrayWithStackOperations();
            var result = solution.BuildArray(new int[] { 1, 3 }, 3);
            AssertHelper.AssertList(new string[] { "Push", "Push", "Pop", "Push" }, result);
        }

        [Test]
        public void BuildArray_2() {
            var solution = new _1441_BuildAnArrayWithStackOperations();
            var result = solution.BuildArray(new int[] { 1, 2, 3 }, 3);
            AssertHelper.AssertList(new string[] { "Push", "Push", "Push" }, result);
        }

        [Test]
        public void BuildArray_3() {
            var solution = new _1441_BuildAnArrayWithStackOperations();
            var result = solution.BuildArray(new int[] { 1, 2 }, 4);
            AssertHelper.AssertList(new string[] { "Push", "Push" }, result);
        }

        [Test]
        public void BuildArray_4() {
            var solution = new _1441_BuildAnArrayWithStackOperations();
            var result = solution.BuildArray(new int[] { 2, 3, 4 }, 4);
            AssertHelper.AssertList(new string[] { "Push", "Pop", "Push", "Push", "Push" }, result);
        }

        [Test]
        public void BuildArray_5() {
            var solution = new _1441_BuildAnArrayWithStackOperations();
            var result = solution.BuildArray(new int[] { 2, 3, 4, 5, 8, 9, 10 }, 10);
            AssertHelper.AssertList(new string[] { "Push", "Pop", "Push", "Push", "Push", "Push", "Push", "Pop", "Push", "Pop", "Push", "Push", "Push" }, result);
        }
    }
}
