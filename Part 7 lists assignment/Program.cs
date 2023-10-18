using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Part_7_lists_assignment
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random generator = new Random();
            List<int> nums = new List<int>() {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24};
            int fin = 0;
            int choose;
            bool done = false;
            while (!done)
            {

                if (fin <= 24)
                {

                    for (int i = 0; i < nums.Count; i++)
                    {
                        nums[i] = generator.Next(10, 21);
                        Console.Write(nums[i] + " ");
                        fin = fin + 1;
                    }
                }
                else if (fin == 25)
                {
                    done = true;
                }
            }
            fin = 0;
            done = false;
            while (!done)
            {
                Console.WriteLine();
                Console.WriteLine("Please choose one of the following.");
                Console.WriteLine("1. Sort");
                Console.WriteLine("2. New Numbers");
                Console.WriteLine("3. Remove");
                Console.WriteLine("4. Add");
                Console.WriteLine("5. Count One Number");
                Console.WriteLine("6. Show Largest");
                Console.WriteLine("7. Show Smallest");
                Console.WriteLine("8. The Sum And Average");
                Console.WriteLine("9. Show Most Frequent");
                Console.WriteLine("10. How Often A Number Occurs");
                Console.WriteLine("11. Quit");
                choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 1)
                {
                    nums.Sort();
                    Console.WriteLine(nums[0] + " " + nums[1] + " " + nums[2] + " " + nums[3] + " " + nums[4] + " " + nums[5] + " " + nums[6] + " " + nums[7] + " " + nums[8] + " " + nums[9] + " " + nums[10] + " " + nums[11] + " " + nums[12] + " " + nums[13] + " " + nums[14] + " " + nums[15] + " " + nums[16] + " " + nums[17] + " " + nums[18] + " " + nums[19] + " " + nums[20] + " " + nums[21] + " " + nums[22] + " " + nums[23] + " " + nums[24]);
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (choose == 2)
                {
                    while (!done)
                    {

                        if (fin <= 24)
                        {

                            for (int i = 0; i < nums.Count; i++)
                            {
                                nums[i] = generator.Next(10, 21);
                                Console.Write(nums[i] + " ");
                                fin = fin + 1;
                            }
                        }
                        else if (fin == 25)
                        {
                            done = true;
                        }
                    }
                    fin = 0;
                    done = false;
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (choose == 3)
                {
                    Remove();
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (choose == 4)
                {
                    Add();
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (choose == 5)
                {
                    Count();
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (choose == 6)
                {
                    nums.Sort();
                    Console.WriteLine(nums[24]);
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (choose == 7)
                {
                    nums.Sort();
                    Console.WriteLine(nums[0]);
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (choose == 8)
                {
                    SumAndAverage();
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (choose == 9)
                {
                    MostFrequent();
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (choose == 10)
                {
                    SelectOccurrensses();
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (choose == 11)
                {
                    Console.WriteLine("Goodbye");
                    done = true;
                }
                else if (choose >= 12 || choose <= 0)
                {
                    Console.WriteLine("Error! Input invalid!");
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }
        public static void Remove()
        {
            Console.Write("Please pick a number to remove: ");
            int remove = Convert.ToInt32(Console.ReadLine());
        }
        public static void Add()
        {

        }
        public static void Count()
        {

        }
        public static void SumAndAverage()
        {

        }
        public static void MostFrequent()
        {

        }
        public static void SelectOccurrensses()
        {

        }
    }
}
