using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltInList
{
    public class ListDemo
    {
        public class Customer
        {
            public string Name { get; set; }

            public DateTime  BirthDate { get; set; }
        }
        public static void Run()
        {
            List<int> list = new List<int>();
            // List<string> listOfStrings = new List<string>();
            LogCountAndCapacity(list);

            for (int i = 0; i < 16; i++)
            {
                list.Add(i);
                LogCountAndCapacity(list);
            }
            for (int i = 10;i > 0; i--)
            {
                list.RemoveAt(i - 1);
                LogCountAndCapacity(list);
            }

            // Sets the capacity of this list to the size of the list. This method can
            // be used to minimize a list's memory overhead once it is known that no
            // new elements will be added to the list.
            list.TrimExcess();
            LogCountAndCapacity(list);

            list.Add(1);
            LogCountAndCapacity(list);

        }

        public static void ApiMembers()
        {
            var list = new List<int>() { 1, 0, 5, 3, 4, 5, 6, };
            list.Sort();

            int indexBinSearch = list.BinarySearch(3);
            list.Reverse();

            ReadOnlyCollection<int> readOnlyList = list.AsReadOnly();

            int[] array = list.ToArray();

            var listCustomers = new List<Customer>
            {
                new Customer {BirthDate = new DateTime(1978,08,09), Name= "Frodo"},
                new Customer {BirthDate = new DateTime(1977,07,05), Name= "Samu"},
                new Customer {BirthDate = new DateTime(1903,03,06), Name= "Gandalf"}
            };
            listCustomers.Sort((left, right) =>
            {
                if (left.BirthDate > right.BirthDate)
                    return 1;
                if (right.BirthDate > left.BirthDate)
                    return -1;
                return 0;
            });
        }
            
        private static void LogCountAndCapacity(List<int> list)
        {
            Console.WriteLine($"Count={list.Count}. Capacity={list.Capacity}");
            // Count is the actual number of elemets contained ina list
            // Capacity shows how many items can be contained at least untill the next resix+zing
            // If we want to save some memory we have to call the trim access method explicitly
        }
    }
}
