using ClassLibrary;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void Test_NameValidation_NameIsValid()
        {
            FootballPlayer player = new FootballPlayer() { Id = 1, Name = "Adam", Age = 20, ShirtNumber = 9};

            player.NameValidation();
        }

        [TestMethod]
        public void Test_NameValidation_NameIsNull()
        {
            FootballPlayer player = new FootballPlayer() { Id = 1, Name = null, Age = 20, ShirtNumber = 9 };

            Assert.ThrowsException<ArgumentNullException>(() => player.NameValidation());

        }

        [TestMethod]
        public void Test_NameValidation_NameOneCharacter()
        {

            FootballPlayer player = new FootballPlayer() { Id = 1, Name = "a", Age = 20, ShirtNumber = 9 };

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => player.NameValidation());

        }

        [TestMethod]
        public void Test_AgeValidation_ValidAge()
        {
            FootballPlayer player = new FootballPlayer() { Id = 1, Name = "Adam", Age = 25, ShirtNumber = 9 };

            player.AgeValidation();

        }

        [TestMethod]
        public void Test_AgeValidation_NegativeAge()
        {
            FootballPlayer player = new FootballPlayer() { Id = 1, Name = "Adam", Age = -25, ShirtNumber = 9 };

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => player.AgeValidation());

        }

        [TestMethod]
        public void Test_ShirtNumberValidation_ValidShirtNumber()
        {
            FootballPlayer player = new FootballPlayer() { Id = 1, Name = "Adam", Age = 20, ShirtNumber = 9 };

            player.ShirtNumberValidation();

        }

        [TestMethod]
        public void Test_ShirtNumberValidation_OutOfRangeNumber()
        {

            FootballPlayer player = new FootballPlayer() { Id = 1, Name = "Adam", Age = 20, ShirtNumber = 666 };

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => player.ShirtNumberValidation());

        }

        [TestMethod]
        public void Test_ValidateEverything()
        {
            FootballPlayer player = new FootballPlayer() { Id = 1, Name = "Adam", Age = 20, ShirtNumber = 9 };

            player.Validate();
        }
    }
}