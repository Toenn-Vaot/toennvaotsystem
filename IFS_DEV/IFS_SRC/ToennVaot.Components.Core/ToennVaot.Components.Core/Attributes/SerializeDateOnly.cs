namespace ToennVaot.Components.Core.Attributes
{
    /// <summary>
    /// Attribute to indicate the field should serialize only the date part of DateTime
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class SerializeDateOnlyAttribute : Attribute { }
}