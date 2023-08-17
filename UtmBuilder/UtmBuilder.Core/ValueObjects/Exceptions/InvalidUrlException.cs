using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UtmBuilder.Core.ValueObjects.Exceptions
{
    //derivar de exception
    internal partial class InvalidUrlException : Exception
    {
        //message
        private const string DefaultErrorMessage = "Invalid Url";
        
        public InvalidUrlException(string message = DefaultErrorMessage)
            : base(message)
        {

        }

        public static void ThrowIfInvalid(string address, string message = DefaultErrorMessage)
        {
            if (string.IsNullOrEmpty(address))
                throw new InvalidUrlException(message);

            //teste da url
            if (!UrlRegex().IsMatch(address))
                throw new InvalidUrlException("");
        }

        //novo comando do net7 para regular expression
        //ESTUDAR
        [GeneratedRegex("^(http|https):(\\/\\/www\\.|\\/\\/www\\.|\\/\\/|\\/\\/)[a-z0-9]+([\\-\\.]{1}[a-z0-9]+)*\\.[a-z]{2,5}(:[0-9]{1,5})?(\\/.*)?$|(http|https):(\\/\\/localhost:\\d*|\\/\\/127\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]))(:[0-9]{1,5})?(\\/.*)?$")]
        private static partial Regex UrlRegex();
    }


}
