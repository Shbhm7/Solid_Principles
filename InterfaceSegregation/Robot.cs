using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace InterfaceSegregation
{
   public class Robot : IWorkable, IRechargeable
   {
    public void Work()
    {
      Console.WriteLine("Robot is working.");
    }
     public void Recharge()
       {
         Console.WriteLine("Robot is recharging.");
        }
   }
}

 