using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //1
            int x = 5; int y = 6;
            if (x > y) { Console.WriteLine($"The largest number is x :  {x}"); }
            else { Console.WriteLine($"The largest number is y :  {y}"); };


            Console.WriteLine("The largest number is " + Math.Max(x, y));

            ////////////////////////////////////////////
           //2
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 > 0) { Console.WriteLine("The sign is: +"); }

            else { Console.WriteLine("The sign is : -"); };
            ///////////////////////////////
           //2
            int[] array = { 0, -1, 4 };
            Array.Sort(array);

            Console.WriteLine(array[0] + " " + array[1] + " " + array[2] + " ");
            //////////////////////////////////////////////
            //4
            int[] array1 = { -5, -2, -6, 0, -1 };
            Array.Sort(array1);
            int lastindex = array1.Length - 1;
            Console.WriteLine(array1[lastindex]);
            ////////////////////////////////////////////
           //5

            double speed = Convert.ToDouble(Console.ReadLine());
            double newSpeed = speed / 1.60934;
            Console.WriteLine(" To converts kilometers per hour to miles per hour : " + newSpeed);
            ////////////////////////////////////////////
           //6
            int hour = Convert.ToInt32(Console.ReadLine());
            int Convert1 = Convert.ToInt32(Console.ReadLine());
            int Converthour = hour * 60;
            int totalMintus = Converthour + Convert1;
            Console.WriteLine($"The total hour in min {totalMintus}");
            /////////////////////////////////////////////
//7
            int Hours1 = Convert.ToInt32(Console.ReadLine());

            int newHours1 = (Hours1 / 60);
            //هون الموديولاس بتقبل عددين صحيحين وبتقسمهم على بعض بس شو بتعمل بتوخد المتبقيمن القسمة يعني ما بتوخد العدد الصحيح لأ المتبقي
            int minutes = Hours1 % 60;
            Console.WriteLine($"{newHours1}Hours,{minutes}Minutes");
            //////////////////////////////////////////////
            //8
            string[] strings = { "Rawaah Abdullruhman", "I don't like cats", "These day,Iam trainee in Orange Academy", "I live in Bushra", "I'm VoiceOver" };
            Console.WriteLine(strings[0]);
            Console.WriteLine(strings[1]);
            Console.WriteLine(strings[2]);
            Console.WriteLine(strings[3]);
            Console.WriteLine(strings[4]);
            Console.WriteLine(strings[5]);
            Console.WriteLine($"{strings[0].Length}   {strings[1].Length}  {strings[2].Length}  {strings[3].Length}  {strings[4].Length}  {strings.Length}");










        }
    }
}
