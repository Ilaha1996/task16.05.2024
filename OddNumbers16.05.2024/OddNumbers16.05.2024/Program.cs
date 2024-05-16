using System.ComponentModel.Design;

namespace OddNumbers16._05._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 15;
            int end = 80;

            if (end > start)
            { 
                               
              
                if (start % 2 == 1 && end % 2 == 1)
                {
                    Console.WriteLine((end - start) / 2 -1 );   
                }

                else
                {
                Console.WriteLine((end - start) / 2);
                }


            }
        }
    }
}
