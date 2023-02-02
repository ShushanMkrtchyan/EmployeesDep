using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesDep
{
    static class Extension
    {
        public static IEnumerable<T> GetByCondition<T>(this IEnumerable<T> list, Predicate<T> predicate)
        {
            foreach (T item in list)
            {
                if (predicate(item))
                {
                    yield return item;
                }
                else
                {
                    Console.WriteLine("Please try again. Valid Name");
                }
            }
        }
    }
}
