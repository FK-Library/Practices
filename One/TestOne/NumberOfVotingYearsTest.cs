using Newtonsoft.Json.Linq;
using One;

namespace TestOne
{
    [TestClass]
    public class NumberOfVotingYearsTest
    {
        [TestMethod]
        [DataRow(18, 0)]
        [DataRow(19, 0)]
        [DataRow(20, 0)]
        [DataRow(21, 0)]
        [DataRow(22, 1)]
        [DataRow(23, 1)]
        public void Calculate_GivenAge_ReturnsElectionEligibilityYears(int age, int expected)
        {
            //Arrange
            var electionEligibilityYears = new ElectionEligibilityYears();

            //Act
            var result = electionEligibilityYears.Calculate(age);

            //Assert
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        [DataRow(17, "Invalid Age")]
        [DataRow(-1, "Invalid Age")]
        [DataRow(0, "Invalid Age")]
        public void Calculate_GivenInvalidAge_ThrowsError(int age, string expected)
        {
            //Arrange
            var electionEligibilityYears = new ElectionEligibilityYears();

            //Act
            //Assert
            Assert.ThrowsException<Exception>(() => electionEligibilityYears.Calculate(age), expected);

        }
    }
}