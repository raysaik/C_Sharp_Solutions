using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            //A sorted Array
            int[] searchArr = { 11, 12, 43, 57, 87, 93, 101, 129, 134, 156, 178, 190, 213, 214, 666, 888, 999 };
            Console.WriteLine(string.Join(",", searchArr));
            int upperBoundary; int lowerBoundary;
            bool found = false;
            Char choice = 'Y';

            do
            {
                found = false;
                upperBoundary = searchArr.Length; lowerBoundary = 0;
                Console.Write("Please enter the element to be searched:");
                //Element to be searched 
                string searchElement = Console.ReadLine();
                int s = 0;
                if (!int.TryParse(searchElement, out s))
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                int usefulArrLength = searchArr.Length;
                int middleIndex = 0;
                do
                {
                    middleIndex = (upperBoundary + lowerBoundary) % 2 == 0 ? ((upperBoundary + lowerBoundary) / 2) : ((upperBoundary + lowerBoundary + 1) / 2);
                    if (s < searchArr[middleIndex - 1])
                    {
                        if (middleIndex == 1 || middleIndex == upperBoundary) //means the first element has been searched OR the upperboundary has already been serached
                            break; 
                        upperBoundary = middleIndex;
                    }
                    else if (s > searchArr[middleIndex - 1])
                    {
                        if (middleIndex == searchArr.Length || middleIndex == upperBoundary) //means the last elment has been searched
                            break;
                        lowerBoundary = middleIndex;
                    }
                    else
                    {
                        Console.WriteLine(string.Format("Element {0} found at position {1}", s, middleIndex));
                        found = true;
                        break;
                    }
                }
                while (upperBoundary != (lowerBoundary));
                if(!found)Console.WriteLine(string.Format("Element {0} not found", s));
                Console.Write("Continue? Y/N : ");
                choice = Console.ReadLine()[0];
            } while (choice == 'Y' || choice == 'y');
            return;
        }

        
    }
}
