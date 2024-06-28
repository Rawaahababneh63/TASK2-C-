using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //1 - Correct the syntax error:
            //            •	string[] ARR = [1, 7  9  45,]
            int[] ARR = { 1, 7, 9, 4, 5 };
            for (int i = 0; i < ARR.Length; i++) { Console.WriteLine(ARR[i]); }

            Console.WriteLine("              ");
            //•	int arr2 = ["Str" "alex","moh"

            string[] arr2 = {"Str", "alex", "moh"};
            Console.WriteLine(arr2[0]);
            //•	string arr3= 'the','fox' 'over' lazy, 'dog',  ]
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };

            ////////////////////////////////////////////////////////////////
            //            2 - What the index of "Banana","Tomato" ?
            String[] fruits = { "Tomato", "Banana", "Watermelon" };
            Console.WriteLine(Array.IndexOf(fruits,"Banana"));
            Console.WriteLine(Array.IndexOf(fruits,"Tomato"));
            Console.WriteLine("              ");
            /////////////////////////////////////////////////////////////////

            //            3 - Create an multiple arrays that represents your:
            //•	Favorite Food(5 item)
            //•	Favorite Sport(3 item)
            //•	Favorite Movie(4 item)
            //Then, print each array using foreach, and Loop Through an Array
            //a
            string[] FavoriteFood = { "Kabsah", "Mandi", "shawrmah", "fahita", "pitza" };
            foreach (string food in FavoriteFood) { Console.WriteLine(food); }

            for (int i = 0;i <FavoriteFood.Length;i++) {  Console.WriteLine(FavoriteFood[i]);}
            Console.WriteLine("              ");
            //b
            string[] FavoriteSport = { "football", "basketball", "Gym" };
           foreach(string sport in FavoriteSport){ Console.WriteLine(sport);}
            //c
            Console.WriteLine("              ");
            string[] moves = { "move1", "move2", "move3", "move4" };
            foreach(string move in moves) {Console.WriteLine(move); }
            //////////////////////////////////////////////////////
            Console.WriteLine("              ");

            //            1 - Write a program in C# to calculate the sum of three numbers with getting input in one line separated by a comma
            //•	Expected Output:
            //•	Input three numbers separated by comma: 5,10,15
            //•	The sum of three numbers: 30.
            int num1 =Convert.ToInt32( Console.ReadLine());
            int num2 =Convert.ToInt32( Console.ReadLine());
            int num3 =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine(num1+num2+num3);
            ////////////////////////////////////////////////////////
            Console.WriteLine("              ");
            //            5 - Write a program in C# to display the n terms of odd number and their sum from [1- 100 ]. 
            //•	Test Data
            //•	The odd numbers are1 3 5 7 9 11 13 15 17 19……
            //•	The Sum of odd Numbers is: …...
            int x = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i+" ");
           
                }
            }
            Console.WriteLine("      ");
            //for print sum of odd number

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0) { 
                
                    x = x + i;


                    Console.Write(x+"   ");
                }
            }
            /////////////////////////////////////  
            Console.WriteLine("      ");


//            6 - Write a program in C## to display the pattern like right angle triangle using an asterisk. Go to the editor
//The pattern like:
//   *
//  **
// ***
//****

            for(int i = 1;i <=4; i++)
            {
                for(int j = 1; j <=4- i; j++)
                {
                    Console.Write(" ");
                }
                for(int m =1; m <=i; m++) { 
                Console.Write("*");
                }

                Console.WriteLine(" ");
            }

            /////////////////////////////////////  
            Console.WriteLine("      ");


            //            -Write a program in C# to make such a pattern like right angle triangle with number increased by 1. Go to the editor
            //The pattern like




            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4 - i; j++)
                {
                    Console.Write(" ");
                }
               
                for (int t = 1; t < i * 2; t++) { 
                    Console.Write(t);
               
            }
            Console.WriteLine();
            }








        }
    }
}
