using System;
namespace MethodParaMeters1
{
  
    class Program
    {
        static void Main(string[] args)
        {
               int sum = 0;
               int product = 0;
               Add(100, 20, out sum, out product);
               Console.WriteLine("sum={0} && product= {1}", sum, product); 
            
               Program p = new Program();
               int result= p.Addition(50,50);
               Console.WriteLine("Result = {0} ", result);
        }
          public  int Addition(int a, int b)
          {
              return a + b;
          }

          public static void Add(int fn, int sn,out int Sum,out int product )
          {
            Sum= fn + sn;
            product = fn / sn;

          }   
    }
}
