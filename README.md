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
<br>
<br>
<br>
*7.c# program to generate register number automatically for 100 students usind static constructor*

using System;<br>
namespace Exercise7<br>
{<br>
    class RegisterNum<br>
    {<br>
        int regNo;<br>
        static int startNum;<br>
        static RegisterNum()<br>
        {<br>
            startNum = 20210000;<br>
        }<br>
        RegisterNum()<br>
        {<br>
            regNo = ++startNum;<br>
        }<br>
       public static void Main(string[] args)<br>
        {<br>
           for(int i=0; i<100;i++)<br>
        {<br>
            RegisterNum student = new RegisterNum();<br>
            Console.WriteLine("Student {0}:{1}", i + 1, student.regNo);<br>
        }<br>
        }<br>
    }<br>
}<br>

![image](https://user-images.githubusercontent.com/97940058/154631296-82f56c61-e96d-440a-aa87-c2208117f9d6.png) ![image](https://user-images.githubusercontent.com/97940058/154631715-a56ca44b-bce9-4976-a7a7-5162b2a766f7.png) ![image](https://user-images.githubusercontent.com/97940058/154632074-424b9312-47d1-466a-92d4-100d0ab83edb.png)![image](https://user-images.githubusercontent.com/97940058/154632768-00967b3f-86c6-40d2-be8e-ad9243c42b88.png)
<br>
<br>
<br>
*8.c# program to find the frequency of the word "is" in a given structure*

using System;<br>
namespace Exercise8<br>
{<br>
    class FrequencyIS<br>
    {<br>
        static void Main(string[] args)<br>
        {<br>
            int count = 0;<br>
            string inputString;<br>
            Console.WriteLine("\n-------------Frequency of word 'is'----------");<br>
            Console.Write("\n enter the input string:");<br>
            inputString = Console.ReadLine();<br>
            char[] separator = { ',', ' ', '.', '!', '\n' };<br>
            string teststring = inputString.ToLower();<br>
            string[] outcomes = teststring.Split(separator);<br>
            foreach(string s in outcomes)<br>
            {<br>
                Console.WriteLine(s);<br>
                if (s == "is")<br>
                    count++;<br>
            }<br>
            Console.WriteLine("\n Number of 'is' in '''+inputString +''' is: "+ count);<br>
        }<br>
    }<br>
}<br>
<br>
![image](https://user-images.githubusercontent.com/97940058/154634536-9e0280f9-5409-4425-a728-eca760ce3a06.png)

<br>
<br>
*9.c# program that bechmarks 2D, jagged array allocation*
using System;<br>
using System.Diagnostics;<br>
namespace Exercise9<br>
{<br>
    class BenchmarkAllocation<br>
    {<br>
        const int max = 100000;<br>
        static void Main(string[] args)<br>
        {<br>
            var Arr2D = new int[100, 100];<br>
            var ArrJagged = new int[100][];<br>
            for (int i = 0; i < 100; i++)<br>
            {<br>
                ArrJagged[i] = new int[100];<br>
            }<br>
            var Stopwatch2D = Stopwatch.StartNew();<br>
            for (int i = 0; i < max; i++)<br>
            {<br>
                for (int j = 0; j< 100; j++)<br>
                {<br>
                    for (int k = 0; k < 100; k++)<br>
                    {<br>
                        Arr2D[j, k] = k;<br>
                    }<br>
                }<br>
            }<br>
            Stopwatch2D.Stop();<br>
            var StopwatchJagged = Stopwatch.StartNew();<br>
            for (int i = 0; i < max; i++)<br>
            {<br>
                for( int j = 0; j < 100; j++)<br>
                {<br>
                    for (int k = 0; k < 100; k++)<br>
                    {<br>
                        ArrJagged[j][k] = k;<br>
                    }<br>
                }<br>
            }<br>
            StopwatchJagged.Stop();<br>
            Console.Write("\n Time taken for allocation in case of 2D array:");<br>
            Console.WriteLine(Stopwatch2D.Elapsed.TotalMilliseconds + "milliseconds");<br>
            Console.Write("\n time taken for allocation in case of jagged array:");<br>
            Console.WriteLine(StopwatchJagged.Elapsed.TotalMilliseconds + "milliseconds");<br>
        }<br>
    }<br>
}<br>

![image](https://user-images.githubusercontent.com/97940058/154635758-ae1d2cf9-f523-438d-b9c1-abde21f2bfc3.png)
<br>
<br>
<br>
*10.c# program to find the sum of the values on diagonal of the matrix*

using System;<br>
namespace Exercise10<br>
{<br>
    class SumOfDiagonals<br>
    {<br>
        static void Main(string[] args)<br>
        {<br>
            int MaxRow, MaxCol, sum = 0;<br>
            int[,] Matrix;<br>
            Console.WriteLine("\n------SUM OF DIAGONAL OF A MATRIX ------\n");<br>
            Console.WriteLine("\n Enter the number of rows:");<br>
            MaxRow = Convert.ToInt32(Console.ReadLine());<br>
            Console.Write("\n Enter the nummber of columns:");<br>
            MaxCol = Convert.ToInt32(Console.ReadLine());<br>
            if(MaxRow!=MaxCol)<br>
            {<br>
                Console.WriteLine("\n the Dimensions entered are not of square Matrix:");<br>
                Console.WriteLine("\n Existing the program......");<br>
                return;<br>
            }<br>
            Matrix = new int[MaxRow, MaxCol];<br>
            for (int i = 0; i < MaxRow; i++)<br>
            {<br>
                for (int j = 0; j < MaxCol; j++)<br>
                {<br>
                    Console.WriteLine("\n Enter the ({0},{1}) the elements of the matrix:", (i + 1), (j + 1));<br>
                    Matrix[i, j] = Convert.ToInt32(Console.ReadLine());<br>
                }<br>
            }<br>
            Console.WriteLine("\n the entered matrix");<br>
            for(int i=0; i<MaxRow; i++)<br>
            {<br>
                    for(int j=0; j<MaxCol; j++)<br>
                {<br>
                    Console.Write(" " + Matrix[i, j]);<br>
                    if(i==j)<br>
                    {<br>
                        sum += Matrix[i, j];<br>
                    }<br>
                }<br>
                Console.WriteLine();<br>
            }<br>
            Console.WriteLine("\n The sum of diagonal is" + sum);<br>
        }<br>
    }<br>
}<br>

![image](https://user-images.githubusercontent.com/97940058/154636981-7aab0702-932a-475b-a993-ab7d2f19e5d6.png)
![image](https://user-images.githubusercontent.com/97940058/154637185-7ffbf268-102a-4b23-981e-8cff87cd21a8.png)
<br>
<br>

*11.c# program to create a file, check the existance of a file and read the contents of the file*

using System;<br>
using System.IO;<br>
namespace Exercise11<br>
{<br>
    class FileRead<br>
    {
        static void Main()
        {
            string fileName;
            while (true)
            {
                Console.WriteLine("\n-------MENU------\n");
                Console.WriteLine("\n 1.Create a File");
                Console.WriteLine("\n2.Existenace of the file");
                Console.WriteLine("\n3.Read the contents of the file");
                Console.WriteLine("\n4.Exit");
                Console.Write("\n Enter your choice:");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                Console.Write("\n Enter the file name to ceate:");
                fileName = Console.ReadLine();
                Console.WriteLine("\n Write the contents to the file:\n");
                string r = Console.ReadLine();
                using (StreamWriter fileStr = File.CreateText(fileName))
                {
                    fileStr.WriteLine(r);

                }
                Console.WriteLine("File is created.....");
                break;
                case 2:

                Console.WriteLine("\n Enter the File name:");
                fileName = Console.ReadLine();
                if (File.Exists(fileName))
                {
                    Console.WriteLine("File exists.....");

                }
                else
                {
                    Console.WriteLine("File does not exist in the current directory!");

                }
                break;
                case 3:
                Console.Write("Enter the file name to read the contents :\n");
                fileName = Console.ReadLine();
                if (File.Exists(fileName))
                {
                    using (StreamReader sr = File.OpenText(fileName))
                    {
                        string s = "";
                        Console.WriteLine("Here is the content of the file:");
                        while ((s = sr.ReadLine())!=null)
                        {
                            Console.WriteLine(s);

                        }
                        Console.WriteLine("");

                    }

                }
                else
                {
                    Console.WriteLine("File does not exists");

                }
                break;
                case 4:
                Console.WriteLine("\n Existing...");
                return;
                default:
                    Console.WriteLine("\n Invalid choice");
                break;



                }
            }
        }
    }
}
























