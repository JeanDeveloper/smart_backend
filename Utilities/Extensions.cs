using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smart_backend.Utilities
{
    public static class Extensions
    {
        public static bool IsNull(this object value) => value == null;

        public static bool IsNotNull(this object value) => !IsNull(value);

        public static bool IsEmpty<T>(this ICollection<T> value) => value.Count == 0;

        public static bool IsEmpty<T>(this IEnumerable<T> value) => !value.Any();

        public static bool IsNotEmpty<T>(this ICollection<T> value) => !value.IsEmpty();

        public static bool IsNotEmpty<T>(this IEnumerable<T> value) => !value.IsEmpty();

        public static bool IsNullOrEmpty<T>(this ICollection<T> value) => value.IsNull() || value.IsEmpty();

    }
}
