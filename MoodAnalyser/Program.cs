using System;

namespace MoodAnalyser
{
    class Program
    {
        /// <summary>
        /// Mood Analyser Program using Exceptions.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Mood Analyser program using Exceptions");

            MoodAnalyserr moodAnalyserr = new MoodAnalyserr();
            Console.WriteLine(moodAnalyserr.MoodCheck("Iam in Sad Mood"));
        }
    }
}
