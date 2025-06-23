namespace ToennVaot.Components.Core.Attributes
{
    /// <summary>
    /// Attribute to indicate the field should be available only for application
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ApplicationOnlyAttribute : Attribute { }
}