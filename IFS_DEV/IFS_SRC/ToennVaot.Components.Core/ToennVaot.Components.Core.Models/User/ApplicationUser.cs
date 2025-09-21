using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using ToennVaot.Components.Core.Models.Enumerations;

namespace ToennVaot.Components.Core.Models.User
{
    /// <summary>
    /// The application user
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        /// The gender
        /// </summary>
        [Required]
        [PersonalData]
        public GenderEnum Gender { get; set; } = default!;
        
        /// <summary>
        /// The pronoun to use
        /// </summary>
        [PersonalData]
        public string Pronoun { get; set; } = default!;

        /// <summary>
        /// The first name
        /// </summary>
        [Required(AllowEmptyStrings = false)]
        [ProtectedPersonalData]
        public string FirstName { get; set; } = default!;

        /// <summary>
        /// The last name
        /// </summary>
        [Required(AllowEmptyStrings = false)]
        [ProtectedPersonalData]
        public string LastName { get; set; } = default!;

        /// <summary>
        /// The customer identifier
        /// </summary>
        public int? CustomerExternalReference { get; set; }
    }
}