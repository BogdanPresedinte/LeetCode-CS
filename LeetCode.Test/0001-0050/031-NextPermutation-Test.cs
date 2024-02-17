namespace LeetCode.Test
{
    public class _031_NextPermutation_Test
    {
        [Test]
        public void NextPermutationTest() {
            var input = new int[] { 1, 2, 3, 4 };
            var solution = new _031_NextPermutation();

            solution.NextPermutation(input);
            AssertHelper.AssertArray(new int[] { 1, 2, 4, 3 }, input);

            solution.NextPermutation(input);
            AssertHelper.AssertArray(new int[] { 1, 3, 2, 4 }, input);

            solution.NextPermutation(input);
            AssertHelper.AssertArray(new int[] { 1, 3, 4, 2 }, input);

            solution.NextPermutation(input);
            AssertHelper.AssertArray(new int[] { 1, 4, 2, 3 }, input);

            solution.NextPermutation(input);
            AssertHelper.AssertArray(new int[] { 1, 4, 3, 2 }, input);

            solution.NextPermutation(input);
            AssertHelper.AssertArray(new int[] { 2, 1, 3, 4 }, input);
        }

        [Test]
        public void NextPermutationTest_NoArrangement() {
            var input = new int[] { 4, 3, 2, 1 };
            var solution = new _031_NextPermutation();

            solution.NextPermutation(input);
            AssertHelper.AssertArray(new int[] { 1, 2, 3, 4 }, input);
        }

        [Test]
        public void NextPermutationTest_EmptyInput() {
            var input = new int[] { };
            var solution = new _031_NextPermutation();

            solution.NextPermutation(input);
            AssertHelper.AssertArray(new int[] { }, input);
        }

        [Test]
        public void NextPermutationTest_OnlyOneItem() {
            var input = new int[] { 1 };
            var solution = new _031_NextPermutation();

            solution.NextPermutation(input);
            AssertHelper.AssertArray(new int[] { 1 }, input);
        }
    }
}
