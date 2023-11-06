using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
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
                Console.WriteLine("8. Quit");
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
                    Console.Write("Please input a number to remove: ");
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
                    Console.Write("Please input a number to add: ");
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
                    bool ff = false;
                    while (!ff)
                    {
                        Console.Write("Please input a number and I'll tell you if it's in the list: ");
                        int numTC = Convert.ToInt32(Console.ReadLine());
                        if (nums.Contains(numTC))
                        {
                            Console.WriteLine($"{numTC} is in the list.");
                            ff = true;
                        }
                        else if (!nums.Contains(numTC))
                        {
                            Console.WriteLine($"{numTC} is not in the list.");
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                    }
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
                    Console.WriteLine("Goodbye");
                    done = true;
                }
                else if (choose >= 9 || choose <= 0)
                {
                    Console.WriteLine("Error! Input invalid!");
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Veggies();
        }

        public static void Veggies()
        {
            List<string> veggies = new List<string>() {"CARROT", "BEET", "CELERY", "RADISH", "CABBAGE"};
            bool done = false;
            int stuck = 0;
            string release;
            while (!done)
            {
                Console.WriteLine();
                Console.WriteLine();
                for (int i = 0; i < veggies.Count; i++)
                {
                    Console.WriteLine($"{i + 1} {veggies[i]}");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Please select one of the following:");
                Console.WriteLine("1. Remove (number)");
                Console.WriteLine("2. Remove (name)");
                Console.WriteLine("3. Search");
                Console.WriteLine("4. Add");
                Console.WriteLine("5. Sort");
                Console.WriteLine("6. Clear");
                Console.WriteLine("7. Quit");
                int select = Convert.ToInt32(Console.ReadLine());
                while (select == 1)
                {
                    Console.Write("Pick a number and I'll remove that item from the list: ");
                    int remove1 = Convert.ToInt32(Console.ReadLine());
                    remove1 = remove1 - 1;
                    if (remove1 >= 0 && remove1 <= veggies.Count)
                    {
                        veggies.RemoveAt(remove1);
                        select = 0;
                    }
                    else if (remove1 <= -1 || remove1 >= (veggies.Count + 1))
                    {
                        Console.WriteLine("INVALID NUMBER!");
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }
                while (select == 2)
                {
                    Console.Write("Pick a name and I'll remove that item from the list: ");
                    string remove2 = Console.ReadLine().ToUpper();
                    if (veggies.Contains(remove2))
                    {
                        veggies.Remove(remove2);
                        select = 0;
                    }
                    else if (!veggies.Contains(remove2))
                    {
                        Console.WriteLine("INVALID NAME!");
                        Console.WriteLine();
                        Console.WriteLine();
                        stuck = stuck + 1;
                        if (stuck == 20)
                        {
                            Console.WriteLine("Are you stuck? If so please type Y if not type N: ");
                            release = Console.ReadLine().ToUpper();
                            if (release == "Y")
                            {
                                select = 0;
                            }
                            else
                            {
                                stuck = 0;
                            }
                        }
                    }
                }
                while (select == 3)
                {
                    Console.Write("Pick an item by name and I'll search for it: ");
                    string search = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                    if (veggies.Contains(search))
                    {
                        Console.Write($"{search} is in the list. it's number {veggies.IndexOf(search) + 1}");
                        select = 0;
                    }
                    else if (!veggies.Contains(search))
                    {
                        Console.WriteLine("INVALID NAME!");
                        Console.WriteLine();
                        Console.WriteLine();
                        stuck = stuck + 1;
                        if (stuck == 20)
                        {
                            Console.WriteLine("Are you stuck? If so please type Y if not type N: ");
                            release = Console.ReadLine().ToUpper();
                            if (release == "Y")
                            {
                                select = 0;
                            }
                            else
                            {
                                stuck = 0;
                            }
                        }
                    }
                }
                while (select == 4)
                {
                    Console.Write("Write a name and I'll add that item from the list: ");
                    string add = Console.ReadLine().ToUpper();
                    if (!veggies.Contains(add))
                    {
                        veggies.Add(add);
                        select = 0;
                    }
                    else if (veggies.Contains(add))
                    {
                        Console.WriteLine("INVALID! Already in list.");
                        Console.WriteLine();
                        Console.WriteLine();
                        stuck = stuck + 1;
                        if (stuck == 20)
                        {
                            Console.WriteLine("Are you stuck? If so please type Y if not type N: ");
                            release = Console.ReadLine().ToUpper();
                            if (release == "Y")
                            {
                                select = 0;
                            }
                            else
                            {
                                stuck = 0;
                            }
                        }
                    }
                }
                while (select == 5)
                {
                    veggies.Sort();
                    select = 0;
                }
                while (select == 6)
                {
                    veggies.Clear();
                    select = 0;
                }
                while (select == 7)
                {
                    done = true;
                    Console.WriteLine("Goodbye.");
                    select = 0;
                }
            }
        }
    }
}
