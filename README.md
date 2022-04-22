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
    {<br>
        static void Main()<br>
        {<br>
            string fileName;<br>
            while (true)<br>
            {<br>
                Console.WriteLine("\n-------MENU------\n");<br>
                Console.WriteLine("\n 1.Create a File");<br>
                Console.WriteLine("\n2.Existenace of the file");<br>
                Console.WriteLine("\n3.Read the contents of the file");<br>
                Console.WriteLine("\n4.Exit");<br>
                Console.Write("\n Enter your choice:");<br>
                int ch = int.Parse(Console.ReadLine());<br>
                switch (ch)<br>
                {<br>
                    case 1:<br>
                Console.Write("\n Enter the file name to ceate:");<br>
                fileName = Console.ReadLine();<br>
                Console.WriteLine("\n Write the contents to the file:\n");<br>
                string r = Console.ReadLine();
                using (StreamWriter fileStr = File.CreateText(fileName))
                {<br>
                    fileStr.WriteLine(r);<br>
                }<br>
                Console.WriteLine("File is created.....");<br>
                break;<br>
                case 2:<br>
                Console.WriteLine("\n Enter the File name:");<br>
                fileName = Console.ReadLine();<br>
                if (File.Exists(fileName))<br>
                {<br>
                    Console.WriteLine("File exists.....");<br>
                }<br>
                else<br>
                {<br>
                    Console.WriteLine("File does not exist in the current directory!");<br>
                }<br>
                break;<br>
                case 3:<br>
                Console.Write("Enter the file name to read the contents :\n");<br>
                fileName = Console.ReadLine();<br>
                if (File.Exists(fileName))<br>
                {<br>
                    using (StreamReader sr = File.OpenText(fileName))<br>
                    {<br>
                        string s = "";<br>
                        Console.WriteLine("Here is the content of the file:");<br>
                        while ((s = sr.ReadLine())!=null)<br>
                        {<br>
                            Console.WriteLine(s);<br>
                        }<br>
                        Console.WriteLine("");<br>
                    }<br>
                }<br>
                else<br>
                {<br>
                    Console.WriteLine("File does not exists");<br>
                }<br>
                break;<br>
                case 4:<br>
                Console.WriteLine("\n Existing...");<br>
                return;<br>
                default:<br>
                    Console.WriteLine("\n Invalid choice");<br>
                break;<br>
                }<br>
            }<br>
        }<br>
    }<br>
}<br>
<br>
![image](https://user-images.githubusercontent.com/97940058/155660956-89555372-38c1-4046-9ac6-30921857aa96.png)
![image](https://user-images.githubusercontent.com/97940058/155661271-d8a027ae-38d3-4b0f-bdeb-a1202230d044.png)
![image](https://user-images.githubusercontent.com/97940058/155662628-61eaccab-ef41-4cf4-a3ac-4886ea43c19b.png)
<br>
<br>

<br>
*12.c# program to perform file operation*

using System;<br>
using System.IO;<br>
namespace Exercise12<br>
{<br>
    class FileRead<br>
    {<br>
         public static void Main()<br>
        {<br>
            string file1;<br>
            string file2;<br>
            Console.Write("Enter the first file path:");<br>
            file1 = Console.ReadLine();<br>
            Console.Write("Enter the second file path:");
            file2 = Console.ReadLine();<br>
            if(!File.Exists(file1))<br>
            {<br>
                Console.WriteLine("First file Does not exists!");<br>
           }<br>
            else if(!File.Exists(file2))<br>
            {<br>
                Console.WriteLine("Second File does not exists");<br>
            }<br>
            else if( File.ReadAllText(file1)==File.ReadAllText(file2))<br>
            {<br>
                Console.WriteLine("Both file contain the same contemt");<br>
            }<br>
            else<br>
            {<br>
                Console.WriteLine("Contents of files are not same");<br>
            }<br>
        }<br>
    }<br>
}<br>

![image](https://user-images.githubusercontent.com/97940058/155664121-8ce37d1e-2816-4e56-917b-07974c30634a.png)
![image](https://user-images.githubusercontent.com/97940058/155664242-7cf45686-edfd-44f9-b980-489adccb210a.png)
![image](https://user-images.githubusercontent.com/97940058/155664372-4464c5e4-a072-40a6-8a62-0217d8700625.png)


![image](https://user-images.githubusercontent.com/97940058/155665222-324268bc-5df4-4d3f-a8b5-046d76b29711.png)
![image](https://user-images.githubusercontent.com/97940058/155665438-39ab9778-335f-497e-b949-a02757c4ebe4.png)


*13.c# program toimplement IComparable interface*

using System;<br>
namespace Exercise13<br>
{<br>
    class Fraction:IComparable<br>
    {<br>
        int z, n;<br>
        public Fraction(int z, int n)<br>
        {<br>
            this.z = z;<br>
            this.n = n;<br>
        }<br>
        public static Fraction operator +(Fraction a, Fraction b)<br>
        {<br>
            return new Fraction(a.z * b.n + a.n * b.z, a.n * b.n);<br>
        }<br>
        public static Fraction operator *(Fraction a, Fraction b)<br>
        {<br>
            return new Fraction(a.z * b.z, a.n * b.n);<br>
        }<br>
        public int CompareTo(object obj)<br>
            {<br>
            Fraction f = (Fraction)obj;<br>
            if ((float)z / n < (float)f.z / f.n)<br>
                return -1;<br>
            else if ((float)z / n > (float)f.z / f.n)<br>
                return 1;<br>
            else<br>
                return 0;<br>
        }<br>
        public override string ToString()<br>
        {<br>
            return z + "/" + n;<br>
        }<br>
    }<br>
    class IComplnterface<br>
    {<br>
          public static void Main()<br>
        {<br>
            Fraction[] a =<br>
            {<br>
                   new Fraction(5,2),<br>
                   new Fraction(29,6),<br>
                   new Fraction(4,5),<br>
                   new Fraction(10,8),<br>
                   new Fraction(34,7)<br>
            };<br>
            Array.Sort(a);<br>
            Console.WriteLine("Implementing theIcomparable Interface in " + "Displaying Fractions :");<br>
            foreach(Fraction f in a)<br>
            {<br>
                Console.WriteLine(f + "");<br>
            }<br>
            Console.WriteLine();<br>
            Console.ReadLine();<br>
        }<br>
    }<br>
}<br>

![image](https://user-images.githubusercontent.com/97940058/155669226-b5f42553-72d8-473b-bd05-b511bd49e6bf.png)


*14.c# program to create thread pools*


using System;<br>
using System.Threading;<br>
namespace Exercises<br>
{<br>
    class ThreadPoolProg<br>
    {<br>
        public void ThreadFun1(object obj)<br>
        {<br>
            int loop = 0;<br>
            for (loop = 0; loop <= 4; loop++)<br>
            {<br>
                Console.WriteLine("Thread1 is executing");<br>
            }<br>
        }<br>
        public void ThreadFun2(object obj)<br>
        {<br>
            int loop = 0;<br>
            for (loop = 0; loop <= 4; loop++)<br>
            {<br>
                Console.WriteLine("Thread2 is executing");<br>
            }<br>
        }<br>
        public static void Main()<br>
        {<br>
            ThreadPoolProg TP = new ThreadPoolProg();<br>
            for (int i = 0; i < 2; i++)<br>
            {<br>
                ThreadPool.QueueUserWorkItem(new WaitCallback(TP.ThreadFun1)); ThreadPool.QueueUserWorkItem(new WaitCallback(TP.ThreadFun2));<br>
            }<br>
            Console.ReadKey();<br>
        }<br>
    }<br>
}<br>

![image](https://user-images.githubusercontent.com/97940058/155670530-44831a9c-446a-44b7-8b52-b8660f12dad5.png)
<br>
<br>
<br>
*15.c# program to demonstate error handling using Try, Catch and Finnaly block*



using System;<br>
namespace Exercises<br>
{<br>
    class ExceptionHandling<br>
    {<br>
        static void Main(string[] args)<br>
        {<br>
            Age a = new Age();<br>
            try<br>
            {<br>
                a.displayAge();<br>
            }<br>
            catch (AgeIsNegativeException e)<br>
            {<br>
                Console.WriteLine("AgeIsNegativeException: {0}", e.Message);<br>
            }<br>
            finally<br>
            {<br>
                Console.WriteLine("Execution of Finally block is done.");<br>
            }<br>
        }<br>
    }<br>
}<br>
public class AgeIsNegativeException : Exception<br>
{<br>
    public AgeIsNegativeException(string message) : base(message)<br>
    {<br>
    }<br>
}<br>
public class Age<br>
{<br>
    int age = -5;<br>
    public void displayAge()<br>
    {<br>
        if (age < 0)<br>
        {<br>
            throw (new AgeIsNegativeException("Age cannot be negative"));<br>
        }<br>
        else<br>
        {<br>
            Console.WriteLine("Age is: {0}", age);<br>
        }<br>
    }<br>
}<br>

![image](https://user-images.githubusercontent.com/97940058/155671934-c2cbd361-ddb8-457a-9967-efc3fb45c4e2.png)

*16.c# program to generate fibonacci numbers*

using System;<br>
namespace Exercises<br>
{<br>
    public class FibonacciExample<br>
    {<br>
        public static void Main(string[] args)<br>
        {<br>
            int n1 = 0, n2 = 1, n3, i, number;<br>
            Console.Write("Enter the number of elements: ");<br>
            number = int.Parse(Console.ReadLine());<br>
            Console.Write(n1 + " " + n2 + " ");<br>
            for (i = 2; i < number; ++i)<br>
            {<br>
                n3 = n1 + n2;<br>
                Console.Write(n3 + " ");<br>
                n1 = n2;<br>
                n2 = n3;<br>
            }<br>
        }<br>
    }<br>
}<br>

![image](https://user-images.githubusercontent.com/97940058/155935301-4408ee25-243e-4881-86fd-a952c733c734.png)

<br>
<br>
<br>
*17.c# program to check prime number*
using System;<br>
namespace Exercises<br>
{<br>
    public class FibonacciExample<br>
    {<br>
        public static void Main(string[] args)<br>
        {<br>
            int n1 = 0, n2 = 1, n3, i, number;<br>
            Console.Write("Enter the number of elements: ");<br>
            number = int.Parse(Console.ReadLine());<br>
            Console.Write(n1 + " " + n2 + " ");<br>
            for (i = 2; i < number; ++i)<br>    
            {<br>
                n3 = n1 + n2;<br>
                Console.Write(n3 + " ");<br>
                n1 = n2;<br>
                n2 = n3;<br>
            }<br>
        }<br>
    }<br>
}<br>


![image](https://user-images.githubusercontent.com/97940058/156500134-2c29073a-0860-4d60-ba23-c320be9871e3.png)
![image](https://user-images.githubusercontent.com/97940058/156500209-5118765f-77f0-4de7-9a74-34cb464e8512.png)


<br>
<br>
<br>
*18.c# program to check whether the given number is palindrome or not*
using System;<br>
public class PalindromeExample<br>
{<br>
    public static void Main(string[] args)<br>
    {<br>
        int n, r, sum = 0, temp;<br>
        Console.Write("Enter the Number: ");<br>
        n = int.Parse(Console.ReadLine());<br>
        temp = n;<br>
        while (n > 0)<br>
        {<br>
            r = n % 10;<br>
            sum = (sum * 10) + r;<br>
            n = n / 10;<br>
        }<br>
        if (temp == sum)<br>
            Console.Write("Number is Palindrome.");<br>
        else<br>
           Console.Write("Number is not Palindrome");<br>
    }<br>
}<br>

![image](https://user-images.githubusercontent.com/97940058/156502084-0461c64c-e6cb-4c04-b664-d1835fdda05d.png)
![image](https://user-images.githubusercontent.com/97940058/156502474-5e7f97af-11ff-460b-91a2-f7175ed27ac5.png)

<br>
<br>
<br>
<br>

*19.c# progrm to print factrocial of a number*
using System;<br>
public class FactorialExample<br>
{<br>
    public static void Main(string[] args)<br>
    {<br>
        int i, fact = 1, number;<br>
        Console.Write("Enter any Number: ");<br>
        number = int.Parse(Console.ReadLine());<br>
        for (i = 1; i <= number; i++)<br>
        {<br>
            fact = fact * i;<br>
        }<br>
        Console.Write("Factorial of " + number + " is: " + fact);<br>
    }<br>
}<br>

![image](https://user-images.githubusercontent.com/97940058/156502564-100ed17a-8ebb-4466-a445-45e5da8346f8.png)
<br>
<br>
<br>
*20.c# program to check Armstrong number*
using System;<br>
public class ArmstrongExample<br>
{<br>
    public static void Main(string[] args)<br>
    {<br>
        int n, r, sum = 0, temp;<br>
        Console.Write("Enter the Number= ");<br>
        n = int.Parse(Console.ReadLine());<br>
        temp = n;<br>
        while (n > 0)<br>
        {<br>
            r = n % 10;<br>
            sum = sum + (r * r * r);<br>
            n = n / 10;<br>
        }<br>
        if (temp == sum)<br>
            Console.Write("Armstrong Number.");<br>
        else<br>
            Console.Write("Not Armstrong Number.");<br>
    }<br>
}<br>

![image](https://user-images.githubusercontent.com/97940058/156503450-c09b64ac-c498-4195-85ca-1139c5be6af5.png)
![image](https://user-images.githubusercontent.com/97940058/156503540-f4df865a-a646-4294-8629-0673b4644ea6.png)
<br>
<br>
<br>
*21.c# program to print sum of digits*
using System;<br>
public class SumExample<br>
{<br>
    public static void Main(string[] args)<br>
    {<br>
        int n, sum = 0, m;<br>
        Console.Write("Enter a number: ");<br>
        n = int.Parse(Console.ReadLine());<br>
        while (n > 0)<br>
        {<br>
            m = n % 10;<br>
            sum = sum + m;<br>
            n = n / 10;<br>
        }<br>
        Console.Write("Sum is= " + sum);<br>
    }<br>
}<br>
![image](https://user-images.githubusercontent.com/97940058/156505146-3373c067-5916-4165-a455-9299d8002d8c.png)

<br>
<br>

*22.c# progrm to reverse a given number*
using System;<br>
public class ReverseExample<br>
{<br>
    public static void Main(string[] args)<br>
    {<br>
        int n, reverse = 0, rem;<br>
        Console.Write("Enter a number: ");<br>
        n = int.Parse(Console.ReadLine());<br>
        while (n != 0)<br>
        {<br>
            rem = n % 10;<br>
            reverse = reverse * 10 + rem;<br>
            n /= 10;<br>
        }<br>
        Console.Write("Reversed Number: " + reverse);<br>
    }<br>
}<br>
![image](https://user-images.githubusercontent.com/97940058/156505195-ea254dbd-7285-4e25-9ab7-8e9ec2c54d7b.png)





    







![image](https://user-images.githubusercontent.com/97940058/164618032-a4f64f45-2529-48ee-b50a-fb49d70cdc31.png)

















