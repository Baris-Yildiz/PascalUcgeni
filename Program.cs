using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascal_Üçgeni
{
    class Program
    {

        static long Factorial(long number)
        {
            if (number == 0)
            {
                return 1;
            }
            //Console.Write(number.ToString() + "*");
            return number * Factorial(number - 1);            //29 dan sonra bazı sayılarda negatif oluyor nedense o yüzden abs lazım
        }

        static long Combination(long num1 , long num2)
        {
            long a = Factorial(num1);
            long b = Factorial(num1 - num2) * Factorial(num2);

            return a / b;
        }

        static string AddSpaces(int count)
        {
            string result = "";

            for (int i = 0; i < count; i++)
            {
                result += " ";
            }

            return result;
        }

        static void Main(string[] args)
        {   
            Console.Write("How many rows? : ");

            int GivenRow = Convert.ToInt32(Console.ReadLine());

            string triangle = "";

            int row = 0;

            int spaceCount = 25;

            int acceleration = 1;

            while (row <= GivenRow-1)            //aşağıdaki nedenden dolayı GivenRow -1 oldu.
            {
                int rowIndex = 0;

                for(int i =0; i < row+1; i++)           //row+1 olmasının nedeni 0.rowda 1 sayı olacak, 1.rowda 2 sayı vs.
                {
                    if(rowIndex == 0)
                    {
                        triangle += AddSpaces(spaceCount);

                        spaceCount += acceleration;

                        acceleration += 2;
                    }

                    triangle += Combination(row, rowIndex) + " ";
                    
                    rowIndex += 1;

                    spaceCount -= 2;
                }

                triangle += Environment.NewLine;
                row += 1;
            }

            Console.WriteLine(triangle);
            
        }

    }
}