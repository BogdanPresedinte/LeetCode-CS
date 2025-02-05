namespace LeetCode.Test
{
    public class _1436_DestinationCity_Test
    {
        [Test]
        public void DestCity_1() {
            var solution = new _1436_DestinationCity();
            var result = solution.DestCity(new string[][] {
                new string[] { "London", "New York" },
                new string[] { "New York", "Lima" },
                new string[] { "Lima", "Sao Paulo" },
            });
            Assert.AreEqual("Sao Paulo", result);
        }

        [Test]
        public void DestCity_2() {
            var solution = new _1436_DestinationCity();
            var result = solution.DestCity(new string[][] {
                new string[] { "B","C" },
                new string[] { "D", "B" },
                new string[] { "C", "A" }
            });
            Assert.AreEqual("A", result);
        }
    }
}
