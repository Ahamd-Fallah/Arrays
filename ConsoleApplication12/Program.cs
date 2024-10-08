using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length of Array:");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            int select = 1;
            while (select!=7)
            {
                Console.Clear();
                Console.WriteLine("1-input");
                Console.WriteLine("2-Show");
                Console.WriteLine("3-Sort");
                Console.WriteLine("4-Reverse");
                Console.WriteLine("5-Linear Search");
                Console.WriteLine("6-Binary Search");
                Console.WriteLine("7-Exit");
                Console.WriteLine("please select one of this items(1-7)");
                select = int.Parse(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        int i = 0;
                        for ( i=0; i < arr.Length; i++)
                        {
                            Console.Write("Enter array[{0}]: ",i+1);
                            arr[i] = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 2:
                        Console.WriteLine("*******array is*********");
                        for ( i = 0; i < arr.Length; i++)
                        {
                            Console.Write("{0,-4}",arr[i]);
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Array.Sort(arr);
                        Console.WriteLine("array sorted press any key to continue");
                        Console.ReadKey();
                        break;
                    case 4:
                        Array.Reverse(arr);
                        Console.WriteLine("array reversed press any key to continue");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Write("enter a number for search: ");
                        int key = int.Parse(Console.ReadLine());
                        bool found = false;
                        for ( i = 0; i < arr.Length; i++)
                        
                           if (arr[i] == key)
                            {
                                found = true;
                                break;
                            }
                        if (!found)
                        {
                            Console.WriteLine("not found : ");
                        }
                        else
                        {
                            Console.WriteLine("founded in {0}", i + 1);
                        }

                            Console.ReadKey();
                        
                        break;
                    case 6:
                        Console.Write("enter a number for search: ");
                         key = int.Parse(Console.ReadLine());
                         Array.Sort(arr);
                         int result = Array.BinarySearch(arr, key);
                        if(result<0)
                            Console.WriteLine("not found");
                        else
                            Console.WriteLine("founded in {0}",result);
                        Console.ReadKey();
                        break;
                    case 7:
                        break;
                    default:
                        select = 1;
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
