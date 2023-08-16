using System;

using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace InterfaceSegregation
{
    public class Human : IWorkable
    {
        public void Work()
        {
        Console.WriteLine("Human is working.");
        }
    }
}