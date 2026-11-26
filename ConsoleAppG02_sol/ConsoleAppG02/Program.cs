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

            #region  StringFormat
            string superString = """ D:\CorrerspondenceSourceTree\prototypes\incoming-report-mockup""";
            string path = "D:\\CorrerspondenceSourceTree\\prototypes\\incoming-report-mockup";
            string path_= @"D:\CorrerspondenceSourceTree\prototypes\incoming-report-mockup";//string is literal, no need to escape backslash
            #endregion


            #region session task
            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Age: ");
            int age =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter Grade1");
            int grade1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Grade2");
            int grade2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Grade3");
            int grade3 = Convert.ToInt32(Console.ReadLine());
            
            int totaGrades = grade1 + grade2 + grade3;
            int avgGrade = totaGrades / 3;

            string status = (avgGrade >= 50) ? "Passed" : "Failed";
            string category = (age >= 18) ? "Adult" : "Minor";


            Console.WriteLine(string.Format("Student Name : {0}\nStudent Age : {1}\n", name,age));
            
            Console.WriteLine(string.Format("Total Grades : {0}\nAverage : {1}\n", totaGrades,avgGrade));

            Console.WriteLine(string.Format("Status : {0}\nCategory : {1}\n", status,category));

            #endregion
        }
    }
}
