using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serilog;
namespace MyDemo.Logger
{
    public class ApiLog 
    {
        
        public void doLog(string message)
        {
            Log.Information(message);
        }
}
