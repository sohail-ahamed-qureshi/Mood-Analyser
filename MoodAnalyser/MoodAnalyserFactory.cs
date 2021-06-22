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
        /// 
        private string className;
        public MoodAnalyserFactory(string className)
        {
            this.className = className;
        }
        public MoodAnalyserFactory()
        {
            
        }
        public object CreateObjectAtRuntime()
        {
            try
            {
                //variable
                object moodAnalyserObject;
                Assembly assembly = Assembly.GetExecutingAssembly();
                Type moodAnalyserType = assembly.GetType(this.className);
                //if class name is invalid will throw an exception.
                if (moodAnalyserType == null)
                    throw new MoodAnalysisException(className);
                else
                {
                    Console.WriteLine($"Name of the class at Runtime: {moodAnalyserType.Name}");
                    //creating an object with parameterized Constructor.
                    moodAnalyserObject = Activator.CreateInstance(moodAnalyserType, "this is a message");
                }
                return moodAnalyserObject;
            }
            catch (MoodAnalysisException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Done Reflections");
            }
            return null;
        }

        public object CreateObjectAtRuntime(string className)
        {
            try
            {
                //variable
                object moodAnalyserObject;
                Assembly assembly = Assembly.GetExecutingAssembly();
                Type moodAnalyserType = assembly.GetType(this.className);
                //if class name is invalid will throw an exception.
                if (moodAnalyserType == null)
                    throw new MoodAnalysisException(className);
                else
                {
                    Console.WriteLine($"Name of the class at Runtime: {moodAnalyserType.Name}");
                    //creating an object with parameterized Constructor.
                    moodAnalyserObject = Activator.CreateInstance(moodAnalyserType, "MoodAnalyser.MoodAnalyserr");
                }
                return moodAnalyserObject;
            }
            catch (MoodAnalysisException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Done Reflections");
            }
            return null;
        }
    }
}
