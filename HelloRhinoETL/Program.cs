using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloRhinoETL
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                new MainProcess().Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.ReadLine();
        }
    }
}
