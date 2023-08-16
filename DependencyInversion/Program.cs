using DependencyInversion;
class Program
{
    static void Main(string[] args)
    {
        ILogger consoleLogger = new Logger();
        ILogger fileLogger = new FileLogger();
        ReportGenerator reportGeneratorWithConsoleLogger = new ReportGenerator(consoleLogger);
        reportGeneratorWithConsoleLogger.GenerateReport();
        ReportGenerator reportGeneratorWithFileLogger = new ReportGenerator(fileLogger);
        reportGeneratorWithFileLogger.GenerateReport();
    }
}