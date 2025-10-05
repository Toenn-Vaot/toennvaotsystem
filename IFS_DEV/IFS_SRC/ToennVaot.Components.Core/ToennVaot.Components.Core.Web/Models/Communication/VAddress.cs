using System.Text;

namespace ToennVaot.Components.Core.Web.Models.Communication
{
    /// <summary>
    /// Represents an address in <see cref="VCard"/>
    /// </summary>
    public class VAddress
    {
        /// <summary>
        /// The type of address
        /// </summary>
        public VAddressTypeEnum TypeEnum { get; set; }

        /// <summary>
        /// The full street name address
        /// </summary>
        public string StreetAddress { get; set; }

        /// <summary>
        /// the postal code
        /// </summary>
        public string Zip { get; set; }

        /// <summary>
        /// The city name
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// The country name
        /// </summary>
        public string CountryName { get; set; }

        /// <inheritdoc />
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append("ADR;" + TypeEnum + ";PREF:;;");
            builder.Append(StreetAddress + ";");
            builder.Append(City + ";;");
            builder.Append(Zip + ";");
            builder.AppendLine(CountryName);

            return builder.ToString();
        }
    }
}