using System;
using System.Diagnostics.CodeAnalysis;

namespace CodeAcademy16._05._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = { 'c', 'o', 'd', 'e', 'a', 'c', 'a', 'd', 'e', 'm', 'y' };
            char targetChart = chars[0]; // c
            int countChart = 0;            
           
            for (int i = 0; i < chars.Length; i++) 
            {
                if (chars[i] == targetChart) 
                
                {                  
                    countChart++;
                    
                }
            }
            Console.WriteLine($"Number of '{targetChart}' in the array: {countChart}");
        }
            
    }
}
