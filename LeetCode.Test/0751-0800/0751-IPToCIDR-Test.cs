namespace LeetCode.Test
{
    public class _0751_IPToCIDR_Test
    {
        [Test]
        public void IpToCIDR_1() {
            var solution = new _0751_IPToCIDR();
            var result = solution.IpToCIDR("255.0.0.7", 10);
            AssertHelper.AssertList(new string[] { "255.0.0.7/32", "255.0.0.8/29", "255.0.0.16/32" }, result);
        }
    }
}
