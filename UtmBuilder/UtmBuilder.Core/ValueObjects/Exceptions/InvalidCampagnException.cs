using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtmBuilder.Core.ValueObjects.Exceptions
{
    internal class InvalidCampagnException : Exception
    {
        private const string DefaultErrorMessage = "Invalid UTM parameters";

        public InvalidCampagnException(string message = DefaultErrorMessage)
            :base(message)
        {
        }

        public static void ThrowIfNull(string? item, string message = DefaultErrorMessage)
        {
            if (string.IsNullOrEmpty(item))
            {
                throw new InvalidCampagnException(message);
            }
        }
    }
}
