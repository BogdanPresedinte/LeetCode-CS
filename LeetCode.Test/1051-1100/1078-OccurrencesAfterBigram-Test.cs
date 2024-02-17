namespace LeetCode.Test
{
    public class _1078_OccurrencesAfterBigram_Test
    {
        [Test]
        public void FindOcurrences_1() {
            var solution = new _1078_OccurrencesAfterBigram();
            var result = solution.FindOcurrences("alice is a good girl she is a good student", "a", "good");
            AssertHelper.AssertArray(new string[] { "girl", "student" }, result);
        }

        [Test]
        public void FindOcurrences_2() {
            var solution = new _1078_OccurrencesAfterBigram();
            var result = solution.FindOcurrences("we will we will rock you", "we", "will");
            AssertHelper.AssertArray(new string[] { "we", "rock" }, result);
        }
    }
}
