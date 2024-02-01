using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTask2
{
    internal class Sort
    {
        public delegate void SortDelegate(List<string> list);

        public event SortDelegate? SortDelegateEvent;
        public void SortList(List<string> list)
        {
            list = list.OrderBy(x => x).ToList();

            foreach (string s in list) { Console.WriteLine(s); }

            SortDelegateEvent?.Invoke(list);
        }
        public void RevSortList(List<string> list)
        {
            list = list.OrderByDescending(x => x).ToList();

            foreach (var s in list) { Console.WriteLine(s); }

            SortDelegateEvent?.Invoke(list);

        }

    }
}
