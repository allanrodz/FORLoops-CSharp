using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;

            Console.WriteLine("***********Array Revision*******\n\n");

            Console.Write("Enter size of array: ");
            int arraySize = int.Parse(Console.ReadLine());

            string[] names = new string[arraySize];

            for (i = 0; i < names.Length ; i++)
            {

                Console.Write("\nEnter name: ");
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("\n\n******************");

            foreach (string s in names)
            {

                Console.WriteLine(s);
            }


            //------------------------------------------------------------------------------//

            Console.WriteLine("**********More LOOPS and ARRAYS*************\n");
            


            Console.Write("Set the size of the ARRAY: ");
            int size = int.Parse(Console.ReadLine());

            int[] nums = new int[size];

            for (i = 0; i < nums.Length; i++)
            {
                Console.Write("Enter a number for index {0}:  ", i);
                int n = int.Parse(Console.ReadLine());
                nums[i] = n;
            }

            Console.WriteLine("I'm out of the loop.");

            for (j = 0; j < nums.Length; j++)
            {
                if (nums[j] % 2 == 0)
                {
                    Console.WriteLine("Index position {0} is an even number {1}", j, nums[j]);

                }
                else
                {

                    Console.WriteLine("Index position {0} is an odd number {1}", j, nums[j]);

                }

            }

            Console.WriteLine("I'm out of the loop.");

            //----------------------------------------------------------------------------//

            int[] nums1 = { 3, 7, 16, 9, 10, 25, 4 };

            Array.Sort(nums1);
            Console.WriteLine(nums1[2]);
            Console.WriteLine("\n***************\n");

            String[] names1 = { "joe", "mary", "pat", "Jim", "Barbara" };
            Array.Sort(names1);

            for (i = 0; 1 < names1.Length; i++)
            {

                Console.WriteLine("Element  " + names1[i]);
            }


            Console.ReadLine();

            //----------------------------------------------------------------------------//

            Console.WriteLine("********* Array Exercise 1 **********\n");
            
            string[] mynames = new string[3];

            mynames[0] = "Joe";
            mynames[1] = "Tom";
            mynames[2] = "Bill";

            for (i = 0; 1 < mynames.Length; i++)
            {
                Console.WriteLine(mynames[i]);
            }

            Console.WriteLine("i'm out of the loop.");

            Console.ReadLine();
        }
    }
}
