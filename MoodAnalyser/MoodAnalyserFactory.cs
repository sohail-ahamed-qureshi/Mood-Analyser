using System;
using System.Reflection;

namespace MoodAnalyser
{
    /// <summary>
    /// Creating object at runtime using Reflections with default constructor.
    /// </summary>
    public class MoodAnalyserFactory
    {
        /// <summary>
        /// Achieve Late binding.
        /// Assembly = create an executing assembly at the runtime
        /// Type = getting type of class at the runtime with refrence of assembly
        /// Activator - activating the create instance method and creating an instance of class MoodAnalyserr
        /// GetMethod- accessing the method MoodCheck at runtime.
        /// Invoke - invoking the method that takes an object and parameters as its parameters and
        ///          returns the object type value which can be converted to required type implicitly at runtime
        /// </summary>
        public static object CreateObjectAtRuntime()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type moodAnalyserType = assembly.GetType("MoodAnalyser.MoodAnalyserr");
            Console.WriteLine($"Name of the class at Runtime: {moodAnalyserType.Name}");
            object moodAnalyserObject = Activator.CreateInstance(moodAnalyserType);
            return moodAnalyserObject;
        }
    }
}
