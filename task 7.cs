using System;

namespace functions_and_methods
{
    class Program
    {
        public static void Main()
        {
            
            int number1;
            int exponent1;
            Console.Write("\n\nFunction : To calculate the result of raising an interger number to another :\n");
            Console.Write("----------------------------------------\n");
            Console.Write("Input base number:");
            number1= Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the exponent:");
            exponent1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( "So the number {0} ^ (to the power) {1} = {2} ", number1, exponent1, PowerRaising(number1,exponent1));
            
            
            
        
          
            
        
        }
        public static int PowerRaising(int number1, int exponent1) {
            int rvalue = 1;
            int i;
            for(i=1;i<=exponent1;i++)

            rvalue = rvalue*number1;
            return rvalue;
        }
        
        
        

    }
}
