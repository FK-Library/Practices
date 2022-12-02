using One;

namespace TestOne
{
    [TestClass]
    public class NumberOfVotingYearsTest
    {
        [TestMethod]
        [DataRow(20,0)]
        public void CalculateVotes_GivenAge_ReturnsElectionEligibilityYears(int age, int expected)
        {
            //Arrange
            var electionEligibilityYears = new ElectionEligibilityYears();

            //Act
            var result = electionEligibilityYears.Calculate(age);

            //Assert
            Assert.AreEqual(expected, result);

        }
    }
}