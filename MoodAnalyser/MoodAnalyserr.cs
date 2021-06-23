

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
            message = SAD_MESSAGE;
            //checking for null
            if (message != null)
                message = message.ToLower();

        }
        public MoodAnalyserr(string message)
        {
            if (this.message != null)
                this.message = message.ToLower();
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
                    throw new MoodAnalysisException(MoodAnalysisException.Errors.EMPTY);
                if (message.Contains("sad"))
                    return "SAD";
                if (message.Contains("happy"))
                    return "HAPPY";
            }
            catch (MoodAnalysisException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done");
            }
            return null;
        }
    }
}
