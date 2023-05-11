using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace CollectionsMasterConsoleUI
{
    class Program
    {

        static void Main(string[] args)
        {
    
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //DONE: Create an integer Array of size 50

            int[] numbers1 = new int[50];


            //DONE: Create a method to populate the number array with 50 random numbers that are between 0 and 50

            numbers1 = randomArray(50);


                //DONE: Print the first number of the array

                Console.WriteLine(numbers1[0]);

                //DONE: Print the last number of the array
                Console.WriteLine(numbers1[49]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbers1);
            Console.WriteLine("-------------------");

            //DONE: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            Array.Reverse(numbers1);
            NumberPrinter(numbers1);
            

            //DONE: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            Console.WriteLine("-------------------");

            ThreeKiller(numbers1);
            NumberPrinter(numbers1);


            //DONE: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbers1);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //DONE: Create an integer List
            var integerlist = new List<int>();

            //DONE: Print the capacity of the list to the console
            Console.WriteLine(integerlist.Capacity);

            //DONE: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(integerlist);

            //TODO: Print the new capacity
            Console.WriteLine(integerlist.Capacity);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            bool inputType = false;
            int numInput;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                var Input = Console.ReadLine();


                if (int.TryParse(Input, out numInput))
                {
                    NumberChecker(integerlist, numInput);
                    inputType = true;
                }
                else
                {
                    Console.WriteLine("Nope!!! Please give a valid integer!!!");
                }

            } while (inputType == false);

    
            


            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(integerlist);
            Console.WriteLine("-------------------");


            //Done: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            OddKiller(integerlist);

            Console.WriteLine("------------------");

            //Done: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");

            integerlist.Sort();

            Console.WriteLine(integerlist);
            Console.WriteLine("------------------");

            //Done: Convert the list to an array and store that into a variable
            int[] listArray = integerlist.ToArray();

            //Done: Clear the list
            integerlist.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers1)
        {
            foreach (int j in numbers1)
            {
                if (j % 3 == 0)
                {
                    numbers1[j] = 0;
                }

            }
        }
        private static void OddKiller(List<int> integerlist)
        {
           for(int a = 0; a < 50; a++)
            {
                if(integerlist[a] % 2 != 0)
                {
                    integerlist.RemoveAt(a);
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine("The number is in the range!!!!");
            }
            else
            {
                Console.WriteLine("Your number is not in the range.");
            }
        }

        private static void Populater(List<int> numberList)
        {

            for(int i = 0; i < 51; i++)
            {
                Random rng = new Random();
                numberList.Add(rng.Next(50));
            }
        }

        private static int[] randomArray(int size1)
        {
             Random rand = new Random();
             int[] randArray = new int[size1];

             for (int i = 0; i < size1; i++)
             {
                 randArray[i] = rand.Next(0, size1);
             }

             return randArray;
        }

            private static void ReverseArray(int[] array)
        {
            
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
