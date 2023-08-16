using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
        public class Logger : ILogger
    {
        public void Log(string message)
        {
           Console.WriteLine($"Console Logger: {message}");
        }
    }

    public class FileLogger : ILogger
    {
    public void Log(string message)
    {          
      Console.WriteLine($"File Logger: {message}");
    }
 }
}

 