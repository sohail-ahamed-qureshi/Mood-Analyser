

namespace MoodAnalyser
{
    public class MoodAnalyserr
    {
        //constants
        private const string SAD_MESSAGE = "Iam in Sad Mood";
        private const string HAPPY_MESSAGE = "Iam in Any Mood";
        /// <summary>
        /// Check for mood if sad return sad message and
        /// if happy return happy message.
        /// </summary>
        /// <param name="message">string passed by user</param>
        /// <returns></returns>
        public string MoodCheck(string message)
        {
            if (message == SAD_MESSAGE)
                return "SAD";
            if (message == HAPPY_MESSAGE)
                return "HAPPY";
            return null;
        }
    }
}
