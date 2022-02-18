*c# program to print a statement hello world*<br>

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
*1.c# program to print a binary triangle*<br>
using System;<br>
namespace Excercises<br>
{<br>
    class BinaryTriangle1<br>
    {<br>
        static void Main(string[] args)<br>
        {<br>
            int number, digit = 1;<br>
            Console.Write("\nEnter the number of lines:");<br>
            number = Convert.ToInt32(Console.ReadLine());<br>
            for (int i = 1; i <= number; i++)<br>
            {<br>
                for (int space = number - i; space > 0; space--)<br>
                {<br>
                    Console.Write(" ");<br>

                }<br>
                for (int j = 0; j < i; j++)<br>
                {<br>
                    Console.Write(digit + " ");<br>
                    digit = (digit == 1) ? 0 : 1;<br>
                }<br>

                Console.Write("\n");<br>
            }<br>

        }<br>
    }<br>
}<br>
![image](https://user-images.githubusercontent.com/97940058/154621833-9d4c7692-e9a6-4b4c-abef-e3c6bac160c8.png)
<br>
<br>
<br>
<br>
*c# program to check whether the enterd number is an amicable number or not*
