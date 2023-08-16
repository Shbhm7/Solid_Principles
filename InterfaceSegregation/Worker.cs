using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace InterfaceSegregation
{
     public class Worker : IWorkable
    {
      public void Work()
    {
       Console.WriteLine("Worker is working.");
    }
    }
}