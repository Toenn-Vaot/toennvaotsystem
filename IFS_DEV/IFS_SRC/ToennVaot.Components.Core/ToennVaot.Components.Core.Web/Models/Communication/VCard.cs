using System.Text;

namespace ToennVaot.Components.Core.Web.Models.Communication
{
    /// <summary>
    /// Represents an electronic business card.
    /// </summary>
    /// <remarks>vCard is a standard format of personal data exchange which is normalized by RFC 6350 and 6868</remarks>
    public class VCard
    {
        /// <summary>
        /// The civility prefix
        /// </summary>
        public string Civility { get; set; }

        /// <summary>
        /// The first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The organization name
        /// </summary>
        public string Organization { get; set; }

        /// <summary>
        /// The service name
        /// </summary>
        public string Service { get; set; }

        /// <summary>
        /// The job title
        /// </summary>
        public string JobTitle { get; set; }

        /// <summary>
        /// The home address
        /// </summary>
        public VAddress HomeAddress { get; set; }

        /// <summary>
        /// The business address
        /// </summary>
        public VAddress BusinessAddress { get; set; }

        /// <summary>
        /// The birthdate
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// The personal phone number
        /// </summary>
        public string PersonalPhone { get; set; }

        /// <summary>
        /// The business phone number
        /// </summary>
        public string BusinessPhone { get; set; }

        /// <summary>
        /// The mobile phone number
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// The personal email address
        /// </summary>
        public string AlternativeEmail { get; set; }

        /// <summary>
        /// The business email address
        /// </summary>
        public string PreferredEmail { get; set; }

        /// <summary>
        /// The personal homepage URL
        /// </summary>
        public string PersonalHomePage { get; set; }

        /// <summary>
        /// The business homepage URL
        /// </summary>
        public string BusinessHomePage { get; set; }

        /// <summary>
        /// The image content bytes
        /// </summary>
        public byte[] Image { get; set; }

        /// <summary>
        /// Returns a string represents the object
        /// </summary>
        /// <returns>The vCard file content like it is defined in the reference of vCard format</returns>
        /// <remarks>It is used here also to get the content of a vCard file</remarks>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("BEGIN:VCARD");
            builder.AppendLine("VERSION:2.1");
            // Name
            builder.AppendLine("N:" + LastName + ";" + FirstName + ";;" + Civility);
            // Full name
            builder.AppendLine("FN:" + FirstName + " " + LastName);
            // Address
            builder.AppendLine(HomeAddress.ToString());
            builder.AppendLine(BusinessAddress.ToString());
            // Birthdate
            builder.AppendLine("BDAY:" + BirthDate.ToString("yyyyMMdd"));
            // Add image
            if (Image != null && Image.Length > 0)
            {
                builder.AppendLine("PHOTO;ENCODING=BASE64;TYPE=JPEG:");
                builder.AppendLine(Convert.ToBase64String(Image));
                builder.AppendLine(string.Empty);
            }
            // Other data
            builder.AppendLine("ORG:" + Organization + ";" + Service);
            builder.AppendLine("TITLE:" + JobTitle);
            builder.AppendLine("ROLE:" + JobTitle);
            builder.AppendLine("TEL;HOME;VOICE:" + PersonalPhone);
            builder.AppendLine("TEL;WORK;VOICE:" + BusinessPhone);
            builder.AppendLine("TEL;CELL;VOICE:" + Mobile);
            builder.AppendLine("URL;HOME:" + PersonalHomePage);
            builder.AppendLine("URL;WORK:" + BusinessHomePage);
            builder.AppendLine("EMAIL;PREF;INTERNET:" + PreferredEmail);
            builder.AppendLine("EMAIL;INTERNET:" + AlternativeEmail);
            builder.AppendLine("END:VCARD");
            return builder.ToString();
        }
    }
}