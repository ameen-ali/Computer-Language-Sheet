using System;
using System.Management;

/* 
   Write a program, which prints on the standard output 
   the count of days, hours, and minutes, which have passes
   since the computer is started until the moment of the program execution.
   For the implementation use the class Environment.
*/

namespace Application24
{
    class Program
    {
        static void Main(string[] args)
        {
            var mo = new ManagementObject(@"\\.\root\cimv2:win32_operatingSystem=@");
            var lastBootUp = ManagementDateTimeConverter.ToDateTime(mo["LastBootUpTime"].ToString());
            Console.WriteLine(DateTime.Now.ToUniversalTime() - lastBootUp.ToUniversalTime());
        }
    }
}
