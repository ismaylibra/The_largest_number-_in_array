using System;

namespace Number_array_inde_en_boyuk_element
{
    class Program
    {
        static void Main(string[] args)
        { int num1 = Convert.ToInt32(Console.ReadLine());
          int num2 = Convert.ToInt32(Console.ReadLine());
          int num3 = Convert.ToInt32(Console.ReadLine());
          int num4 = Convert.ToInt32(Console.ReadLine());
            
          
            
          int[] numbers = { num1, num2, num3, num4 };
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                    Console.WriteLine(numbers[i]);
                }
            
            }
        } 
        
    }  
    {
       
    }
}
