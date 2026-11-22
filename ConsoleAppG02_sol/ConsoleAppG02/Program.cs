using System.Reflection.Metadata;
using ConsoleAppG02.Books;
using ConsoleAppG02.Second;

namespace ConsoleAppG02 //folder name 
{
    internal class Program
    {
        //entry point (main function) 
        static void Main(string[] args)
        {
           

        

            #region MyRegion (Q01)
            Book book = new Book();
            object bookObj = book;
            Console.WriteLine("\nQ01 :  " );
            Console.WriteLine( bookObj);
            #endregion

            #region MyRegion(Q02)
            Console.WriteLine("\nQ02 :  ");
            Console.WriteLine(book.ToString()); ;
            Console.WriteLine(book.Equals(bookObj));
            Console.WriteLine(book.GetHashCode());
           Console.WriteLine(book.GetType());
            #endregion


            #region MyRegion(Q03)
            //it's a compile time error => don't use "", that "" used for string not int
           // int pages = 464;
            #endregion

            #region MyRegion(Q04)
            try
            {
                Console.WriteLine("\nQ04 :  ");
                int a = 10;
                int b = 0;
                int x = a / b;

            }
            catch (Exception ex)
            {
                Console.WriteLine("can't divide by zero");
            }
            finally { Console.WriteLine("Done"); }
            #endregion

            #region MyRegion(Q05)
            int pages = 300;
            double pagesD = pages;
            Console.WriteLine("\nQ05 :  ");
            Console.WriteLine(pagesD.GetType());
            #endregion

            #region MyRegion(Q06)
            double price = 49.99;
            int priceI =   (int)price;
            Console.WriteLine("\nQ06 :  ");
            Console.WriteLine(priceI.GetType());
            #endregion

            #region MyRegion(Q07)
            string pagesText = "464";
            int pagesI = Convert.ToInt32( pagesText);
            Console.WriteLine("\nQ07 :  ");
            Console.WriteLine(pagesI);
            Console.WriteLine(pagesI.GetType());
            #endregion

            #region MyRegion(Q08)
            Console.WriteLine("\nQ08 :  ");
            string yearText = "2023";
            int yearI =  int.Parse(yearText);
            string badText = "abc";
         
              if( int.TryParse(badText, out int number))
                {
                    Console.WriteLine(number);
                }
                else
                {
                    Console.WriteLine("bad convert");
                }
            #endregion



            #region MyRegion(Q09)
            Console.WriteLine("\nQ09 :  ");
            int pages_ = 400;
            string pagesS=pages.ToString();
            Console.WriteLine(pagesS.GetType());
            #endregion


            #region MyRegion(Q10)
            Console.WriteLine("\nQ10 :  ");
            int copies = 100;
            object obj = copies;
            int newCopies = (int)obj;
            Console.WriteLine("copies : "+copies.GetType());
            Console.WriteLine("obj : " + obj.GetType());
            Console.WriteLine("newCopies : " + newCopies.GetType());

            #endregion

            #region MyRegion(Q11)
            Console.WriteLine("\nQ11 :  ");
            int ?year = null; 
             Console.WriteLine(year.HasValue); 
            year = 2024;
            Console.WriteLine(year); 
            #endregion

            #region MyRegion(Q12)
            Console.WriteLine("\nQ12 :  ");
            string? reviewer = null;

            Console.WriteLine(reviewer is not null);
            #endregion

            #region MyRegion(Q13+14)
            Console.WriteLine("\nQ13+14 :  "); 
            Book ?bk1= null;
            string title = bk1?.Title;
            Console.WriteLine(title ?? "untitled");
           title??= "Untitled";
            Console.WriteLine(title  );
            #endregion  
            
            #region MyRegion(Q15)
            Console.WriteLine("\nQ15 :  ");
            string ?name = "Ahmad";
            string confirmedName = name!;
            Console.WriteLine(confirmedName);
            #endregion
            Console.ReadKey();
        }
    }
}
