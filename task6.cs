using System;

namespace functions_and_methods
{
    class Program
    {
        public static void Main()
        {
            
            int number1,number2;
            Console.Write("\n\nFunction : To swap the values of two interger numbers :\n");
            Console.Write("----------------------------------------\n");
            Console.Write("Enter a number:");
            number1= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number:");
            number2= Convert.ToInt32(Console.ReadLine());
            Interchange( ref  number1, ref  number2 );
            Console.WriteLine( "Now the 1st number is : {0} , and the 2nd number is : {1}", number1, number2);
            
            
            
        
          
            
        
        }
        public static void  Interchange(ref int number1, ref int number2) {
            int newnumber;
            newnumber = number1;
            number1 = number2;
            number2 = newnumber;
        }
        
        
        

    }
}
