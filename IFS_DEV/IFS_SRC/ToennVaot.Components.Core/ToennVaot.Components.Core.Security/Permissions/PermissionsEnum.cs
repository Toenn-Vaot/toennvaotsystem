using System.ComponentModel.DataAnnotations;
using ToennVaot.Components.Core.Security.Attributes;

namespace ToennVaot.Components.Core.Security.Permissions
{
    /// <summary>
    /// The enumeration list all available permission
    /// </summary>
    public enum PermissionEnum : short
    {
        /// <summary>
        ///Credit Note read
        /// </summary>
        [Display(GroupName = "Configuration", Name = "Read", Description = "Allows the user to read the system configuration parameters", Order = 40)] //(
        ConfigurationRead = 40,

        /// <summary>
        ///Credit Note read
        /// </summary>
        [Display(GroupName = "Document", Name = "Read", Description = "Allows the user to read Credit Note documents", Order = 50)] //2
        CreditNoteRead = 50,

        /// <summary>
        ///Invoice read
        /// </summary>
        [Display(GroupName = "Document", Name = "Read", Description = "Allows the user to read Invoice documents", Order = 53)] //5
        InvoiceRead = 53,

        /// <summary>
        ///Reminder read
        /// </summary>
        [Display(GroupName = "Document", Name = "Read", Description = "Allows the user to read Reminder documents", Order = 56)] //8
        ReminderRead = 56,

        /// <summary>
        /// Card read
        /// </summary>
        [Display(GroupName = "Card", Name = "Read", Description = "Allows the user to read Cards data", Order = 60)] //<
        CardRead = 60,

        /// <summary>
        /// Card update
        /// </summary>
        [Display(GroupName = "Card", Name = "Update", Description = "Allows the user to update Cards data", Order = 61)] //=
        CardUpdate = 61,

        /// <summary>
        /// Card blacklist
        /// </summary>
        [Display(GroupName = "Card", Name = "Blacklist", Description = "Allows the user to blacklist Cards", Order = 62)] //>
        CardBlacklist = 62,

        /// <summary>
        /// Card subsidized
        /// </summary>
        [Display(GroupName = "Card", Name = "Subsidized", Description = "Allows the user to act on subsidized Cards", Order = 63)] //?
        CardSubsidized = 63,

        /// <summary>
        /// Customer read
        /// </summary>
        [Display(GroupName = "Customer", Name = "Read", Description = "Allows the user to read Customers data", Order = 70)] //F
        CustomerRead = 70,

        /// <summary>
        /// Customer create
        /// </summary>
        [Display(GroupName = "Customer", Name = "Create", Description = "Allows the user to create Customers", Order = 71)] //G
        CustomerCreate = 71,

        /// <summary>
        /// Customer update
        /// </summary>
        [Display(GroupName = "Customer", Name = "Update", Description = "Allows the user to update Customers data", Order = 72)] //H
        CustomerUpdate = 72,

        /// <summary>
        /// Customer associate
        /// </summary>
        [Display(GroupName = "Customer", Name = "Associate", Description = "Allows the user to associate a ward", Order = 73)] //I
        CustomerAssociate = 73,

        /// <summary>
        /// Customer account activation
        /// </summary>
        [ApplicationOnly]
        [Display(GroupName = "Customer", Name = "AccountActivation", Description = "Allows the user to activate an account (ONLY for Application User)", Order = 74)] //J
        CustomerAccountActivation = 74,

        /// <summary>
        /// Customer password update
        /// </summary>
        [UserOnly]
        [Display(GroupName = "Customer", Name = "PasswordUpdate", Description = "Allows the user to change the password of the account (ONLY for Customer' User)", Order = 75)] //K
        CustomerPasswordUpdate = 75,

        /// <summary>
        /// Customer username read
        /// </summary>
        [ApplicationOnly]
        [Display(GroupName = "Customer", Name = "UsernameRead", Description = "Allows the user to read username of accounts (ONLY for Application' User)", Order = 76)] //L
        CustomerUsernameRead = 76,

        /// <summary>
        /// Order read
        /// </summary>
        [Display(GroupName = "Order", Name = "Read", Description = "Allows the user to read Orders data", Order = 80)] //P
        OrderRead = 80,

        /// <summary>
        /// Order create
        /// </summary>
        [Display(GroupName = "Order", Name = "Create", Description = "Allows the user to create Orders", Order = 81)] //Q
        OrderCreate = 81,

        /// <summary>
        /// Order update
        /// </summary>
        [Display(GroupName = "Order", Name = "Update", Description = "Allows the user to update Orders data", Order = 82)] //R
        OrderUpdate = 82,

        /// <summary>
        /// Order delete
        /// </summary>
        [Display(GroupName = "Order", Name = "Delete", Description = "Allows the user to delete Orders data (only unpaid)", Order = 83)] //S
        OrderDelete = 83,

        /// <summary>
        /// Order update
        /// </summary>
        [Display(GroupName = "Order", Name = "Cancel", Description = "Allows the user to cancel Orders", Order = 84)] //T
        OrderCancel = 84,

        /// <summary>
        /// Payment read
        /// </summary>
        [Display(GroupName = "Payment", Name = "Read", Description = "Allows the user to read Payments data", Order = 90)] //Z
        PaymentRead = 90,

        /// <summary>
        /// Payment create
        /// </summary>
        [Display(GroupName = "Payment", Name = "Create", Description = "Allows the user to create Payments", Order = 91)] //[
        PaymentCreate = 91,

        /// <summary>
        /// Payment update
        /// </summary>
        [Display(GroupName = "Payment", Name = "Update", Description = "Allows the user to update Payments data", Order = 92)] //\
        PaymentUpdate = 92,

        /// <summary>
        /// Payment share
        /// </summary>
        [Display(GroupName = "Payment", Name = "Share", Description = "Allows the user to share a Payment agreement", Order = 93)] //]
        PaymentShare = 93,

        /// <summary>
        /// Package read
        /// </summary>
        [Display(GroupName = "Package", Name = "Read", Description = "Allows the user to access Commercial and Bulk packages", Order = 100)] //d
        PackageRead = 100,

        /// <summary>
        /// All access
        /// </summary>
        [Display(GroupName = "SuperAdmin", Name = "AccessAll", Description = "This allows the user to access every feature", Order = short.MaxValue)]
        AccessAll = 0,// short.MaxValue,
    }
}
