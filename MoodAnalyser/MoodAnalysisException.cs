using System;


namespace MoodAnalyser
{
    public class MoodAnalysisException : Exception
    {
        public enum Errors
        {
            EMPTY,
            CLASS_ERROR,
            METHOD_ERROR
        }
        public Errors errors;
        /// <summary>
        /// custom exception for mood analysis. display an empty message.
        /// </summary>
        public MoodAnalysisException(Errors errors)
        {
            if (errors == Errors.EMPTY)
            {
                Console.WriteLine(errors + ": Mood cannot be empty.");
            }
             if (errors == Errors.CLASS_ERROR)
            {
                Console.WriteLine(errors + ": No Such Class Error.");
            }
            if(errors == Errors.METHOD_ERROR)
            {
                Console.WriteLine(errors + " : No such method error");
            }
        }
    }
}