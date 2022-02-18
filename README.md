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
*2.c# program to check whether the enterd number is an amicable number or not*<br>
using System;<br>
namespace amicableConsoleApp3<br>
{<br>
    class AmicableNumber<br>
    {<br>
        static void Main(string[] args)<br>
        {<br>
            int num1, num2, sum1 = 0, sum2 = 0;<br>
            Console.WriteLine("\n-------AMICABLE NUMBERS-------\n)");<br>
            Console.Write("\nEnter the first number:");<br>
            num1 = Convert.ToInt32(Console.ReadLine());<br>
            Console.Write("\nEnter the second number:");<br>
            num2 = Convert.ToInt32(Console.ReadLine());<br>
            for (int i=1; i < num1; i++)<br>
            {<br>
                if (num1 % i== 0)<br>
                {<br>
                    sum1 += i;<br>
                }<br>
           }<br>
            for (int i = 1; i < num2; i++)<br>
            {<br>
                if (num2 % i == 0)<br>
                {<br>
                    sum2 += i;<br>
                }<br>
            }<br>
            if (sum1 == num2 && sum2 == num1)<br>
            {<br>
                Console.WriteLine("\nThe numbers {0} and {1} are amicable.", num1, num2);<br>
            }<br>
            else<br>
            {<br>
                Console.WriteLine("\n The numbers{0} and {1} are not amicable.,num1,num2");<br>
            }<br>
        }<br>
    }<br>
}<br>
<br>
<br>
![image](https://user-images.githubusercontent.com/97940058/154623206-a11f04e7-a90e-4a36-b628-a808d40fb448.png)
<br>
<br>
<br>
*3.c# program to illustrate multilevel inheritance with virtual model(displaying student details)*
<br>
using System;<br>
namespace DetailsConsoleApp3<br>
{<br>
    class PersonalDetails<br>
    {<br>
        string name;<br>
        int age;<br>
        string gender;<br>
        public PersonalDetails(string name, int age, string gender)<br>
        {<br>
            this.name = name;<br>
            this.age = age;<br>
            this.gender = gender;<br>
        }<br>
        public virtual void Display()<br>
        {<br>
            Console.WriteLine("\n-------PERSONAL DETAILS---------\n");<br>
            Console.WriteLine("Name      :" + name);<br>
            Console.WriteLine("Age      :" + age);<br>
            Console.WriteLine("Gender     :" + gender);<br>
        }<br>
    }<br>
    class CourseDetails : PersonalDetails<br>
    {<br>
        int regNo;<br>
        string course;<br>
        int semester;<br>
        public CourseDetails(string name, int age, string gender, int regNo, string course, int semester) : base(name, age, gender)<br>
        {<br>
            this.regNo = regNo;<br>
            this.course = course;<br>
            this.semester = semester;<br>
        }<br>
        public override void Display()<br>
        {<br>
            base.Display();<br>
            Console.WriteLine("\n------CORDE DETAILS------\n");<br>
            Console.WriteLine("Register Number     :" + regNo);<br>
            Console.WriteLine("course    : " + course);<br>
            Console.WriteLine("semester     :" + semester);<br>
        }<br>
    }<br>
    class MarksDetails : CourseDetails<br>
    {<br>
        int[] marks = new int[5];<br>
        int total;<br>
        float average;<br>
        string grade;<br>
        int flagFail;<br>
        public MarksDetails(String name, int age, string gender, int regNo, string course, int semester, int[] marks) : base(name, age, gender, regNo, course, semester)<br>
        {<br>
            total = 0;<br>
            for (int i = 0; i < 5; i++)<br>
            {<br>
                this.marks[i] = marks[i];<br>
                total += marks[i];<br>
                if (marks[i] < 35)<br>
                {<br>
                    flagFail = 1;<br>
                }<br>
            }<br>
            calculate();<br>
        }<br>
        private void calculate()<br>
        {<br>
            average = total / 5;<br>
            if (flagFail == 1 || average > 40)<br>
                grade = "Fail";<br>
            else if (average >= 60)<br>
                grade = "First class";<br>
            else if (average >= 50)<br>
                grade = "second class";<br>
            else<br>
                grade = "pass class";<br>   
        }<br>
        public override void Display()<br>
        {<br>
            base.Display();<br>
            Console.WriteLine("\n--------MARKS DETAIS------\n");<br>
            Console.Write("marks in 5 subjects:");<br>
            for (int i = 0; i < 5; i++)<br>
                Console.Write(marks[i] + "  ");<br>
            Console.WriteLine();<br>
            Console.WriteLine("Total    :" + total);<br>
            Console.WriteLine("Average    :" + average);<br>
            Console.WriteLine("Grade     :" + grade);<br>
        }<br>
    }<br>
    class MultiLevel<br>
    {<br>
        public static void Main(string[] args)<br>
        {<br>
            MarksDetails student1 = new MarksDetails("Abhijith", 22, "Male", 2019001, "MCA", 5, new int[] { 77, 80, 98, 95, 90 });<br>
            student1.Display();<br>
        }<br>
    }<br>
}<br>
![image](https://user-images.githubusercontent.com/97940058/154623796-7a5165d5-e680-4561-8264-a2b74718cf9b.png)
<br>
<br>
<br>
*4.c# program to create a gray code*

using System;<br>
namespace program4<br>
{<br>
    class GrayCode<br>
    {<br>
        static int getGray(int n)<br>
        {<br>
            return n ^ (n >> 1);<br>
        }<br>
       static void Main(string[] args)<br>
        {<br>
            int InputNum, GrayNum;<br>
            Console.WriteLine("\nEnter the decimal number :");<br>
            InputNum = Convert.ToInt32(Console.ReadLine());<br>
            Console.WriteLine("\nBinary equivalent of {0}:{1}", InputNum, Convert.ToString(InputNum, 2));<br>
            GrayNum = getGray(InputNum);<br>
            Console.WriteLine("Gray Code equivalent of {0}:{1}", InputNum, Convert.ToString(GrayNum, 2));<br>
        }<br>
    }<br>
}<br>
<br>
![image](https://user-images.githubusercontent.com/97940058/154626580-7e4602e9-c376-462d-9283-84fb91207ed5.png)
<br>
<br>
<br>
*5.c# program to calculate volume of 2 boxes and find the resultant volume after addition of 2 boxes by implenting operator overloading*

using System;<br>
namespace Exercises5<br>
{<br>
   class Box<br>
    {<br>
        float width;<br>
        float height;<br>
        float length;<br>
        public float Volume<br>
        {<br>
            get {return  width * height * length; }<br>
        }<br>
        public Box(float width ,float height,float length )<br>
        {<br>
            this.width = width;<br>
            this.height = height;<br>
            this.length = length; <br>
        }    <br>
        public static float operator +(Box box1, Box box2)<br>
        {<br>
            return box1.Volume + box2.Volume<br> 
        }<br>
        public override String ToString()<br>
        {<br>
                return "box with width "+ width +" ,+height"+height+" and length " + length;<br>
        }<br>
    }<br>
    class OperatorOverloading<br>
    {<br>
             public static void Main()<br>
        {<br>
            Box box1 = new Box(10, 20, 30);<br>
            Box box2 = new Box(23, 32, 15);<br>
            Console.WriteLine("Volume of{0} is:{1}", box1, box1.Volume);<br>
            Console.WriteLine("Volume of{0} is:{1}", box2, box2.Volume);<br>
            Console.WriteLine("Voume after adding boxes :{0}", box1 + box2);<br>
        }<br>
    }<br>
}<br>
<br>

![image](https://user-images.githubusercontent.com/97940058/154628638-243c67d9-671e-43e1-8e67-c997a099daff.png)
<br>
<br>
<br>
*6.c# program to implement priciples of delegates converting input strings to uppercase first, last and entire string*
using System;<br>
namespace Exercises<br>
{<br>
    class Delegates<br>
    {<br>
        delegate string UppercaseDelegate(string input);<br>
        static string UppercaseFirst(string input)<br>
        {<br>
            char[] buffer = input.ToCharArray();<br>
            buffer[0] = char.ToUpper(buffer[0]);<br>
            return new string(buffer);<br>
        }<br>
        static string UppercaseLast(string input)<br>
        {<br>
            char[] buffer = input.ToCharArray();<br>
            buffer[buffer.Length - 1] = char.ToUpper(buffer[buffer.Length - 1]); return new string(buffer);<br>
        }<br>
        static string UppercaseAll(string input)<br>
        {<br>
            return input.ToUpper();<br>
        }<br>
        static void WriteOutput(string input, UppercaseDelegate del)<br>
        {<br>
            Console.WriteLine("Input String: {0}", input);<br>
            Console.WriteLine("Output String: {0}", del(input));<br>
        }<br>
        static void Main()<br>
        {<br>
            WriteOutput("tom ", new UppercaseDelegate(UppercaseFirst));<br>
            WriteOutput("tom", new UppercaseDelegate(UppercaseLast));<br>
            WriteOutput("tom", new UppercaseDelegate(UppercaseAll));<br>
            Console.ReadLine();<br>
        }<br>
    }<br>
}<br>
<br>
![image](https://user-images.githubusercontent.com/97940058/154629715-835a63f9-2153-4b14-8e4d-c807ad85ee11.png)




