namespace LeetCode.Test
{
    public class _0449_SerializeAndDeserializeBST_Test
    {
        [Test]
        public void SerializeAndDeserialize_1() {
            var root = TestHelper.GenerateTree(new int?[] { 2, 1, 3 });

            var solution = new _0449_SerializeAndDeserializeBST();
            var result = solution.serialize(root);
            AssertHelper.AssertTree(new int?[] { 2, 1, 3 }, solution.deserialize(result));
        }

        [Test]
        public void SerializeAndDeserialize_2() {
            var root = TestHelper.GenerateTree(new int?[] { 2, 1, 3 });

            var solution = new _0449_SerializeAndDeserializeBST();
            var result = solution.serialize(null);
            Assert.IsNull(solution.deserialize(result));
        }
    }
}
