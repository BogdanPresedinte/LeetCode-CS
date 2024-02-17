namespace LeetCode.Test
{
    public class _0818_RaceCar_Test
    {
        [Test]
        public void RacecarTest_1() {
            var solution = new _0818_RaceCar();
            var result = solution.Racecar(1);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void RacecarTest_2() {
            var solution = new _0818_RaceCar();
            var result = solution.Racecar(2);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void RacecarTest_3() {
            var solution = new _0818_RaceCar();
            var result = solution.Racecar(3);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void RacecarTest_4() {
            var solution = new _0818_RaceCar();
            var result = solution.Racecar(4);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void RacecarTest_5() {
            var solution = new _0818_RaceCar();
            Assert.AreEqual(7, solution.Racecar(5));
        }

        [Test]
        public void RacecarTest_6() {
            var solution = new _0818_RaceCar();
            Assert.AreEqual(5, solution.Racecar(6));
        }

        [Test]
        public void RacecarTest_7() {
            var solution = new _0818_RaceCar();
            Assert.AreEqual(3, solution.Racecar(7));
        }

        [Test]
        public void RacecarTest_8() {
            var solution = new _0818_RaceCar();
            Assert.AreEqual(6, solution.Racecar(8));
        }

        [Test]
        public void RacecarTest_15() {
            var solution = new _0818_RaceCar();
            Assert.AreEqual(4, solution.Racecar(15));
        }

        [Test]
        public void RacecarTest_30() {
            var solution = new _0818_RaceCar();
            Assert.AreEqual(7, solution.Racecar(30));
        }
    }
}
