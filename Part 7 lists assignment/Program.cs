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
                Console.WriteLine("9. How Often A Number Occurs");
                Console.WriteLine("10. Quit");
                choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 1)
                {
                    nums.Sort();
                    foreach (int i in nums)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (choose == 2)
                {
                    while (!done)
                    {

                        if (fin < nums.Count)
                        {

                            for (int i = 0; i < nums.Count; i++)
                            {
                                nums[i] = generator.Next(10, 21);
                                Console.Write(nums[i] + " ");
                                fin = fin + 1;
                            }
                        }
                        else if (fin == nums.Count)
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
                    Console.Write("Please input a number to remove:");
                    int remove = Convert.ToInt32(Console.ReadLine());
                    nums.Remove(remove);
                    foreach (int i in nums)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (choose == 4)
                {
                    Console.Write("Please input a number to add:");
                    int[] add = new int[] {Convert.ToInt32(Console.ReadLine())};
                    nums.AddRange(add);
                    foreach (int i in nums)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (choose == 5)
                {
                    Console.Write("Please input a number and I'll show you how many times it appears:");
                    int count = Convert.ToInt32(Console.ReadLine());
                    nums.Sort();
                    nums.FindAll(x => x == count);
                    Console.WriteLine(nums.FindAll(x => x == count));
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (choose == 6)
                {
                    nums.Sort();
                    nums.Reverse();
                    Console.WriteLine(nums[0]);
                    nums.Sort();
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
                    Console.Write("The sum of all the numbers are: ");
                    
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (choose == 9)
                {
                    SelectOccurrensses();
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (choose == 10)
                {
                    Console.WriteLine("Goodbye");
                    done = true;
                }
                else if (choose >= 11 || choose <= 0)
                {
                    Console.WriteLine("Error! Input invalid!");
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }

        public static bool FindLast(List<int> nums)
        {
            throw new NotImplementedException();
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
