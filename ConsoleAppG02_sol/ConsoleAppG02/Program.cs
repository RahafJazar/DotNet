using System.Diagnostics;
using System.Text;

namespace ConsoleAppG02 //folder name 
{
    internal class Program
    {
        //entry point (main function) 
        static void Main(string[] args)
        {
            #region  StringBuilder

            StringBuilder sb = new StringBuilder("A");
            string s= "A";  
            Stopwatch sw=new Stopwatch();
            sw.Start();
for(int i = 0; i < 100000; i++)
            { 
                s += "A";
            }
sw.Stop();
            Console.WriteLine($"String concatenation time: {sw.ElapsedMilliseconds} ms");
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();

            for (int i = 0; i < 100000; i++)
            {
                sb.Append("A");
            }
            sw2.Stop();
            Console.WriteLine($"StringBuilder concatenation time: {sw2.ElapsedMilliseconds} ms");
            #endregion
        }
    }
}
