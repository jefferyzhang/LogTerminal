using System;
using System.Collections.Generic;
using System.Linq;

namespace LogTerminal.Infrastructure
{
    public static class EnumerableExt
    {
        public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> source, bool condition, Predicate<T> predicate)
        {
            return condition ? source.Where(x => predicate(x)) : source;
        }
    }
}
