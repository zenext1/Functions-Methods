using System;

namespace functions_and_methods
{
    class Program
    {
        public static void Main()
        {
            int[] array = {5,7,3,2,9};
            
            int sum = 0;
            Array.ForEach(array, i => sum += i);

            Console.WriteLine(sum);
            
            
        
          
            
            

        
            
        
        
        }
        static string space(string li) {
            return li = (li + "containes" + (li.Split(' ').Length-1) + "spaces");

    
        }
        
        
        

    }
}
