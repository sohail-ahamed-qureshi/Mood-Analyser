using NUnit.Framework;
using MoodAnalyser;

namespace NUnitMoodAnalyser.Test
{
    /// <summary>
    /// check for sad mood, returns "SAD" message.
    /// </summary>
    public class Tests
    {
        [Test]
        public void WhenGivenMood_ReturnsString()
        {
            //Arrange
            string message = "Iam in Sad Mood";
            string expected = "SAD";
            //Act
            MoodAnalyserr mood = new MoodAnalyserr();
            string result = mood.MoodCheck(message);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}