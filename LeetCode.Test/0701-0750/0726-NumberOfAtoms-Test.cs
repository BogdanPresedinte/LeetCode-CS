namespace LeetCode.Test
{
    public class _0726_NumberOfAtoms_Test
    {
        [Test]
        public void CountOfAtoms_1() {
            var solution = new _0726_NumberOfAtoms();
            var result = solution.CountOfAtoms("H2O");
            Assert.AreEqual("H2O", result);
        }

        [Test]
        public void CountOfAtoms_2() {
            var solution = new _0726_NumberOfAtoms();
            var result = solution.CountOfAtoms("Mg(OH)2");
            Assert.AreEqual("H2MgO2", result);
        }

        [Test]
        public void CountOfAtoms_3() {
            var solution = new _0726_NumberOfAtoms();
            var result = solution.CountOfAtoms("K4(ON(SO3)2)2");
            Assert.AreEqual("K4N2O14S4", result);
        }
    }
}
