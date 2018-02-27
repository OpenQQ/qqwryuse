using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorLogCollector.SplitTask
{
    class Program
    {
        static void Main(string[] args)
        {
             string root = AppDomain.CurrentDomain.SetupInformation.ApplicationBase.TrimEnd('\\');
            string file = root + @"\QQWry.dat";
            
            QQWry.NET.QQWryLocator qqWry = new QQWry.NET.QQWryLocator(file);
            //从基础表读
            var cc = qqWry.Query("115.160.178.253");
            Console.WriteLine(cc.Country);
            Console.WriteLine(cc.Local);
            Console.Read();
        }
    }
}
