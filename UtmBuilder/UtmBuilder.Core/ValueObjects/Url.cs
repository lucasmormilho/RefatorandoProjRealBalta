using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects
{
    public class Url : ValueObject
    {

        /// <summary>
        /// Create a new URL
        /// </summary>
        /// <param name="address">Address of URL (Website link)</param>
        public Url(string address)
        {
            Address = address;
            InvalidUrlException.ThrowIfInvalid(address);
            //aqui aplica-se dois testes de sim e não
        }

        /// <summary>
        /// Address of URL (Website link)
        /// </summary>
        public string Address { get; } //remove o set para ficar restrito ou colocar o private

    }
}
