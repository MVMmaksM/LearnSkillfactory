using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9
{
    internal class SortList
    {        
        public event Func<string[], string[]> SortAscending;
        public event Func<string[], string[]> SortDescending;
        public void OnSortArray(int sortNumber, ref string[] lastNames)
        {           
            if (sortNumber == 1)
            {
                SortAscending?.Invoke(lastNames);
            }
            else if (sortNumber == 2)
            {
                SortDescending?.Invoke(lastNames);
            }
            else
            {
                throw new ArgumentException("\nНеверный аргумент сортировки!");
            }
        }
    }
}
