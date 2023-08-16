using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DependencyInversion
{
    public class ReportGenerator
    {
    private readonly ILogger _logger;
    public ReportGenerator(ILogger logger)
    {

     _logger = logger;
    }
    public void GenerateReport()
    {        
     _logger.Log("Report generated");
    }
    }
}