using System.ComponentModel.DataAnnotations;
using System.Reflection;
using ToennVaot.Components.Core.Security.Attributes;

namespace ToennVaot.Components.Core.Security.Permissions
{
    /// <summary>
    /// Permission display class to let value of enumeration displayed in output
    /// </summary>
    public class PermissionDisplay
    {
        /// <summary>
        /// The permission group name
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// The permission name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The permission enumeration value
        /// </summary>
        public PermissionEnum Permission { get; set; }

        /// <summary>
        /// The permission is only for application
        /// </summary>
        public bool OnlyForApplication { get; set; }

        /// <summary>
        /// The permission is only for user
        /// </summary>
        public bool OnlyForUser { get; set; }

        /// <summary>
        /// The order value
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="groupName">the group name</param>
        /// <param name="name">The name</param>
        /// <param name="description">The description</param>
        /// <param name="permission">The permission value</param>
        /// <param name="order">The order value</param>
        public PermissionDisplay(string groupName, string name, string description, PermissionEnum permission, int order)
        {
            Permission = permission;
            GroupName = groupName;
            Name = name;
            Description = description;
            Permission = permission;
            Order = order;

            OnlyForApplication = typeof(PermissionEnum).GetField(Enum.GetName(typeof(PermissionEnum), permission) ?? string.Empty)?.GetCustomAttribute<ApplicationOnly>(false) != null;
            OnlyForUser = typeof(PermissionEnum).GetField(Enum.GetName(typeof(PermissionEnum), permission) ?? string.Empty)?.GetCustomAttribute<UserOnly>(false) != null;
        }

        /// <summary>
        /// Get the values of <paramref name="enumType"/> to display
        /// </summary>
        /// <param name="enumType">The enumeration type</param>
        /// <param name="onlyForApplication">Indicates if the permission should include permission for application ONLY or not. If not, permission for application ONLY will not be displayed. Those for user ONLY will be.</param>
        /// <returns>The values to display</returns>
        public static List<PermissionDisplay> GetPermissionsToDisplay(Type enumType, bool onlyForApplication)
        {
            var result = new List<PermissionDisplay>();
            foreach (var permissionName in Enum.GetNames(enumType))
            {
                var member = enumType.GetMember(permissionName);
                var displayAttribute = member[0].GetCustomAttribute<DisplayAttribute>();
                if (displayAttribute == null)
                    continue;

                var permission = (PermissionEnum)Enum.Parse(enumType, permissionName, false);
                var isApplicationOnly = typeof(PermissionEnum).GetField(Enum.GetName(typeof(PermissionEnum), permission) ?? string.Empty)?.GetCustomAttribute<ApplicationOnly>(false) != null;
                var isUserOnly = typeof(PermissionEnum).GetField(Enum.GetName(typeof(PermissionEnum), permission) ?? string.Empty)?.GetCustomAttribute<UserOnly>(false) != null;
                if(!isApplicationOnly && !isUserOnly || onlyForApplication && isApplicationOnly || !onlyForApplication && isUserOnly)
                    result.Add(new PermissionDisplay(displayAttribute.GroupName ?? string.Empty, displayAttribute.Name ?? string.Empty, displayAttribute.Description ?? string.Empty, permission, displayAttribute.Order));
            }

            return result.OrderBy(o => o.Order).ToList();
        }

        /// <summary>
        /// Get the values applying <paramref name="permissions"/>
        /// </summary>
        /// <param name="permissions">The permissions to apply</param>
        /// <returns>The values to display filtered</returns>
        public static List<PermissionDisplay> GetApplicationPermissionsToDisplay(IEnumerable<PermissionEnum> permissions)
        {
            return GetPermissionsToDisplay(typeof(PermissionEnum), true).Where(p => permissions.Contains(p.Permission)).ToList();
        }

    }
}
