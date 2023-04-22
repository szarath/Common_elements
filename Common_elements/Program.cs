using System;

namespace Common_elements
{
    class Program
    {
        public static void Main(string[] args)
        {

            // Create two integer arrays, list1 and list2
            int[] list1 = new int[] { 1, 2, 3, 4, 5 };
            int[] list2 = new int[] { 3, 4, 5, 6, 7 };

            // Find the common elements in both lists and store them in list3
            var list3 = list1.Intersect(list2);
            Console.WriteLine("Common elements in both lists: " + string.Join(" ", list3));

            // Find the elements in list1 that do not appear in list2 and store them in list4
            var list4 = list1.Except(list2);
            Console.WriteLine("Elements in List1 that do not appear in List2: " + string.Join(" ", list4));

            // Find the elements in list2 that do not appear in list1 and store them in list5
            var list5 = list2.Except(list1);
            Console.WriteLine("Elements in List2 that do not appear in List1: " + string.Join(" ", list5));

            // Prompt the user to press enter to continue
            Console.WriteLine("Press <ENTER> to continue");
            Console.ReadLine();
        }
    }
}
