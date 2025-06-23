namespace ToennVaot.Components.Core.Attributes
{
    /// <summary>
    /// Attribute to indicate the field should be available only for user
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class UserOnlyAttribute : Attribute { }
}