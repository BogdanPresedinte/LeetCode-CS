namespace LeetCode.Test
{
    public class _0599_MinimumIndexSumOfTwoLists_Test
    {
        [Test]
        public void FindRestaurant_1() {
            var solution = new _0599_MinimumIndexSumOfTwoLists();
            var result = solution.FindRestaurant(new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" }, new string[] { "Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun" });
            AssertHelper.AssertArray(new string[] { "Shogun" }, result);
        }

        [Test]
        public void FindRestaurant_2() {
            var solution = new _0599_MinimumIndexSumOfTwoLists();
            var result = solution.FindRestaurant(new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" }, new string[] { "KFC", "Shogun", "Burger King" });
            AssertHelper.AssertArray(new string[] { "Shogun" }, result);
        }
    }
}
