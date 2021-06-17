using System;


namespace MoodAnalyser
{
    class MoodAnalysisException : Exception
    {
        public enum Errors { EMPTY }
        /// <summary>
        /// custom exception for mood analysis. display an empty message.
        /// </summary>
        public MoodAnalysisException() 
        {
            Console.WriteLine(Errors.EMPTY);
        }
    }
}
