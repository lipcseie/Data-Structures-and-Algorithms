using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltInList
{
    public class ListDemo
    {
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

        private static void LogCountAndCapacity(List<int> list)
        {
            Console.WriteLine($"Count={list.Count}. Capacity={list.Capacity}");
            // Count is the actual number of elemets contained ina list
            // Capacity shows how many items can be contained at least untill the next resix+zing
            // If we want to save some memory we have to call the trim access method explicitly
        }
    }
}
