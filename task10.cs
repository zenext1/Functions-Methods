using System;

namespace functions_and_methods
{
    class Program
    {
        public static void Main() {
            int number;
            Console.Write("\n\nFunction : To calculate the sum of the individual digits of a number :\n");
            Console.Write("-------------------------------------------\n");
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sume of the digits of the number {0} is : {1} \n",number,SumCal(number));

            
        }
        public static int SumCal(int n) {
            string number1 = Convert.ToString(n);
            int sum = 0;
            for (int i = 0; i < number1.Length; i++)
            sum += Convert.ToInt32(number1.Substring(i,1));
            return sum;
        }
       
        


        
        
            
            
        
        
        

    }
}
