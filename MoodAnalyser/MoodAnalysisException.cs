using System;


namespace MoodAnalyser
{
    class MoodAnalysisException : Exception
    {
        private readonly string message = "Invalid mood entered/ Mood cannot be NULL";
        /// <summary>
        /// custom exception for mood analysis.
        /// </summary>
        public MoodAnalysisException() 
        {
            Console.WriteLine(message);
        }
    }
}
