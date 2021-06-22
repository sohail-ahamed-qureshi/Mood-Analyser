using System;
using System.Reflection;

namespace MoodAnalyser
{
    class Program
    {
        /// <summary>
        /// Mood Analyser Program using Reflections.
        /// Creating an Object of Mood Analyser class at run time with reflections.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            //MoodAnalyserr mood = new MoodAnalyserr("");
            //mood.MoodCheck();
            //Console.WriteLine("Mood Analyser program using Reflections");
            ////creating an instance of an Class at Compile time.
            //MoodAnalyserr moodAnalyserr = new MoodAnalyserr("");
            //Console.WriteLine(" Method called at Compile time : " + moodAnalyserr.MoodCheck("Iam in Sad Mood"));
            //Static method to create an instance of class at Compile Time.
            MoodAnalyserFactory moodAnalyserFactory = new MoodAnalyserFactory("MoodAnalyser.MoodAnalyser");
            object objName = moodAnalyserFactory.CreateObjectAtRuntime();
            Console.WriteLine(objName);
        }
    }
}
