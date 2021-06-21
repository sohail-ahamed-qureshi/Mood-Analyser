using MoodAnalyser;
using NUnit.Framework;
using System;
using System.Reflection;

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
            try
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
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        /// <summary>
        /// Check for Happy mood, return "HAPPY" message.
        /// </summary>
        [Test]
        public void WhenGivenHappyMood_ReturnsHappyMessage()
        {
            try
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
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
        /// <summary>
        /// check for invalid mood, returns "HAPPY" message.
        /// </summary>
        [Test]
        public void WhenGivenInvalidMood_ReturnsHappyMessage()
        {
            try
            {
                //Arrange
                string message = "";
                string expected = "HAPPY";
                //Act
                MoodAnalyserr mood = new MoodAnalyserr(message);
                string result = mood.MoodCheck();
                //Assert
                Assert.AreEqual(expected, result);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        /// <summary>
        /// check when given Class name should return object name
        /// </summary>
        [Test]
        public void WhenGivenClassName_ReturnsObject()
        {
            try
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                //
                Type moodAnalyserType = assembly.GetType("MoodAnalyser.MoodAnalyserr");
                //cross checking
                Console.WriteLine($"{moodAnalyserType.Name}");
                //creating object of class
                object tempObject = Activator.CreateInstance(moodAnalyserType);
                //Arrange
                string expected = (string)tempObject;
                //Act
                string result = "MoodAnalyser.MoodAnalyserr";
                //Assert
                Assert.AreEqual(expected, result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done all test cases");
            }

        }
    }
}