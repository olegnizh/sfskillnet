using System.Text;
using Microsoft.Extensions.Configuration;

namespace ConsoleAppConfiguration
{
    public class Program
    {

        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            // https://stackoverflow.com/questions/31453495/how-to-read-appsettings-values-from-a-json-file-in-asp-net-core
            // .NET Core 3.0 / .NET 6

            //var AppName = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["APP_Name"];
            //var ccc = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["ccc"];

            var MyConfig = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var IntExample = MyConfig.GetValue<int>("AppSettings:SampleIntValue");
            var AppName = MyConfig.GetValue<string>("AppSettings:APP_Name");
            var ccc = MyConfig.GetValue<string>("AppSettings:ccc");

            Console.WriteLine(AppName);
            Console.WriteLine(IntExample);
            Console.WriteLine(ccc);

            Console.ReadKey();

        }



    }

}