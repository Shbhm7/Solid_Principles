using InterfaceSegregation;
class Program
{
        static void Main(string[] args)
    {
        var worker = new Worker();
        var robot = new Robot();
        var human = new Human();
        DoWork(worker);
        DoWork(robot);
        DoWork(human);
        if (robot is IRechargeable rechargeableRobot)
        {
          rechargeableRobot.Recharge();
        }
    }
    static void DoWork(IWorkable worker)
    {
       worker.Work();
    }

}

 