using ClassLibrary;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void Test_NameValidation_NameIsValid()
        {
            FootballPlayer player = new FootballPlayer(1, "Adam", 20, 9);

            player.NameValidation("Erik");

            Assert.AreEqual("Erik", player.Name);
        }

        [TestMethod]
        public void Test_NameValidation_NameIsNull()
        {
            FootballPlayer player = new FootballPlayer(1, "Adam", 20, 9);


            Assert.ThrowsException<ArgumentNullException>(() => player.NameValidation(null));

        }

        [TestMethod]
        public void Test_NameValidation_NameOneCharacter()
        {

            FootballPlayer player = new FootballPlayer(1, "Adam", 20, 9);


            Assert.ThrowsException<ArgumentOutOfRangeException>(() => player.NameValidation("a"));

        }

        [TestMethod]
        public void Test_AgeValidation_ValidAge()
        {
            FootballPlayer player = new FootballPlayer(1, "Adam", 20, 9);

            player.AgeValidation(25);

            Assert.AreEqual(25, player.Age);

        }

        [TestMethod]
        public void Test_AgeValidation_NegativeAge()
        {
            FootballPlayer player = new FootballPlayer(1, "Adam", 20, 9);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => player.AgeValidation(-2));

        }

        [TestMethod]
        public void Test_ShirtNumberValidation_ValidShirtNumber()
        {
            FootballPlayer player = new FootballPlayer(1, "Adam", 20, 9);

            player.ShirtNumberValidation(55);

            Assert.AreEqual(55, player.ShirtNumber);

        }

        [TestMethod]
        public void Test_ShirtNumberValidation_OutOfRangeNumber()
        {

            FootballPlayer player = new FootballPlayer(1, "Adam", 20, 9);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => player.ShirtNumberValidation(200));

        }
    }
}