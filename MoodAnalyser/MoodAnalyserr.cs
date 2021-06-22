

using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace MoodAnalyser
{
    public class MoodAnalyserr
    {
        //constants
        private const string SAD_MESSAGE = "Iam in Sad Mood";
        private const string HAPPY_MESSAGE = "Iam in Any Mood";
        //variables
        private readonly string message;
        public MoodAnalyserr()
        {

        }
        public MoodAnalyserr(string message)
        {
            this.message = message;
        }
        /// <summary>
        /// Check for mood if sad return sad message and
        /// if happy return happy message.
        /// if mood is null throw an exception invalid mood.
        /// </summary>
        /// <param name="message">string passed by user</param>
        /// <returns></returns>
        public string MoodCheck()
        {
            try
            {
                if (message == null || message == string.Empty)
                    throw new MoodAnalysisException(message);
                if (message == SAD_MESSAGE)
                    return "SAD";
                if (message == HAPPY_MESSAGE)
                    return "HAPPY";
            }
            catch(MoodAnalysisException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Done");
            }
            return null;
        }
    }
}
