namespace LeetCode.Test
{
    public class _1175_PrimeArrangements_Test
    {
        [Test]
        public void NumPrimeArrangements_1() {
            var solution = new _1175_PrimeArrangements();
            var result = solution.NumPrimeArrangements(5);
            Assert.AreEqual(12, result);
        }

        [Test]
        public void NumPrimeArrangements_2() {
            var solution = new _1175_PrimeArrangements();
            var result = solution.NumPrimeArrangements(100);
            Assert.AreEqual(682289015, result);
        }
    }
}
