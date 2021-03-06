using System;

namespace Symas.Core.Validation
{
    public static class ArgumentExtensions
    {
        public static ArgumentValidation<T> RequireThat<T>(this T item)
        {
            return new ArgumentValidation<T>(item, nameof(item));
        }
    }
}
