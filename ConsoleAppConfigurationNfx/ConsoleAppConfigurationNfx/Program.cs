using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace ConsoleAppConfigurationNfx
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var connectionString = ConfigurationSettings.AppSettings["StringConnection"];
            Console.WriteLine(connectionString);
			
            var qa_table = ConfigurationSettings.AppSettings["qatable"];
            Console.WriteLine(qa_table);

            Console.ReadKey();

        }


    }
}
