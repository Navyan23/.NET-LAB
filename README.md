using System;<br>

namespace helloconsoleapp<br>
{<br>
    class hello<br>
    {<br>
        static void Main(string[] args)<br>
        {<br>
            Console.WriteLine("Hello World!");<br>
            Console.ReadLine();<br>
        }<br>
    }<br>
}<br>
![image](https://user-images.githubusercontent.com/97940058/154424179-5dd496de-6d62-4fca-b673-cefcdfc518c5.png)
<br>
<br>
using System;

namespace Excercises
{
    class BinaryTriangle1
    {
        static void Main(string[] args)
        {
            int number, digit = 1;
            Console.Write("\nEnter the number of lines:");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                for (int space = number - i; space > 0; space--)
                {
                    Console.Write(" ");

                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(digit + " ");
                    digit = (digit == 1) ? 0 : 1;
                }

                Console.Write("\n");
            }

        }
    }
}
