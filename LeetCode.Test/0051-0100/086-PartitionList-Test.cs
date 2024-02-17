namespace LeetCode.Test
{
    public class _086_PartitionList_Test
    {
        [Test]
        public void PartitionTest() {
            var input = TestHelper.GenerateList(new int[] { 1, 4, 3, 2, 5, 2 });

            var solution = new _086_PartitionList();
            var result = solution.Partition(input, 3);

            AssertHelper.AssertLinkList(new int[] { 1, 2, 2, 4, 3, 5 }, result);
        }

        [Test]
        public void PartitionTest_AllLessThan() {
            var input = TestHelper.GenerateList(new int[] { 1, 4, 3, 2, 5, 2 });

            var solution = new _086_PartitionList();
            var result = solution.Partition(input, 6);

            AssertHelper.AssertLinkList(new int[] { 1, 4, 3, 2, 5, 2 }, result);
        }

        [Test]
        public void PartitionTest_AllGreaterThan() {
            var input = TestHelper.GenerateList(new int[] { 1, 4, 3, 2, 5, 2 });

            var solution = new _086_PartitionList();
            var result = solution.Partition(input, 0);

            AssertHelper.AssertLinkList(new int[] { 1, 4, 3, 2, 5, 2 }, result);
        }

        [Test]
        public void PartitionTest_EmptyList() {
            var solution = new _086_PartitionList();
            var result = solution.Partition(null, 3);

            Assert.IsNull(result);
        }

        [Test]
        public void PartitionTest_OneItem_LessThan() {
            var input = TestHelper.GenerateList(new int[] { 1 });

            var solution = new _086_PartitionList();
            var result = solution.Partition(input, 3);

            AssertHelper.AssertLinkList(new int[] { 1 }, result);
        }

        [Test]
        public void PartitionTest_OneItem_GreaterThan() {
            var input = TestHelper.GenerateList(new int[] { 1 });

            var solution = new _086_PartitionList();
            var result = solution.Partition(input, 0);

            AssertHelper.AssertLinkList(new int[] { 1 }, result);
        }
    }
}
