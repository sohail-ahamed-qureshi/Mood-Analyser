using NUnit.Framework;
using MoodAnalyser;

namespace NUnitMoodAnalyser.Test
{
  
    public class Tests
    {
        /// <summary>
        /// check for sad mood, returns "SAD" message.
        /// </summary>
        [Test]
        public void WhenGivenSadMood_ReturnsSadMessge()
        {
            //Arrange
            string message = "Iam in Sad Mood";
            string expected = "SAD";
            //Act
            MoodAnalyserr mood = new MoodAnalyserr(message);
            string result = mood.MoodCheck();
            //Assert
            Assert.AreEqual(expected, result);
        }
        /// <summary>
        /// Check for Happy mood, return "HAPPY" message.
        /// </summary>
        [Test]
        public void WhenGivenHappyMood_ReturnsHappyMessage()
        {
            //Arrange
            string message = "Iam in Any Mood";
            string expected = "HAPPY";
            //Act
            MoodAnalyserr mood = new MoodAnalyserr(message);
            string result = mood.MoodCheck();
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}