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
            int[] searchArr = { 11, 12, 43, 57, 87, 93, 101, 129, 134, 156, 178, 190 };
            Console.WriteLine(string.Join(",", searchArr));
            bool found = false;
            Char choice = 'Y';
            do
            {
                Console.Write("Please enter the element to be searched:");
                //Element to be searched 
                string searchElement = Console.ReadLine();
                int s = 0;
                if (!int.TryParse(searchElement, out s))
                {
                    Console.WriteLine("Invalid input");
                    return;
                }
                int usefulArrLength = searchArr.Length;
                int middleIndex = usefulArrLength % 2 == 0 ? (usefulArrLength / 2) : (usefulArrLength + 1) / 2;
                do
                {

                    if (searchArr[middleIndex - 1] > s)
                    {
                        if (middleIndex > 1)
                            middleIndex = middleIndex % 2 == 0 ? (middleIndex / 2) : (middleIndex + 1) / 2;
                        else break;
                    }
                    else if (searchArr[middleIndex - 1] < s)
                    {
                        middleIndex = middleIndex + (middleIndex % 2 == 0 ? (middleIndex / 2) : (middleIndex + 1) / 2);
                    }
                    else
                    {
                        Console.WriteLine(string.Format("Element {0} found at position {1}", s, middleIndex));
                        found = true;
                        break;
                    }
                }
                while (middleIndex < searchArr.Length);
                if(!found)Console.WriteLine(string.Format("Element {0} not found", s));
                Console.WriteLine("Continue? Y/N");
                choice = Console.ReadLine()[0];
            } while (choice == 'Y' || choice == 'y');
            return;
        }
    }
}
