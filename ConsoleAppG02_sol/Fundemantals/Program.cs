namespace Fundemantals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion(Errors)
            int[] x = [4, 33, 4];
            int s = 20, y = 0;

            try
            {
                Console.WriteLine(x[0]);
                Console.WriteLine(s/y);
            }
          
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }          
            catch(DivideByZeroException ex)
            {
               
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }
            #endregion
            #region unchecked
            unchecked
            {
                long r = 10000000000000000;
                int l =(int) r;
                Console.WriteLine(l);
            }
            #endregion

            #region tostring
            double msg = 3.145563;
            Console.WriteLine(msg.ToString("F2"));
            #endregion

        }
    }
}
