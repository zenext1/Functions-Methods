using System;

namespace functions_and_methods
{
    class Program
    {
        public static int Fibo(int nno) {
            int number1 = 0;
            int number2 = 1;

            for (int i = 0; i < nno; i++){
                int temp = number1;
                number1 = number2;
                number2 = temp + number2;
            }
            return number1;
        }
        public static void Main() {
            Console.Write("\n\nFunction : To display the n number Fibonacci series :\n");
            Console.Write("------------------------------------------\n");
            Console.Write("Input number of Fibonacci Series : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Fibonacci seriesof "+n+" numbers is :");
            for (int i = 0; i < n; i++) {
                Console.Write(Fibo(i)+" ");
            }
            Console.WriteLine();
        }


        
        
            
            
        
        
        

    }
}
