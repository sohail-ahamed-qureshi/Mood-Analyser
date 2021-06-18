using NUnit.Framework;
using MoodAnalyser;

namespace NUnitMoodAnalyser.Test
{
    public class Tests
    {
        /// <summary>
        /// check when given Class name should return object name
        /// </summary>
        [Test]
        public void WhenGivenClassName_ReturnsObject()
        {
            //Arrange
            string expected = "MoodAnalyser.MoodAnalyserr";
            //Act
            object result =MoodAnalyserFactory.CreateObjectAtRuntime();
            //Assert
            Assert.AreEqual(expected, result.ToString());
        }
    }
}