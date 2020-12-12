using System;

namespace CShapeTest
{
    public class IfLoopTest
    {
        public IfLoopTest() { }

        public void Bunki()
        {
            int a = 5;
            int b = 3;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10.");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }
        }

        public void loop()
        {
            int counter = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 10);

            for (int count=0;count < 10;count++)
            {
                Console.WriteLine($"Hello World! The counter is {count}");
            }

            for (int row = 1; row < 11; row++)
            {
                for(char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }

            int sum = 0;
            for (int num = 1; num < 21; num++)
            {
                if (num % 3 == 0)
                {
                    sum = sum + num;
                }
            }
            Console.WriteLine($"Anser {sum}");
        }

    }
}