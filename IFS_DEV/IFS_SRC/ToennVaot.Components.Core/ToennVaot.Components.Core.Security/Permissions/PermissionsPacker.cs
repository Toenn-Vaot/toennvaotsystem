namespace ToennVaot.Components.Core.Security.Permissions
{
    /// <summary>
    /// Packer for <see cref="PermissionEnum"/>
    /// </summary>
    public static class PermissionsPacker
    {
        /// <summary>
        /// Pack <paramref name="items"/> to their <see cref="string"/> representation
        /// </summary>
        /// <param name="items">The permissions</param>
        /// <returns>The <see cref="string"/> representation</returns>
        public static string Pack(IEnumerable<PermissionEnum> items)
        {
            return string.Join(string.Empty, items.ToList().ConvertAll(x => ((char)x).ToString()));
        }

        /// <summary>
        /// Unpack <paramref name="representation"/> to their <see cref="PermissionEnum"/> values
        /// </summary>
        /// <param name="representation">The <see cref="string"/> representation of permission items</param>
        /// <returns>The <see cref="PermissionEnum"/> values</returns>
        public static IEnumerable<PermissionEnum> Unpack(string representation)
        {
            if (representation == null)
                throw new ArgumentNullException(nameof(representation));

            foreach (var character in representation)
            {
                yield return ((PermissionEnum)character);
            }
        }
    }
}
