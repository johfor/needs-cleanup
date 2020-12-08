using System;

namespace CleanUpTask
{
    public interface ILogger
    {
        void Log(string s);
        void Write(string s);
    }
    public class Logger : ILogger
    {
        public void Log(string s)
        {
            Console.WriteLine(s);
        }

       public void Write(string s)
        {
            Console.Write(s);
        }
    }
}
