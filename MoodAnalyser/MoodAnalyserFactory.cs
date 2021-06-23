using System;
using System.Reflection;

namespace MoodAnalyser
{
    /// <summary>
    /// Creating object at runtime using Reflections with default constructor.
    /// </summary>
    public class MoodAnalyserFactory
    {
        //variable
        private readonly string className;
        /// <summary>
        /// Achieve Late binding.
        /// Assembly = create an executing assembly at the runtime
        /// Type = getting type of class at the runtime with refrence of assembly
        /// Activator - activating the create instance method and creating an instance of class MoodAnalyserr
        /// GetMethod- accessing the method MoodCheck at runtime.
        /// Invoke - invoking the method that takes an object and parameters as its parameters and
        ///          returns the object type value which can be converted to required type implicitly at runtime
        /// </summary>
        public MoodAnalyserFactory(string className)
        {
            this.className = className;
        }
        //constructor without parameters
        public MoodAnalyserFactory()
        {
            this.className = "MoodAnalyser.MoodAnalyserr";
        }
        //variable
        Type moodAnalyserType;
        object moodAnalyserObject;
        Assembly assembly = Assembly.GetExecutingAssembly();

        /// <summary>
        /// method for creating an object at runtime
        /// </summary>
        /// <returns></returns>
        public object CreateObjectAtRuntime()
        {
            try
            {
                moodAnalyserType = assembly.GetType(this.className);
                //if class name is invalid will throw an exception.
                if (moodAnalyserType == null)
                    throw new MoodAnalysisException(MoodAnalysisException.Errors.CLASS_ERROR);
                else
                {
                    //creata an object with Constructor.
                    moodAnalyserObject = Activator.CreateInstance(moodAnalyserType);
                    //ConstructorInfo constructor = GetConstructor();
                    //var conObj = CreateConstructor(this.className, constructor);
                    //Console.WriteLine("Constructor object: " + conObj);
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
        /// <summary>
        /// Creating an non paramterzied constructor at run time.
        /// if classname is improper throws an exception
        /// </summary>
        /// <param name="className"></param>
        /// <param name="constructor"></param>
        /// <returns></returns>
        public object CreateConstructor(string className, ConstructorInfo constructor)
        {

            //for creating an constructor we need classname and constructor parameter
            //class name should be same as existing class name
            if (className != moodAnalyserType.FullName)
                throw new MoodAnalysisException(MoodAnalysisException.Errors.CLASS_ERROR);
            //constructor name should be same as Constructor in this case we are checking for non parameteized constructor.
            if (constructor != moodAnalyserType.GetConstructors()[0])
                throw new MoodAnalysisException(MoodAnalysisException.Errors.METHOD_ERROR);
            //we create an constructor with create instance method.
            var constructorObj = Activator.CreateInstance(moodAnalyserType);
            return constructorObj;
        }


        /// <summary>
        /// returns a parameterless cosntructor
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public ConstructorInfo GetConstructor(int parameter = 0)
        {
            try
            {
                moodAnalyserType = assembly.GetType(this.className);
                ConstructorInfo[] constructorInfo = moodAnalyserType.GetConstructors();
                foreach (ConstructorInfo constructor in constructorInfo)
                {
                    //checking for cosntructor with no parameters
                    if (constructor.GetParameters().Length == parameter)
                        return constructor;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //getting constuctors from the class.
            return null;
        }


        public string InvokeMethod()
        {
            //creating an object of class by CreatAbjectAtRuntime() method.
            object moodAnalysisObj = CreateObjectAtRuntime();
            //Getting the methods present in the class
            MethodInfo methodMoodCheck = moodAnalyserType.GetMethod("MoodCheck");
            //invoking method using predefined Invoke method with object and passing string parameter.
            //return object type.
            var outputMessage = methodMoodCheck.Invoke(moodAnalysisObj, null);
            return outputMessage.ToString();
        }
    }
}
